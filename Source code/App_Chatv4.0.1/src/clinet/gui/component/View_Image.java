package clinet.gui.component;

import clinet.gui.center.chat.ChatFile;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.filechooser.FileNameExtensionFilter;

/**
 *
 * @author Hùng Trần
 */
public class View_Image extends javax.swing.JComponent {
    private pojo.DataFile dataFile;
    public View_Image() {
        initComponents();
    }
    public void setImage(Icon image){
        pictureBox1.setImage(image);
        this.setVisible(true);
        pictureBox1.setPreferredSize(new Dimension(700, 700));
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
        pictureBox1 = new lib.PictureBox();
        jPanel2 = new javax.swing.JPanel();
        btnClose = new javax.swing.JButton();
        btnDowload = new javax.swing.JButton();

        setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 0, 0, 0));
        setLayout(new java.awt.BorderLayout());

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setBorder(javax.swing.BorderFactory.createEmptyBorder(50, 100, 100, 100));

        pictureBox1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                pictureBox1MousePressed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pictureBox1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addGap(0, 0, 0)
                .addComponent(pictureBox1, javax.swing.GroupLayout.DEFAULT_SIZE, 588, Short.MAX_VALUE))
        );

        add(jPanel1, java.awt.BorderLayout.CENTER);

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));
        jPanel2.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 0, 0, 50));
        jPanel2.setMinimumSize(new java.awt.Dimension(50, 50));
        jPanel2.setPreferredSize(new java.awt.Dimension(50, 50));

        btnClose.setBackground(new java.awt.Color(204, 204, 204));
        btnClose.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/cross.png"))); // NOI18N
        btnClose.setBorder(null);
        btnClose.setBorderPainted(false);
        btnClose.setFocusPainted(false);
        btnClose.setOpaque(false);
        btnClose.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCloseActionPerformed(evt);
            }
        });

        btnDowload.setBackground(new java.awt.Color(204, 204, 204));
        btnDowload.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/download.png"))); // NOI18N
        btnDowload.setBorder(null);
        btnDowload.setBorderPainted(false);
        btnDowload.setFocusPainted(false);
        btnDowload.setOpaque(false);
        btnDowload.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDowloadActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addGap(0, 619, Short.MAX_VALUE)
                .addComponent(btnDowload, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(btnClose, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(btnClose, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addComponent(btnDowload, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        add(jPanel2, java.awt.BorderLayout.PAGE_START);
    }// </editor-fold>//GEN-END:initComponents

    private void pictureBox1MousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pictureBox1MousePressed

    }//GEN-LAST:event_pictureBox1MousePressed

    private void btnCloseActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCloseActionPerformed
        this.setVisible(false);
    }//GEN-LAST:event_btnCloseActionPerformed
    private void btnDowloadActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDowloadActionPerformed
        JFileChooser savefile = new JFileChooser();
        savefile.getFileSystemView().getHomeDirectory();
        savefile.setDialogTitle("Lưu");
        savefile.setSelectedFile(new File(dataFile.getName()));
        savefile.setAcceptAllFileFilterUsed(false);
        String ty  = dataFile.getName();
        ty = ty.substring(ty.indexOf(".")+1,ty.length());
        System.out.print(ty);
        FileNameExtensionFilter filter = new FileNameExtensionFilter(ty, ty);
        savefile.addChoosableFileFilter(filter);
        savefile.setPreferredSize(new Dimension(700, 400));
        int rVal = savefile.showSaveDialog(null);
        if(rVal == JFileChooser.APPROVE_OPTION) {
            try {
                FileOutputStream out = new FileOutputStream(savefile.getSelectedFile());
                out.write(dataFile.getFile());
                out.close();
            } catch (FileNotFoundException ex) {
                Logger.getLogger(ChatFile.class.getName()).log(Level.SEVERE, null, ex);
            } catch (IOException ex) {
                Logger.getLogger(ChatFile.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }//GEN-LAST:event_btnDowloadActionPerformed
    public void setDataFile(pojo.DataFile dataFile) {
        this.dataFile = dataFile;
        setImage(new ImageIcon(dataFile.getFile()));
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnClose;
    private javax.swing.JButton btnDowload;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private lib.PictureBox pictureBox1;
    // End of variables declaration//GEN-END:variables
}
