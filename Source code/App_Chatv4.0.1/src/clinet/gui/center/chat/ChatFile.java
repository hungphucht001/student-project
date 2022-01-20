package clinet.gui.center.chat;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.List;
import java.awt.event.ActionEvent;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.filechooser.FileNameExtensionFilter;

/**
 *
 * @author Hùng Trần
 */
public class ChatFile extends javax.swing.JLayeredPane {
    private String content;
    private FileInfo fileInfo;
    private pojo.DataFile dataFile;
    
    public ChatFile(pojo.DataFile dataFile,Color foreground) {
        
        this.content = dataFile.getName();
        int index = content.indexOf("_");
        content = content.substring(index + 1, content.length()); 
        this.dataFile = dataFile;
        fileInfo = new FileInfo();
        initComponents();
        setInfo();
        setColorText(foreground);
        if(dataFile.getType() == 5)
            btnDowload.setEnabled(false);
    }
    public void setColorText(Color clr){
        txtName.setForeground(clr);
        txtSize.setForeground(clr);
    }
    public void setBack(Color clr){
        btnDowload.setBackground(clr);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel2 = new javax.swing.JPanel();
        lbLogo = new javax.swing.JLabel();
        jPanel4 = new javax.swing.JPanel();
        txtName = new javax.swing.JLabel();
        txtSize = new javax.swing.JLabel();
        jPanel3 = new javax.swing.JPanel();
        btnDowload = new javax.swing.JButton();

        setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 0, 0, 0));
        setMaximumSize(new java.awt.Dimension(450, 100));
        setMinimumSize(new java.awt.Dimension(450, 100));
        setLayout(new java.awt.BorderLayout());

        jPanel2.setMaximumSize(new java.awt.Dimension(90, 80));
        jPanel2.setMinimumSize(new java.awt.Dimension(90, 80));
        jPanel2.setOpaque(false);
        jPanel2.setPreferredSize(new java.awt.Dimension(90, 80));
        jPanel2.setLayout(new java.awt.GridLayout(1, 1));

        lbLogo.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jPanel2.add(lbLogo);

        add(jPanel2, java.awt.BorderLayout.LINE_START);

        jPanel4.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 5, 1, 1));
        jPanel4.setOpaque(false);

        txtName.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        txtName.setText("FIle mới");

        txtSize.setText("5:20");

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(txtName, javax.swing.GroupLayout.DEFAULT_SIZE, 294, Short.MAX_VALUE)
            .addComponent(txtSize, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addContainerGap(19, Short.MAX_VALUE)
                .addComponent(txtName)
                .addGap(18, 18, 18)
                .addComponent(txtSize)
                .addGap(26, 26, 26))
        );

        add(jPanel4, java.awt.BorderLayout.CENTER);

        jPanel3.setMaximumSize(new java.awt.Dimension(60, 100));
        jPanel3.setMinimumSize(new java.awt.Dimension(60, 100));
        jPanel3.setOpaque(false);
        jPanel3.setPreferredSize(new java.awt.Dimension(60, 100));
        jPanel3.setLayout(new java.awt.GridLayout(1, 0));

        btnDowload.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/download.png"))); // NOI18N
        btnDowload.setBorder(null);
        btnDowload.setContentAreaFilled(false);
        btnDowload.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDowloadActionPerformed(evt);
            }
        });
        jPanel3.add(btnDowload);

        add(jPanel3, java.awt.BorderLayout.LINE_END);
    }// </editor-fold>//GEN-END:initComponents

    private void btnDowloadActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDowloadActionPerformed
            JFileChooser savefile = new JFileChooser();
            savefile.getFileSystemView().getHomeDirectory();
            savefile.setSelectedFile(new File(dataFile.getName()));
            savefile.setAcceptAllFileFilterUsed(false);
            String ty  = dataFile.getName();
            ty = ty.substring(ty.indexOf(".")+1,ty.length());
            FileNameExtensionFilter filter = new FileNameExtensionFilter(ty, ty);
            savefile.addChoosableFileFilter(filter);
            savefile.setPreferredSize(new Dimension(700, 400));
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
    private void setInfo(){
        lbLogo.setIcon(new ImageIcon(fileInfo.setLogoFile(content)));
        txtName.setText(fileInfo.setNameFile(content, 40));
        txtSize.setText(fileInfo.setSizeFile(dataFile.getFileSize()) + " MB");
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnDowload;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JLabel lbLogo;
    private javax.swing.JLabel txtName;
    private javax.swing.JLabel txtSize;
    // End of variables declaration//GEN-END:variables
    public void setSendFile(pojo.DataFile dataFile) {
        this.dataFile = dataFile;
    }
}
