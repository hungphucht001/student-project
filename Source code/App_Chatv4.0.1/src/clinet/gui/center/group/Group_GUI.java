package clinet.gui.center.group;

import java.awt.BorderLayout;

/**
 *
 * @author Hùng Trần
 */
public class Group_GUI extends javax.swing.JPanel {
    public Group_GUI() {
        initComponents();
        add(new GroupHeader(),BorderLayout.PAGE_START);
        add(new GroupCenter(),BorderLayout.CENTER);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.BorderLayout());
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables
}
