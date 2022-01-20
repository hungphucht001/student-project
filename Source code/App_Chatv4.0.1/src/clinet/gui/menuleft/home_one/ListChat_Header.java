package clinet.gui.menuleft.home_one;

import lib.Fun;
import clinet.gui.dialog.AddGroup;
import clinet.gui.dialog.AddMess;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.border.MatteBorder;
import lib.FontSchatz;

/**
 *
 * @author Hùng Trần
 */
public class ListChat_Header extends javax.swing.JPanel {
    private boolean isMessage = true;
    public ListChat_Header() {
        initComponents();
        buttonClick();
        init();
        Fun.clickTextField(txtSearch, "Tìm kiếm");
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel2 = new javax.swing.JPanel();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        txtSearch = new javax.swing.JTextField();
        jPanel4 = new javax.swing.JPanel();
        btnMessage = new javax.swing.JButton();
        btnMessgroup = new javax.swing.JButton();

        setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        setMaximumSize(new java.awt.Dimension(432, 196));
        setMinimumSize(new java.awt.Dimension(432, 196));
        setOpaque(false);
        setLayout(new java.awt.BorderLayout());

        jPanel1.setOpaque(false);
        jPanel1.setPreferredSize(new java.awt.Dimension(449, 50));
        jPanel1.setLayout(new java.awt.BorderLayout());

        jLabel1.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        jLabel1.setText("Tin nhắn");
        jPanel1.add(jLabel1, java.awt.BorderLayout.CENTER);

        jPanel2.setOpaque(false);
        jPanel2.setPreferredSize(new java.awt.Dimension(120, 50));
        jPanel2.setLayout(new java.awt.GridLayout(1, 2, 10, 0));

        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon_addmess.png"))); // NOI18N
        jButton1.setToolTipText("Tin nhắn mới");
        jButton1.setBorder(null);
        jButton1.setBorderPainted(false);
        jButton1.setContentAreaFilled(false);
        jButton1.setFocusPainted(false);
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        jPanel2.add(jButton1);

        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon-addgroup.png"))); // NOI18N
        jButton2.setToolTipText("Tạo nhóm");
        jButton2.setBorder(null);
        jButton2.setBorderPainted(false);
        jButton2.setContentAreaFilled(false);
        jButton2.setFocusPainted(false);
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        jPanel2.add(jButton2);

        jPanel1.add(jPanel2, java.awt.BorderLayout.LINE_END);

        add(jPanel1, java.awt.BorderLayout.PAGE_START);

        jPanel3.setBackground(new java.awt.Color(102, 102, 102));
        jPanel3.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(243, 243, 243)));
        jPanel3.setMaximumSize(new java.awt.Dimension(30, 30));
        jPanel3.setMinimumSize(new java.awt.Dimension(30, 30));
        jPanel3.setOpaque(false);
        jPanel3.setPreferredSize(new java.awt.Dimension(30, 60));
        jPanel3.setLayout(new java.awt.BorderLayout());

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/magnifying-glass.png"))); // NOI18N
        jLabel2.setPreferredSize(new java.awt.Dimension(50, 0));
        jPanel3.add(jLabel2, java.awt.BorderLayout.LINE_END);

        txtSearch.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtSearch.setForeground(new java.awt.Color(204, 204, 204));
        txtSearch.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        txtSearch.setOpaque(false);
        jPanel3.add(txtSearch, java.awt.BorderLayout.CENTER);

        add(jPanel3, java.awt.BorderLayout.PAGE_END);

        jPanel4.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 0, 10, 0));
        jPanel4.setMaximumSize(new java.awt.Dimension(220, 58));
        jPanel4.setMinimumSize(new java.awt.Dimension(220, 58));
        jPanel4.setOpaque(false);
        jPanel4.setLayout(new java.awt.GridLayout(1, 2, 10, 0));

        btnMessage.setFont(new java.awt.Font("Arial", 1, 15)); // NOI18N
        btnMessage.setText("Tin nhắn");
        btnMessage.setActionCommand("");
        btnMessage.setBorder(null);
        btnMessage.setContentAreaFilled(false);
        btnMessage.setFocusPainted(false);
        btnMessage.setMaximumSize(new java.awt.Dimension(62, 65));
        btnMessage.setMinimumSize(new java.awt.Dimension(62, 65));
        btnMessage.setPreferredSize(new java.awt.Dimension(62, 65));
        jPanel4.add(btnMessage);

        btnMessgroup.setFont(new java.awt.Font("Arial", 1, 15)); // NOI18N
        btnMessgroup.setText("Tin nhắn nhóm");
        btnMessgroup.setBorder(null);
        btnMessgroup.setContentAreaFilled(false);
        btnMessgroup.setFocusPainted(false);
        btnMessgroup.setMaximumSize(new java.awt.Dimension(62, 30));
        btnMessgroup.setMinimumSize(new java.awt.Dimension(62, 30));
        btnMessgroup.setPreferredSize(new java.awt.Dimension(62, 30));
        jPanel4.add(btnMessgroup);

        add(jPanel4, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        new AddMess(null, true).setVisible(true);
        
    }//GEN-LAST:event_jButton1ActionPerformed
    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        new AddGroup(null, true).setVisible(true);
        
    }//GEN-LAST:event_jButton2ActionPerformed
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnMessage;
    private javax.swing.JButton btnMessgroup;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JTextField txtSearch;
    // End of variables declaration//GEN-END:variables
    private void buttonClick() {
        getBtnMessage().addActionListener((ActionEvent e) -> {
            getBtnMessage().setBorder(new MatteBorder(0, 0, 1, 0, FontSchatz.COLOR_BTN));
            getBtnMessage().setForeground(FontSchatz.COLOR_BTN);
            getBtnMessgroup().setBorder(new MatteBorder(0, 0, 1, 0, Color.white));
            getBtnMessgroup().setForeground(Color.black);
            setIsMessage(true);
        });
        getBtnMessgroup().addActionListener((ActionEvent e) -> {
            getBtnMessgroup().setBorder(new MatteBorder(0, 0, 1, 0, FontSchatz.COLOR_BTN));
            getBtnMessgroup().setForeground(FontSchatz.COLOR_BTN);
            getBtnMessage().setBorder(new MatteBorder(0, 0, 1, 0, Color.white));
            getBtnMessage().setForeground(Color.black);
            setIsMessage(false);
        });
    }
    private void init() {
        getBtnMessage().setBorder(new MatteBorder(0, 0, 1, 0, FontSchatz.COLOR_BTN));
        getBtnMessage().setForeground(FontSchatz.COLOR_BTN);
        getBtnMessgroup().setBorder(new MatteBorder(0, 0, 1, 0, Color.white));
        getBtnMessgroup().setForeground(Color.black);
    }
    public javax.swing.JButton getBtnMessage() {
        return btnMessage;
    }
    public javax.swing.JButton getBtnMessgroup() {
        return btnMessgroup;
    }
    public javax.swing.JTextField getTxtSearch() {
        return txtSearch;
    }
    public void setTxtSearch(javax.swing.JTextField txtSearch) {
        this.txtSearch = txtSearch;
    }
    public boolean isIsMessage() {
        return isMessage;
    }
    public void setIsMessage(boolean isMessage) {
        this.isMessage = isMessage;
    }
}
