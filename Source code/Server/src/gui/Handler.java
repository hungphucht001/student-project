package gui;

import dao.Friend_DAO;
import dao.Group_DAO;
import static dao.Group_DAO.insertMember;
import dao.Message_DAO;
import dao.Notification_DAO;
import dao.User_DAO;
import static gui.Server.hmUser;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import static gui.Server.txt;
import java.awt.Dimension;
import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.PrintWriter;
import java.util.Set;
import javax.swing.JFileChooser;
import pojo.DataFile;
import pojo.GroupMember;
import pojo.ListChatPeople;
import pojo.User_account;
/**
 *
 * @author Hùng Trần
 */
public class Handler implements Runnable{
    private Socket s;
    private User_account user;
    private ObjectOutputStream oos;
    private ObjectInputStream ois;
    public Handler(Socket s, User_account user) {
        this.s = s;
        this.user = user;
    }
    public Handler(pojo.User_account user){
        this.user = user;
    }
    public Handler(Socket s){
        this.s = s;
    }
    @Override
    public  void run() {
        try {
            oos = new ObjectOutputStream(s.getOutputStream());
            sendData();
            String message;
            while (true) { 
                ois = new ObjectInputStream(s.getInputStream());
                message = ois.readUTF();
                if(message != null){
                    //Client gửi message 'logout'
                    if(message.equals("logout")){logout(); break;}
                    //gửi-nhận một tin nhắn
                    else if(message.equals("Messages peopel")) textMessages();
                    //gửi-nhận một tin nhắn group
                    else if(message.equals("Message group")) textMessagesGroup();
                    
                    else if(message.equals("Load data chat peopel")) loadDataChatPeopel();
                    else if(message.equals("Load data chat group")) loadDataChatGroup();
                     //Tạo group
                    else if(message.equals("Create group")) createGroup();
                    //Cập nhật thông tin
                    else if(message.equals("User update")) createUpdateInfro();
                    //rời nhóm
                    else if(message.equals("Out group")) outGroup();
                    //đổi mật khẩu
                    else if(message.equals("Change password info")) changePassword();
                    //cập nhật avatar
                    else if(message.equals("Update avatar")) updateAvatar();
                    //đổi tên group
                    else if(message.equals("Rename group")) renameGroup();
                }
            }
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        finally{
            try {
                s.close();
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        }
    }
    public void setS(Socket s) {
        this.s = s;
    }
    public User_account getUser() {
        return user;
    }
    public void setUser(User_account user) {
        this.user = user;
    }
    public ObjectOutputStream getOos() {
        return oos;
    }
    public void setOos(ObjectOutputStream oos) {
        this.oos = oos;
    }
//     <editor-fold>
    private void sendData(){
        try {
            //gửi dữ liệu tới client khi đăng nhập thành công
            Server.txt.append("\nLoad data to client: " +getUser().getUsername()+"...");
            getOos().writeUTF("loadData");
            getOos().writeObject(getUser());
            getOos().writeObject(User_DAO.listUser(user.getId()));
            getOos().writeObject(User_DAO.listChat(user.getId()));
            getOos().writeObject(Group_DAO.memberInGroup(user.getId()));
            getOos().writeObject(Group_DAO.listChatGroup(user.getId()));
            getOos().writeObject(Notification_DAO.listNotification(user.getId()));
            getOos().flush();
            Server.txt.append("\n\nFinished loading data for: "  +getUser().getUsername());
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    private void loadDataChatPeopel(){
        try {
            int idFriend = Friend_DAO.selectIDFriend(user.getId(), ois.readInt());
            getOos().writeUTF("Receive data chat peopel");
            getOos().writeObject(Message_DAO.ListMessageByIDFriend(idFriend));
            getOos().flush();
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    private void loadDataChatGroup() {
        try {
            int idGroup = ois.readInt();
            getOos().writeUTF("Receive data chat group");
            getOos().writeObject(Message_DAO.ListMessageByIDGroup(idGroup));
            getOos().flush();
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    private void textMessages(){
        try {
            pojo.PeopelMessage mess = (pojo.PeopelMessage) ois.readObject();
            mess.setId_frgr(Friend_DAO.selectIDFriend(mess.getId_receive(), mess.getId_send()));
            if(mess.getType()== 1 || mess.getType()== 2 || mess.getType()== 4){
                pojo.DataFile dataFile = mess.getDataFile();
                String path = "./src/data/fileupload/"+fun.Function.randomCode()+"_"+dataFile.getName();
                mess.setContent(path);
                try {
                    FileOutputStream out = new FileOutputStream(path);
                    out.write(dataFile.getFile());
                    out.close();
                } catch (FileNotFoundException ex) {
                    ex.printStackTrace();
                }
            }
            Message_DAO.insertMessagePeopel(mess);
            Handler hdReceiveMessage = hmUser.get(mess.getId_receive());
            if(hdReceiveMessage.getUser().getStatus() == 1){
                try {
                    hdReceiveMessage.getOos().writeUTF("Receive messages peopel");
                    hdReceiveMessage.getOos().writeObject(mess);
                    hdReceiveMessage.getOos().flush();
                } catch (IOException ex) {
                    Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    private void textMessagesGroup(){
        try {
            pojo.GroupMessage mess = (pojo.GroupMessage) ois.readObject();
            if(mess.getType()== 1 || mess.getType()== 2 || mess.getType()== 4){
                pojo.DataFile dataFile = mess.getDataFile();
                String path = "./src/data/fileupload/"+fun.Function.randomCode()+"_"+dataFile.getName();
                mess.setContent(path);
                try {
                    FileOutputStream out = new FileOutputStream(path);
                    out.write(dataFile.getFile());
                    out.close();
                } catch (FileNotFoundException ex) {
                    ex.printStackTrace();
                }
            }
            Message_DAO.insertMessageGroup(mess);
            ArrayList<GroupMember> alMember = Server.hmGroup.get(mess.getId_frgr()).getAlMember();
            for(GroupMember g : alMember){
                Handler hdReceiveMessage = hmUser.get(g.getUser().getId());
                if(hdReceiveMessage.getUser().getStatus() == 1 && hdReceiveMessage.getUser().getId() != user.getId()){
                    hdReceiveMessage.getOos().writeUTF("Receive messages group");
                    hdReceiveMessage.getOos().writeObject(mess);
                    hdReceiveMessage.getOos().flush();
                }
            }
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    private void logout(){
        try {
            if(user.getStatus()==1)
            {
                flush("Safe to leave");
                Server.txt.append("\n["+user.getUsername()+"]: logout");
                User_DAO.updateOnline(0, user.getId());
                hmUser.get(user.getId()).getUser().setStatus(0);
                ois.close();
                oos.close();
                s.close();
                Server.loadListChat(user.getId());
            }
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    private void createGroup() {
        try {
            String name = ois.readUTF();
            ArrayList<Integer> alId = (ArrayList<Integer>) ois.readObject();
            int idGroup = Group_DAO.createGroup(name);
            if(idGroup > 0){
                if(insertMember(idGroup, user.getId(), 0) > 0){
                    for(Integer i: alId){
                        insertMember(idGroup, i, 1);
                    }
                    Server.hmGroup.put(idGroup, Group_DAO.alGroup(idGroup));
                    oos.writeUTF("Successful group creation");
                    oos.writeObject(Group_DAO.alGroup(idGroup));
                    oos.flush();
                    for(Integer i: alId){
                        Handler hn = hmUser.get(i);
                        if(hn.user.getStatus() == 1 && hn.getUser().getId() != user.getId()){
                            hn.getOos().writeUTF("Successful group");
                            hn.getOos().writeObject(Group_DAO.alGroup(idGroup));
                            oos.flush();
                        }
                    }
                }
            }
            else
                flush("create error group");
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    private void createUpdateInfro() {
        try {
            User_account user = (User_account) ois.readObject();
            Server.hmUser.get(user.getId()).setUser(user);
            int kq = User_DAO.updateUser(user);
            if(kq > 0)
                flush("Update successful infor");
            else
                flush("Update error infor");
 
        } catch (Exception ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        } 
    }

    private void outGroup() {
        try {
            int idGroup = ois.readInt();
            if(Group_DAO.deleteMember(user.getId(), idGroup)>0){
                oos.writeUTF("Delete group successful");
                oos.writeInt(idGroup);
                oos.flush();
            }
            else {
                flush("Delete group error");
            }
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private void changePassword() {
        try {
            String pass = ois.readUTF();
            if(User_DAO.updatePassword(user.getId(), pass)>0){
                oos.writeUTF("Change password successful");
                oos.flush();
            }
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private void updateAvatar() {
        try {
            DataFile dataFile = (DataFile) ois.readObject();
            try {
                String path = "./src/data/uploadAvatar/"+user.getId()+"_"+dataFile.getName();
                
                FileOutputStream out = new FileOutputStream(path);
                out.write(dataFile.getFile());
                out.close();
                
                if(User_DAO.updateAvatar(user.getId(), path)>0){
                    oos.writeUTF("Update avatar successful");
                    oos.writeObject(dataFile);
                    oos.flush();
                    getUser().setDataFileAvatar(dataFile);
                    hmUser.get(user.getId()).getUser().setDataFileAvatar(dataFile);
                }
                else{
                    flush("Update avatar error");
                }
            } catch (FileNotFoundException ex) {
                ex.printStackTrace();
            }
            
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    private void flush(String str){
        try {
            oos.writeUTF(str);
            oos.flush();
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
     private void renameGroup() {
        try {
            int idGroup = ois.readInt();
            String newName = ois.readUTF();
            int n = Group_DAO.renameGroup(idGroup, newName);
            if(n > 0){
                oos.writeUTF("Rename group success");
                oos.writeInt(idGroup);
                oos.writeUTF(newName);
                oos.flush();
                Server.hmGroup.get(idGroup).setName(newName);
            }
            else flush("Rename group error");
        } catch (IOException ex) {
            Logger.getLogger(Handler.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
//     </editor-fold>
}
 