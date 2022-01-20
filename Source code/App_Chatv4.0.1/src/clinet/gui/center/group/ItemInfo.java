package clinet.gui.center.group;

import clinet.gui.publicevent.PublicEvent;
import java.awt.Dimension;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

/**
 *
 * @author Hùng Trần
 */
public class ItemInfo extends javax.swing.JPanel {
    private boolean isShow = false;
    private int id;
    private String title;
    public ItemInfo() {
        initComponents();
        showContent();
        eventHeadling();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnTitle = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        lbTitle = new javax.swing.JLabel();
        jPanel2 = new javax.swing.JPanel();
        pnContent = new javax.swing.JPanel();

        setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 0, 0, 0));
        setLayout(new java.awt.BorderLayout());

        pnTitle.setBackground(new java.awt.Color(255, 255, 255));
        pnTitle.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 10, 0, 10));
        pnTitle.setPreferredSize(new java.awt.Dimension(400, 50));
        pnTitle.setLayout(new java.awt.BorderLayout());

        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/right.png"))); // NOI18N
        jLabel1.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 10, 1, 5));
        pnTitle.add(jLabel1, java.awt.BorderLayout.LINE_END);

        lbTitle.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        lbTitle.setText("Thành viên");
        pnTitle.add(lbTitle, java.awt.BorderLayout.CENTER);

        add(pnTitle, java.awt.BorderLayout.PAGE_START);

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));
        jPanel2.setBorder(javax.swing.BorderFactory.createEmptyBorder(1, 10, 10, 10));
        jPanel2.setLayout(new java.awt.BorderLayout());

        pnContent.setBackground(new java.awt.Color(255, 255, 255));
        pnContent.setBorder(javax.swing.BorderFactory.createEmptyBorder(0, 0, 10, 0));
        pnContent.setMinimumSize(new java.awt.Dimension(380, 100));

        javax.swing.GroupLayout pnContentLayout = new javax.swing.GroupLayout(pnContent);
        pnContent.setLayout(pnContentLayout);
        pnContentLayout.setHorizontalGroup(
            pnContentLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 380, Short.MAX_VALUE)
        );
        pnContentLayout.setVerticalGroup(
            pnContentLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 90, Short.MAX_VALUE)
        );

        jPanel2.add(pnContent, java.awt.BorderLayout.CENTER);

        add(jPanel2, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JLabel lbTitle;
    private javax.swing.JPanel pnContent;
    private javax.swing.JPanel pnTitle;
    // End of variables declaration//GEN-END:variables
    public void setInfo(String title, int id){
        lbTitle.setText(title);
        this.id = id;
        this.title = title;
    }
    private void eventHeadling() {
        pnTitle.addMouseListener(new MouseListener() {

            @Override
            public void mouseClicked(MouseEvent e) {
            }
            @Override
            public void mousePressed(MouseEvent e) {
            }
            @Override
            public void mouseReleased(MouseEvent e) {
                showContent();
                PublicEvent.getPublicEvent().getSeeAllInfoGroup().seeAllInfoGroup(title,id);
            }
            @Override
            public void mouseEntered(MouseEvent e) {
            }
            @Override
            public void mouseExited(MouseEvent e) {
            }
        }
        );
    }
    private void showContent(){
        if(isShow){
            pnContent.setVisible(true);
            isShow = false;
        }
        else{
            pnContent.setVisible(false);
            isShow = true;
        }
    }
}
