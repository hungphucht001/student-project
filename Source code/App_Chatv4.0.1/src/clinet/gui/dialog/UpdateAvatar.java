/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.dialog;

import lib.Fun;
import clinet.gui.publicevent.PublicEvent;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.filechooser.FileNameExtensionFilter;
import lib.FontSchatz;
import pojo.DataFile;

/**
 *
 * @author Hùng Trần
 */
public class UpdateAvatar extends javax.swing.JDialog {
    private JFileChooser flCs;
    private File selectedFile;
    /**
     * Creates new form UpdateAvatar
     */
    public UpdateAvatar(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        Fun.setButton(btn,FontSchatz.BACKGROUND_CL,FontSchatz.COLOR_TEXT_W);
        this.setLocationRelativeTo(null);
        flCs = new JFileChooser();
        flCs.setAcceptAllFileFilterUsed(false);
        FileNameExtensionFilter filter = new FileNameExtensionFilter("JPG, PNG", "png","jpg");
        flCs.addChoosableFileFilter(filter);
        setFocusable(true);
        addKeyListener(new KeyListener() {

            @Override
            public void keyTyped(KeyEvent e) {
            }

            @Override
            public void keyPressed(KeyEvent e) {
                if(e.getKeyCode() == KeyEvent.VK_ESCAPE)
                {
                    setVisible(false);
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
            }
        });
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        imageAvatar1 = new lib.ImageAvatar();
        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel3 = new javax.swing.JPanel();
        jPanel4 = new javax.swing.JPanel();
        btn = new javax.swing.JButton();
        jPanel5 = new javax.swing.JPanel();
        jPanel6 = new javax.swing.JPanel();
        lbavatar = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Thay đổi ảnh đại diện");
        setResizable(false);
        getContentPane().setLayout(new java.awt.GridLayout(1, 0));

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setLayout(new java.awt.BorderLayout());

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));
        jPanel2.setPreferredSize(new java.awt.Dimension(523, 90));
        jPanel2.setLayout(new java.awt.GridLayout(1, 1));

        jLabel1.setBackground(new java.awt.Color(255, 255, 255));
        jLabel1.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Cập nhật ảnh đại diện");
        jPanel2.add(jLabel1);

        jPanel1.add(jPanel2, java.awt.BorderLayout.PAGE_START);

        jPanel3.setLayout(new java.awt.BorderLayout());

        jPanel4.setBackground(new java.awt.Color(255, 255, 255));
        jPanel4.setLayout(new java.awt.FlowLayout(1, 20, 30));

        btn.setBackground(new java.awt.Color(51, 153, 255));
        btn.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        btn.setText("Thay đổi");
        btn.setBorder(null);
        btn.setFocusPainted(false);
        btn.setPreferredSize(new java.awt.Dimension(100, 45));
        btn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnActionPerformed(evt);
            }
        });
        jPanel4.add(btn);

        jPanel3.add(jPanel4, java.awt.BorderLayout.PAGE_END);

        jPanel5.setBackground(new java.awt.Color(255, 255, 255));

        jPanel6.setBackground(new java.awt.Color(255, 255, 255));
        jPanel6.setPreferredSize(new java.awt.Dimension(150, 150));
        jPanel6.setLayout(new java.awt.GridLayout(1, 0));

        lbavatar.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lbavatar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/U.jpg"))); // NOI18N
        lbavatar.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseReleased(java.awt.event.MouseEvent evt) {
                lbavatarMouseReleased(evt);
            }
        });
        jPanel6.add(lbavatar);

        jPanel5.add(jPanel6);

        jPanel3.add(jPanel5, java.awt.BorderLayout.CENTER);

        jPanel1.add(jPanel3, java.awt.BorderLayout.CENTER);

        getContentPane().add(jPanel1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void lbavatarMouseReleased(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_lbavatarMouseReleased
    int rVal = flCs.showOpenDialog(null);
        if(rVal==JFileChooser.APPROVE_OPTION) {
            selectedFile = flCs.getSelectedFile();
            lbavatar.setVisible(false);
            imageAvatar1.setImage(new ImageIcon(selectedFile.getPath()));
            imageAvatar1.setVisible(true);
            jPanel6.removeAll();
            jPanel6.add(imageAvatar1);
            jPanel6.revalidate();
            jPanel6.repaint();
        }
    }//GEN-LAST:event_lbavatarMouseReleased
    private void btnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnActionPerformed
         try {
            FileInputStream in;
            in = new FileInputStream(selectedFile);
            byte b[] = new byte[in.available()];
            in.read(b);
            pojo.DataFile dataFile = new DataFile(3, b, selectedFile.getName(),selectedFile.length());
            PublicEvent.getPublicEvent().getEventSendToServer().evendUpdateAvatar(dataFile);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }//GEN-LAST:event_btnActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn;
    private lib.ImageAvatar imageAvatar1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JLabel lbavatar;
    // End of variables declaration//GEN-END:variables
}
