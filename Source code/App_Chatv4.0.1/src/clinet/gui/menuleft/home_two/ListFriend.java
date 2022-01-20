package clinet.gui.menuleft.home_two;

import lib.Fun;
import clinet.gui.SocketCommunication;
import clinet.gui.dialog.AddGroup;
import clinet.gui.dialog.AddMess;
import clinet.gui.publicLoading.PublicLoading;
import clinet.gui.publicevent.PublicEvent;
import java.awt.Cursor;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.ArrayList;
import java.util.Date;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.SwingUtilities;
import lib.ScrollBar;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */
public class ListFriend extends javax.swing.JPanel {
    private DefaultListModel<User_account> dlm;
    private JList<User_account> listFriend;
    public ListFriend() {
        initComponents();
        init();
        loadData();
        initEvent();
        search();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        jPanel6 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel7 = new javax.swing.JPanel();
        jButton3 = new javax.swing.JButton();
        jButton4 = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        jPanel8 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        txtSearch = new javax.swing.JTextField();
        jPanel2 = new javax.swing.JPanel();
        spListFriend = new javax.swing.JScrollPane();

        jButton1.setText("jButton1");

        jButton2.setText("jButton2");

        setBackground(new java.awt.Color(255, 255, 255));
        setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        setLayout(new java.awt.BorderLayout());

        jPanel1.setOpaque(false);
        jPanel1.setLayout(new javax.swing.BoxLayout(jPanel1, javax.swing.BoxLayout.PAGE_AXIS));

        jPanel6.setOpaque(false);
        jPanel6.setPreferredSize(new java.awt.Dimension(449, 50));
        jPanel6.setLayout(new java.awt.BorderLayout());

        jLabel1.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        jLabel1.setText("Danh sách bạn bè");
        jPanel6.add(jLabel1, java.awt.BorderLayout.CENTER);

        jPanel7.setOpaque(false);
        jPanel7.setPreferredSize(new java.awt.Dimension(120, 50));
        jPanel7.setLayout(new java.awt.GridLayout(1, 2, 10, 0));

        jButton3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon_addmess.png"))); // NOI18N
        jButton3.setToolTipText("Tin nhắn mới");
        jButton3.setBorder(null);
        jButton3.setBorderPainted(false);
        jButton3.setContentAreaFilled(false);
        jButton3.setFocusPainted(false);
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });
        jPanel7.add(jButton3);

        jButton4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon-addgroup.png"))); // NOI18N
        jButton4.setToolTipText("Tạo nhóm");
        jButton4.setBorder(null);
        jButton4.setBorderPainted(false);
        jButton4.setContentAreaFilled(false);
        jButton4.setFocusPainted(false);
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
            }
        });
        jPanel7.add(jButton4);

        jPanel6.add(jPanel7, java.awt.BorderLayout.LINE_END);

        jPanel1.add(jPanel6);

        jPanel3.setBackground(new java.awt.Color(255, 255, 255));
        jPanel3.setMaximumSize(new java.awt.Dimension(31243, 60));
        jPanel3.setPreferredSize(new java.awt.Dimension(10, 89));

        jPanel8.setBackground(new java.awt.Color(102, 102, 102));
        jPanel8.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(243, 243, 243)));
        jPanel8.setMaximumSize(new java.awt.Dimension(30, 30));
        jPanel8.setMinimumSize(new java.awt.Dimension(30, 30));
        jPanel8.setOpaque(false);
        jPanel8.setPreferredSize(new java.awt.Dimension(30, 60));
        jPanel8.setLayout(new java.awt.BorderLayout());

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/magnifying-glass.png"))); // NOI18N
        jLabel2.setPreferredSize(new java.awt.Dimension(50, 0));
        jPanel8.add(jLabel2, java.awt.BorderLayout.LINE_END);

        txtSearch.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtSearch.setForeground(new java.awt.Color(204, 204, 204));
        txtSearch.setText("Tìm kiếm");
        txtSearch.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        txtSearch.setOpaque(false);
        txtSearch.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtSearchActionPerformed(evt);
            }
        });
        jPanel8.add(txtSearch, java.awt.BorderLayout.CENTER);

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 361, Short.MAX_VALUE)
            .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel3Layout.createSequentialGroup()
                    .addGap(0, 0, 0)
                    .addComponent(jPanel8, javax.swing.GroupLayout.DEFAULT_SIZE, 361, Short.MAX_VALUE)
                    .addGap(0, 0, 0)))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 89, Short.MAX_VALUE)
            .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel3Layout.createSequentialGroup()
                    .addGap(14, 14, 14)
                    .addComponent(jPanel8, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGap(15, 15, 15)))
        );

        jPanel1.add(jPanel3);

        add(jPanel1, java.awt.BorderLayout.PAGE_START);

        jPanel2.setOpaque(false);
        jPanel2.setLayout(new java.awt.GridLayout(1, 0));

        spListFriend.setBorder(null);
        spListFriend.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        spListFriend.setOpaque(false);
        jPanel2.add(spListFriend);

        add(jPanel2, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents
    private void txtSearchActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtSearchActionPerformed
    }//GEN-LAST:event_txtSearchActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        new AddMess(null, true).setVisible(true);
    }//GEN-LAST:event_jButton3ActionPerformed

    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
       new AddGroup(null, true).setVisible(true);
    }//GEN-LAST:event_jButton4ActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JButton jButton4;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel7;
    private javax.swing.JPanel jPanel8;
    private javax.swing.JScrollPane spListFriend;
    private javax.swing.JTextField txtSearch;
    // End of variables declaration//GEN-END:variables

    private void init() {
        dlm = new DefaultListModel<User_account>();
        listFriend = new JList<User_account>(dlm);
        listFriend.setCellRenderer(new ListFriendRender());
        spListFriend.setVerticalScrollBar(new ScrollBar());
        spListFriend.getVerticalScrollBar().setUnitIncrement(50);
        spListFriend.setViewportView(listFriend);
        Fun.clickTextField(txtSearch, "Tìm kiếm");
        listFriend.setCursor(new Cursor(Cursor.HAND_CURSOR) {
        });
    }
    private void loadData() {
        for (User_account user: SocketCommunication.listUser) {
            dlm.addElement(user);
        }
    }
    private void initEvent() {
        listFriend.addMouseListener(new MouseListener() {

            @Override
            public void mouseClicked(MouseEvent e) {
            }
            @Override
            public void mousePressed(MouseEvent e) {
            }
            @Override
            public void mouseReleased(MouseEvent e) {
                if(SwingUtilities.isLeftMouseButton(e)){
                    PublicEvent.getPublicEvent().getEventPersonChat().eventPersonChat2(listFriend.getSelectedValue());
                    PublicLoading.getPublicLoading().getLoadSize().loadSize();
                    PublicEvent.getPublicEvent().getEventSendToServer().eventLoadDataMessPeopel(listFriend.getSelectedValue().getId());
                }
            }
            @Override
            public void mouseEntered(MouseEvent e) {
            }

            @Override
            public void mouseExited(MouseEvent e) {
            }
        });
    }
    private void search(){
        txtSearch.addKeyListener(new KeyAdapter() {
            @Override
            public void keyReleased(KeyEvent e) {
                DefaultListModel<pojo.User_account> dlm = new DefaultListModel<pojo.User_account>();
                ArrayList<pojo.User_account> arr = SocketCommunication.listUser;
                arr.forEach(item->{
                    String name = item.fullName();
                    if(name.toLowerCase().contains(txtSearch.getText().toLowerCase())){
                        dlm.addElement(item);
                    }
                });
                listFriend.setModel(dlm);
            }
        });
    }
}
