package clinet.gui.center.chat;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;
import lib.DateTimeFormat;
import lib.FontSchatz;

/**
 *
 * @author Hùng Trần
 */
public class ChatRight extends javax.swing.JPanel {
    private static final Color BACKGROUND = FontSchatz.BACKGROUND_CHAT_RIGHT;
    private ChatItem chatItem;
    public ChatRight(pojo.PeopelMessage mess, int dateauto) {
        chatItem = new ChatItem(BACKGROUND, FontSchatz.COLOR_CHAT_RIGHT, mess,dateauto);
        chatItem.setTime(new DateTimeFormat().getCurrentTime(mess.getDateofsend()));
        initComponents();
        add(chatItem);
    }
    public ChatRight(pojo.GroupMessage mess, int dateauto) {
        chatItem = new ChatItem(BACKGROUND, FontSchatz.COLOR_CHAT_RIGHT, mess,dateauto);
        chatItem.setTime(new DateTimeFormat().getCurrentTime(mess.getDateofsend()));
        initComponents();
        add(chatItem);
    }
    protected void paintComponent(Graphics grphcs) {
//        Graphics2D g2 = (Graphics2D) grphcs;
//        g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);
//        g2.setColor(BACKGROUND);
//        g2.fillRoundRect(0, 0, getWidth(), getHeight(), 15, 15);
//        super.paintComponent(grphcs);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        setOpaque(false);
        setLayout(new java.awt.GridLayout(1, 1));
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables
}
