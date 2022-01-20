package clinet.gui.center.chat;

import lib.Fun;
import clinet.gui.SocketCommunication;
import clinet.gui.center.group.InfoGroupChat;
import clinet.gui.publicevent.ChatStickerEvent;
import clinet.gui.publicevent.EventReceiveMess;
import clinet.gui.publicevent.PublicEvent;
import clinet.gui.publicevent.ReceiveMessageLoadDataChat;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.Icon;
import javax.swing.JFileChooser;
import javax.swing.filechooser.FileNameExtensionFilter;
import lib.DateTimeFormat;
import net.miginfocom.swing.MigLayout;
import pojo.DataFile;
import pojo.GroupMessage;
import pojo.ListChatGroup;
import pojo.Message;
import pojo.PeopelMessage;
import pojo.User_account;
/**
 *
 * @author Hùng Trần
 */
public class Chat_GUI extends javax.swing.JPanel {
    private ChatCenter chatCentent;
    private ChatBottom_GUI chatBottom;
    private ChatTop_GUI chatTop;
    private ChatInfo chatInfo;
    private InfoGroupChat infoGroup;
    private DateTimeFormat dateFormat;
    private ListChatGroup listChatGroup;
    private boolean isShowInfo = false;
    private boolean isShowSticker = false;
    private boolean isGroup, isOnline;
    private int idMe, idFriend ,set;
    private String dateStr;
    private pojo.User_account user;
    private ArrayList<PeopelMessage> alMessFM = new ArrayList<PeopelMessage>();
    public Chat_GUI(int set){
        this.set = set;
        if(set == 0){
            PublicEvent.getPublicEvent().setEventReceiveMess(new EventReceiveMess() {
            @Override
            public void eventReceiveMessGroup(GroupMessage message) {
            }
            @Override
            public void eventReceiveMessPeople(PeopelMessage message) {
            }
        });
        }
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnInfo = new javax.swing.JPanel();
        pnChat = new javax.swing.JPanel();

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.BorderLayout());

        pnInfo.setBackground(new java.awt.Color(255, 255, 255));
        pnInfo.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 1, 0, 0, new java.awt.Color(200, 200, 200)));
        pnInfo.setMinimumSize(new java.awt.Dimension(350, 10));
        pnInfo.setPreferredSize(new java.awt.Dimension(350, 10));
        pnInfo.setLayout(new java.awt.CardLayout());
        add(pnInfo, java.awt.BorderLayout.LINE_END);

        pnChat.setBackground(new java.awt.Color(244, 244, 244));
        add(pnChat, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel pnChat;
    private javax.swing.JPanel pnInfo;
    // End of variables declaration//GEN-END:variables
    private void init() {
        this.setFocusable(true);
        chatCentent  = new ChatCenter();
        chatTop = new ChatTop_GUI(isOnline);
        chatBottom = new ChatBottom_GUI();
        dateFormat = new DateTimeFormat();
        pnChat.setLayout(new BorderLayout());
        pnChat.add(chatTop,BorderLayout.PAGE_START);
        pnChat.add(chatCentent,BorderLayout.CENTER);
        pnChat.add(chatBottom,BorderLayout.PAGE_END);
        if(isGroup == false){
            chatInfo = new ChatInfo();
            pnInfo.add(chatInfo);
        }
        else{
            infoGroup = new InfoGroupChat(listChatGroup.getGroup().getAlMember(),getListChatGroup().getGroup().getId());
            pnInfo.add(infoGroup);
        }
        dateStr = dateFormat.getTimeInDateTime(new Date());
    }
    private void eventHeadling() {
        //Nhận tin nhắn từ server 
        PublicEvent.getPublicEvent().setEventReceiveMess(new EventReceiveMess() {
            @Override
            public void eventReceiveMessGroup(GroupMessage message) {
                if(isGroup == true && message.getId_frgr() == listChatGroup.getGroup().getId()){
                    byte[] b = SocketCommunication.user.getDataFileAvatar().getFile();
                    for(pojo.GroupMember m: listChatGroup.getGroup().getAlMember()){
                        if(message.getId_send() == m.getUser().getId()){
                            b = m.getUser().getDataFileAvatar().getFile();
                        }
                    }
                    chatCentent.addLeft(message, b, 1);
                    if(message.getType() == 1 || message.getType() == 2){
                        infoGroup.getAlMess().add(message);
                    }
                }else return;
            }
            @Override
            public void eventReceiveMessPeople(PeopelMessage message) {
                if(isGroup== false && message.getId_send() == user.getId()){
                    chatCentent.addLeft(message, user.getDataFileAvatar().getFile(), 1);
                }else return;
            }
        });
        //Gửi tin nhắn đến server
        chatBottom.getBtnSend().addActionListener((ActionEvent e )->{
            if(!chatBottom.getTxt().getText().equals(""))
                {
                    if(isGroup == false){
                        pojo.PeopelMessage mess = new PeopelMessage();
                        mess.setContent(chatBottom.getTxt().getText().trim());
                        mess.setId_receive(user.getId());
                        mess.setId_send(idMe);
                        mess.setType(0);
                        mess.setId_frgr(idFriend);
                        mess.setStatus(1);
                        mess.setDateofsend(new Date());
                        PublicEvent.getPublicEvent().getEventSendToServer().evendSendMessagePeopel(mess);
                        chatCentent.addRight(mess,1);
                    }
                    else{
                         pojo.GroupMessage mess = new GroupMessage();
                         mess.setContent(chatBottom.getTxt().getText().trim());
                         mess.setId_send(idMe);
                         mess.setId_frgr(listChatGroup.getGroup().getId());
                         mess.setType(0);
                         mess.setDateofsend(new Date());
                         PublicEvent.getPublicEvent().getEventSendToServer().eventSendMessageGroup(mess);
                         chatCentent.addRight(mess,1);
                    }
                    
                    chatBottom.getTxt().setText(null);
                    chatBottom.getTxt().requestFocus();
                    chatBottom.getBtnSend().setEnabled(false);
                }
        });
        chatBottom.getTxt().addKeyListener(new KeyAdapter() {
                public void keyReleased(KeyEvent e) {
                    if(e.getKeyCode() == KeyEvent.VK_ENTER ){
                        String text = chatBottom.getTxt().getText();
                        char c = text.charAt(1);
                        if((int)c != (int)e.getKeyChar())
                        {
                                if(isGroup == false){
                                    pojo.PeopelMessage mess = new PeopelMessage();
                                    mess.setContent(chatBottom.getTxt().getText().trim());
                                    mess.setId_receive(user.getId());
                                    mess.setId_send(idMe);
                                    mess.setType(0);
                                    mess.setId_frgr(idFriend);
                                    mess.setStatus(1);
                                    mess.setDateofsend(new Date());
                                    PublicEvent.getPublicEvent().getEventSendToServer().evendSendMessagePeopel(mess);
                                    chatCentent.addRight(mess,1);
                                }
                                else{
                                    pojo.GroupMessage mess = new GroupMessage();
                                    mess.setContent(chatBottom.getTxt().getText().trim());
                                    mess.setId_send(idMe);
                                    mess.setId_frgr(listChatGroup.getGroup().getId());
                                    mess.setType(0);
                                    mess.setDateofsend(new Date());
                                    PublicEvent.getPublicEvent().getEventSendToServer().eventSendMessageGroup(mess);
                                    chatCentent.addRight(mess,1);
                                }
                        }
                        chatBottom.getTxt().setText(null);
                        chatBottom.getTxt().setText(null);
                        chatBottom.getTxt().requestFocus();
                        chatBottom.getBtnSend().setEnabled(false);
                    }
                    if(!chatBottom.getTxt().getText().equals("")){
                        chatBottom.getBtnSend().setEnabled(true);
                    }
                    chatBottom.scrollToBottom();
                }
            });
            chatBottom.getBtnFile().addActionListener((ActionEvent e)->{
                JFileChooser fileSend = new JFileChooser();
                fileSend.getFileSystemView().getHomeDirectory();
                fileSend.setDialogTitle("Gửi File");
                fileSend.setPreferredSize(new Dimension(700, 400));
                int rVal = fileSend.showOpenDialog(null);
                if(rVal == JFileChooser.APPROVE_OPTION) {
                    try {
                        File selectedFile = fileSend.getSelectedFile();
                        FileInputStream in = new FileInputStream(selectedFile);
                        byte b[] = new byte[in.available()];
                        in.read(b);
                        pojo.DataFile dataFile = new DataFile(1, b, selectedFile.getName(),selectedFile.length());
                        if(isGroup == false){
                            pojo.PeopelMessage mess = new PeopelMessage();
                            mess.setContent(selectedFile.getPath());
                            mess.setType(2);
                            mess.setDateofsend(new Date());
                            mess.setId_receive(user.getId());
                            mess.setId_send(idMe);
                            mess.setId_frgr(idFriend);
                            mess.setStatus(1);
                            mess.setDataFile(dataFile);
                            PublicEvent.getPublicEvent().getEventSendToServer().evendSendMessagePeopel(mess);
                            chatCentent.addRight(mess,1);
                            alMessFM.add(mess);
                            chatInfo.loadData();
                        }
                        else {
                            pojo.GroupMessage mess = new GroupMessage();
                            mess.setContent(selectedFile.getPath());
                            mess.setDateofsend(new Date());
                            mess.setId_frgr(listChatGroup.getGroup().getId());
                            mess.setType(2);
                            mess.setId_send(idMe);
                            mess.setDataFile(dataFile);
                            PublicEvent.getPublicEvent().getEventSendToServer().eventSendMessageGroup(mess);
                            chatCentent.addRight(mess,1);
                            infoGroup.getAlMess().add(mess);
                        }
                    } catch (IOException ex) {
                        Logger.getLogger(Chat_GUI.class.getName()).log(Level.SEVERE, null, ex);
                    }
                }
            });
        chatBottom.getBtnMedia().addActionListener((ActionEvent e)->{
            JFileChooser fileMedia = new JFileChooser();
            fileMedia.getFileSystemView().getHomeDirectory();
            fileMedia.setDialogTitle("Gửi media");
            fileMedia.setAcceptAllFileFilterUsed(false);
            FileNameExtensionFilter filter = new FileNameExtensionFilter("JPG, PNG, GIF, MP3", "png","jpg","gif","mp3");
            fileMedia.addChoosableFileFilter(filter);
            fileMedia.setPreferredSize(new Dimension(700, 400));
            int rVal = fileMedia.showOpenDialog(null);
            if(rVal == JFileChooser.APPROVE_OPTION) {
                try {
                    File selectedFile = fileMedia.getSelectedFile();
                    FileInputStream in = new FileInputStream(selectedFile);
                    byte b[] = new byte[in.available()];
                    in.read(b);
                    int type = Fun.checkFile(selectedFile.getName());
                    pojo.DataFile dataFile = new DataFile(type, b, selectedFile.getName(),selectedFile.length());
                    if(isGroup == false){
                        pojo.PeopelMessage mess = new PeopelMessage();
                        mess.setContent(selectedFile.getName());
                        mess.setType(type);
                        mess.setDateofsend(new Date());
                        mess.setId_receive(user.getId());
                        mess.setId_send(idMe);
                        mess.setId_frgr(idFriend);
                        mess.setStatus(1);
                        mess.setDataFile(dataFile);
                        PublicEvent.getPublicEvent().getEventSendToServer().evendSendMessagePeopel(mess);
                        chatCentent.addRight(mess,1);
                        alMessFM.add(mess);
                        chatInfo.loadData();
                    }
                    else {
                        pojo.GroupMessage mess = new GroupMessage();
                        mess.setContent(selectedFile.getName());
                        mess.setDateofsend(new Date());
                        mess.setId_frgr(listChatGroup.getGroup().getId());
                        mess.setType(type);
                        mess.setId_send(idMe);
                        mess.setDataFile(dataFile);
                        PublicEvent.getPublicEvent().getEventSendToServer().eventSendMessageGroup(mess);
                        chatCentent.addRight(mess,1);
                        infoGroup.getAlMess().add(mess);
                    }
                } catch (IOException ex) {
                    Logger.getLogger(Chat_GUI.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        });
        chatBottom.getBtnSticker().addActionListener((ActionEvent e)->{
            if(isShowSticker){
                chatBottom.getPnSticker().setVisible(false);
                chatBottom.setPreferredSize(new Dimension(WIDTH, 68));
                isShowSticker = false;
            }
            else{
                chatBottom.getPnSticker().setVisible(true);
                chatBottom.setPreferredSize(new Dimension(WIDTH, 300));
                isShowSticker = true;
            }
        });
        chatTop.getBtnShowInfo().addActionListener((ActionEvent e)->{
            showInfo();
        });
        PublicEvent.getPublicEvent().addChatStickerEvent(new ChatStickerEvent() {
            @Override
            public void chatStickerEvent(String txt) {
                if(isGroup == false){
                    PeopelMessage mess = new PeopelMessage();
                    mess.setContent(txt);
                    mess.setId_receive(user.getId());
                    mess.setId_send(idMe);
                    mess.setType(3);
                    mess.setId_frgr(idFriend);
                    mess.setStatus(1);
                    mess.setDateofsend(new Date());
                    PublicEvent.getPublicEvent().getEventSendToServer().evendSendMessagePeopel(mess);
                    chatCentent.addRight(mess,1);
                }
                else{
                    pojo.GroupMessage mess = new GroupMessage();
                    mess.setContent(txt);
                    mess.setDateofsend(new Date());
                    mess.setType(3);
                    mess.setId_frgr(listChatGroup.getGroup().getId());
                    mess.setId_send(idMe);
                    PublicEvent.getPublicEvent().getEventSendToServer().eventSendMessageGroup(mess);
                    chatCentent.addRight(mess,1);
                }
            }
        });
    }
    private void showInfo(){
        if(isShowInfo){
            isShowInfo = false;
            pnInfo.setVisible(true);
        }else{
            isShowInfo = true;
            pnInfo.setVisible(false);
        }
    }
    private void setInfoMess(){
        chatTop.setInfo(user.fullName(),user.getDataFileAvatar().getFile(),user.getStatus());
    }
    private void setInfoGroup(){
        chatTop.setInfo(getListChatGroup().getGroup().getName(),getListChatGroup().getGroup().getNumberMember(),listChatGroup.getGroup().getDataFileAvatar().getFile());
    } 
    private void loadData() {
        PublicEvent.getPublicEvent().setReceiveMessageLoadDataChat(new ReceiveMessageLoadDataChat() {
            @Override
            public void receiveMessagePeopel(ArrayList<PeopelMessage> alMess) {
                setCursor(new Cursor(Cursor.WAIT_CURSOR));
                String dateLine = "";
                alMessFM.clear();
                chatCentent.setVisible(false);
                for(PeopelMessage mess: alMess){
                    Date time = mess.getDateofsend();
                    String date2 = dateFormat.getDateInDateTime(time);
                    if(dateFormat.compareDateWithDate(date2, dateLine)==0){
                        chatCentent.addDate(date2);
                    }
                    if(SocketCommunication.user.getId() == mess.getId_send())
                        chatCentent.addRight(mess, 0);
                    else chatCentent.addLeft(mess, user.getDataFileAvatar().getFile(), 0);
                    if(mess.getType() == 1 || mess.getType()==2)
                        alMessFM.add(mess);
                    dateLine = date2;
                }
                setCursor(new Cursor(Cursor.DEFAULT_CURSOR));
                chatCentent.setVisible(true);
                chatInfo.setAlMessFM(alMessFM);
            }
            @Override
            public void receiveMessageGroup(ArrayList<GroupMessage> alMess) {
                setCursor(new Cursor(Cursor.WAIT_CURSOR));
                String dateLine = "";
                chatCentent.setVisible(false);
                for(GroupMessage mess: alMess){
                    Date time = mess.getDateofsend();
                    String date2 = dateFormat.getDateInDateTime(time);
                    if(dateFormat.compareDateWithDate(date2, dateLine)==0){
                        chatCentent.addDate(date2);
                    }
                    if(SocketCommunication.user.getId() == mess.getId_send())
                    {
                        chatCentent.addRight(mess, 0);
                    }
                    else {
                        byte[] b = SocketCommunication.user.getDataFileAvatar().getFile();
                        for(pojo.GroupMember m: listChatGroup.getGroup().getAlMember()){
                            if(mess.getId_send() == m.getUser().getId()){
                                b = m.getUser().getDataFileAvatar().getFile();
                                break;
                            }
                        }
                        chatCentent.addLeft(mess, b, 0);
                    }
                    dateLine = date2;
                }
                setCursor(new Cursor(Cursor.DEFAULT_CURSOR));
                chatCentent.setVisible(true);
                infoGroup.setAlMess(alMess);
            }
        });
    }
    public void setIdMe(int idMe) {
        this.idMe = idMe;
    }
    public void setIsGroup(boolean isGroup) {
        this.isGroup = isGroup;
    }
    public void setUser(User_account user) {
        this.user = user;
        initComponents();
        pnInfo.setVisible(false);
        init();
        setSet(1);
        eventHeadling();
        setInfoMess();
        loadData();
    }
    public void setIdFriend(int id_friend) {
        this.idFriend = id_friend;
    }
    public ListChatGroup getListChatGroup() {
        return listChatGroup;
    }
    public void setListChatGroup(ListChatGroup listChatGroup) {
        this.listChatGroup = listChatGroup;
        initComponents();
        pnInfo.setVisible(false);
        init();
        setSet(1);
        eventHeadling();
        setInfoGroup();
        loadData();
        PublicEvent.getPublicEvent().getEventSendToServer().eventLoadDataMessageGroup(listChatGroup.getGroup().getId());
    }
    public int getSet() {
        return set;
    }
    public void setSet(int set) {
        this.set = set;
    }
}
