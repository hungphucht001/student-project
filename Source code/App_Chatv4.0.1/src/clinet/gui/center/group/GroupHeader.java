package clinet.gui.center.group;

/**
 *
 * @author Hùng Trần
 */
public class GroupHeader extends javax.swing.JPanel {

    /**
     * Creates new form Group_Header
     */
    public GroupHeader() {
        initComponents();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        imageAvatar1 = new lib.ImageAvatar();
        jPanel2 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();

        setBackground(new java.awt.Color(255, 255, 255));
        setBorder(javax.swing.BorderFactory.createCompoundBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(200, 200, 200)), javax.swing.BorderFactory.createEmptyBorder(0, 10, 0, 0)));
        setMaximumSize(new java.awt.Dimension(2147483647, 70));
        setMinimumSize(new java.awt.Dimension(200, 70));
        setPreferredSize(new java.awt.Dimension(1080, 70));
        setLayout(new java.awt.BorderLayout());

        jPanel1.setMinimumSize(new java.awt.Dimension(100, 70));
        jPanel1.setOpaque(false);

        imageAvatar1.setImage(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/icon/icon_listgroup.png"))); // NOI18N
        imageAvatar1.setPreferredSize(new java.awt.Dimension(60, 60));
        jPanel1.add(imageAvatar1);

        add(jPanel1, java.awt.BorderLayout.LINE_START);

        jPanel2.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 10, 0, 0));
        jPanel2.setOpaque(false);
        jPanel2.setLayout(new java.awt.GridLayout(1, 0));

        jLabel1.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        jLabel1.setText("Danh sách nhóm");
        jPanel2.add(jLabel1);

        add(jPanel2, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private lib.ImageAvatar imageAvatar1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    // End of variables declaration//GEN-END:variables
}
