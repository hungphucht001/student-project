package clinet.gui.center.chat;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;

/**
 *
 * @author Hùng Trần
 */
public class ChatText extends javax.swing.JLayeredPane {
    public ChatText() {
        initComponents();
        txt.setEditable(false);
        txt.setBackground(new Color(0,0,0,0));
        txt.setOpaque(false);
    }
    public void setText(String text){
        txt.setText(text);
    }
    public void setColorText(Color a){
        txt.setForeground(a);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        txt = new lib.JIMSendTextPane();

        setLayout(new javax.swing.BoxLayout(this, javax.swing.BoxLayout.LINE_AXIS));

        txt.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        txt.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txt.setSelectedTextColor(new java.awt.Color(153, 231, 250));
        txt.setSelectionColor(new java.awt.Color(51, 153, 255));
        add(txt);
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private lib.JIMSendTextPane txt;
    // End of variables declaration//GEN-END:variables
}
