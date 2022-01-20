package clinet.gui.menuleft;

import clinet.gui.menuleft.home_one.ListChat;
import clinet.gui.menuleft.home_three.ListNotification_GUI;
import clinet.gui.menuleft.home_two.ListFriend;
import clinet.gui.publicLoading.LoadSize;
import clinet.gui.publicLoading.PublicLoading;
import java.awt.BorderLayout;
import java.awt.CardLayout;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentEvent;
import java.awt.event.ComponentListener;
import javax.swing.JButton;
import javax.swing.JPanel;
/**
 *
 * @author Hùng Trần
 */
public class Menu_GUI extends javax.swing.JPanel {
    private CardLayout cardl;
    private JButton btnShowChat, btnShowFriend, btnShowNotification, btnShowSetting;
    private JPanel pnHome, pnHeader, pnMenuLeft;
    private Header header;
    private Menu_Left menuLeft;
    private ListNotification_GUI listNotification;
    private ListFriend listFrend;
    private ListChat listChat;

    public Menu_GUI() {
        initComponents();
        init();
        eventHeadling();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.BorderLayout());
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables

    private void init() {
        cardl = new CardLayout();
        pnHome = new JPanel();
        listFrend = new ListFriend();
        listNotification = new ListNotification_GUI();
        listChat = new ListChat();
        
        getPnHome().setBackground(Color.white);
        getPnHome().setLayout(getCardl());
        getPnHome().add(getListChat(),"home1");
        
        header = new Header();
        menuLeft = new Menu_Left();
        
        pnHeader = header;
        pnMenuLeft = menuLeft;
                
        add(pnHeader,BorderLayout.PAGE_START);
        add(pnMenuLeft,BorderLayout.LINE_START);
        add(getPnHome(),BorderLayout.CENTER);
        
        JPanel pnHome2 = listFrend;
        getPnHome().add(pnHome2,"home2");
        getPnHome().add(listNotification,"home3");
        
        btnShowChat = menuLeft.getBtnShowChat();
        btnShowFriend = menuLeft.getBtnShowFriend();
        btnShowNotification = menuLeft.getBtnShowNotification();
        btnShowSetting = menuLeft.getBntShowSetting();
        
//        PublicLoading.getPublicLoading().setLoadSize(new LoadSize() {
//            @Override
//            public void loadSize(int w, int h) {
//                if(w <= 501){
//                    btnShowChat.addActionListener(new ActionListener() {
//                        @Override
//                        public void actionPerformed(ActionEvent e) {
//                            
//                        }
//                    });
//                }
//            }
//        });
        
    }
    //<editor-fold>
    public CardLayout getCardl() {
        return cardl;
    }
    public JPanel getPnHome() {
        return pnHome;
    }
    private void eventHeadling() {
    }
    public JButton getBtnShowChat() {
        return btnShowChat;
    }
    public JButton getBtnShowFriend() {
        return btnShowFriend;
    }
    public JButton getBtnShowNotification() {
        return btnShowNotification;
    }
    public JButton getBtnShowSetting() {
        return btnShowSetting;
    }
    public ListChat getListChat() {
        return listChat;
    }
    // </editor-fold> 
}
