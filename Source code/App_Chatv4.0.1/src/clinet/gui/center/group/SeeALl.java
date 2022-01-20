package clinet.gui.center.group;

import clinet.dto.Setting_DTO;
import clinet.gui.SocketCommunication;
import clinet.gui.center.chat.FileInfo;
import clinet.gui.center.chat.FileItem;
import clinet.gui.component.SettingRender;
import clinet.gui.dialog.AddMember;
import clinet.gui.dialog.RenameGroup;
import clinet.gui.menuleft.home_two.ListFriendRender;
import clinet.gui.publicLoading.PublicLoading;
import clinet.gui.publicevent.PublicEvent;
import java.awt.Color;
import java.awt.Component;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.ArrayList;
import static java.util.Collections.reverse;
import javax.swing.DefaultListModel;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JList;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JPopupMenu;
import javax.swing.SwingUtilities;
import lib.PictureBox;
import net.miginfocom.swing.MigLayout;
import pojo.DataFile;
import pojo.GroupMember;
import pojo.GroupMessage;
import pojo.ListChatGroup;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */

public class SeeALl extends javax.swing.JPanel {
    private DefaultListModel<User_account> dlm;
    private JList<User_account> lMember;
    private int id;
    private FileInfo fileInfo;
    private ArrayList<GroupMember> alMember;
    public SeeALl() {
        initComponents();
        init();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnTitle = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        lbTitle = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        pnContent = new javax.swing.JPanel();
        sp = new javax.swing.JScrollPane();

        setBackground(new java.awt.Color(255, 255, 255));
        setLayout(new java.awt.BorderLayout());

        pnTitle.setBackground(new java.awt.Color(255, 255, 255));
        pnTitle.setMaximumSize(new java.awt.Dimension(32767, 70));
        pnTitle.setMinimumSize(new java.awt.Dimension(100, 70));
        pnTitle.setName(""); // NOI18N
        pnTitle.setPreferredSize(new java.awt.Dimension(309, 70));
        pnTitle.setLayout(new java.awt.BorderLayout());

        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        pnTitle.add(jLabel2, java.awt.BorderLayout.LINE_END);

        lbTitle.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        lbTitle.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lbTitle.setText("Media");
        pnTitle.add(lbTitle, java.awt.BorderLayout.CENTER);

        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/assets/icons/arrow-left.png"))); // NOI18N
        jButton1.setBorder(null);
        jButton1.setBorderPainted(false);
        jButton1.setContentAreaFilled(false);
        jButton1.setFocusPainted(false);
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        pnTitle.add(jButton1, java.awt.BorderLayout.LINE_START);

        add(pnTitle, java.awt.BorderLayout.PAGE_START);

        pnContent.setLayout(new java.awt.GridLayout(1, 0));

        sp.setBorder(null);
        pnContent.add(sp);

        add(pnContent, java.awt.BorderLayout.CENTER);
    }// </editor-fold>//GEN-END:initComponents
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel lbTitle;
    private javax.swing.JPanel pnContent;
    private javax.swing.JPanel pnTitle;
    private javax.swing.JScrollPane sp;
    // End of variables declaration//GEN-END:variables
    private void init() {
        jLabel2.setPreferredSize(jButton1.getPreferredSize());
    }
    public void setTitle(String title, int id, ArrayList<GroupMember> alMember, ArrayList<GroupMessage> alMess, int idGroup) {
        lbTitle.setText(title);
        this.alMember = alMember;

        this.id = id;
        if(id == 1) loadMember(alMember);
        else if(id==2) loadMedia(alMess);
        else if(id==3) loadFile(alMess);
        else orther(idGroup);
    }
    public void loadMember(ArrayList<GroupMember> alMember){
        dlm = new DefaultListModel<User_account>();
        lMember = new JList<User_account>();
        for(pojo.GroupMember member : alMember){
            dlm.addElement(member.getUser());
        }
        lMember.setModel(dlm);
        lMember.setCellRenderer(new ListFriendRender());
        sp.setViewportView(lMember);
        lMember.addMouseListener(new MouseAdapter() {
            public void mouseReleased(MouseEvent e) {
                if(lMember.getSelectedValue().getId() == SocketCommunication.user.getId()){
                    return;
                }
                else if(SwingUtilities.isLeftMouseButton(e)){
                    PublicEvent.getPublicEvent().getEventPersonChat().eventPersonChat2(lMember.getSelectedValue());
                    PublicEvent.getPublicEvent().getEventSendToServer().eventLoadDataMessPeopel(lMember.getSelectedValue().getId());
                }
            }
        });
    }
    public void loadMedia(ArrayList<GroupMessage> alMess){
        JPanel pnContentMedia = new JPanel();
        pnContentMedia.setLayout(new MigLayout("fillx","3[fill]3[fill]3[fill]3"));
        pnContentMedia.setBackground(Color.WHITE);
        int c = 0;
            pnContentMedia.removeAll();
            for (pojo.GroupMessage mess: alMess) {
            if(mess.getType() == 1){
                c++;
                JPanel pnImage = new JPanel();
                pnImage.setBackground(Color.black);
                pnImage.setLayout(new GridLayout());
                PictureBox pic = new PictureBox();
                Icon img = new ImageIcon(mess.getDataFile().getFile());
                pnImage.addMouseListener(new MouseAdapter() {
                    public void mouseReleased(MouseEvent e) {
                        PublicEvent.getPublicEvent().getEventImageView().viewImage(mess.getDataFile());
                    }
                    });
                pic.setImage(img);
                pnImage.add(pic);
                addEvent(pic,mess.getDataFile());
                pnImage.setPreferredSize(new Dimension(100, 100));
                if(c==3){
                   pnContentMedia.add(pnImage,"wrap, w 100::100%/3"); 
                   c = 0;
                }
                else{
                    pnContentMedia.add(pnImage," w 100::100%/3");   
                    }
                }
            }
            sp.setViewportView(pnContentMedia);
    }
    public void loadFile(ArrayList<GroupMessage> alMess){
        fileInfo = new FileInfo();
        JPanel pnContentFile = new JPanel();
        pnContentFile.setBackground(Color.white);
        pnContentFile.setLayout(new MigLayout("fillx","10[]10","7[]7"));
        pnContentFile.removeAll();
 
        for(GroupMessage mess: alMess)
        {
            if(mess.getType() == 2){
                FileItem a = new FileItem();
                a.setInfo(fileInfo.setLogoFile(mess.getDataFile().getName()),fileInfo.setNameFile(mess.getDataFile().getName(),40), fileInfo.setSizeFile(mess.getDataFile().getFileSize()),mess.getDataFile());
                pnContentFile.add(a,"wrap, w 100%-20");  
            }
        }  
        sp.setViewportView(pnContentFile);
    }
    private void addEvent(Component com, DataFile dataFile){
        com.setCursor(new Cursor(Cursor.HAND_CURSOR));
        com.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if(SwingUtilities.isLeftMouseButton(e)){
                    PublicEvent.getPublicEvent().getEventImageView().viewImage(dataFile);
                }
            }
        });
    }
    private void orther(int idGroup){
        DefaultListModel<Setting_DTO> dlmOrther = new DefaultListModel<Setting_DTO>();
        JList<Setting_DTO> lOrther = new JList<Setting_DTO>();
        if(checkLDGroup(alMember) == SocketCommunication.user.getId()){
            dlmOrther.addElement(new Setting_DTO("", "", "Đổi tên nhóm"));
        }
//        dlmOrther.addElement(new Setting_DTO("", "", "Thêm thành viên"));
        dlmOrther.addElement(new Setting_DTO("", "", "Rời nhóm"));

        lOrther.setCellRenderer(new SettingRender());
        lOrther.setModel(dlmOrther);
        sp.setViewportView(lOrther);
        
        lOrther.addMouseListener(new MouseAdapter() {
        @Override
            public void mouseReleased(MouseEvent e) {
                if(lOrther.getSelectedIndex() == 1){
                    PublicEvent.getPublicEvent().getEventSendToServer().evendOutGroup(idGroup);
                }
                else
                    if(lOrther.getSelectedIndex() == 0){
                    new RenameGroup(null, true, idGroup).setVisible(true);
                }
            }
        });
    }
    private int checkLDGroup(ArrayList<GroupMember> alMember){
        for(GroupMember gm: alMember){
            if(gm.getId() == 0){
                return gm.getId_user();
            }
        }
        return 0;
    }
}
