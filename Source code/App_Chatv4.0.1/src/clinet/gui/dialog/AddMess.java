package clinet.gui.dialog;

import lib.Fun;
import clinet.gui.SocketCommunication;
import clinet.gui.menuleft.home_two.ListFriendRender;
import clinet.gui.publicLoading.PublicLoading;
import clinet.gui.publicevent.PublicEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.ArrayList;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.SwingUtilities;
import lib.ScrollBar;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */
public class AddMess extends javax.swing.JDialog {
    private JList<User_account> listFriend;
    private DefaultListModel<User_account> dlm;
    /**
     * Creates new form AddMess
     */
    public AddMess(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        setLocationRelativeTo(null);
        dlm = new DefaultListModel<>();
        loadData();
        listFriend = new JList<User_account>(dlm);
        listFriend.setCellRenderer(new ListFriendRender());
        
        jScrollPane1.setViewportView(listFriend);
        jScrollPane1.setVerticalScrollBar(new ScrollBar());
        jScrollPane1.getVerticalScrollBar().setUnitIncrement(60);
        
        setFocusable(true);
        addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                if(e.getKeyCode() == KeyEvent.VK_ESCAPE)
                {
                    setVisible(false);
                }
            }
        });
        listFriend.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseReleased(MouseEvent e) {
                if(SwingUtilities.isLeftMouseButton(e)){
                    PublicEvent.getPublicEvent().getEventPersonChat().eventPersonChat2(listFriend.getSelectedValue());
                    PublicEvent.getPublicEvent().getEventSendToServer().eventLoadDataMessPeopel(listFriend.getSelectedValue().getId());
                    setVisible(false);
                }
            }
        });
        Fun.clickTextField(txtSearch,"Tìm kiếm");
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel6 = new javax.swing.JPanel();
        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        txtSearch = new javax.swing.JTextField();
        jPanel3 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();

        javax.swing.GroupLayout jPanel6Layout = new javax.swing.GroupLayout(jPanel6);
        jPanel6.setLayout(jPanel6Layout);
        jPanel6Layout.setHorizontalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        jPanel6Layout.setVerticalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 60, Short.MAX_VALUE)
        );

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("  Tin nhắn mới");
        setBackground(new java.awt.Color(255, 255, 255));
        setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        setResizable(false);
        getContentPane().setLayout(new java.awt.GridLayout(1, 0));

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setBorder(javax.swing.BorderFactory.createEmptyBorder(20, 20, 20, 20));
        jPanel1.setLayout(new java.awt.BorderLayout());

        jPanel2.setBorder(javax.swing.BorderFactory.createMatteBorder(1, 1, 1, 1, new java.awt.Color(204, 204, 204)));
        jPanel2.setPreferredSize(new java.awt.Dimension(467, 60));
        jPanel2.setLayout(new java.awt.GridLayout(1, 1, 20, 0));

        txtSearch.setFont(new java.awt.Font("Tahoma", 0, 16)); // NOI18N
        txtSearch.setText("Tìm kiếm");
        txtSearch.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jPanel2.add(txtSearch);

        jPanel1.add(jPanel2, java.awt.BorderLayout.PAGE_START);

        jPanel3.setBorder(javax.swing.BorderFactory.createEmptyBorder(20, 0, 0, 0));
        jPanel3.setOpaque(false);
        jPanel3.setLayout(new java.awt.GridLayout(1, 0));

        jScrollPane1.setBackground(new java.awt.Color(255, 255, 255));
        jScrollPane1.setBorder(null);
        jScrollPane1.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        jScrollPane1.setMinimumSize(new java.awt.Dimension(5, 400));
        jScrollPane1.setPreferredSize(new java.awt.Dimension(100, 400));
        jPanel3.add(jScrollPane1);

        jPanel1.add(jPanel3, java.awt.BorderLayout.CENTER);

        getContentPane().add(jPanel1);

        pack();
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField txtSearch;
    // End of variables declaration//GEN-END:variables

    private void loadData() {
        for(pojo.User_account user : SocketCommunication.listUser){
            dlm.addElement(user);
        }
        search();
    }
    public JList<User_account> getListFriend() {
        return listFriend;
    }
    public void setListFriend(JList<User_account> listFriend) {
        this.listFriend = listFriend;
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
