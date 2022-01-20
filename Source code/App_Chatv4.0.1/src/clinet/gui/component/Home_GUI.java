package clinet.gui.component;

import clinet.gui.SocketCommunication;
import clinet.gui.center.chat.Chat_GUI;
import clinet.gui.center.group.Group_GUI;
import clinet.gui.component.Background;
import clinet.gui.menuleft.Menu_GUI;
import clinet.gui.publicLoading.LoadSize;
import clinet.gui.publicLoading.PublicLoading;
import clinet.gui.publicevent.EventGroupChat;
import clinet.gui.publicevent.EventPersonChat;
import clinet.gui.publicevent.EventReceiveMess;
import clinet.gui.publicevent.PublicEvent;
import java.awt.BorderLayout;
import java.awt.Button;
import java.awt.CardLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import java.awt.event.ComponentListener;
import javax.swing.ImageIcon;
import javax.swing.JPanel;
import javax.swing.border.MatteBorder;
import net.miginfocom.swing.MigLayout;
import pojo.GroupMessage;
import pojo.ListChatGroup;
import pojo.PeopelMessage;
import pojo.User_account;
/**
 *
 * @author Hùng Trần
 */
public class Home_GUI extends javax.swing.JPanel {
    private JPanel pnContent;
    private CardLayout cardl;
    private Chat_GUI chat;
    private Group_GUI group;
    private Menu_GUI menu;
    
    public Home_GUI() {
        initComponents();
        init();
        eventHeadling();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnChat = new javax.swing.JPanel();

        javax.swing.GroupLayout pnChatLayout = new javax.swing.GroupLayout(pnChat);
        pnChat.setLayout(pnChatLayout);
        pnChatLayout.setHorizontalGroup(
            pnChatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 832, Short.MAX_VALUE)
        );
        pnChatLayout.setVerticalGroup(
            pnChatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 787, Short.MAX_VALUE)
        );

        setBackground(new java.awt.Color(255, 255, 255));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 1182, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 787, Short.MAX_VALUE)
        );
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel pnChat;
    // End of variables declaration//GEN-END:variables
    
    private void init() {
        pnContent = new JPanel();
        cardl = new CardLayout();
        chat = new Chat_GUI(0);
        group = new Group_GUI();
        menu = new Menu_GUI();
        
        setLayout(new BorderLayout());
        
        menu.setPreferredSize(new Dimension(470,0));
        
        add(menu,BorderLayout.LINE_START);
        add(pnContent,BorderLayout.CENTER);
        
        pnContent.setBorder(new MatteBorder(0, 1, 0, 0, new Color(200, 200, 200)));
        pnContent.setLayout(cardl);      
        pnContent.add(chat,"chat");     
        pnContent.add(group,"group");
        pnContent.add(new Background(),"back");
        
        cardl.show(pnContent, "back");
    }
    private void eventHeadling() {
        menu.getBtnShowChat().addActionListener((java.awt.event.ActionEvent e) -> {
            menu.getCardl().show(menu.getPnHome(), "home1");
            cardl.show(pnContent, "chat");
        });
        menu.getBtnShowFriend().addActionListener((java.awt.event.ActionEvent e) -> {
            menu.getCardl().show(menu.getPnHome(), "home2");
            cardl.show(pnContent, "group");
        });
        menu.getBtnShowNotification().addActionListener((java.awt.event.ActionEvent e) -> {
            menu.getCardl().show(menu.getPnHome(), "home3");
        });
        PublicEvent.getPublicEvent().setEventPersonChat(new EventPersonChat() {
            @Override
            public void eventPersonChat1(User_account user, PeopelMessage mess) {
                eventChat(user, mess.getId_frgr(),false);
            }
            @Override
            public void eventPersonChat2(User_account user) {
                eventChat(user, user.getIdFriend(),false);
            }
        });
        PublicEvent.getPublicEvent().setEventGroupChat((ListChatGroup listChatGroup) -> {
            eventChat(null, 0, true);
            chat.setListChatGroup(listChatGroup);
        });
        addComponentListener(new ComponentAdapter() {
            @Override
            public void componentResized(ComponentEvent e) {
                int w = getSize().width;
                int h = getSize().height;
                PublicLoading.getPublicLoading().getLoadSizeGroup().loadSizeGroup(w);
                if(w > 1050){
                    menu.setPreferredSize(new Dimension(470,0));
                    add(menu,BorderLayout.LINE_START);
                    add(pnContent,BorderLayout.CENTER);
                    pnContent.setVisible(true);
                    repaint();
                    revalidate();
                    PublicLoading.getPublicLoading().setLoadSize(() -> {
                    });
                }
                else if(w <= 1050){
                    menu.setPreferredSize(new Dimension(70,0));
                    PublicLoading.getPublicLoading().setLoadSize(() -> {
                        if(w <= 1050){
                            repaint();
                            revalidate();
                            menu.setPreferredSize(new Dimension(70,0));
                            add(menu,BorderLayout.LINE_START);
                            add(pnContent,BorderLayout.CENTER);
                            pnContent.setVisible(true);
                        }
                    });
                    menu.getBtnShowChat().addActionListener((ActionEvent e1) -> {
                        layoutScaling(getSize().width);
                    });
                    menu.getBtnShowFriend().addActionListener((ActionEvent e1) -> {
                        layoutScaling(getSize().width);
                    });
                    menu.getBtnShowNotification().addActionListener((ActionEvent e1) -> {
                        layoutScaling(getSize().width);
                    });
                }
            }
        });
    }
    private void eventChat(User_account user,int id_friend ,boolean  isGroup){
        chat.removeAll();
        chat.setIsGroup(isGroup);
        chat.setIdMe(SocketCommunication.user.getId());
        if(!isGroup){
            chat.setIdFriend(id_friend);
            chat.setUser(user);
        }
        chat.repaint();
        chat.revalidate();
        cardl.show(pnContent,"chat");
    }
    private void layoutScaling(int width){
        if(width <= 1050){
            repaint();
            revalidate();
            add(menu,BorderLayout.CENTER);
            add(pnContent,BorderLayout.LINE_END);
            pnContent.setVisible(false);
        }
        else return;
    }
}
