package clinet.gui.center.chat;

import clinet.gui.publicevent.PublicEvent;
import java.awt.Component;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JMenuItem;
import javax.swing.JPopupMenu;
import javax.swing.SwingUtilities;
import lib.PictureBox;
import net.miginfocom.swing.MigLayout;
import pojo.DataFile;

/**
 *
 * @author Hùng Trần
 */
public class ChatImage extends javax.swing.JPanel {
     private boolean isRight;
     private DataFile dataFile;
    public ChatImage(pojo.DataFile dataFile) {
        this.dataFile = dataFile;
        initComponents();
        setLayout(new MigLayout("", "10[]10", "10[]0"));
        addImage(new ImageIcon(dataFile.getFile()));
    }
    private void addEvent(Component com, Icon image){
        com.setCursor(new Cursor(Cursor.HAND_CURSOR));
        com.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseReleased(MouseEvent e) {
                if(SwingUtilities.isLeftMouseButton(e)){
                    PublicEvent.getPublicEvent().getEventImageView().viewImage(dataFile);
                }
            }
        });
    }
    public void addImage(Icon... images){
        for (Icon image : images) {
            PictureBox pic = new PictureBox();
            pic.setPreferredSize(getAutoSize(image, 500, 500));
            pic.setImage(image);
            add(pic, "wrap");
            addEvent(pic,image);
        }
    }
    private Dimension getAutoSize(Icon image, int w, int h){
        int iw = image.getIconWidth();
        int ih = image.getIconHeight();
        double xScale = (double) w / iw;
        double yScale = (double) h / ih;
        double scale = Math.min(xScale, yScale);
        int width = (int) (scale * iw);
        int height = (int) (scale * ih);
        return new Dimension(width, height);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        setOpaque(false);
        setLayout(new javax.swing.BoxLayout(this, javax.swing.BoxLayout.PAGE_AXIS));
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables
}
