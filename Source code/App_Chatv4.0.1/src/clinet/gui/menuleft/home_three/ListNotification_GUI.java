package clinet.gui.menuleft.home_three;

import clinet.gui.SocketCommunication;
import java.awt.Cursor;
import javax.management.Notification;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import lib.ScrollBar;
import pojo.Notifications;

/**
 *
 * @author Hùng Trần
 */
public class ListNotification_GUI extends javax.swing.JPanel {
    public ListNotification_GUI() {
        initComponents();
        init();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        spListNotificationm = new javax.swing.JScrollPane();

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.GridLayout());

        spListNotificationm.setBorder(null);
        add(spListNotificationm);
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JScrollPane spListNotificationm;
    // End of variables declaration//GEN-END:variables

    private void init() {
        DefaultListModel<pojo.Notifications> dlm = new DefaultListModel<Notifications>();
        JList<Notifications> lNotification = new JList<Notifications>(dlm);
        lNotification.setCursor(new Cursor(Cursor.HAND_CURSOR));
        lNotification.setCellRenderer(new NotificationRender());
        
        for(Notifications no: SocketCommunication.listNotification){
            dlm.addElement(no);
        }
        spListNotificationm.setViewportView(lNotification);
        spListNotificationm.setVerticalScrollBar(new ScrollBar());
        spListNotificationm.getVerticalScrollBar().setUnitIncrement(50);
    }
}
