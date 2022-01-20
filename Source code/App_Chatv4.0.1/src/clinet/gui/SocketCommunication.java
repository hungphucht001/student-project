package clinet.gui;

import clinet.gui.publicLoading.PublicLoading;
import clinet.gui.publicevent.*;
import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutput;
import java.io.ObjectOutputStream;
import java.io.PrintWriter;
import java.net.Socket;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Date;
import java.util.HashMap;
import java.util.function.Consumer;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javazoom.jl.player.Player;
import pojo.Group;
import pojo.ListChatPeople;
import pojo.Message;
import pojo.DataFile;
import pojo.GroupMessage;
import pojo.ListChatGroup;
import pojo.Notifications;
import pojo.PeopelMessage;
import pojo.User_account;
/**
 *
 * @author Hùng Trần
 */
public class  SocketCommunication implements Runnable{
    public static User_account user;
    private Socket s;
    private ObjectInputStream ois;
    private ObjectOutputStream oos;
    public static ArrayList<User_account> listUser;
    public static ArrayList<ListChatPeople> listChatPeople;
    public static ArrayList<pojo.Group> listGroup;
    public static ArrayList<pojo.ListChatGroup> listChatGroup;
    public static ArrayList<pojo.Notifications> listNotification;
    public SocketCommunication(){
    } 
    public Socket getS() {
        return s;
    }
    public void setS(Socket s) {
        this.s = s;
        sendDataToServer();
    }
    @Override
    public void run() {
        try {
            ois = new ObjectInputStream(s.getInputStream());
            String message;
            while (true) {
                try {     
//                <editor-fold>
                if((message = getOis().readUTF()) != null){
                    if(message.equals("loadData")){
                        user = (User_account) getOis().readObject();
                        listUser =  (ArrayList<User_account>) getOis().readObject();
                        listChatPeople = (ArrayList<ListChatPeople>) getOis().readObject();
                        listGroup = (ArrayList<Group>) getOis().readObject();
                        listChatGroup = (ArrayList<ListChatGroup>) getOis().readObject();
                        listNotification = (ArrayList<Notifications>) getOis().readObject();
                        PublicLoading.getPublicLoading().getLoadHome().loadHome();
                    }
                    else if(message.equals("loadListChat")){
                        listChatPeople = (ArrayList<ListChatPeople>) getOis().readObject();
                        PublicLoading.getPublicLoading().getLoadListChat().loadListChat(listChatPeople);
                    }
                    else if(message.equals("Safe to leave")){
                        ois.close();
                        s.close();
                        break;
                        }
                    else if(message.equals("Receive messages peopel")){
                        incomingMessageSound();
                        pojo.PeopelMessage mess = (pojo.PeopelMessage) getOis().readObject();
                        PublicEvent.getPublicEvent().getEventReceiveMess().eventReceiveMessPeople(mess);
                        updateListPeopel(mess, mess.getId_send());
                    }
                    else if(message.equals("Receive messages group")){
                        incomingMessageSound();
                        pojo.GroupMessage mess = (pojo.GroupMessage) getOis().readObject();
                        PublicEvent.getPublicEvent().getEventReceiveMess().eventReceiveMessGroup(mess);
                        updateListGroup(mess);
                    }
                    else if(message.equals("Receive data chat peopel")){
                        ArrayList<pojo.PeopelMessage> alMess = (ArrayList<pojo.PeopelMessage>) getOis().readObject();
                        PublicEvent.getPublicEvent().getReceiveMessageLoadDataChat().receiveMessagePeopel(alMess);
                    }
                    else if(message.equals("Receive data chat group")){
                        ArrayList<pojo.GroupMessage> alMess = (ArrayList<pojo.GroupMessage>) getOis().readObject();
                        PublicEvent.getPublicEvent().getReceiveMessageLoadDataChat().receiveMessageGroup(alMess);
                    }
                    else if(message.equals("Update successful infor")){
                        JOptionPane.showMessageDialog(null, "Cập nhật thông tin thành công");
                    }
                    else if(message.equals("Successful group creation")){
                        JOptionPane.showMessageDialog(null, "Tạo nhóm thành công");
                        Group g = (Group) getOis().readObject();
                        listGroup.add(g);
                        PublicLoading.getPublicLoading().getLoadGroupChat().LoadGroupChat();
                    }
                    else if(message.equals("Successful group")){
                        Group g = (Group) getOis().readObject();
                        listGroup.add(g);
                        PublicLoading.getPublicLoading().getLoadGroupChat().LoadGroupChat();
                    }
                    else if(message.equals("Delete group successful")){
                        //thông báo xóa thành công
                        JOptionPane.showMessageDialog(null, "Rời nhóm thành công");
                        //nhận id group
                        int idGroup = getOis().readInt();
                        //xóa group đã rời
                        for(Group g: listGroup){
                             if(g.getId() == idGroup){
                                listGroup.remove(g);
                                break;
                            }
                         }
                        //cập nhật lại danh sách nhóm
                        PublicLoading.getPublicLoading().getLoadGroupChat().LoadGroupChat();
                    }
                    else if(message.equals("Change password successful")){
                        JOptionPane.showMessageDialog(null, "Đổi mật khẩu thành công");
                    }
                    else if(message.equals("Update avatar successful")){
                        user.setDataFileAvatar((DataFile) getOis().readObject());
                        JOptionPane.showMessageDialog(null, "Cập nhật avatar thành công");

                    }
                    else if(message.equals("Rename group success")){
                        int idGroup = ois.readInt();
                        String newName = ois.readUTF();
                        for(Group g: listGroup)
                        {
                            if(g.getId() == idGroup)
                            {
                                g.setName(newName);
                                break;
                            }
                        }
                        JOptionPane.showMessageDialog(null, "Đổi tên nhóm thành công");
                        PublicLoading.getPublicLoading().getLoadGroupChat().LoadGroupChat();
                    }
                    else{
                        System.out.println("ok");
                    }
                }
//                </editor-fold>
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    public void sendDataToServer(){
        PublicEvent.getPublicEvent().setEventSendToServer(new EventSendToServer() {
            @Override
            public void evendSendListIdCreateGroup(String name, ArrayList<Integer> alId) {
                try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Create group");
                    oos.writeUTF(name);
                    oos.writeObject(alId);
                    oos.flush();
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
            @Override
            public void eventSendMessageGroup(GroupMessage message) {
                try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Message group");
                    oos.writeObject(message);
                    oos.flush();
                    updateListGroup(message);

                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }

            @Override
            public void evendSendMessagePeopel(PeopelMessage message) {
                try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Messages peopel");
                    oos.writeObject(message);
                    oos.flush();
                    updateListPeopel(message, message.getId_receive());
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }

            @Override
            public void evendSendInforUpdate(User_account user) {
                try {
                    user.setId(user.getId());
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("User update");
                    oos.writeObject(user);
                    oos.flush();
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
            @Override
            public void evendOutGroup(int idGroup) {
                
                int n  = JOptionPane.showConfirmDialog(null, "Bạn có chắc muốn rời nhóm không", "Schatz", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
                
                if(n == JOptionPane.YES_OPTION){
                    try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Out group");
                    oos.writeInt(idGroup);
                    oos.flush();
                    
                    for(pojo.ListChatGroup g: listChatGroup){
                            if(g.getGroup().getId() == idGroup){
                            listChatGroup.remove(g);
                            break;
                        }
                    }
                    PublicLoading.getPublicLoading().getUpdateList().updateListGroup();
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
                }
                else return;
                
            }

            @Override
            public void evendChangPassword(String pass) {
                try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Change password info");
                    oos.writeUTF(pass);
                    oos.flush();
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }

            @Override
            public void evendUpdateAvatar(DataFile dataFile) {
                try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Update avatar");
                    oos.writeObject(dataFile);
                    oos.flush();
                    user.setDataFileAvatar(dataFile);
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }

            @Override
            public void eventLogout() {
                try {
                oos = new ObjectOutputStream(s.getOutputStream());
                oos.writeUTF("logout");
                oos.flush();
                PublicEvent.getPublicEvent().getEventDisposeFrame().eventDisposeFrame();
            } catch (IOException ex) {
                Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
            }
            }

            @Override
            public void eventLoadDataMessPeopel(int idUser) {
                try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Load data chat peopel");
                    oos.writeInt(idUser);
                    oos.flush();
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }

            @Override
            public void eventLoadDataMessageGroup(int group) {
                try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Load data chat group");
                    oos.writeInt(group);
                    oos.flush();
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }

            @Override
            public void eventRenameGroup(int idgroup, String newName) {
                try {
                    oos = new ObjectOutputStream(s.getOutputStream());
                    oos.writeUTF("Rename group");
                    oos.writeInt(idgroup);
                    oos.writeUTF(newName);
                    oos.flush();
                } catch (IOException ex) {
                    Logger.getLogger(SocketCommunication.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        });
    }
    private ObjectInputStream getOis() {
        return ois;
    }
    private User_account getUser(int id_user){
        User_account u = null;
        for(User_account user: listUser){
            if(user.getId() == id_user){
                u = user;
            }
        }
        return u;
    }
    private Group getGroup(int id_group){
        Group g = null;
        for(Group gr: listGroup){
            if(gr.getId() == id_group){
                g = gr;
            }
        }
        return g;
    }
    private void updateListPeopel(PeopelMessage message, int id){
        int i = 0;
        for(pojo.ListChatPeople l : listChatPeople){
            if (l.getUser().getId() == id) {
                l.setMessage(message);
                i++;
                break;
            }
        }
        if(i == 0){
            listChatPeople.add(new ListChatPeople(getUser(id), message));
        }
        PublicLoading.getPublicLoading().getUpdateList().updateListPeopel();
    }
    private void updateListGroup(GroupMessage message){
        int i = 0;
        for(pojo.ListChatGroup l : listChatGroup){
            if (l.getGroup().getId() == message.getId_frgr()) {
                l.setGroupMessage(message);
                i++;
                break;
            }
        }
        if(i == 0){
            listChatGroup.add(new ListChatGroup(getGroup(message.getId_frgr()), message));
        }
        PublicLoading.getPublicLoading().getUpdateList().updateListGroup();
    }
    private void incomingMessageSound(){
        try{
            Player player;
            File f = new File("./src/data/assets/mp3/exampleSound.mp3");
            FileInputStream fis = new FileInputStream(f);
            BufferedInputStream bis = new BufferedInputStream(fis);
            player = new Player(bis);
            new Thread(new Runnable() {
                @Override
                public void run() {
                    try {
                        player.play();
                    } catch (Exception ex) {
                        ex.printStackTrace();
                    }
                }
            }).start();
        }catch(Exception e){
            System.out.println(e);
        }
    }
}
