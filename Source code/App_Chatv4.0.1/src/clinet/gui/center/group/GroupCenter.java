package clinet.gui.center.group;

import lib.Fun;
import clinet.gui.SocketCommunication;
import clinet.gui.publicLoading.LoadGroupChat;
import clinet.gui.publicLoading.LoadSizeGroup;
import clinet.gui.publicLoading.PublicLoading;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import javax.swing.JComboBox;
import javax.swing.JPanel;
import lib.ScrollBar;
import net.miginfocom.swing.MigLayout;
import pojo.GroupMember;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */

public class GroupCenter extends JPanel {
    public GroupCenter() {
        initComponents();
        init();
        loadData(3,false);
        jPanel1.setVisible(false);
        PublicLoading.getPublicLoading().setLoadGroupChat(() -> {
            loadData(3,false);
        });
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel3 = new javax.swing.JPanel();
        jPanel4 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel6 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        jTextField1 = new javax.swing.JTextField();
        jPanel5 = new javax.swing.JPanel();
        spSearchGroup = new javax.swing.JScrollPane();
        jPanel7 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jPanel8 = new javax.swing.JPanel();
        jPanel10 = new javax.swing.JPanel();
        jPanel11 = new javax.swing.JPanel();
        jPanel9 = new javax.swing.JPanel();
        spListGroup = new javax.swing.JScrollPane();
        pnListGroup = new javax.swing.JPanel();

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.BorderLayout());

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setBorder(javax.swing.BorderFactory.createCompoundBorder(javax.swing.BorderFactory.createMatteBorder(0, 1, 0, 0, new java.awt.Color(200, 200, 200)), javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10)));
        jPanel1.setPreferredSize(new java.awt.Dimension(350, 703));
        jPanel1.setLayout(new java.awt.BorderLayout());

        jPanel3.setBorder(javax.swing.BorderFactory.createCompoundBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(200, 200, 200)), javax.swing.BorderFactory.createEmptyBorder(10, 0, 10, 0)));
        jPanel3.setOpaque(false);
        jPanel3.setLayout(new javax.swing.BoxLayout(jPanel3, javax.swing.BoxLayout.PAGE_AXIS));

        jPanel4.setOpaque(false);
        jPanel4.setPreferredSize(new java.awt.Dimension(449, 50));
        jPanel4.setLayout(new java.awt.BorderLayout());

        jLabel1.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        jLabel1.setText("Tìm kiếm nhóm mới:");
        jPanel4.add(jLabel1, java.awt.BorderLayout.CENTER);

        jPanel3.add(jPanel4);

        jPanel6.setBackground(new java.awt.Color(102, 102, 102));
        jPanel6.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(243, 243, 243)));
        jPanel6.setMaximumSize(new java.awt.Dimension(242342, 30));
        jPanel6.setMinimumSize(new java.awt.Dimension(30, 30));
        jPanel6.setOpaque(false);
        jPanel6.setPreferredSize(new java.awt.Dimension(30, 60));
        jPanel6.setLayout(new java.awt.BorderLayout());

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/magnifying-glass.png"))); // NOI18N
        jLabel2.setPreferredSize(new java.awt.Dimension(50, 0));
        jPanel6.add(jLabel2, java.awt.BorderLayout.LINE_END);

        jTextField1.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        jTextField1.setForeground(new java.awt.Color(204, 204, 204));
        jTextField1.setText("Tìm kiếm");
        jTextField1.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jTextField1.setOpaque(false);
        jPanel6.add(jTextField1, java.awt.BorderLayout.CENTER);

        jPanel3.add(jPanel6);

        jPanel1.add(jPanel3, java.awt.BorderLayout.PAGE_START);

        jPanel5.setOpaque(false);
        jPanel5.setLayout(new java.awt.GridLayout(1, 0));

        spSearchGroup.setBorder(null);
        spSearchGroup.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);

        jPanel7.setBackground(new java.awt.Color(255, 255, 255));

        javax.swing.GroupLayout jPanel7Layout = new javax.swing.GroupLayout(jPanel7);
        jPanel7.setLayout(jPanel7Layout);
        jPanel7Layout.setHorizontalGroup(
            jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 329, Short.MAX_VALUE)
        );
        jPanel7Layout.setVerticalGroup(
            jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 552, Short.MAX_VALUE)
        );

        spSearchGroup.setViewportView(jPanel7);

        jPanel5.add(spSearchGroup);

        jPanel1.add(jPanel5, java.awt.BorderLayout.CENTER);

        add(jPanel1, java.awt.BorderLayout.LINE_END);

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));
        jPanel2.setLayout(new java.awt.BorderLayout());

        jPanel8.setBackground(new java.awt.Color(255, 255, 255));
        jPanel8.setPreferredSize(new java.awt.Dimension(706, 60));
        jPanel8.setLayout(new java.awt.BorderLayout());

        jPanel10.setBackground(new java.awt.Color(255, 255, 255));
        jPanel10.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jPanel10.setPreferredSize(new java.awt.Dimension(159, 150));
        jPanel10.setLayout(new javax.swing.BoxLayout(jPanel10, javax.swing.BoxLayout.LINE_AXIS));
        jPanel8.add(jPanel10, java.awt.BorderLayout.LINE_START);

        jPanel11.setMinimumSize(new java.awt.Dimension(100, 37));
        jPanel11.setOpaque(false);
        jPanel11.setLayout(new java.awt.GridLayout(1, 0));
        jPanel8.add(jPanel11, java.awt.BorderLayout.LINE_END);

        jPanel2.add(jPanel8, java.awt.BorderLayout.PAGE_START);

        jPanel9.setOpaque(false);
        jPanel9.setLayout(new java.awt.GridLayout(1, 0));

        spListGroup.setBorder(null);
        spListGroup.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);

        pnListGroup.setBackground(new java.awt.Color(255, 255, 255));

        javax.swing.GroupLayout pnListGroupLayout = new javax.swing.GroupLayout(pnListGroup);
        pnListGroup.setLayout(pnListGroupLayout);
        pnListGroupLayout.setHorizontalGroup(
            pnListGroupLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 706, Short.MAX_VALUE)
        );
        pnListGroupLayout.setVerticalGroup(
            pnListGroupLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 703, Short.MAX_VALUE)
        );

        spListGroup.setViewportView(pnListGroup);

        jPanel9.add(spListGroup);

        jPanel2.add(jPanel9, java.awt.BorderLayout.CENTER);

        add(jPanel2, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel10;
    private javax.swing.JPanel jPanel11;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel7;
    private javax.swing.JPanel jPanel8;
    private javax.swing.JPanel jPanel9;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JPanel pnListGroup;
    private javax.swing.JScrollPane spListGroup;
    private javax.swing.JScrollPane spSearchGroup;
    // End of variables declaration//GEN-END:variables

    private void init() {
        
        pnListGroup.setLayout(new MigLayout("fillx","5[fill,100::33%]5[fill,100::33%]5[fill,100::33%]5"));
        spListGroup.setVerticalScrollBar(new ScrollBar());
        spListGroup.getVerticalScrollBar().setUnitIncrement(50);
         String s[]={"Tất cả","Nhóm tôi quản lý"};        
        JComboBox cb = new JComboBox(s);    
        cb.setBackground(Color.white);
        cb.setBorder(null);
        cb.setFont(new Font("Aria", Font.PLAIN, 16));
        cb.setVerifyInputWhenFocusTarget(false);
        cb.setPreferredSize(new Dimension(150, 50));
        jPanel10.add(cb);
        Fun.clickTextField(jTextField1, "Tìm kiếm");
        
        PublicLoading.getPublicLoading().setLoadSizeGroup((int size) -> {
            if(size <= 648){
                pnListGroup.setLayout(new MigLayout("fillx","5[fill,100::50%]5[fill,100::50%]5"));
                loadData(2,false);
            }
            else{
                pnListGroup.setLayout(new MigLayout("fillx","5[fill,100::33%]5[fill,100::33%]5[fill,100::33%]5"));
                loadData(3,false);   
            }
        });
        cb.addActionListener(new ActionListener() {

            @Override
            public void actionPerformed(ActionEvent e) {
                 if (cb.getSelectedIndex()==1) {
                    loadData(3,true);
                }
                else loadData(3,false);
            }
        });
    }

    private void loadData(int numberLine, boolean isLeader) {
        int c = 0;
        pnListGroup.removeAll();
        for(pojo.Group g: SocketCommunication.listGroup){
            if(isLeader==true){
                for(GroupMember m : g.getAlMember()){
                    if(m.getId_user() == SocketCommunication.user.getId() && m.getType() == 0){
                        c++;
                        GroupItem itemGroup = new GroupItem(g);
                        if(c==numberLine){
                            pnListGroup.add(itemGroup,"wrap");
                            c = 0;
                        }
                        else pnListGroup.add(itemGroup);
                        break;
                    }
                }
            }
            else{
                c++;
                GroupItem itemGroup = new GroupItem(g);
                if(c==numberLine){
                    pnListGroup.add(itemGroup,"wrap");
                    c =0;
                }
                else pnListGroup.add(itemGroup);         
            }
        }   
        pnListGroup.updateUI();
    }
}
