package clinet.gui.menuleft;

import clinet.gui.publicevent.PublicEvent;
import java.awt.Color;
import lib.FontSchatz;

/**
 *
 * @author Hùng Trần
 */
public class Menu_Left extends javax.swing.JPanel {
    public Menu_Left() {
        initComponents();
        setBackground(FontSchatz.BACKGROUND_CL);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        bntShowSetting = new javax.swing.JButton();
        jPanel2 = new javax.swing.JPanel();
        btnShowChat = new javax.swing.JButton();
        btnShowFriend = new javax.swing.JButton();
        btnShowNotification = new javax.swing.JButton();

        setBackground(new java.awt.Color(255, 153, 51));
        setMaximumSize(new java.awt.Dimension(70, 795));
        setMinimumSize(new java.awt.Dimension(70, 795));
        setPreferredSize(new java.awt.Dimension(70, 795));
        setLayout(new java.awt.BorderLayout());

        jPanel1.setMaximumSize(new java.awt.Dimension(70, 70));
        jPanel1.setMinimumSize(new java.awt.Dimension(70, 70));
        jPanel1.setOpaque(false);
        jPanel1.setPreferredSize(new java.awt.Dimension(70, 70));
        jPanel1.setLayout(new java.awt.GridLayout(1, 0));

        bntShowSetting.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon-setting.png"))); // NOI18N
        bntShowSetting.setBorder(null);
        bntShowSetting.setBorderPainted(false);
        bntShowSetting.setContentAreaFilled(false);
        bntShowSetting.setFocusPainted(false);
        bntShowSetting.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bntShowSettingActionPerformed(evt);
            }
        });
        jPanel1.add(bntShowSetting);

        add(jPanel1, java.awt.BorderLayout.PAGE_END);

        jPanel2.setOpaque(false);
        jPanel2.setPreferredSize(new java.awt.Dimension(70, 75));
        jPanel2.setLayout(new javax.swing.BoxLayout(jPanel2, javax.swing.BoxLayout.PAGE_AXIS));

        btnShowChat.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon-chat.png"))); // NOI18N
        btnShowChat.setBorder(null);
        btnShowChat.setBorderPainted(false);
        btnShowChat.setContentAreaFilled(false);
        btnShowChat.setFocusPainted(false);
        btnShowChat.setMaximumSize(new java.awt.Dimension(70, 70));
        btnShowChat.setMinimumSize(new java.awt.Dimension(70, 70));
        btnShowChat.setPreferredSize(new java.awt.Dimension(70, 70));
        jPanel2.add(btnShowChat);

        btnShowFriend.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon-friend.png"))); // NOI18N
        btnShowFriend.setBorder(null);
        btnShowFriend.setBorderPainted(false);
        btnShowFriend.setContentAreaFilled(false);
        btnShowFriend.setFocusPainted(false);
        btnShowFriend.setMaximumSize(new java.awt.Dimension(70, 70));
        btnShowFriend.setMinimumSize(new java.awt.Dimension(70, 70));
        btnShowFriend.setPreferredSize(new java.awt.Dimension(70, 70));
        jPanel2.add(btnShowFriend);

        btnShowNotification.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon-bell.png"))); // NOI18N
        btnShowNotification.setBorder(null);
        btnShowNotification.setBorderPainted(false);
        btnShowNotification.setContentAreaFilled(false);
        btnShowNotification.setFocusPainted(false);
        btnShowNotification.setMaximumSize(new java.awt.Dimension(70, 70));
        btnShowNotification.setMinimumSize(new java.awt.Dimension(70, 70));
        btnShowNotification.setPreferredSize(new java.awt.Dimension(70, 70));
        jPanel2.add(btnShowNotification);

        add(jPanel2, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents

    private void bntShowSettingActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bntShowSettingActionPerformed
        PublicEvent.getPublicEvent().getShowSetting().showSetting();
    }//GEN-LAST:event_bntShowSettingActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton bntShowSetting;
    private javax.swing.JButton btnShowChat;
    private javax.swing.JButton btnShowFriend;
    private javax.swing.JButton btnShowNotification;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    // End of variables declaration//GEN-END:variables
    public javax.swing.JButton getBntShowSetting() {
        return bntShowSetting;
    }
    public javax.swing.JButton getBtnShowChat() {
        return btnShowChat;
    }
    public javax.swing.JButton getBtnShowFriend() {
        return btnShowFriend;
    }
    public javax.swing.JButton getBtnShowNotification() {
        return btnShowNotification;
    }
}
