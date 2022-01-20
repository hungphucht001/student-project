package clinet.gui.center.chat;

import clinet.gui.publicevent.PublicEvent;
import java.awt.Adjustable;
import java.awt.Color;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.AdjustmentEvent;
import java.awt.event.AdjustmentListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.File;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollBar;
import javax.swing.JScrollPane;
import javax.swing.SwingUtilities;
import javax.swing.border.EmptyBorder;
import lib.JIMSendTextPane;
import lib.PictureBox;
import lib.ScrollBar;
import net.miginfocom.swing.MigLayout;

/**
 *
 * @author Hùng Trần
 */
public class ChatBottom_GUI extends javax.swing.JPanel {
    private JIMSendTextPane txt;
    private JScrollPane scroll;
    public ChatBottom_GUI() {
        initComponents();
        init();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel2 = new javax.swing.JPanel();
        btnSend = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        jPanel1 = new javax.swing.JPanel();
        btnFile = new javax.swing.JButton();
        btnMedia = new javax.swing.JButton();
        btnSticker = new javax.swing.JButton();
        pnCentent = new javax.swing.JPanel();
        pnSticker = new javax.swing.JPanel();
        tabPn = new javax.swing.JTabbedPane();

        setBackground(new java.awt.Color(255, 255, 255));
        setBorder(javax.swing.BorderFactory.createMatteBorder(1, 0, 0, 0, new java.awt.Color(0, 0, 0)));
        setMinimumSize(new java.awt.Dimension(50, 68));
        setPreferredSize(new java.awt.Dimension(50, 68));
        setLayout(new java.awt.BorderLayout());

        jPanel2.setMaximumSize(new java.awt.Dimension(50, 68));
        jPanel2.setMinimumSize(new java.awt.Dimension(50, 68));
        jPanel2.setOpaque(false);
        jPanel2.setPreferredSize(new java.awt.Dimension(50, 68));
        jPanel2.setLayout(new java.awt.BorderLayout());

        btnSend.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/send.png"))); // NOI18N
        btnSend.setBorder(null);
        btnSend.setBorderPainted(false);
        btnSend.setContentAreaFilled(false);
        btnSend.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnSend.setEnabled(false);
        btnSend.setFocusPainted(false);
        btnSend.setMaximumSize(new java.awt.Dimension(50, 68));
        btnSend.setMinimumSize(new java.awt.Dimension(50, 68));
        btnSend.setPreferredSize(new java.awt.Dimension(50, 68));
        jPanel2.add(btnSend, java.awt.BorderLayout.PAGE_END);

        add(jPanel2, java.awt.BorderLayout.LINE_END);

        jPanel3.setOpaque(false);
        jPanel3.setPreferredSize(new java.awt.Dimension(150, 68));
        jPanel3.setLayout(new java.awt.BorderLayout());

        jPanel1.setMaximumSize(new java.awt.Dimension(150, 68));
        jPanel1.setMinimumSize(new java.awt.Dimension(150, 68));
        jPanel1.setOpaque(false);
        jPanel1.setPreferredSize(new java.awt.Dimension(150, 68));
        jPanel1.setLayout(new java.awt.GridLayout(1, 3));

        btnFile.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/paperclip.png"))); // NOI18N
        btnFile.setBorder(null);
        btnFile.setBorderPainted(false);
        btnFile.setContentAreaFilled(false);
        btnFile.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnFile.setMaximumSize(new java.awt.Dimension(50, 50));
        btnFile.setMinimumSize(new java.awt.Dimension(50, 9));
        btnFile.setPreferredSize(new java.awt.Dimension(50, 9));
        jPanel1.add(btnFile);

        btnMedia.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/photo.png"))); // NOI18N
        btnMedia.setBorder(null);
        btnMedia.setBorderPainted(false);
        btnMedia.setContentAreaFilled(false);
        btnMedia.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnMedia.setMaximumSize(new java.awt.Dimension(50, 50));
        btnMedia.setMinimumSize(new java.awt.Dimension(50, 9));
        btnMedia.setPreferredSize(new java.awt.Dimension(50, 9));
        jPanel1.add(btnMedia);

        btnSticker.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/stickers-face.png"))); // NOI18N
        btnSticker.setBorder(null);
        btnSticker.setBorderPainted(false);
        btnSticker.setContentAreaFilled(false);
        btnSticker.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnSticker.setMaximumSize(new java.awt.Dimension(50, 50));
        btnSticker.setMinimumSize(new java.awt.Dimension(50, 9));
        btnSticker.setPreferredSize(new java.awt.Dimension(50, 9));
        jPanel1.add(btnSticker);

        jPanel3.add(jPanel1, java.awt.BorderLayout.PAGE_END);

        add(jPanel3, java.awt.BorderLayout.LINE_START);

        pnCentent.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 1, 0, 1, new java.awt.Color(200, 200, 200)));
        pnCentent.setMaximumSize(new java.awt.Dimension(32767, 324234));
        pnCentent.setMinimumSize(new java.awt.Dimension(0, 68));
        pnCentent.setOpaque(false);
        pnCentent.setPreferredSize(new java.awt.Dimension(277, 68));

        javax.swing.GroupLayout pnCententLayout = new javax.swing.GroupLayout(pnCentent);
        pnCentent.setLayout(pnCententLayout);
        pnCententLayout.setHorizontalGroup(
            pnCententLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 275, Short.MAX_VALUE)
        );
        pnCententLayout.setVerticalGroup(
            pnCententLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 68, Short.MAX_VALUE)
        );

        add(pnCentent, java.awt.BorderLayout.CENTER);

        pnSticker.setBackground(new java.awt.Color(255, 255, 255));
        pnSticker.setBorder(javax.swing.BorderFactory.createMatteBorder(0, 0, 1, 0, new java.awt.Color(200, 200, 200)));
        pnSticker.setMinimumSize(new java.awt.Dimension(100, 232));
        pnSticker.setPreferredSize(new java.awt.Dimension(477, 232));
        pnSticker.setLayout(new java.awt.GridLayout(1, 0));

        tabPn.setBackground(new java.awt.Color(255, 255, 255));
        tabPn.setTabLayoutPolicy(javax.swing.JTabbedPane.SCROLL_TAB_LAYOUT);
        pnSticker.add(tabPn);

        add(pnSticker, java.awt.BorderLayout.PAGE_START);
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnFile;
    private javax.swing.JButton btnMedia;
    private javax.swing.JButton btnSend;
    private javax.swing.JButton btnSticker;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel pnCentent;
    private javax.swing.JPanel pnSticker;
    private javax.swing.JTabbedPane tabPn;
    // End of variables declaration//GEN-END:variables
    private void init() {
        pnCentent.setLayout(new MigLayout("fillx, filly", "0[fill]0[]0[]2", "2[fill]2"));
        scroll = new JScrollPane(JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED, JScrollPane.HORIZONTAL_SCROLLBAR_NEVER);
        scroll.setBorder(null);
        txt = new JIMSendTextPane();
        getTxt().setFont(new Font("Aria", Font.PLAIN, 16));
        getTxt().setBorder(new EmptyBorder(20, 10, 20, 10));
        getTxt().addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent ke) {
                refresh();
            }
        });
        scroll.setViewportView(getTxt());
        ScrollBar sb = new ScrollBar();
        sb.setPreferredSize(new Dimension(10, 10));
        scroll.setVerticalScrollBar(sb);
        pnCentent.add(scroll, "w 100%");
        pnSticker.setVisible(false);
//        scrollToBottom();
        loadSticker();
        
    }
    public void setTxt(String txta){
        txt.setText(txta);
    }
    private void refresh() {
        revalidate();
    }
    public JIMSendTextPane getTxt() {
        return txt;
    }
    public javax.swing.JButton getBtnFile() {
        return btnFile;
    }
    public javax.swing.JButton getBtnMedia() {
        return btnMedia;
    }
    public javax.swing.JButton getBtnSend() {
        return btnSend;
    }
    public javax.swing.JButton getBtnSticker() {
        return btnSticker;
    }
    public javax.swing.JPanel getPnSticker() {
        return pnSticker;
    }
    public void scrollToBottom() {
        JScrollBar verticalBar = scroll.getVerticalScrollBar();
        AdjustmentListener downScroller = new AdjustmentListener() {
            @Override
            public void adjustmentValueChanged(AdjustmentEvent e) {
                Adjustable adjustable = e.getAdjustable();
                adjustable.setValue(adjustable.getMaximum());
                verticalBar.removeAdjustmentListener(this);
            }
        };
        verticalBar.addAdjustmentListener(downScroller);
    }
    private void loadSticker(){
        String pathStickers = "./src/data/assets/stickers/";
        File fStickers = new File(pathStickers);
        if(fStickers.isDirectory()){
            File[] listStickerPar =  fStickers.listFiles();
            for(File a: listStickerPar)
            {
                JPanel pnItemTab = new JPanel();
                pnItemTab.setBackground(Color.white);
                pnItemTab.setLayout(new GridLayout());
                JScrollPane spSticker = new JScrollPane(JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED,JScrollPane.HORIZONTAL_SCROLLBAR_NEVER);
                spSticker.setVerticalScrollBar(new ScrollBar());
                spSticker.getVerticalScrollBar().setUnitIncrement(50);
                JPanel pnWrapStickers = new JPanel();
                pnWrapStickers.setBackground(Color.white);
                pnWrapStickers.setLayout(new FlowLayout(FlowLayout.LEFT,7,7));
                pnWrapStickers.setPreferredSize(new Dimension(tabPn.getPreferredSize().width, 300));
                spSticker.setViewportView(pnWrapStickers);
                pnItemTab.add(spSticker);
                tabPn.add(pnItemTab);
                String nameFolder = a.getName();
                File sticker = new File(pathStickers+nameFolder);
                if(sticker.isDirectory()){
                    File[] stks = sticker.listFiles();
                    for(File flStk: stks){
                        JLabel pic = new JLabel();
                        pic.setPreferredSize(new Dimension(100, 100));
                        pic.setCursor(new Cursor(Cursor.HAND_CURSOR));
                        pic.setHorizontalAlignment(JLabel.CENTER);
                        pic.addMouseListener(new MouseAdapter() {
                            @Override
                            public void mouseReleased(MouseEvent e) {
                                if(SwingUtilities.isLeftMouseButton(e)){
                                    PublicEvent.getPublicEvent().getChatStickerEvent().chatStickerEvent(pic.getIcon().toString());
                                }
                            }
                        });
                        pic.setIcon(new ImageIcon(pathStickers+nameFolder+"/"+flStk.getName()));
                        pnWrapStickers.add(pic);
                    }
                }
            }
        }
    }
}
