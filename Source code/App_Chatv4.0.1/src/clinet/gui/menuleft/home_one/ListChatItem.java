package clinet.gui.menuleft.home_one;

import clinet.gui.SocketCommunication;
import static clinet.gui.SocketCommunication.listChatGroup;
import static clinet.gui.SocketCommunication.listChatPeople;
import clinet.gui.publicLoading.LoadListChat;
import clinet.gui.publicLoading.PublicLoading;
import clinet.gui.publicLoading.UpdateList;
import clinet.gui.publicevent.PublicEvent;
import java.awt.Cursor;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.BufferedInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.SwingUtilities;
import javazoom.jl.player.Player;
import lib.ScrollBar;
import pojo.ListChatGroup;
import pojo.ListChatPeople;
/**
 *
 * @author Hùng Trần
 */
public class ListChatItem extends javax.swing.JPanel {
    private JList<pojo.ListChatPeople> ltChatItemFriend;
    private JList<ListChatGroup> ltChatItemGroup;
    private DefaultListModel<pojo.ListChatPeople> dlmfriend;
    private DefaultListModel<ListChatGroup> dlmGroup;
    private int numberSlIndexLFriend = -1;
    private int numberSlIndexLGroup = -1;
    public ListChatItem() {
        initComponents();
        init();
        loadDataMess();
        loadDataGroup();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        spListItemChat = new javax.swing.JScrollPane();

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.GridLayout(1, 0));

        spListItemChat.setBackground(new java.awt.Color(255, 255, 255));
        spListItemChat.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        spListItemChat.setHorizontalScrollBarPolicy(javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        add(spListItemChat);
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JScrollPane spListItemChat;
    // End of variables declaration//GEN-END:variables
    Player player;
    private void init() {
        getSpListItemChat().setVerticalScrollBar(new ScrollBar());
        getSpListItemChat().getVerticalScrollBar().setUnitIncrement(40);
        //mess
        dlmfriend = new DefaultListModel<pojo.ListChatPeople>();
        ltChatItemFriend = new JList<pojo.ListChatPeople>(dlmfriend);
        
        ltChatItemFriend.setCellRenderer(new ListChatRender());
        getSpListItemChat().setViewportView(getLtChatItemFriend());
        //group
        dlmGroup = new DefaultListModel<ListChatGroup>();
        ltChatItemGroup = new JList<ListChatGroup>(dlmGroup);
        ltChatItemGroup.setCellRenderer(new MessageGroupListRender());
        initEvent();
        PublicLoading.getPublicLoading().setUpdateList(new UpdateList() {
            @Override
            public void updateListPeopel() {
                sortListPeopel();
                loadDataMess();
            }
            @Override
            public void updateListGroup() {
                sortListGroup();
                loadDataGroup();
            }
        });
    }
    
    public void sortListPeopel(){
        Collections.sort(SocketCommunication.listChatPeople,new Comparator<ListChatPeople>(){
            @Override
            public int compare(ListChatPeople o1, ListChatPeople o2) {
                return (o2.getMessage().getDateofsend().compareTo(o1.getMessage().getDateofsend()));
            }
        });
    }
    public void sortListGroup(){
        Collections.sort(SocketCommunication.listChatGroup,new Comparator<ListChatGroup>(){
            @Override
            public int compare(ListChatGroup o1, ListChatGroup o2) {
                return (o2.getGroupMessage().getDateofsend().compareTo(o1.getGroupMessage().getDateofsend()));
            }
        });
    }
    private void loadDataMess() {
        if(SocketCommunication.listChatPeople != null){
            dlmfriend.removeAllElements();
            for(pojo.ListChatPeople l : SocketCommunication.listChatPeople){
                dlmfriend.addElement(l);
        }
        PublicLoading.getPublicLoading().setLoadListChat(new LoadListChat() {
            @Override
            public void loadListChat(ArrayList<ListChatPeople> listChatPeople) {
                dlmfriend.removeAllElements();
                for(pojo.ListChatPeople l : listChatPeople){
                    dlmfriend.addElement(l);
                    }
                }
            });
        }
    }
    private void loadDataGroup() {
        if(SocketCommunication.listChatGroup != null){
            dlmGroup.removeAllElements();
            for(ListChatGroup l: SocketCommunication.listChatGroup){
                dlmGroup.addElement(l);
            }
        }
    }
    public javax.swing.JScrollPane getSpListItemChat() {
        return spListItemChat;
    }
    public JList<pojo.ListChatPeople> getLtChatItemFriend() {
        return ltChatItemFriend;
    }
    public JList<ListChatGroup> getLtChatItemGroup() {
        return ltChatItemGroup;
    }
    private void initEvent() {
        getLtChatItemFriend().setCursor(new Cursor(Cursor.HAND_CURSOR));
        getLtChatItemGroup().setCursor(new Cursor(Cursor.HAND_CURSOR));
        getLtChatItemFriend().addMouseListener(new MouseAdapter() {
            @Override
            public void mouseReleased(MouseEvent e) {
                if(SwingUtilities.isLeftMouseButton(e) && getLtChatItemFriend().getSelectedIndex() != numberSlIndexLFriend){
                    numberSlIndexLGroup = -1;
                    getLtChatItemGroup().revalidate();
                    PublicEvent.getPublicEvent().getEventPersonChat().eventPersonChat1(getLtChatItemFriend().getSelectedValue().getUser(),getLtChatItemFriend().getSelectedValue().getMessage());
                    numberSlIndexLFriend = getLtChatItemFriend().getSelectedIndex();
                    PublicEvent.getPublicEvent().getEventSendToServer().eventLoadDataMessPeopel(getLtChatItemFriend().getSelectedValue().getUser().getId());
                }
                PublicLoading.getPublicLoading().getLoadSize().loadSize();
            }
        });
        getLtChatItemGroup().addMouseListener(new MouseAdapter() {
            @Override
            public void mouseReleased(MouseEvent e) {
                if(SwingUtilities.isLeftMouseButton(e) && getLtChatItemGroup().getSelectedIndex() != numberSlIndexLGroup){
                    numberSlIndexLFriend = -1;
                    getLtChatItemFriend().revalidate();
                    PublicEvent.getPublicEvent().getEventGroupChat().eventGroupChat(getLtChatItemGroup().getSelectedValue());
                    numberSlIndexLGroup = getLtChatItemGroup().getSelectedIndex();
                    PublicEvent.getPublicEvent().getEventSendToServer().eventLoadDataMessageGroup(getLtChatItemGroup().getSelectedValue().getGroup().getId());
                }
                PublicLoading.getPublicLoading().getLoadSize().loadSize();
            }
        });
    }
}
