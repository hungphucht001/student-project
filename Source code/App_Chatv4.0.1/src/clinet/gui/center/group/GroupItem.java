package clinet.gui.center.group;

import clinet.gui.SocketCommunication;
import clinet.gui.publicevent.PublicEvent;
import java.awt.Color;
import java.awt.Cursor;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import javax.swing.ImageIcon;
import javax.swing.JMenuItem;
import javax.swing.JPopupMenu;
import javax.swing.SwingUtilities;
import pojo.ListChatGroup;

/**
 *
 * @author Hùng Trần
 */
public class GroupItem extends javax.swing.JPanel {
    private pojo.Group g;
    private JPopupMenu popupMenu;
    public GroupItem(pojo.Group g) {
        this.g = g;
        initComponents();
        init();
        setBackground();
        setInfo();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lbAvatar = new javax.swing.JLabel();
        pnWrap = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        pnBackground = new javax.swing.JPanel();
        imageAvatar = new lib.ImageAvatar();
        jPanel1 = new javax.swing.JPanel();
        lbName = new javax.swing.JLabel();
        lbNumberMember = new javax.swing.JLabel();

        lbAvatar.setBackground(new java.awt.Color(204, 204, 0));
        lbAvatar.setFont(new java.awt.Font("Arial", 1, 48)); // NOI18N
        lbAvatar.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lbAvatar.setText("G");
        lbAvatar.setMaximumSize(new java.awt.Dimension(100, 100));
        lbAvatar.setMinimumSize(new java.awt.Dimension(100, 100));
        lbAvatar.setOpaque(true);
        lbAvatar.setPreferredSize(new java.awt.Dimension(100, 100));

        setBackground(new java.awt.Color(255, 255, 255));
        setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(204, 204, 204)));
        setMinimumSize(new java.awt.Dimension(0, 215));
        setPreferredSize(new java.awt.Dimension(150, 243));
        addAncestorListener(new javax.swing.event.AncestorListener() {
            public void ancestorMoved(javax.swing.event.AncestorEvent evt) {
                formAncestorMoved(evt);
            }
            public void ancestorAdded(javax.swing.event.AncestorEvent evt) {
            }
            public void ancestorRemoved(javax.swing.event.AncestorEvent evt) {
            }
        });
        setLayout(new java.awt.GridLayout(1, 0));

        pnWrap.setOpaque(false);
        pnWrap.setLayout(new java.awt.BorderLayout());

        jPanel2.setMaximumSize(new java.awt.Dimension(32767, 150));
        jPanel2.setMinimumSize(new java.awt.Dimension(10, 150));
        jPanel2.setOpaque(false);
        jPanel2.setPreferredSize(new java.awt.Dimension(381, 150));
        jPanel2.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.CENTER, 5, 25));

        pnBackground.setMaximumSize(new java.awt.Dimension(100, 100));
        pnBackground.setMinimumSize(new java.awt.Dimension(100, 100));
        pnBackground.setName(""); // NOI18N
        pnBackground.setOpaque(false);
        pnBackground.setPreferredSize(new java.awt.Dimension(100, 100));
        pnBackground.setLayout(new java.awt.GridLayout(1, 0));
        pnBackground.add(imageAvatar);

        jPanel2.add(pnBackground);

        pnWrap.add(jPanel2, java.awt.BorderLayout.CENTER);

        jPanel1.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 1, 30, 1));
        jPanel1.setOpaque(false);
        jPanel1.setLayout(new java.awt.GridLayout(2, 1));

        lbName.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        lbName.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lbName.setText("10DHTH@");
        jPanel1.add(lbName);

        lbNumberMember.setFont(new java.awt.Font("Arial", 0, 15)); // NOI18N
        lbNumberMember.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jPanel1.add(lbNumberMember);

        pnWrap.add(jPanel1, java.awt.BorderLayout.PAGE_END);

        add(pnWrap);
    }// </editor-fold>//GEN-END:initComponents

    private void formAncestorMoved(javax.swing.event.AncestorEvent evt) {//GEN-FIRST:event_formAncestorMoved
        setCursor(new Cursor(Cursor.HAND_CURSOR));
    }//GEN-LAST:event_formAncestorMoved
    private void setBackground(){
        int R = (int)(Math.random()*256);
        int G = (int)(Math.random()*256);
        int B= (int)(Math.random()*256);
        Color color = new Color(R, G, B);
        lbAvatar.setBackground(color);
        lbAvatar.setForeground(Color.white);  
    }
    public void setInfo(){
        imageAvatar.setImage(new ImageIcon(g.getDataFileAvatar().getFile()));
        lbName.setText(g.getName());
        lbNumberMember.setText(g.getNumberMember()+" thành viên");
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private lib.ImageAvatar imageAvatar;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JLabel lbAvatar;
    private javax.swing.JLabel lbName;
    private javax.swing.JLabel lbNumberMember;
    private javax.swing.JPanel pnBackground;
    private javax.swing.JPanel pnWrap;
    // End of variables declaration//GEN-END:variables

    private void init() {
        setCursor(new Cursor(Cursor.HAND_CURSOR));
        popupMenu = new JPopupMenu();
        JMenuItem mnItRoiNhom = new JMenuItem("Rời nhóm");
        popupMenu.add(mnItRoiNhom);
        mnItRoiNhom.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                PublicEvent.getPublicEvent().getEventSendToServer().evendOutGroup(g.getId());
            }
        });
        addMouseListener(new MouseAdapter() {
            public void mouseReleased(MouseEvent e) {
                 if(SwingUtilities.isLeftMouseButton(e)){
                    PublicEvent.getPublicEvent().getEventGroupChat().eventGroupChat(new ListChatGroup(g, null));
                    
                }   
                else if(SwingUtilities.isRightMouseButton(e)){
                    popupMenu.show(pnWrap, e.getX(), e.getY());
                }
            }
        });
    }
}
