package clinet.gui.center.chat;

import clinet.gui.publicevent.PublicEvent;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.RenderingHints;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.ImageIcon;
import lib.FontSchatz;
import pojo.DataFile;

/**
 *
 * @author Hùng Trần
 */
public class ChatItem extends javax.swing.JPanel {
    private Color background,foreground;
    private int type;//0 - Text   1 - Image   2 - file   3  - Sticker
    private String content;
    private DataFile dataFile;
    public ChatItem(Color background,Color foreground, pojo.PeopelMessage mess, int dateauto) {
        this.background = background;
        this.foreground = foreground;
        this.type = mess.getType();
        dataFile = mess.getDataFile();
        this.content = mess.getContent();
        initComponents();
        if(dateauto == 1){
            setTimeAuto();
        }
        checkMessageType();
        lbTime.setForeground(foreground);
    }
    public ChatItem(Color background,Color foreground, pojo.GroupMessage mess, int dateauto) {
        this.background = background;
        this.foreground = foreground;
        dataFile = mess.getDataFile();
        this.content = mess.getContent();
        this.type = mess.getType();
        initComponents();
        if(dateauto == 1){
            setTimeAuto();
        }
        checkMessageType();
        lbTime.setForeground(foreground);
    }
    private void checkMessageType() {
        if(type == 0){
            setText(content);
        }
        else if(type == 3){
            setSticker(content);
            pnTime.setVisible(false);
        }else if(type == 2){
           setFile(dataFile);
        }
        else if(type == 1){
            setImage(dataFile);
        }
        else if(type == 4)
        {
            setMp3(dataFile);
        }
    }
    private void setSticker(String text){
        ChatSticker chatSticker = new ChatSticker();
        chatSticker.setSticker(text);
        pnContent.add(chatSticker);
    }
    private void setText(String text){
        ChatText chattext = new ChatText();
        chattext.setText(text);
        chattext.setColorText(foreground);
        pnContent.add(chattext);
    }
    public void setTime(String dateString){
        lbTime.setText(dateString);
    }
    public void setTimeAuto(){
        String isoDatePattern = "HH:mm";
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat(isoDatePattern);
        String dateString = simpleDateFormat.format(new Date());
        lbTime.setText(dateString);
    }
    private void setImage(pojo.DataFile dataFile){
        ChatImage chatImage = new ChatImage(dataFile);
        pnContent.add(chatImage);
    }
    private void setMp3(DataFile dataFile){
        ChatMp3 chatMp3 = new ChatMp3(dataFile);
        pnContent.add(chatMp3);
    }
    private void setFile(pojo.DataFile dataFile) {
        ChatFile chatFile = new ChatFile(dataFile,foreground);
        pnContent.add(chatFile);
    }
    protected void paintComponent(Graphics grphcs) {
        Graphics2D g2 = (Graphics2D) grphcs;
        g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);
        if(type != 3){
            g2.setColor(background);
        }
        else g2.setColor(FontSchatz.BACKGROUND_CHAT);
        g2.fillRoundRect(0, 0, getWidth(), getHeight(), 15, 15);
        super.paintComponent(grphcs);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel2 = new javax.swing.JPanel();
        pnContent = new javax.swing.JPanel();
        pnTime = new javax.swing.JPanel();
        lbTime = new javax.swing.JLabel();

        setBackground(new java.awt.Color(102, 204, 0));
        setOpaque(false);
        setLayout(new javax.swing.BoxLayout(this, javax.swing.BoxLayout.PAGE_AXIS));

        jPanel2.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 0, 0, 0));
        jPanel2.setOpaque(false);
        jPanel2.setLayout(new javax.swing.BoxLayout(jPanel2, javax.swing.BoxLayout.PAGE_AXIS));

        pnContent.setBackground(new java.awt.Color(255, 153, 153));
        pnContent.setOpaque(false);
        pnContent.setLayout(new java.awt.GridLayout(1, 0));
        jPanel2.add(pnContent);

        pnTime.setBackground(new java.awt.Color(255, 0, 102));
        pnTime.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 0, 3, 0));
        pnTime.setMaximumSize(new java.awt.Dimension(32767, 7));
        pnTime.setMinimumSize(new java.awt.Dimension(48, 7));
        pnTime.setOpaque(false);
        pnTime.setLayout(new java.awt.GridLayout(1, 0));

        lbTime.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        lbTime.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        lbTime.setText("5:02");
        lbTime.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 10, 0, 10));
        pnTime.add(lbTime);

        jPanel2.add(pnTime);

        add(jPanel2);
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel jPanel2;
    private javax.swing.JLabel lbTime;
    private javax.swing.JPanel pnContent;
    private javax.swing.JPanel pnTime;
    // End of variables declaration//GEN-END:variables
}
