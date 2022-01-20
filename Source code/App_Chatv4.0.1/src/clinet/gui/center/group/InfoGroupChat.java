package clinet.gui.center.group;

import clinet.gui.publicevent.PublicEvent;
import clinet.gui.publicevent.SeeAllInfoGroup;
import java.util.ArrayList;
import static java.util.Collections.reverse;
import jdk.nashorn.internal.objects.NativeArray;
import lib.ScrollBar;
import pojo.GroupMember;
import pojo.GroupMessage;
import pojo.Message;
/**
 *
 * @author Hùng Trần
 */
public class InfoGroupChat extends javax.swing.JLayeredPane {
    private ArrayList<GroupMember> alMember;
    private ArrayList<GroupMessage> alMess;
    private int idGroup;
    public InfoGroupChat(ArrayList<GroupMember> alMember,int idGroup) {
        initComponents();
        init();
        initEvent();
        this.idGroup = idGroup;
        this.alMember = alMember; 
        
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLayeredPane1 = new javax.swing.JLayeredPane();
        seeALl1 = new clinet.gui.center.group.SeeALl();
        jPanel4 = new javax.swing.JPanel();
        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel2 = new javax.swing.JPanel();
        sp = new javax.swing.JScrollPane();
        jPanel3 = new javax.swing.JPanel();
        itemInfo1 = new clinet.gui.center.group.ItemInfo();
        itemInfo2 = new clinet.gui.center.group.ItemInfo();
        itemInfo3 = new clinet.gui.center.group.ItemInfo();
        itemInfo4 = new clinet.gui.center.group.ItemInfo();

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.GridLayout());

        jLayeredPane1.setLayout(new java.awt.CardLayout());
        jLayeredPane1.add(seeALl1, "card3");
        jLayeredPane1.setLayer(seeALl1, javax.swing.JLayeredPane.MODAL_LAYER);

        jPanel4.setLayout(new java.awt.BorderLayout());

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(200, 200, 200)));
        jPanel1.setMinimumSize(new java.awt.Dimension(343, 70));
        jPanel1.setPreferredSize(new java.awt.Dimension(343, 70));
        jPanel1.setLayout(new java.awt.GridLayout());

        jLabel1.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("10DHTH3");
        jPanel1.add(jLabel1);

        jPanel4.add(jPanel1, java.awt.BorderLayout.PAGE_START);

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));
        jPanel2.setLayout(new java.awt.GridLayout());

        sp.setBorder(null);
        sp.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);

        jPanel3.setBackground(new java.awt.Color(255, 255, 255));
        jPanel3.setLayout(new javax.swing.BoxLayout(jPanel3, javax.swing.BoxLayout.Y_AXIS));

        itemInfo1.setMaximumSize(new java.awt.Dimension(2147483647, 60));
        itemInfo1.setMinimumSize(new java.awt.Dimension(148, 60));
        jPanel3.add(itemInfo1);

        itemInfo2.setMaximumSize(new java.awt.Dimension(1929923, 60));
        itemInfo2.setMinimumSize(new java.awt.Dimension(148, 60));
        jPanel3.add(itemInfo2);

        itemInfo3.setMaximumSize(new java.awt.Dimension(2332931, 60));
        itemInfo3.setMinimumSize(new java.awt.Dimension(148, 60));
        jPanel3.add(itemInfo3);

        itemInfo4.setMaximumSize(new java.awt.Dimension(2342341, 60));
        itemInfo4.setMinimumSize(new java.awt.Dimension(148, 60));
        jPanel3.add(itemInfo4);

        sp.setViewportView(jPanel3);

        jPanel2.add(sp);

        jPanel4.add(jPanel2, java.awt.BorderLayout.CENTER);

        jLayeredPane1.add(jPanel4, "card2");

        add(jLayeredPane1);
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private clinet.gui.center.group.ItemInfo itemInfo1;
    private clinet.gui.center.group.ItemInfo itemInfo2;
    private clinet.gui.center.group.ItemInfo itemInfo3;
    private clinet.gui.center.group.ItemInfo itemInfo4;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLayeredPane jLayeredPane1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private clinet.gui.center.group.SeeALl seeALl1;
    private javax.swing.JScrollPane sp;
    // End of variables declaration//GEN-END:variables

    private void init() {
        itemInfo1.setInfo("Thành viên",1);
        itemInfo2.setInfo("Media",2);
        itemInfo3.setInfo("File",3);
        itemInfo4.setInfo("Khác",4);
        sp.setVerticalScrollBar(new ScrollBar());
        sp.getVerticalScrollBar().setUnitIncrement(50);
        seeALl1.setVisible(false);
        jPanel4.setVisible(true);
        
    }
    private void initEvent() {
        PublicEvent.getPublicEvent().addSeeAllInfoGroup(new SeeAllInfoGroup() {
            @Override
            public void seeAllInfoGroup(String txt, int id) {
                reverse(alMess);
                seeALl1.setVisible(true);
                seeALl1.setTitle(txt, id, alMember, getAlMess(),idGroup);
                seeALl1.repaint();
                seeALl1.revalidate();
            }
        });
    }
    public void loadData(GroupMessage gm){
        alMess.add(gm);
    }
    public ArrayList<GroupMessage> getAlMess() {
        return alMess;
    }
    public void setAlMess(ArrayList<GroupMessage> alMess) {
        this.alMess = alMess;
    }

}
