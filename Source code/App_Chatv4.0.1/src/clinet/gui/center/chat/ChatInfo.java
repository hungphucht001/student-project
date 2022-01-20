package clinet.gui.center.chat;

import clinet.gui.publicevent.PublicEvent;
import java.awt.Color;
import java.awt.Component;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.File;
import java.util.ArrayList;
import static java.util.Collections.reverse;
import javax.swing.BorderFactory;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;
import lib.FontSchatz;
import lib.PictureBox;
import lib.ScrollBar;
import net.miginfocom.swing.MigLayout;
import pojo.DataFile;
/**
 *
 * @author Hùng Trần
 */
public class ChatInfo extends javax.swing.JPanel {
    private FileInfo fileInfo;
    private ArrayList<pojo.PeopelMessage> alMessFM;
    public ChatInfo() {
        initComponents();
        fileInfo = new FileInfo();
        pnContentMedia.setLayout(new MigLayout("fillx","3[fill]3[fill]3[fill]3"));
        pnContentFile.setLayout(new MigLayout("fillx","10[]10","7[]7"));
        btnMedia.setBorder(BorderFactory.createMatteBorder(0, 0, 2, 0, FontSchatz.COLOR_BTN));
        btnMedia.setForeground(FontSchatz.COLOR_BTN);
        spInfo.setVerticalScrollBar(new ScrollBar());
        spInfo.getVerticalScrollBar().setUnitIncrement(40);
        spInfo.setViewportView(pnContentMedia);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnContentFile = new javax.swing.JPanel();
        jPanel1 = new javax.swing.JPanel();
        lbTitle = new javax.swing.JLabel();
        jPanel2 = new javax.swing.JPanel();
        jPanel3 = new javax.swing.JPanel();
        btnMedia = new javax.swing.JButton();
        btnFile = new javax.swing.JButton();
        jPanel4 = new javax.swing.JPanel();
        spInfo = new javax.swing.JScrollPane();
        pnContentMedia = new javax.swing.JPanel();

        pnContentFile.setBackground(new java.awt.Color(255, 255, 255));

        javax.swing.GroupLayout pnContentFileLayout = new javax.swing.GroupLayout(pnContentFile);
        pnContentFile.setLayout(pnContentFileLayout);
        pnContentFileLayout.setHorizontalGroup(
            pnContentFileLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 400, Short.MAX_VALUE)
        );
        pnContentFileLayout.setVerticalGroup(
            pnContentFileLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 617, Short.MAX_VALUE)
        );

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.BorderLayout());

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setMaximumSize(new java.awt.Dimension(32767, 70));
        jPanel1.setMinimumSize(new java.awt.Dimension(70, 70));
        jPanel1.setPreferredSize(new java.awt.Dimension(400, 70));
        jPanel1.setLayout(new java.awt.GridLayout(1, 0));

        lbTitle.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lbTitle.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lbTitle.setText("Media");
        lbTitle.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(200, 200, 200)));
        jPanel1.add(lbTitle);

        add(jPanel1, java.awt.BorderLayout.PAGE_START);

        jPanel2.setOpaque(false);
        jPanel2.setLayout(new java.awt.BorderLayout());

        jPanel3.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jPanel3.setOpaque(false);
        jPanel3.setLayout(new java.awt.GridLayout(1, 2, 20, 0));

        btnMedia.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        btnMedia.setText("Media");
        btnMedia.setBorder(null);
        btnMedia.setContentAreaFilled(false);
        btnMedia.setFocusPainted(false);
        btnMedia.setPreferredSize(new java.awt.Dimension(47, 37));
        btnMedia.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMediaActionPerformed(evt);
            }
        });
        jPanel3.add(btnMedia);

        btnFile.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        btnFile.setText("File");
        btnFile.setBorder(null);
        btnFile.setContentAreaFilled(false);
        btnFile.setFocusPainted(false);
        btnFile.setPreferredSize(new java.awt.Dimension(47, 37));
        btnFile.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnFileActionPerformed(evt);
            }
        });
        jPanel3.add(btnFile);

        jPanel2.add(jPanel3, java.awt.BorderLayout.PAGE_START);

        jPanel4.setOpaque(false);
        jPanel4.setLayout(new java.awt.GridLayout(1, 0));

        spInfo.setBackground(new java.awt.Color(255, 255, 255));
        spInfo.setBorder(null);
        spInfo.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        spInfo.setOpaque(false);

        pnContentMedia.setBackground(new java.awt.Color(255, 255, 255));

        javax.swing.GroupLayout pnContentMediaLayout = new javax.swing.GroupLayout(pnContentMedia);
        pnContentMedia.setLayout(pnContentMediaLayout);
        pnContentMediaLayout.setHorizontalGroup(
            pnContentMediaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 405, Short.MAX_VALUE)
        );
        pnContentMediaLayout.setVerticalGroup(
            pnContentMediaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 617, Short.MAX_VALUE)
        );

        spInfo.setViewportView(pnContentMedia);

        jPanel4.add(spInfo);

        jPanel2.add(jPanel4, java.awt.BorderLayout.CENTER);

        add(jPanel2, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents

    private void btnMediaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMediaActionPerformed
        btnMedia.setBorder(BorderFactory.createMatteBorder(0, 0, 2, 0, FontSchatz.COLOR_BTN));
        btnMedia.setForeground(FontSchatz.COLOR_BTN);
        btnFile.setBorder(BorderFactory.createMatteBorder(0, 0, 2, 0, new Color(255,255,255)));
        btnFile.setForeground(Color.black);
        lbTitle.setText("Media");
        spInfo.setViewportView(pnContentMedia);
    }//GEN-LAST:event_btnMediaActionPerformed

    private void btnFileActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnFileActionPerformed
        btnFile.setBorder(BorderFactory.createMatteBorder(0, 0, 2, 0, FontSchatz.COLOR_BTN));
        btnFile.setForeground(FontSchatz.COLOR_BTN);
        btnMedia.setBorder(BorderFactory.createMatteBorder(0, 0, 2, 0, new Color(255,255,255)));
        btnMedia.setForeground(Color.black);
        lbTitle.setText("File");
        spInfo.setViewportView(pnContentFile);
    }//GEN-LAST:event_btnFileActionPerformed
    public void loadData(){
            int c = 0;
            pnContentMedia.removeAll();
            pnContentFile.removeAll();
            reverse(alMessFM);
            for (pojo.PeopelMessage mess: alMessFM) {
            if(mess.getType() == 1){
                c++;
                JPanel pnImage = new JPanel();
                pnImage.setBackground(Color.black);
                pnImage.setLayout(new GridLayout());
                PictureBox pic = new PictureBox();
                Icon img = new ImageIcon(mess.getDataFile().getFile());
                pnImage.addMouseListener(new MouseAdapter() {
                    public void mouseReleased(MouseEvent e) {
                        PublicEvent.getPublicEvent().getEventImageView().viewImage(mess.getDataFile());
                    }
                    });
                pic.setImage(img);
                pnImage.add(pic);
                addEvent(pic,mess.getDataFile());
                pnImage.setPreferredSize(new Dimension(100, 100));
                if(c==3){
                   pnContentMedia.add(pnImage,"wrap, w 100::100%/3"); 
                   c = 0;
                }
                else{
                    pnContentMedia.add(pnImage," w 100::100%/3");   
                    }
            }
            else{
                FileItem a = new FileItem();
                a.setInfo(fileInfo.setLogoFile(mess.getDataFile().getName()),fileInfo.setNameFile(mess.getDataFile().getName(),40), fileInfo.setSizeFile(mess.getDataFile().getFileSize()),mess.getDataFile());
                pnContentFile.add(a,"wrap, w 100%-20");    
            }
            repaint();
            revalidate();
            }
    }
    private void addEvent(Component com, DataFile dataFile){
        com.setCursor(new Cursor(Cursor.HAND_CURSOR));
        com.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseReleased(MouseEvent e) {
                if(SwingUtilities.isLeftMouseButton(e)){
                    PublicEvent.getPublicEvent().getEventImageView().viewImage(dataFile);
                }
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnFile;
    private javax.swing.JButton btnMedia;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JLabel lbTitle;
    private javax.swing.JPanel pnContentFile;
    private javax.swing.JPanel pnContentMedia;
    private javax.swing.JScrollPane spInfo;
    // End of variables declaration//GEN-END:variables
    public ArrayList<pojo.PeopelMessage> getAlMessFM() {
        return alMessFM;
    }
    public void setAlMessFM(ArrayList<pojo.PeopelMessage> alMessFM) {
        this.alMessFM = alMessFM;
        loadData();
    }
}
