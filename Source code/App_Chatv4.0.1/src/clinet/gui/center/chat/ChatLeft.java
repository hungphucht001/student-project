package clinet.gui.center.chat;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;
import javax.swing.ImageIcon;
import javax.swing.border.EmptyBorder;
import lib.DateTimeFormat;
import lib.FontSchatz;

/**
 *
 * @author Hùng Trần
 */
public class ChatLeft extends javax.swing.JPanel {
    private static final Color BACKGROUND = FontSchatz.BACKGROUND_CHAT_LEFT;
    private ChatItem chatItem;
    private int type = 0 ;
    public ChatLeft(pojo.PeopelMessage mess ,int dateauto) {
        if(mess.getType() == 0 && mess.getType() == 3){
            chatItem = new ChatItem(BACKGROUND, FontSchatz.COLOR_CHAT_LEFT, mess,dateauto);
        }
        else{
            chatItem = new ChatItem(BACKGROUND, FontSchatz.COLOR_CHAT_LEFT, mess,dateauto);
            }
        chatItem.setTime(new DateTimeFormat().getCurrentTime(mess.getDateofsend()));
        initComponents();
        pnContent.add(chatItem);
    }
    public ChatLeft(pojo.GroupMessage mess ,int dateauto) {
        if(mess.getType() == 0 && mess.getType() == 3){
            chatItem = new ChatItem(BACKGROUND, FontSchatz.COLOR_CHAT_LEFT, mess,dateauto);
        }
        else{
            chatItem = new ChatItem(BACKGROUND, FontSchatz.COLOR_CHAT_LEFT, mess,dateauto);
            }
        chatItem.setTime(new DateTimeFormat().getCurrentTime(mess.getDateofsend()));
        initComponents();
        pnContent.add(chatItem);
    }
    public void setAvatar(byte[] file){
        imageAvatar1.setImage(new ImageIcon(file));
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel3 = new javax.swing.JPanel();
        jPanel4 = new javax.swing.JPanel();
        imageAvatar1 = new lib.ImageAvatar();
        pnContent = new javax.swing.JPanel();

        setOpaque(false);
        setLayout(new javax.swing.BoxLayout(this, javax.swing.BoxLayout.PAGE_AXIS));

        jPanel1.setOpaque(false);
        jPanel1.setLayout(new java.awt.BorderLayout());

        jPanel3.setOpaque(false);
        jPanel3.setPreferredSize(new java.awt.Dimension(50, 36));
        jPanel3.setLayout(new java.awt.BorderLayout());

        jPanel4.setOpaque(false);
        jPanel4.setPreferredSize(new java.awt.Dimension(50, 50));
        jPanel4.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.CENTER, 0, 10));

        imageAvatar1.setPreferredSize(new java.awt.Dimension(40, 40));
        jPanel4.add(imageAvatar1);

        jPanel3.add(jPanel4, java.awt.BorderLayout.PAGE_END);

        jPanel1.add(jPanel3, java.awt.BorderLayout.LINE_START);

        pnContent.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 5, 0, 5));
        pnContent.setOpaque(false);
        pnContent.setLayout(new java.awt.GridLayout(1, 0));
        jPanel1.add(pnContent, java.awt.BorderLayout.CENTER);

        add(jPanel1);
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private lib.ImageAvatar imageAvatar1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel pnContent;
    // End of variables declaration//GEN-END:variables
}
