package clinet.gui.dialog;

import cambodia.raven.DateChooser;
import clinet.gui.SocketCommunication;
import clinet.gui.publicevent.PublicEvent;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.time.LocalDate;
import java.util.Date;
import javafx.scene.control.DatePicker;
import javax.swing.ImageIcon;
import javax.swing.JComponent;
import javax.swing.JOptionPane;
import lib.DateTimeFormat;
import lib.FontSchatz;
import lib.Fun;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */
public class SettingAccount extends javax.swing.JDialog {
    private pojo.User_account user = SocketCommunication.user;
    private DateBth dateBth = new DateBth(null, true);
    private DateTimeFormat formatDate = new DateTimeFormat();
    public SettingAccount(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);
        this.setFocusable(true);
        Fun.setButton(btnUpdate,FontSchatz.BACKGROUND_CL,FontSchatz.COLOR_TEXT_W);
        Fun.setButton(btnExit,FontSchatz.BACKGROUND_EXITS,FontSchatz.COLOR_TEXT_W);
        loadData();
        xuLySuKien();
            
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jPanel5 = new javax.swing.JPanel();
        imageAvatar = new lib.ImageAvatar();
        jPanel6 = new javax.swing.JPanel();
        lbBackgorup = new javax.swing.JLabel();
        jPanel3 = new javax.swing.JPanel();
        btnExit = new javax.swing.JButton();
        btnUpdate = new javax.swing.JButton();
        jPanel4 = new javax.swing.JPanel();
        jPanel7 = new javax.swing.JPanel();
        jPanel20 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtSurName = new javax.swing.JTextField();
        jPanel21 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        txtName = new javax.swing.JTextField();
        jPanel8 = new javax.swing.JPanel();
        txtAddress = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        jPanel16 = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        txtUsername = new javax.swing.JTextField();
        jPanel17 = new javax.swing.JPanel();
        jLabel7 = new javax.swing.JLabel();
        jPanel9 = new javax.swing.JPanel();
        rdoNam = new javax.swing.JRadioButton();
        rdoNu = new javax.swing.JRadioButton();
        rdoKhac = new javax.swing.JRadioButton();
        jPanel18 = new javax.swing.JPanel();
        jLabel6 = new javax.swing.JLabel();
        txtDateBth = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        jPanel19 = new javax.swing.JPanel();
        txtEmail = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setResizable(false);
        getContentPane().setLayout(new java.awt.GridLayout(1, 0));

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setLayout(new java.awt.BorderLayout());

        jPanel2.setOpaque(false);
        jPanel2.setPreferredSize(new java.awt.Dimension(508, 250));
        jPanel2.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel5.setBackground(new java.awt.Color(204, 204, 204));
        jPanel5.setMaximumSize(new java.awt.Dimension(100, 100));
        jPanel5.setMinimumSize(new java.awt.Dimension(100, 100));
        jPanel5.setOpaque(false);
        jPanel5.setPreferredSize(new java.awt.Dimension(100, 100));
        jPanel5.setLayout(new java.awt.GridLayout(1, 0));
        jPanel5.add(imageAvatar);

        jPanel2.add(jPanel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 140, -1, -1));

        jPanel6.setBackground(new java.awt.Color(255, 255, 255));
        jPanel6.setMaximumSize(new java.awt.Dimension(510, 200));
        jPanel6.setMinimumSize(new java.awt.Dimension(510, 200));
        jPanel6.setPreferredSize(new java.awt.Dimension(510, 0));
        jPanel6.setLayout(new java.awt.GridLayout(1, 0));

        lbBackgorup.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lbBackgorup.setMaximumSize(new java.awt.Dimension(508, 0));
        lbBackgorup.setMinimumSize(new java.awt.Dimension(508, 0));
        lbBackgorup.setPreferredSize(new java.awt.Dimension(508, 0));
        jPanel6.add(lbBackgorup);

        jPanel2.add(jPanel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 510, 200));

        jPanel1.add(jPanel2, java.awt.BorderLayout.PAGE_START);

        jPanel3.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 1, 25, 1));
        jPanel3.setOpaque(false);

        btnExit.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        btnExit.setText("Hủy");
        btnExit.setFocusPainted(false);
        btnExit.setMaximumSize(new java.awt.Dimension(100, 40));
        btnExit.setMinimumSize(new java.awt.Dimension(100, 40));
        btnExit.setPreferredSize(new java.awt.Dimension(100, 40));
        btnExit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnExitActionPerformed(evt);
            }
        });
        jPanel3.add(btnExit);

        btnUpdate.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        btnUpdate.setText("Cập nhật");
        btnUpdate.setFocusPainted(false);
        btnUpdate.setMaximumSize(new java.awt.Dimension(100, 40));
        btnUpdate.setMinimumSize(new java.awt.Dimension(100, 40));
        btnUpdate.setPreferredSize(new java.awt.Dimension(100, 40));
        btnUpdate.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnUpdateActionPerformed(evt);
            }
        });
        jPanel3.add(btnUpdate);

        jPanel1.add(jPanel3, java.awt.BorderLayout.PAGE_END);

        jPanel4.setBackground(new java.awt.Color(204, 0, 102));
        jPanel4.setBorder(javax.swing.BorderFactory.createEmptyBorder(40, 40, 40, 40));
        jPanel4.setOpaque(false);

        jPanel7.setBackground(new java.awt.Color(255, 255, 255));
        jPanel7.setMinimumSize(new java.awt.Dimension(0, 80));
        jPanel7.setPreferredSize(new java.awt.Dimension(430, 80));
        jPanel7.setLayout(new java.awt.GridLayout(1, 2, 5, 0));

        jPanel20.setBackground(new java.awt.Color(255, 255, 255));

        jLabel1.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel1.setText("Họ:");

        txtSurName.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        txtSurName.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(0, 0, 0)));

        javax.swing.GroupLayout jPanel20Layout = new javax.swing.GroupLayout(jPanel20);
        jPanel20.setLayout(jPanel20Layout);
        jPanel20Layout.setHorizontalGroup(
            jPanel20Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jLabel1, javax.swing.GroupLayout.DEFAULT_SIZE, 212, Short.MAX_VALUE)
            .addComponent(txtSurName)
        );
        jPanel20Layout.setVerticalGroup(
            jPanel20Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel20Layout.createSequentialGroup()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtSurName, javax.swing.GroupLayout.DEFAULT_SIZE, 56, Short.MAX_VALUE))
        );

        jPanel7.add(jPanel20);

        jPanel21.setBackground(new java.awt.Color(255, 255, 255));

        jLabel2.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel2.setText("Tên:");

        txtName.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        txtName.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(0, 0, 0)));

        javax.swing.GroupLayout jPanel21Layout = new javax.swing.GroupLayout(jPanel21);
        jPanel21.setLayout(jPanel21Layout);
        jPanel21Layout.setHorizontalGroup(
            jPanel21Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(txtName, javax.swing.GroupLayout.DEFAULT_SIZE, 212, Short.MAX_VALUE)
        );
        jPanel21Layout.setVerticalGroup(
            jPanel21Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel21Layout.createSequentialGroup()
                .addComponent(jLabel2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtName, javax.swing.GroupLayout.DEFAULT_SIZE, 56, Short.MAX_VALUE))
        );

        jPanel7.add(jPanel21);

        jPanel8.setBackground(new java.awt.Color(255, 255, 255));
        jPanel8.setMinimumSize(new java.awt.Dimension(0, 80));
        jPanel8.setPreferredSize(new java.awt.Dimension(430, 80));
        jPanel8.setLayout(null);

        txtAddress.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtAddress.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(0, 0, 0)));
        txtAddress.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtAddressActionPerformed(evt);
            }
        });
        jPanel8.add(txtAddress);
        txtAddress.setBounds(0, 20, 430, 60);

        jLabel5.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel5.setText("Địa chỉ");
        jPanel8.add(jLabel5);
        jLabel5.setBounds(0, 0, 430, 17);

        jPanel16.setBackground(new java.awt.Color(255, 255, 255));
        jPanel16.setMinimumSize(new java.awt.Dimension(0, 80));
        jPanel16.setPreferredSize(new java.awt.Dimension(430, 80));
        jPanel16.setLayout(null);

        jLabel3.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel3.setText("Tên đăng nhập:");
        jPanel16.add(jLabel3);
        jLabel3.setBounds(0, 0, 430, 17);

        txtUsername.setEditable(false);
        txtUsername.setBackground(new java.awt.Color(255, 255, 255));
        txtUsername.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtUsername.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(0, 0, 0)));
        txtUsername.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtUsernameActionPerformed(evt);
            }
        });
        jPanel16.add(txtUsername);
        txtUsername.setBounds(0, 20, 430, 60);

        jPanel17.setBackground(new java.awt.Color(255, 255, 255));
        jPanel17.setMinimumSize(new java.awt.Dimension(0, 80));
        jPanel17.setPreferredSize(new java.awt.Dimension(430, 80));
        jPanel17.setLayout(null);

        jLabel7.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel7.setText("Giới tính");
        jPanel17.add(jLabel7);
        jLabel7.setBounds(0, 0, 430, 17);

        jPanel9.setBackground(new java.awt.Color(255, 255, 255));
        jPanel9.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.CENTER, 20, 20));

        buttonGroup1.add(rdoNam);
        rdoNam.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        rdoNam.setText("Nam");
        rdoNam.setFocusPainted(false);
        rdoNam.setOpaque(false);
        jPanel9.add(rdoNam);

        buttonGroup1.add(rdoNu);
        rdoNu.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        rdoNu.setText("Nữ");
        rdoNu.setFocusPainted(false);
        rdoNu.setOpaque(false);
        jPanel9.add(rdoNu);

        buttonGroup1.add(rdoKhac);
        rdoKhac.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        rdoKhac.setText("Khác");
        rdoKhac.setFocusPainted(false);
        rdoKhac.setOpaque(false);
        jPanel9.add(rdoKhac);

        jPanel17.add(jPanel9);
        jPanel9.setBounds(0, 20, 430, 60);

        jPanel18.setBackground(new java.awt.Color(255, 255, 255));
        jPanel18.setMinimumSize(new java.awt.Dimension(0, 80));
        jPanel18.setPreferredSize(new java.awt.Dimension(430, 80));
        jPanel18.setLayout(null);

        jLabel6.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel6.setText("Ngày sinh:");
        jPanel18.add(jLabel6);
        jLabel6.setBounds(0, 0, 430, 17);

        txtDateBth.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtDateBth.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(0, 0, 0)));
        txtDateBth.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtDateBthActionPerformed(evt);
            }
        });
        jPanel18.add(txtDateBth);
        txtDateBth.setBounds(0, 20, 320, 60);

        jButton1.setBackground(new java.awt.Color(0, 153, 153));
        jButton1.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        jButton1.setForeground(new java.awt.Color(255, 255, 255));
        jButton1.setText("Chọn ngày");
        jButton1.setBorder(null);
        jButton1.setFocusPainted(false);
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        jPanel18.add(jButton1);
        jButton1.setBounds(320, 30, 110, 50);

        jPanel19.setBackground(new java.awt.Color(255, 255, 255));
        jPanel19.setMinimumSize(new java.awt.Dimension(0, 80));
        jPanel19.setPreferredSize(new java.awt.Dimension(430, 80));
        jPanel19.setLayout(null);

        txtEmail.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtEmail.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(0, 0, 0)));
        txtEmail.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtEmailActionPerformed(evt);
            }
        });
        jPanel19.add(txtEmail);
        txtEmail.setBounds(0, 20, 430, 60);

        jLabel4.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel4.setText("Email:");
        jPanel19.add(jLabel4);
        jLabel4.setBounds(0, 0, 430, 17);

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel8, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel17, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel18, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel16, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel19, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel7, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addComponent(jPanel7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel16, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel19, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel8, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel18, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel17, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );

        jPanel1.add(jPanel4, java.awt.BorderLayout.CENTER);

        getContentPane().add(jPanel1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnUpdateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnUpdateActionPerformed
        int yearNow = new Date().getYear();
        int yearO = formatDate.convertStrToDate(txtDateBth.getText()).getYear();
        if((yearNow - yearO) > 14)
        {
            user.setName(txtName.getText());
            user.setSurname(txtSurName.getText());
            user.setEmail(txtEmail.getText());
            int sex = -1;
            if(rdoNam.isSelected()) sex = 0;
            else if(rdoNu.isSelected()) sex = 1;
            else sex = 2;
            user.setSex(sex);
            user.setAddress(txtAddress.getText());
            user.setYearofbirth(txtDateBth.getText());
            loadData();
            PublicEvent.getPublicEvent().getEventSendToServer().evendSendInforUpdate(user);
        }
        else JOptionPane.showMessageDialog(this, "Phải lớn hơn 14 tuổi","Schatz",JOptionPane.WARNING_MESSAGE);
    }//GEN-LAST:event_btnUpdateActionPerformed

    private void txtUsernameActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtUsernameActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtUsernameActionPerformed

    private void txtEmailActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtEmailActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtEmailActionPerformed

    private void txtAddressActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtAddressActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtAddressActionPerformed

    private void btnExitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnExitActionPerformed
        // TODO add your handling code here:
        this.dispose();
    }//GEN-LAST:event_btnExitActionPerformed

    private void txtDateBthActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtDateBthActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtDateBthActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        dateBth.setVisible(true);
    }//GEN-LAST:event_jButton1ActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnExit;
    private javax.swing.JButton btnUpdate;
    private javax.swing.ButtonGroup buttonGroup1;
    private lib.ImageAvatar imageAvatar;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel16;
    private javax.swing.JPanel jPanel17;
    private javax.swing.JPanel jPanel18;
    private javax.swing.JPanel jPanel19;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel20;
    private javax.swing.JPanel jPanel21;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel7;
    private javax.swing.JPanel jPanel8;
    private javax.swing.JPanel jPanel9;
    private javax.swing.JLabel lbBackgorup;
    private javax.swing.JRadioButton rdoKhac;
    private javax.swing.JRadioButton rdoNam;
    private javax.swing.JRadioButton rdoNu;
    private javax.swing.JTextField txtAddress;
    private javax.swing.JTextField txtDateBth;
    private javax.swing.JTextField txtEmail;
    private javax.swing.JTextField txtName;
    private javax.swing.JTextField txtSurName;
    private javax.swing.JTextField txtUsername;
    // End of variables declaration//GEN-END:variables

    private void loadData() {
        lbBackgorup.setIcon(new ImageIcon(SocketCommunication.user.getDataFileBack().getFile()));
        imageAvatar.setImage(new ImageIcon(SocketCommunication.user.getDataFileAvatar().getFile()));
        imageAvatar.setBorderColor(Color.WHITE);
        imageAvatar.setBorderSize(3);
        txtName.setText(user.getName());
        txtSurName.setText(user.getSurname());
        txtUsername.setText(user.getUsername());
        txtEmail.setText(user.getEmail());
        txtAddress.setText(user.getAddress());

        if(user.getSex() == 0){
            rdoNam.setSelected(true);
        }
        else if(user.getSex()==1){
            rdoNu.setSelected(true);
        }
        else rdoKhac.setSelected(true);

        txtDateBth.setText(user.getYearofbirth());
        
        this.setTitle(user.fullName());
    }

    private void xuLySuKien() {
        imageAvatar.addMouseListener(new MouseListener() {

            @Override
            public void mouseClicked(MouseEvent e) {
            }

            @Override
            public void mousePressed(MouseEvent e) {
            }

            @Override
            public void mouseReleased(MouseEvent e) {
                new UpdateAvatar(null, true).setVisible(true);
            }

            @Override
            public void mouseEntered(MouseEvent e) {
            }

            @Override
            public void mouseExited(MouseEvent e) {
            }
        });
        addKeyListener(new KeyListener() {

            @Override
            public void keyTyped(KeyEvent e) {
            }

            @Override
            public void keyPressed(KeyEvent e) {
                if(e.getKeyCode() == KeyEvent.VK_ESCAPE)
                {
                    setVisible(false);
                    dispose();
                }
            }
            @Override
            public void keyReleased(KeyEvent e) {
            }
        });
            dateBth.getBtnOk().addActionListener((ActionEvent e) -> {
            txtDateBth.setText(dateBth.getTxtDate().getText());
            dateBth.setVisible(false);
        });
    }
}
