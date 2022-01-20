package clinet.gui.center.chat;

import clinet.gui.publicevent.PublicEvent;
import jaco.mp3.player.MP3Player;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.BufferedInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.JMenuItem;
import javax.swing.JPopupMenu;
import javax.swing.SwingUtilities;
import javax.swing.filechooser.FileNameExtensionFilter;
import javazoom.jl.decoder.JavaLayerException;
import javazoom.jl.player.Player;
import pojo.DataFile;
import pojo.ListChatGroup;

/**
 *
 * @author Hùng Trần
 */
public class ChatMp3 extends javax.swing.JPanel {
    private boolean isPlayer = true;
    private MP3Player playerMp3;
    private Thread th;
    private DataFile dataFile;
    private JPopupMenu popupMenu;
    public ChatMp3(DataFile dataFile) {
        this.dataFile = dataFile;
        playerMp3 = new MP3Player();
        initComponents();
        putar();
        init();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnWrap = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        btnPlay = new javax.swing.JButton();
        btnStop = new javax.swing.JButton();

        setOpaque(false);
        setLayout(new java.awt.GridLayout(1, 0));

        pnWrap.setBackground(new java.awt.Color(255, 255, 255));
        pnWrap.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        pnWrap.setOpaque(false);
        pnWrap.setLayout(new java.awt.BorderLayout());

        jPanel2.setOpaque(false);
        jPanel2.setLayout(new java.awt.GridLayout(1, 0));

        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/Sound-Wave-icon.png"))); // NOI18N
        jLabel1.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 20, 0, 20));
        jPanel2.add(jLabel1);

        pnWrap.add(jPanel2, java.awt.BorderLayout.CENTER);

        jPanel1.setOpaque(false);
        jPanel1.setLayout(new java.awt.GridLayout(1, 2));

        btnPlay.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/play-icon.png"))); // NOI18N
        btnPlay.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 10, 1, 10));
        btnPlay.setBorderPainted(false);
        btnPlay.setContentAreaFilled(false);
        btnPlay.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPlayActionPerformed(evt);
            }
        });
        jPanel1.add(btnPlay);

        btnStop.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/stop-icon.png"))); // NOI18N
        btnStop.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 10, 1, 10));
        btnStop.setBorderPainted(false);
        btnStop.setContentAreaFilled(false);
        btnStop.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnStopActionPerformed(evt);
            }
        });
        jPanel1.add(btnStop);

        pnWrap.add(jPanel1, java.awt.BorderLayout.LINE_START);

        add(pnWrap);
    }// </editor-fold>//GEN-END:initComponents

    private void btnPlayActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPlayActionPerformed
        if(isPlayer == true){
            play();
            isPlayer = false;
            btnPlay.setIcon(new ImageIcon(getClass().getResource("/data/assets/icons/pause-icon.png")));
        }
        else {
            isPlayer = true;
            pause();
            btnPlay.setIcon(new ImageIcon(getClass().getResource("/data/assets/icons/play-icon.png")));
        }
    }//GEN-LAST:event_btnPlayActionPerformed

    private void btnStopActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnStopActionPerformed
        playerMp3.stop();
        isPlayer = true;
        btnPlay.setIcon(new ImageIcon(getClass().getResource("/data/assets/icons/play-icon.png")));
    }//GEN-LAST:event_btnStopActionPerformed
    void putar(){
        try{
            File f = new File("./src/data/assets/mp3/default.mp3");
            
            FileOutputStream fos = new FileOutputStream(f);
            fos.write(dataFile.getFile());
            fos.close();
            
            playerMp3.addToPlayList(f);
            
        }catch(Exception e){
            System.out.println(e);
        }
    }
    private void play(){
        playerMp3.play();
    } 
    private void pause(){
        playerMp3.pause();
    }
    private byte[] convertFileToByte(File f) throws IOException{
        FileInputStream in = null;
        try {
            in = new FileInputStream(f);
            byte b[] = new byte[in.available()];
            in.read(b);
            return b;
        } catch (FileNotFoundException ex) {
            ex.printStackTrace();
        } finally {
            try {
                in.close();
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        }
        return null;
    }
    private void init() {
        setCursor(new Cursor(Cursor.HAND_CURSOR));
        popupMenu = new JPopupMenu();
        JMenuItem mnItDowLoad= new JMenuItem("Tải xuống");
        popupMenu.add(mnItDowLoad);
        mnItDowLoad.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JFileChooser savefile = new JFileChooser();
                savefile.getFileSystemView().getHomeDirectory();
                savefile.setDialogTitle("Lưu File");
                savefile.setSelectedFile(new File(dataFile.getName()));
                savefile.setPreferredSize(new Dimension(700, 400));
                savefile.setAcceptAllFileFilterUsed(false);
                String ty  = dataFile.getName();
                ty = ty.substring(ty.indexOf(".")+1,ty.length());
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
            }
        });
        pnWrap.addMouseListener(new MouseAdapter() {
            public void mouseReleased(MouseEvent e) {
                if(SwingUtilities.isRightMouseButton(e)){
                    popupMenu.show(pnWrap, e.getX(), e.getY());
                }
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnPlay;
    private javax.swing.JButton btnStop;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel pnWrap;
    // End of variables declaration//GEN-END:variables
}
