package clinet.gui.center.chat;

import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Image;
import java.awt.Rectangle;
import java.awt.RenderingHints;
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
import pojo.DataFile;

/**
 *
 * @author Hùng Trần
 */
public class FileItem extends javax.swing.JPanel {
    private Icon image;
    private DataFile dataFile;
    public FileItem() {
        initComponents();
    }
    public void setInfo(String logo ,String name, double size,DataFile dataFile){
        image = new ImageIcon(logo);
        
        if(dataFile.getType() == 5)
            btnDowload.setEnabled(false);
        
        int index = name.indexOf("_");
        name = name.substring(index + 1, name.length()); 
        
        lbName.setText(name);
        pictureBox1.setImage(image);
        this.dataFile = dataFile;
        lbSize.setText(size+" MB");
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        pictureBox1 = new lib.PictureBox();
        jPanel2 = new javax.swing.JPanel();
        btnDowload = new javax.swing.JButton();
        jPanel4 = new javax.swing.JPanel();
        lbName = new javax.swing.JLabel();
        lbSize = new javax.swing.JLabel();

        setBackground(new java.awt.Color(255, 255, 255));
        setMaximumSize(new java.awt.Dimension(2147483647, 60));
        setMinimumSize(new java.awt.Dimension(0, 60));
        setPreferredSize(new java.awt.Dimension(400, 60));
        setLayout(new java.awt.BorderLayout());

        jPanel1.setMaximumSize(new java.awt.Dimension(60, 60));
        jPanel1.setMinimumSize(new java.awt.Dimension(60, 60));
        jPanel1.setOpaque(false);
        jPanel1.setPreferredSize(new java.awt.Dimension(60, 60));
        jPanel1.setLayout(new java.awt.GridLayout(1, 0));
        jPanel1.add(pictureBox1);

        add(jPanel1, java.awt.BorderLayout.LINE_START);

        jPanel2.setMaximumSize(new java.awt.Dimension(60, 60));
        jPanel2.setMinimumSize(new java.awt.Dimension(60, 60));
        jPanel2.setOpaque(false);
        jPanel2.setPreferredSize(new java.awt.Dimension(60, 60));
        jPanel2.setLayout(new java.awt.GridLayout(1, 0));

        btnDowload.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/download.png"))); // NOI18N
        btnDowload.setBorder(null);
        btnDowload.setBorderPainted(false);
        btnDowload.setContentAreaFilled(false);
        btnDowload.setFocusPainted(false);
        btnDowload.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDowloadActionPerformed(evt);
            }
        });
        jPanel2.add(btnDowload);

        add(jPanel2, java.awt.BorderLayout.LINE_END);

        jPanel4.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 10, 1, 10));
        jPanel4.setMaximumSize(new java.awt.Dimension(32767, 60));
        jPanel4.setMinimumSize(new java.awt.Dimension(100, 60));
        jPanel4.setOpaque(false);
        jPanel4.setPreferredSize(new java.awt.Dimension(280, 60));

        lbName.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        lbName.setText("ahsduihasoias.dox");

        lbSize.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        lbSize.setText("lbSize");

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(lbName, javax.swing.GroupLayout.DEFAULT_SIZE, 271, Short.MAX_VALUE)
                    .addComponent(lbSize, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addGap(0, 0, Short.MAX_VALUE))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addComponent(lbName, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(lbSize, javax.swing.GroupLayout.PREFERRED_SIZE, 16, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        add(jPanel4, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents

    private void btnDowloadActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDowloadActionPerformed
        JFileChooser savefile = new JFileChooser();
        savefile.getFileSystemView().getHomeDirectory();
        savefile.setDialogTitle("Lưu File");
        savefile.setSelectedFile(new File(dataFile.getName()));
        savefile.setPreferredSize(new Dimension(700, 400));
        savefile.setAcceptAllFileFilterUsed(false);
        String ty  = dataFile.getName();
        ty = ty.substring(ty.indexOf(".")+1,ty.length());
        System.out.print(ty);
        FileNameExtensionFilter filter = new FileNameExtensionFilter(ty, ty);
        savefile.addChoosableFileFilter(filter);
        int rVal = savefile.showSaveDialog(null);
        if(rVal == JFileChooser.APPROVE_OPTION) {
            try {
                FileOutputStream out = new FileOutputStream(savefile.getSelectedFile());
                out.write(dataFile.getFile());
                out.close();
            } catch (Exception ex) {
                ex.printStackTrace();
            }
        }
    }//GEN-LAST:event_btnDowloadActionPerformed
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnDowload;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JLabel lbName;
    private javax.swing.JLabel lbSize;
    private lib.PictureBox pictureBox1;
    // End of variables declaration//GEN-END:variables
}
