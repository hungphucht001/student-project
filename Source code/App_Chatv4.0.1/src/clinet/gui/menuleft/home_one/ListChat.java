package clinet.gui.menuleft.home_one;

import clinet.gui.SocketCommunication;
import clinet.gui.publicevent.PublicEvent;
import clinet.gui.publicevent.ReceiveMessageLoadDataChat;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import javax.swing.DefaultListModel;
import pojo.GroupMessage;
import pojo.ListChatPeople;
import pojo.PeopelMessage;

/**
 *
 * @author Hùng Trần
 */
public class ListChat extends javax.swing.JPanel {
    public ListChat(){
        initComponents();
        init();
        eventHandling();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        listChat_Header = new clinet.gui.menuleft.home_one.ListChat_Header();
        pnShowMessage = new javax.swing.JPanel();
        listChatItem2 = new clinet.gui.menuleft.home_one.ListChatItem();

        setOpaque(false);
        setLayout(new java.awt.BorderLayout());
        add(listChat_Header, java.awt.BorderLayout.PAGE_START);

        pnShowMessage.setBackground(new java.awt.Color(255, 255, 255));
        pnShowMessage.setOpaque(false);
        pnShowMessage.setLayout(new java.awt.CardLayout());
        pnShowMessage.add(listChatItem2, "card2");

        add(pnShowMessage, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private clinet.gui.menuleft.home_one.ListChatItem listChatItem2;
    private clinet.gui.menuleft.home_one.ListChat_Header listChat_Header;
    private javax.swing.JPanel pnShowMessage;
    // End of variables declaration//GEN-END:variables
    private void init() {
        search();
    }
    private void eventHandling() {
        listChat_Header.getBtnMessage().addActionListener((ActionEvent e) -> {
            listChatItem2.getSpListItemChat().setViewportView(listChatItem2.getLtChatItemFriend());
        });
        listChat_Header.getBtnMessgroup().addActionListener((ActionEvent e) -> {
            listChatItem2.getSpListItemChat().setViewportView(listChatItem2.getLtChatItemGroup());
        });
        PublicEvent.getPublicEvent().setReceiveMessageLoadDataChat(new ReceiveMessageLoadDataChat() {

            @Override
            public void receiveMessagePeopel(ArrayList<PeopelMessage> alMess) {
            }

            @Override
            public void receiveMessageGroup(ArrayList<GroupMessage> alMess) {
            }
        });
    }
    private void search(){
        listChat_Header.getTxtSearch().addKeyListener(new KeyAdapter() {
            @Override
            public void keyReleased(KeyEvent e) {
                if(listChat_Header.isIsMessage()==true){
                    DefaultListModel<pojo.ListChatPeople> dlm = new DefaultListModel<pojo.ListChatPeople>();
                    ArrayList<pojo.ListChatPeople> arr = SocketCommunication.listChatPeople;
                    arr.forEach(item->{
                        String name = item.getUser().fullName();
                        if(name.toLowerCase().contains(listChat_Header.getTxtSearch().getText().toLowerCase())){
                            dlm.addElement(item);
                        }
                    });
                    listChatItem2.getLtChatItemFriend().setModel(dlm);
                }else{
                    DefaultListModel<pojo.ListChatGroup> dlm = new DefaultListModel<pojo.ListChatGroup>();
                    ArrayList<pojo.ListChatGroup> arr = SocketCommunication.listChatGroup;
                    arr.forEach(item->{
                        String name = item.getGroup().getName();
                        if(name.toLowerCase().contains(listChat_Header.getTxtSearch().getText().toLowerCase())){
                            dlm.addElement(item);
                        }
                    });
                    listChatItem2.getLtChatItemGroup().setModel(dlm);
                }
            }
        });
    }
}
