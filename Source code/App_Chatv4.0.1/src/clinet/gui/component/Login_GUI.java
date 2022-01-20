/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.component;

import lib.Fun;
import java.awt.Color;
import lib.FontSchatz;

/**
 *
 * @author Hùng Trần
 */
public class Login_GUI extends javax.swing.JPanel {

    public javax.swing.JButton getBtnSigIn() {
        return btnSigIn;
    }
    public void setBtnSigIn(javax.swing.JButton btnSigIn) {
        this.btnSigIn = btnSigIn;
    }
    public Login_GUI() {
        initComponents();
        Fun.setButton(btnDangNhap,FontSchatz.BACKGROUND_CL,FontSchatz.COLOR_TEXT_W);
        Fun.setButton(btnThoat,FontSchatz.BACKGROUND_EXITS,FontSchatz.COLOR_TEXT_W);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnLogin = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jPanel10 = new javax.swing.JPanel();
        jLabel6 = new javax.swing.JLabel();
        jPanel11 = new javax.swing.JPanel();
        jLabel5 = new javax.swing.JLabel();
        jPanel3 = new javax.swing.JPanel();
        jPanel4 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel5 = new javax.swing.JPanel();
        btnDangNhap = new javax.swing.JButton();
        btnThoat = new javax.swing.JButton();
        jPanel6 = new javax.swing.JPanel();
        jPanel7 = new javax.swing.JPanel();
        txtPassword = new javax.swing.JPasswordField();
        jPanel8 = new javax.swing.JPanel();
        txtUsername = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        btnForgotPassword = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        btnSigIn = new javax.swing.JButton();

        setLayout(new java.awt.GridLayout(1, 0));

        pnLogin.setBackground(new java.awt.Color(255, 255, 255));
        pnLogin.setLayout(new java.awt.GridLayout(1, 2));

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));
        jPanel2.setBorder(javax.swing.BorderFactory.createEmptyBorder(150, 150, 150, 150));
        jPanel2.setFocusable(false);
        jPanel2.setLayout(new java.awt.BorderLayout());

        jPanel10.setMinimumSize(new java.awt.Dimension(272, 60));
        jPanel10.setOpaque(false);
        jPanel10.setPreferredSize(new java.awt.Dimension(272, 60));
        jPanel10.setLayout(new java.awt.GridLayout(1, 0));

        jLabel6.setFont(new java.awt.Font("Arial", 1, 48)); // NOI18N
        jLabel6.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel6.setText("SChatZ");
        jPanel10.add(jLabel6);

        jPanel2.add(jPanel10, java.awt.BorderLayout.PAGE_END);

        jPanel11.setOpaque(false);
        jPanel11.setLayout(new java.awt.GridLayout(1, 0));

        jLabel5.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel5.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/logo/icon.png"))); // NOI18N
        jPanel11.add(jLabel5);

        jPanel2.add(jPanel11, java.awt.BorderLayout.CENTER);

        pnLogin.add(jPanel2);

        jPanel3.setBackground(new java.awt.Color(255, 255, 255));
        jPanel3.setLayout(new java.awt.BorderLayout());

        jPanel4.setMaximumSize(new java.awt.Dimension(555, 60));
        jPanel4.setMinimumSize(new java.awt.Dimension(555, 60));
        jPanel4.setOpaque(false);
        jPanel4.setPreferredSize(new java.awt.Dimension(555, 80));
        jPanel4.setLayout(new java.awt.GridLayout(1, 0));

        jLabel1.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Đăng nhập");
        jLabel1.setBorder(javax.swing.BorderFactory.createEmptyBorder(30, 1, 1, 1));
        jPanel4.add(jLabel1);

        jPanel3.add(jPanel4, java.awt.BorderLayout.PAGE_START);

        jPanel5.setBorder(javax.swing.BorderFactory.createEmptyBorder(20, 40, 20, 40));
        jPanel5.setOpaque(false);
        jPanel5.setPreferredSize(new java.awt.Dimension(555, 150));

        btnDangNhap.setText("Đăng nhập");
        btnDangNhap.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnDangNhap.setFocusPainted(false);
        btnDangNhap.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDangNhapActionPerformed(evt);
            }
        });

        btnThoat.setText("Thoát");
        btnThoat.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnThoat.setFocusPainted(false);
        btnThoat.setFocusable(false);
        btnThoat.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnThoatActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel5Layout = new javax.swing.GroupLayout(jPanel5);
        jPanel5.setLayout(jPanel5Layout);
        jPanel5Layout.setHorizontalGroup(
            jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel5Layout.createSequentialGroup()
                .addGap(87, 87, 87)
                .addComponent(btnThoat, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(75, 75, 75)
                .addComponent(btnDangNhap, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(90, Short.MAX_VALUE))
        );
        jPanel5Layout.setVerticalGroup(
            jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel5Layout.createSequentialGroup()
                .addGroup(jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnThoat, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnDangNhap, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(0, 62, Short.MAX_VALUE))
        );

        jPanel3.add(jPanel5, java.awt.BorderLayout.PAGE_END);

        jPanel6.setBorder(javax.swing.BorderFactory.createEmptyBorder(20, 40, 20, 40));
        jPanel6.setOpaque(false);

        jPanel7.setMaximumSize(new java.awt.Dimension(451, 50));
        jPanel7.setMinimumSize(new java.awt.Dimension(451, 50));
        jPanel7.setOpaque(false);
        jPanel7.setPreferredSize(new java.awt.Dimension(451, 50));
        jPanel7.setLayout(new java.awt.GridLayout(1, 0));

        txtPassword.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 2, 0, new java.awt.Color(0, 0, 0)));
        jPanel7.add(txtPassword);

        jPanel8.setMaximumSize(new java.awt.Dimension(451, 50));
        jPanel8.setMinimumSize(new java.awt.Dimension(451, 50));
        jPanel8.setOpaque(false);
        jPanel8.setPreferredSize(new java.awt.Dimension(451, 50));
        jPanel8.setLayout(new java.awt.GridLayout(1, 0));

        txtUsername.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtUsername.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 2, 0, new java.awt.Color(0, 0, 0)));
        jPanel8.add(txtUsername);

        jLabel3.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        jLabel3.setText("Tên đăng nhập");

        jLabel4.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        jLabel4.setText("Mật khẩu");

        btnForgotPassword.setBackground(new java.awt.Color(255, 255, 255));
        btnForgotPassword.setFont(new java.awt.Font("Tahoma", 0, 16)); // NOI18N
        btnForgotPassword.setForeground(new java.awt.Color(0, 0, 255));
        btnForgotPassword.setText("Quên mật khẩu");
        btnForgotPassword.setBorder(null);
        btnForgotPassword.setBorderPainted(false);
        btnForgotPassword.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnForgotPassword.setFocusPainted(false);
        btnForgotPassword.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);

        jLabel2.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        jLabel2.setText("Chưa có tài khoản ");

        btnSigIn.setBackground(new java.awt.Color(255, 255, 255));
        btnSigIn.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        btnSigIn.setText("Đăng kí");
        btnSigIn.setBorder(null);
        btnSigIn.setBorderPainted(false);
        btnSigIn.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnSigIn.setDefaultCapable(false);
        btnSigIn.setFocusPainted(false);
        btnSigIn.setFocusable(false);
        btnSigIn.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        btnSigIn.setOpaque(false);
        btnSigIn.setRequestFocusEnabled(false);
        btnSigIn.setRolloverEnabled(false);
        btnSigIn.setVerifyInputWhenFocusTarget(false);

        javax.swing.GroupLayout jPanel6Layout = new javax.swing.GroupLayout(jPanel6);
        jPanel6.setLayout(jPanel6Layout);
        jPanel6Layout.setHorizontalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jPanel8, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jPanel7, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(jPanel6Layout.createSequentialGroup()
                        .addGroup(jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel6Layout.createSequentialGroup()
                                .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, 135, Short.MAX_VALUE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnSigIn, javax.swing.GroupLayout.DEFAULT_SIZE, 67, Short.MAX_VALUE))
                            .addGroup(jPanel6Layout.createSequentialGroup()
                                .addComponent(btnForgotPassword)
                                .addGap(0, 0, Short.MAX_VALUE)))
                        .addGap(266, 266, 266))
                    .addGroup(jPanel6Layout.createSequentialGroup()
                        .addGroup(jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel3)
                            .addComponent(jLabel4))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        jPanel6Layout.setVerticalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addGap(60, 60, 60)
                .addComponent(jLabel3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jPanel8, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jLabel4)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jPanel7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(46, 46, 46)
                .addGroup(jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(btnSigIn, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnForgotPassword)
                .addGap(0, 0, 0))
        );

        jPanel3.add(jPanel6, java.awt.BorderLayout.CENTER);

        pnLogin.add(jPanel3);

        add(pnLogin);
    }// </editor-fold>//GEN-END:initComponents
    private void btnDangNhapActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDangNhapActionPerformed

    }//GEN-LAST:event_btnDangNhapActionPerformed
    private void btnThoatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnThoatActionPerformed
        System.exit(0);
    }//GEN-LAST:event_btnThoatActionPerformed
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnDangNhap;
    private javax.swing.JButton btnForgotPassword;
    private javax.swing.JButton btnSigIn;
    private javax.swing.JButton btnThoat;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JPanel jPanel10;
    private javax.swing.JPanel jPanel11;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel7;
    private javax.swing.JPanel jPanel8;
    private javax.swing.JPanel pnLogin;
    private javax.swing.JPasswordField txtPassword;
    private javax.swing.JTextField txtUsername;
    // End of variables declaration//GEN-END:variables
    public javax.swing.JButton getBtnDangNhap() {
        return btnDangNhap;
    }
    public javax.swing.JPasswordField getTxtPassword() {
        return txtPassword;
    }
    public javax.swing.JTextField getTxtUsername() {
        return txtUsername;
    }
    public javax.swing.JButton getBtnForgotPassword() {
        return btnForgotPassword;
    }
}
