package clinet.gui.menuleft;
import clinet.gui.SocketCommunication;
import clinet.gui.dialog.SettingAccount;
import clinet.gui.publicevent.PublicEvent;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import lib.FontSchatz;

/**
 *
 * @author Hùng Trần
 */
public class Header extends javax.swing.JPanel {
    public Header() {
        initComponents();
        this.setBackground(FontSchatz.BACKGROUND_CL);
        lbFullName.setForeground(FontSchatz.COLOR_TEXT_W);
        loadInfo(); 
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnAvatar = new javax.swing.JPanel();
        imageAvatar1 = new lib.ImageAvatar();
        pnLogout = new javax.swing.JPanel();
        btnLogout = new javax.swing.JButton();
        pnName = new javax.swing.JPanel();
        lbFullName = new javax.swing.JLabel();

        setBackground(new java.awt.Color(255, 153, 51));
        setMinimumSize(new java.awt.Dimension(273, 70));
        setPreferredSize(new java.awt.Dimension(222, 70));
        setLayout(new java.awt.BorderLayout());

        pnAvatar.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 5, 1, 1));
        pnAvatar.setMaximumSize(new java.awt.Dimension(72, 62));
        pnAvatar.setMinimumSize(new java.awt.Dimension(72, 62));
        pnAvatar.setOpaque(false);
        pnAvatar.setPreferredSize(new java.awt.Dimension(72, 62));
        pnAvatar.setLayout(new javax.swing.BoxLayout(pnAvatar, javax.swing.BoxLayout.LINE_AXIS));

        imageAvatar1.setBorderColor(null);
        imageAvatar1.setInheritsPopupMenu(true);
        imageAvatar1.setMaximumSize(new java.awt.Dimension(60, 60));
        imageAvatar1.setMinimumSize(new java.awt.Dimension(60, 60));
        imageAvatar1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseReleased(java.awt.event.MouseEvent evt) {
                imageAvatar1MouseReleased(evt);
            }
        });
        pnAvatar.add(imageAvatar1);

        add(pnAvatar, java.awt.BorderLayout.LINE_START);

        pnLogout.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 1, 1, 10));
        pnLogout.setOpaque(false);
        pnLogout.setPreferredSize(new java.awt.Dimension(50, 80));
        pnLogout.setRequestFocusEnabled(false);
        pnLogout.setLayout(new java.awt.GridLayout(1, 0));

        btnLogout.setBackground(new java.awt.Color(255, 153, 51));
        btnLogout.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon-logout.png"))); // NOI18N
        btnLogout.setBorder(null);
        btnLogout.setBorderPainted(false);
        btnLogout.setContentAreaFilled(false);
        btnLogout.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnLogout.setFocusPainted(false);
        btnLogout.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnLogoutActionPerformed(evt);
            }
        });
        pnLogout.add(btnLogout);

        add(pnLogout, java.awt.BorderLayout.LINE_END);

        pnName.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 10, 1, 1));
        pnName.setMaximumSize(new java.awt.Dimension(161, 80));
        pnName.setMinimumSize(new java.awt.Dimension(161, 80));
        pnName.setOpaque(false);
        pnName.setLayout(new java.awt.GridLayout(1, 0));

        lbFullName.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        pnName.add(lbFullName);

        add(pnName, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents

    private void btnLogoutActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLogoutActionPerformed
        int tl = JOptionPane.showConfirmDialog(null, "Đăng xuất", "Schatz", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
        if(tl == JOptionPane.YES_OPTION){
            PublicEvent.getPublicEvent().getEventSendToServer().eventLogout();
        }
        else if(tl== JOptionPane.NO_OPTION){
            return ;
        }
    }//GEN-LAST:event_btnLogoutActionPerformed

    private void imageAvatar1MouseReleased(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_imageAvatar1MouseReleased
        new SettingAccount(null, true).setVisible(true);
    }//GEN-LAST:event_imageAvatar1MouseReleased

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnLogout;
    private lib.ImageAvatar imageAvatar1;
    private javax.swing.JLabel lbFullName;
    private javax.swing.JPanel pnAvatar;
    private javax.swing.JPanel pnLogout;
    private javax.swing.JPanel pnName;
    // End of variables declaration//GEN-END:variables

    private void loadInfo() {
        imageAvatar1.updateUI();
        imageAvatar1.setImage(new ImageIcon(SocketCommunication.user.getDataFileAvatar().getFile()));
        lbFullName.setText(SocketCommunication.user.fullName());
    }
}
