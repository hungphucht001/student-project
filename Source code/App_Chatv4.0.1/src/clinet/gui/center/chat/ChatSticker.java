package clinet.gui.center.chat;

import javax.swing.ImageIcon;

/**
 *
 * @author Hùng Trần
 */
public class ChatSticker extends javax.swing.JPanel {
    public ChatSticker() {
        initComponents();
    }
    public void setSticker(String path){
        lbSticker.setIcon(new ImageIcon(path));
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lbSticker = new javax.swing.JLabel();

        setBackground(new java.awt.Color(255, 204, 204));
        setMaximumSize(new java.awt.Dimension(100, 100));
        setMinimumSize(new java.awt.Dimension(100, 100));
        setOpaque(false);
        setPreferredSize(new java.awt.Dimension(100, 100));
        setLayout(new java.awt.GridLayout());

        lbSticker.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        add(lbSticker);
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel lbSticker;
    // End of variables declaration//GEN-END:variables
}
