package clinet.gui.component;

import clinet.dto.Setting_DTO;
import clinet.gui.dialog.ChangePasswordInfor;
import clinet.gui.dialog.SettingAccount;
import clinet.gui.dialog.VersionInfor;
import clinet.gui.publicevent.PublicEvent;
import java.awt.Color;
import java.awt.Desktop;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.IOException;
import java.net.URI;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.JOptionPane;
import lib.ScrollBar;

/**
 *
 * @author Hùng Trần
 */
public class Setting extends javax.swing.JComponent{
    private JList<Setting_DTO> l,lIntroduce,lAccount,lSetting;
    public Setting() {
        initComponents();
        loadData();
        initEvent();
    }
    private void loadData(){
        DefaultListModel<Setting_DTO> dlm = new DefaultListModel<Setting_DTO>();
        dlm.addElement(new Setting_DTO("./src/data/assets/icons/icon_user.png", "./src/data/assets/icons/right.png", "Tài khoản"));
        dlm.addElement(new Setting_DTO("./src/data/assets/icons/icon_settign.png", "./src/data/assets/icons/right.png", "Cài đặt"));
        dlm.addElement(new Setting_DTO("./src/data/assets/icons/icon_i.png", "./src/data/assets/icons/right.png", "Giới thiệu"));
        dlm.addElement(new Setting_DTO("./src/data/assets/icons/icon/icon-logout.png", "", "Đăng xuất"));
        l = new JList<Setting_DTO>(dlm);
        l.setCellRenderer(new SettingRender());
        spMenu.setViewportView(l);
        spMenu.setVerticalScrollBar(new ScrollBar());
        //Account
        DefaultListModel<Setting_DTO> dlmAccount = new DefaultListModel<Setting_DTO>();
        dlmAccount.addElement(new Setting_DTO("", "", "Cập nhật tài khoản"));
        dlmAccount.addElement(new Setting_DTO("", "", "Đổi mật khẩu"));
        lAccount = new JList<Setting_DTO>(dlmAccount);
        lAccount.setCellRenderer(new SettingRender());
        //introduce
        DefaultListModel<Setting_DTO> dlmIntroduce = new DefaultListModel<Setting_DTO>();
        dlmIntroduce.addElement(new Setting_DTO("", "", "Hướng dẫn sử dụng"));
        dlmIntroduce.addElement(new Setting_DTO("", "", "Thông tin liên hệ"));

        lIntroduce = new JList<Setting_DTO>(dlmIntroduce);
        lIntroduce.setCellRenderer(new SettingRender());
        
        DefaultListModel<Setting_DTO> dlmSetting = new DefaultListModel<Setting_DTO>();
        dlmSetting.addElement(new Setting_DTO("", "", "Cài đặt chung"));

        lSetting = new JList<Setting_DTO>(dlmSetting);
        lSetting.setCellRenderer(new SettingRender());
        
        l.setSelectedIndex(0);
        spItem.setViewportView(lAccount);
        spItem.setVerticalScrollBar(new ScrollBar());
    }
     protected void paintComponent(Graphics grphcs) {
        Graphics2D g2 = (Graphics2D) grphcs;
        g2.setColor(new Color(0, 0, 0, 150));
        g2.fillRect(0, 0, getWidth(), getHeight());
        super.paintComponent(grphcs);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jPanel3 = new javax.swing.JPanel();
        jButton2 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jPanel4 = new javax.swing.JPanel();
        jPanel5 = new javax.swing.JPanel();
        jPanel6 = new javax.swing.JPanel();
        spMenu = new javax.swing.JScrollPane();
        jPanel7 = new javax.swing.JPanel();
        spItem = new javax.swing.JScrollPane();

        addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                formMousePressed(evt);
            }
        });
        setLayout(new javax.swing.BoxLayout(this, javax.swing.BoxLayout.LINE_AXIS));

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setBorder(javax.swing.BorderFactory.createEmptyBorder(100, 1, 100, 1));
        jPanel1.setOpaque(false);

        jPanel2.setMaximumSize(new java.awt.Dimension(600, 64564564));
        jPanel2.setMinimumSize(new java.awt.Dimension(600, 700));
        jPanel2.setPreferredSize(new java.awt.Dimension(600, 700));
        jPanel2.setLayout(new java.awt.BorderLayout());

        jPanel3.setBackground(new java.awt.Color(255, 255, 255));
        jPanel3.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(102, 102, 102)));
        jPanel3.setPreferredSize(new java.awt.Dimension(600, 40));
        jPanel3.setLayout(new java.awt.BorderLayout());

        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/cross.png"))); // NOI18N
        jButton2.setBorder(null);
        jButton2.setBorderPainted(false);
        jButton2.setContentAreaFilled(false);
        jButton2.setFocusPainted(false);
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        jPanel3.add(jButton2, java.awt.BorderLayout.LINE_END);

        jLabel1.setFont(new java.awt.Font("Arial", 1, 15)); // NOI18N
        jLabel1.setText("Cài đặt");
        jLabel1.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 10, 1, 1));
        jPanel3.add(jLabel1, java.awt.BorderLayout.CENTER);

        jPanel2.add(jPanel3, java.awt.BorderLayout.PAGE_START);

        jPanel4.setLayout(new java.awt.GridLayout(1, 0));

        jPanel5.setBackground(new java.awt.Color(255, 255, 255));
        jPanel5.setLayout(new java.awt.BorderLayout());

        jPanel6.setBackground(new java.awt.Color(255, 255, 255));
        jPanel6.setBorder(javax.swing.BorderFactory.createCompoundBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 0, 1, new java.awt.Color(200, 200, 200)), javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10)));
        jPanel6.setPreferredSize(new java.awt.Dimension(250, 100));
        jPanel6.setLayout(new java.awt.GridLayout());

        spMenu.setBorder(null);
        spMenu.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        jPanel6.add(spMenu);

        jPanel5.add(jPanel6, java.awt.BorderLayout.LINE_START);

        jPanel7.setBackground(new java.awt.Color(255, 255, 255));
        jPanel7.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jPanel7.setLayout(new java.awt.GridLayout());

        spItem.setBorder(null);
        spItem.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        jPanel7.add(spItem);

        jPanel5.add(jPanel7, java.awt.BorderLayout.CENTER);

        jPanel4.add(jPanel5);

        jPanel2.add(jPanel4, java.awt.BorderLayout.CENTER);

        jPanel1.add(jPanel2);

        add(jPanel1);
    }// </editor-fold>//GEN-END:initComponents

    private void formMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_formMousePressed
    }//GEN-LAST:event_formMousePressed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        this.setVisible(false);
    }//GEN-LAST:event_jButton2ActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel7;
    private javax.swing.JScrollPane spItem;
    private javax.swing.JScrollPane spMenu;
    // End of variables declaration//GEN-END:variables

    private void initEvent() {
        l.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseReleased(MouseEvent e) {
                if(l.getSelectedIndex()==0){
                    spItem.setViewportView(lAccount);
                }
                else if(l.getSelectedIndex()==2){
                    spItem.setViewportView(lIntroduce);
                }
                else if(l.getSelectedIndex()==1){
                    spItem.setViewportView(lSetting);
                }
                else if(l.getSelectedIndex()==3){
                    int tl = JOptionPane.showConfirmDialog(null, "Đăng xuất", "Schatz", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
                    if(tl == JOptionPane.YES_OPTION){
                        PublicEvent.getPublicEvent().getEventSendToServer().eventLogout();
                    }
                    else if(tl== JOptionPane.NO_OPTION){
                        return ;
                    }
                }
            }
        });
        lAccount.addMouseListener(new MouseAdapter() {
             public void mouseReleased(MouseEvent e) {
                if(lAccount.getSelectedIndex()==0){
                    new SettingAccount(null, true).setVisible(true);
                }
                else if(lAccount.getSelectedIndex()== 1){
                    new ChangePasswordInfor(null, true).setVisible(true);
                }
            }
        });
        lIntroduce.addMouseListener(new MouseAdapter() {
             public void mouseReleased(MouseEvent e) {
                if(lIntroduce.getSelectedIndex()==1){
                    new VersionInfor(null, true).setVisible(true);
                }
                else if(lIntroduce.getSelectedIndex()==0){
                    if (Desktop.isDesktopSupported() && Desktop.getDesktop().isSupported(Desktop.Action.BROWSE)) {
                        try {
                            Desktop.getDesktop().browse(new URI("https://hufiedu-my.sharepoint.com/:w:/g/personal/2001190555_hufi_edu_vn/Ec2FYReKxwVMkY-Z8pgvukYB1eC_eMO7dQXz3kb4Uyuk_A?e=QnlrAu"));
                        } catch (Exception ex) {
                            ex.printStackTrace();
                        }
                    }
                }
            }
        });
    }
}
