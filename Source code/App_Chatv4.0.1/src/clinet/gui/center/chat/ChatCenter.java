package clinet.gui.center.chat;

import java.awt.Adjustable;
import java.awt.Color;
import java.awt.Label;
import java.awt.event.AdjustmentEvent;
import java.awt.event.AdjustmentListener;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JScrollBar;
import lib.DateTimeFormat;
import lib.FontSchatz;
import lib.ScrollBar;
import net.miginfocom.swing.MigLayout;
import pojo.Message;
/**
 *
 * @author Hùng Trần
 */
public class ChatCenter extends javax.swing.JPanel {
    DateTimeFormat dateFormat = new DateTimeFormat();
    public ChatCenter() {
        initComponents();
        init();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        spChat = new javax.swing.JScrollPane();
        pnContentChat = new javax.swing.JPanel();

        setBackground(new java.awt.Color(255, 102, 0));
        setLayout(new java.awt.GridLayout(1, 0));

        spChat.setBackground(new java.awt.Color(255, 255, 102));
        spChat.setBorder(null);
        spChat.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);

        pnContentChat.setBackground(new java.awt.Color(255, 255, 255));
        pnContentChat.setMinimumSize(new java.awt.Dimension(30, 30));

        javax.swing.GroupLayout pnContentChatLayout = new javax.swing.GroupLayout(pnContentChat);
        pnContentChat.setLayout(pnContentChatLayout);
        pnContentChatLayout.setHorizontalGroup(
            pnContentChatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 396, Short.MAX_VALUE)
        );
        pnContentChatLayout.setVerticalGroup(
            pnContentChatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 282, Short.MAX_VALUE)
        );

        spChat.setViewportView(pnContentChat);

        add(spChat);
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel pnContentChat;
    private javax.swing.JScrollPane spChat;
    // End of variables declaration//GEN-END:variables
    private void init() {
        this.setBackground(FontSchatz.BACKGROUND_CHAT);
        pnContentChat.setBackground(FontSchatz.BACKGROUND_CHAT);
        spChat.setVisible(true);
        pnContentChat.setLayout(new MigLayout("fillx","10[]10","10[]10"));
        spChat.setVerticalScrollBar(new ScrollBar());
        spChat.getVerticalScrollBar().setUnitIncrement(50);
    }
    public void addLeft(pojo.PeopelMessage message,byte[] avatar ,int dateauto){   
        ChatLeft chatLeft = new ChatLeft(message,dateauto);
        pnContentChat.add(chatLeft,"wrap, w 100::80%");
        chatLeft.setAvatar(avatar);
        revali();
    }
    public void addLeft(pojo.GroupMessage message,byte[] avatar ,int dateauto){   
        ChatLeft chatLeft = new ChatLeft(message,dateauto);
        pnContentChat.add(chatLeft,"wrap, w 100::80%");
        revali();
        chatLeft.setAvatar(avatar);
    }
    public void addRight(pojo.PeopelMessage message,int dateauto){   
        ChatRight chatRight = new ChatRight(message,dateauto);
        pnContentChat.add(chatRight,"wrap,al right, w 100::80%");
        revali();
    }
    public void addRight(pojo.GroupMessage message,int dateauto){   
        ChatRight chatRight = new ChatRight(message,dateauto);
        pnContentChat.add(chatRight,"wrap,al right, w 100::80%");
        revali();
    }
    public void addDate(String date){
        ChatLine chatLine = new ChatLine(date);
        pnContentChat.add(chatLine,"wrap,center, w 100::80%");
        revali();
    }
    private void revali(){
        pnContentChat.repaint();
        pnContentChat.revalidate();
        scrollToBottom();
    }
    private void scrollToBottom() {
        JScrollBar verticalBar = spChat.getVerticalScrollBar();
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
}
