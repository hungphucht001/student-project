package clinet.gui.center.chat;

import java.awt.Color;
import javax.swing.Icon;
import javax.swing.ImageIcon;

/**
 *
 * @author Hùng Trần
 */
public class ChatTop_GUI extends javax.swing.JPanel {
    private boolean isOnline;
    public ChatTop_GUI(boolean isOnline) {
        this.isOnline = isOnline;
        initComponents();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lbStatus = new javax.swing.JLabel();
        lbNumberMember = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        btnShowInfo = new javax.swing.JButton();
        jPanel2 = new javax.swing.JPanel();
        jPanel3 = new javax.swing.JPanel();
        imageAvatar = new lib.ImageAvatar();
        pnCenter = new javax.swing.JPanel();
        lbName = new javax.swing.JLabel();

        lbStatus.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        lbStatus.setText("online");

        lbNumberMember.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        lbNumberMember.setText("45 thành viên");

        setBackground(new java.awt.Color(255, 255, 255));
        setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(200, 200, 200)));
        setMaximumSize(new java.awt.Dimension(823421, 7423420));
        setMinimumSize(new java.awt.Dimension(81, 70));
        setPreferredSize(new java.awt.Dimension(82222221, 70));
        setLayout(new java.awt.BorderLayout());

        jPanel1.setMaximumSize(new java.awt.Dimension(70, 70));
        jPanel1.setMinimumSize(new java.awt.Dimension(70, 70));
        jPanel1.setOpaque(false);
        jPanel1.setPreferredSize(new java.awt.Dimension(70, 70));
        jPanel1.setLayout(new java.awt.GridLayout(1, 0));

        btnShowInfo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/stories.png"))); // NOI18N
        btnShowInfo.setBorder(null);
        btnShowInfo.setBorderPainted(false);
        btnShowInfo.setContentAreaFilled(false);
        btnShowInfo.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnShowInfo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnShowInfoActionPerformed(evt);
            }
        });
        jPanel1.add(btnShowInfo);

        add(jPanel1, java.awt.BorderLayout.LINE_END);

        jPanel2.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 15, 0, 0));
        jPanel2.setOpaque(false);
        jPanel2.setLayout(new java.awt.BorderLayout());

        jPanel3.setBorder(javax.swing.BorderFactory.createEmptyBorder(5, 0, 5, 0));
        jPanel3.setMinimumSize(new java.awt.Dimension(70, 60));
        jPanel3.setOpaque(false);
        jPanel3.setPreferredSize(new java.awt.Dimension(70, 60));
        jPanel3.setLayout(new javax.swing.BoxLayout(jPanel3, javax.swing.BoxLayout.LINE_AXIS));

        imageAvatar.setMaximumSize(new java.awt.Dimension(60, 60));
        imageAvatar.setMinimumSize(new java.awt.Dimension(60, 60));
        jPanel3.add(imageAvatar);

        jPanel2.add(jPanel3, java.awt.BorderLayout.LINE_START);

        pnCenter.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 5, 1, 1));
        pnCenter.setOpaque(false);
        pnCenter.setLayout(new javax.swing.BoxLayout(pnCenter, javax.swing.BoxLayout.PAGE_AXIS));

        lbName.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lbName.setText("Hùng Trần");
        lbName.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 1, 10, 1));
        pnCenter.add(lbName);

        jPanel2.add(pnCenter, java.awt.BorderLayout.CENTER);

        add(jPanel2, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents

    private void btnShowInfoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnShowInfoActionPerformed
        
    }//GEN-LAST:event_btnShowInfoActionPerformed
    public void setInfo(String name, byte[] avatar,int status){
        lbName.setText(name);
        imageAvatar.setImage(new ImageIcon(avatar));
            pnCenter.add(lbStatus);
            if(status == 1){
                lbStatus.setForeground(new Color(27,200,96));
                lbStatus.setText("Online");
            }else{
                lbStatus.setForeground(new Color(72,75,66));
                lbStatus.setText("Ofline");
            }
    }
    public void setInfo(String name,int numberMember ,byte[] avatar){
        lbName.setText(name);
        imageAvatar.setImage(new ImageIcon(avatar));
        pnCenter.add(lbNumberMember);
        lbNumberMember.setText(numberMember+" thành viên");
        
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnShowInfo;
    private lib.ImageAvatar imageAvatar;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JLabel lbName;
    private javax.swing.JLabel lbNumberMember;
    private javax.swing.JLabel lbStatus;
    private javax.swing.JPanel pnCenter;
    // End of variables declaration//GEN-END:variables
    public javax.swing.JButton getBtnShowInfo() {
        return btnShowInfo;
    }
}
