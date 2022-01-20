package clinet.gui.dialog;

import clinet.dto.CheckListItem_DTO;
import clinet.gui.SocketCommunication;
import clinet.gui.center.group.ListFriendCheckRender;
import java.awt.List;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import java.util.Collection;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.JScrollPane;
import javax.swing.ListSelectionModel;
import lib.FontSchatz;
import lib.Fun;
import pojo.GroupMember;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */
public class AddMember extends javax.swing.JDialog {
private ArrayList<Integer> listAddGroup;
    private DefaultListModel<CheckListItem_DTO> dlm;
    private JList<CheckListItem_DTO> listFriend;
    private ArrayList<GroupMember> alMember;
    /**
     * Creates new form AddMember
     */
    public AddMember(java.awt.Frame parent, boolean modal, ArrayList<GroupMember> alMember) {
        super(parent, modal);
        this.alMember = alMember;
        
        initComponents();
        setVisible(false);
        listAddGroup = new ArrayList<Integer>();
        this.setLocationRelativeTo(null);
        dlm = new DefaultListModel<CheckListItem_DTO>();
        loadData();
        listFriend = new JList<CheckListItem_DTO>(dlm);
        listFriend.setCellRenderer(new ListFriendCheckRender());
        JScrollPane scp = new JScrollPane(listFriend, JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED, JScrollPane.HORIZONTAL_SCROLLBAR_AS_NEEDED);
        pnCenter.add(scp);
        listFriend.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        listFriend.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(MouseEvent e) {
                JList list = (JList) e.getSource();
                int index = list.locationToIndex(e.getPoint());
                CheckListItem_DTO item = (CheckListItem_DTO) list.getModel().getElementAt(index);
                item.setIsSelected(!item.isSelected());
                list.repaint(list.getCellBounds(index, index));
              }
        });
        setFocusable(true);
        addKeyListener(new KeyAdapter() {
            public void keyPressed(KeyEvent e) {
                if(e.getKeyCode() == KeyEvent.VK_ESCAPE)
                {
                    setVisible(false);
                }
            }
        });

    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        pnCenter = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 584, Short.MAX_VALUE)
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 100, Short.MAX_VALUE)
        );

        getContentPane().add(jPanel1, java.awt.BorderLayout.PAGE_START);

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 584, Short.MAX_VALUE)
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 100, Short.MAX_VALUE)
        );

        getContentPane().add(jPanel2, java.awt.BorderLayout.PAGE_END);

        pnCenter.setBackground(new java.awt.Color(255, 255, 255));
        pnCenter.setMaximumSize(new java.awt.Dimension(0, 500));
        pnCenter.setMinimumSize(new java.awt.Dimension(0, 500));
        pnCenter.setPreferredSize(new java.awt.Dimension(0, 500));
        pnCenter.setLayout(new java.awt.GridLayout());
        getContentPane().add(pnCenter, java.awt.BorderLayout.CENTER);

        pack();
    }// </editor-fold>//GEN-END:initComponents
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(AddMember.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(AddMember.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(AddMember.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(AddMember.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                AddMember dialog = new AddMember(new javax.swing.JFrame(), true, null);
                dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                    @Override
                    public void windowClosing(java.awt.event.WindowEvent e) {
                        System.exit(0);
                    }
                });
                dialog.setVisible(true);
            }
        });
    }
    private void loadData() {
        ArrayList<User_account> alMemberCln = SocketCommunication.listUser;
        ArrayList<User_account> alMemberCln2 = new ArrayList<User_account>();
        
        ArrayList<Integer> lint = new ArrayList<Integer>();
        
        for(GroupMember gm: alMember)
            if(gm.getUser().getId() != SocketCommunication.user.getId())
                lint.add(gm.getUser().getId());
        
        for(User_account user : alMemberCln){
            for(Integer a: lint)
            {
                if(user.getId() == a) continue;
                else {
                    alMemberCln2.add(user);
                    break;
                }
            }
        }
        
        for(Integer a: lint)
                System.out.println(a);
        for(User_account u: alMemberCln)
        {
           System.out.println( "1     "+ u.getId() + u.fullName() );
        } 
        for(User_account u: alMemberCln2)
        {
           System.out.println("2     "+ u.getId() + u.fullName() );
        }


    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel pnCenter;
    // End of variables declaration//GEN-END:variables
}
