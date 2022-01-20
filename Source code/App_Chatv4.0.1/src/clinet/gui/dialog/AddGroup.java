package clinet.gui.dialog;

import clinet.dto.CheckListItem_DTO;
import lib.Fun;
import clinet.gui.SocketCommunication;
import clinet.gui.center.group.ListFriendCheckRender;
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
import javax.swing.JScrollPane;
import javax.swing.ListSelectionModel;
import lib.FontSchatz;
import lib.ScrollBar;

/**
 *
 * @author Hùng Trần
 */
public class AddGroup extends javax.swing.JDialog {
    private ArrayList<Integer> listAddGroup;
    private DefaultListModel<CheckListItem_DTO> dlm;
    private JList<CheckListItem_DTO> listFriend;

    public AddGroup(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        setVisible(false);
        listAddGroup = new ArrayList<Integer>();
        this.setLocationRelativeTo(null);
        dlm = new DefaultListModel<CheckListItem_DTO>();
        loadData();
        listFriend = new JList<CheckListItem_DTO>(dlm);
        listFriend.setCellRenderer(new ListFriendCheckRender());
        JScrollPane scp = new JScrollPane(listFriend, JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED, JScrollPane.HORIZONTAL_SCROLLBAR_AS_NEEDED);
        scp.setVerticalScrollBar(new ScrollBar());
        scp.getVerticalScrollBar().setUnitIncrement(60);
        pnCenter.add(scp);
        listFriend.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        btnCreate.setEnabled(false);
        Fun.setButton(btnCreate,FontSchatz.BACKGROUND_CL,FontSchatz.COLOR_TEXT_W);
        Fun.setButton(btnThoat,FontSchatz.BACKGROUND_EXITS,FontSchatz.COLOR_TEXT_W);
        listFriend.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(MouseEvent e) {
                
                JList list = (JList) e.getSource();
                int index = list.locationToIndex(e.getPoint());
                CheckListItem_DTO item = (CheckListItem_DTO) list.getModel().getElementAt(index);
                item.setIsSelected(!item.isSelected());
                list.repaint(list.getCellBounds(index, index));
                 try{
                     if(item.isSelected()){
                        listAddGroup.add(item.getUser().getId());
                        lbTotal.setText("Mời thêm bạn vào nhóm ("+listAddGroup.size()+"/100)");
                    }
                    else{
                       for(Integer a: listAddGroup){
                           if(a == item.getUser().getId()){
                               listAddGroup.remove(a);
                               lbTotal.setText("Mời thêm bạn vào nhóm ("+listAddGroup.size()+"/100)");
                           }
                       }
                    }
                 }
                 catch(Exception ex){
                 }
              }
            @Override
            public void mouseReleased(MouseEvent e) {
                if ((!txtName.getText().equals("Nhập tên nhóm ...") || txtName.getText().equals("")) && listAddGroup.size() > 1) {
                    btnCreate.setEnabled(true);
                }
                else{
                    btnCreate.setEnabled(false);  
                }
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

        Fun.clickTextField(txtName,"Nhập tên nhóm ...");
        Fun.clickTextField(txtSearch,"Tìm bạn");
        jPanel8.setVisible(false);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel3 = new javax.swing.JPanel();
        txtName = new javax.swing.JTextField();
        jPanel4 = new javax.swing.JPanel();
        btnThoat = new javax.swing.JButton();
        btnCreate = new javax.swing.JButton();
        jPanel5 = new javax.swing.JPanel();
        jPanel6 = new javax.swing.JPanel();
        lbTotal = new javax.swing.JLabel();
        jPanel8 = new javax.swing.JPanel();
        txtSearch = new javax.swing.JTextField();
        pnCenter = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("    Tạo nhóm");
        setResizable(false);
        getContentPane().setLayout(new java.awt.GridLayout(1, 0));

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setBorder(javax.swing.BorderFactory.createCompoundBorder(javax.swing.BorderFactory.createEmptyBorder(20, 20, 20, 20), javax.swing.BorderFactory.createMatteBorder(0, 0, 0, 0, new java.awt.Color(204, 204, 204))));
        jPanel1.setLayout(new java.awt.BorderLayout());

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));

        jLabel1.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        jLabel1.setText("Tên nhóm");

        jPanel3.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(204, 204, 204)));
        jPanel3.setMaximumSize(new java.awt.Dimension(0, 53));
        jPanel3.setMinimumSize(new java.awt.Dimension(0, 53));
        jPanel3.setLayout(new java.awt.GridLayout(1, 0));

        txtName.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtName.setForeground(new java.awt.Color(204, 204, 204));
        txtName.setText("Nhập tên nhóm ...");
        txtName.setBorder(javax.swing.BorderFactory.createEmptyBorder(13, 13, 13, 13));
        txtName.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtNameKeyPressed(evt);
            }
        });
        jPanel3.add(txtName);

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel3, javax.swing.GroupLayout.DEFAULT_SIZE, 584, Short.MAX_VALUE)
            .addComponent(jLabel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        jPanel1.add(jPanel2, java.awt.BorderLayout.PAGE_START);

        jPanel4.setBackground(new java.awt.Color(255, 255, 255));
        jPanel4.setBorder(javax.swing.BorderFactory.createMatteBorder(1, 0, 0, 0, new java.awt.Color(204, 204, 204)));

        btnThoat.setText("Hủy");
        btnThoat.setMaximumSize(new java.awt.Dimension(100, 40));
        btnThoat.setMinimumSize(new java.awt.Dimension(100, 40));
        btnThoat.setPreferredSize(new java.awt.Dimension(100, 40));
        btnThoat.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnThoatActionPerformed(evt);
            }
        });

        btnCreate.setText("Tạo nhóm");
        btnCreate.setMaximumSize(new java.awt.Dimension(100, 40));
        btnCreate.setMinimumSize(new java.awt.Dimension(100, 40));
        btnCreate.setPreferredSize(new java.awt.Dimension(100, 40));
        btnCreate.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCreateActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                .addContainerGap(285, Short.MAX_VALUE)
                .addComponent(btnThoat, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(99, 99, 99)
                .addComponent(btnCreate, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(22, 22, 22)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnThoat, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnCreate, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(0, 0, Short.MAX_VALUE))
        );

        jPanel1.add(jPanel4, java.awt.BorderLayout.PAGE_END);

        jPanel5.setLayout(new java.awt.BorderLayout());

        jPanel6.setBackground(new java.awt.Color(255, 255, 255));

        lbTotal.setFont(new java.awt.Font("Tahoma", 0, 16)); // NOI18N
        lbTotal.setText("Mời thêm bạn vào nhóm (0/100)");

        jPanel8.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(204, 204, 204)));
        jPanel8.setMaximumSize(new java.awt.Dimension(0, 53));
        jPanel8.setMinimumSize(new java.awt.Dimension(0, 53));
        jPanel8.setLayout(new java.awt.GridLayout(1, 0));

        txtSearch.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txtSearch.setForeground(new java.awt.Color(204, 204, 204));
        txtSearch.setText("Tìm bạn");
        txtSearch.setBorder(javax.swing.BorderFactory.createEmptyBorder(13, 13, 13, 13));
        jPanel8.add(txtSearch);

        javax.swing.GroupLayout jPanel6Layout = new javax.swing.GroupLayout(jPanel6);
        jPanel6.setLayout(jPanel6Layout);
        jPanel6Layout.setHorizontalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel6Layout.createSequentialGroup()
                .addComponent(lbTotal, javax.swing.GroupLayout.DEFAULT_SIZE, 298, Short.MAX_VALUE)
                .addGap(286, 286, 286))
            .addComponent(jPanel8, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jPanel6Layout.setVerticalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(lbTotal)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel8, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(16, Short.MAX_VALUE))
        );

        jPanel5.add(jPanel6, java.awt.BorderLayout.PAGE_START);

        pnCenter.setBackground(new java.awt.Color(255, 255, 255));
        pnCenter.setMaximumSize(new java.awt.Dimension(0, 500));
        pnCenter.setMinimumSize(new java.awt.Dimension(0, 500));
        pnCenter.setPreferredSize(new java.awt.Dimension(0, 500));
        pnCenter.setLayout(new java.awt.GridLayout(1, 0));
        jPanel5.add(pnCenter, java.awt.BorderLayout.CENTER);

        jPanel1.add(jPanel5, java.awt.BorderLayout.CENTER);

        getContentPane().add(jPanel1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnThoatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnThoatActionPerformed
        this.dispose();
    }//GEN-LAST:event_btnThoatActionPerformed
    private void btnCreateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCreateActionPerformed
        PublicEvent.getPublicEvent().getEventSendToServer().evendSendListIdCreateGroup(txtName.getText(), listAddGroup);
        this.dispose();
    }//GEN-LAST:event_btnCreateActionPerformed
    private void txtNameKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNameKeyPressed
        if ((!txtName.getText().equals("Nhập tên nhóm ...") || txtName.getText().equals("")) && listAddGroup.size() > 1) {
            btnCreate.setEnabled(true);
        }
        else{
            btnCreate.setEnabled(false);  
        }
    }//GEN-LAST:event_txtNameKeyPressed
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCreate;
    private javax.swing.JButton btnThoat;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel8;
    private javax.swing.JLabel lbTotal;
    private javax.swing.JPanel pnCenter;
    private javax.swing.JTextField txtName;
    private javax.swing.JTextField txtSearch;
    // End of variables declaration//GEN-END:variables

    private void loadData() {
        for(pojo.User_account a: SocketCommunication.listUser){
            dlm.addElement(new CheckListItem_DTO(a));
        }
    }
}
