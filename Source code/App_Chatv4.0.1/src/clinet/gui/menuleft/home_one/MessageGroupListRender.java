package clinet.gui.menuleft.home_one;

import clinet.gui.SocketCommunication;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridLayout;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.ListCellRenderer;
import javax.swing.border.EmptyBorder;
import lib.ImageAvatar;
import pojo.ListChatGroup;

/**
 *
 * @author Hùng Trần
 */
public class MessageGroupListRender extends JPanel implements ListCellRenderer<ListChatGroup>{
    private JPanel pnAvatar, pnTxt;
    private JLabel lbAvatar, lbName, lbMessLast;
    private ImageAvatar imageCircle;
    public MessageGroupListRender(){
       setLayout(new BorderLayout(0, 0));
       setBackground(Color.white);
       setBorder(new EmptyBorder(0, 0, 0, 10));
        
       pnAvatar = new JPanel();
//       pnAvatar.setPreferredSize(new Dimension(60, 60));
       pnAvatar.setOpaque(false);
       
       pnTxt = new JPanel();
       pnTxt.setOpaque(false);
       pnTxt.setBorder(new EmptyBorder(10, 10, 7, 0));
       pnTxt.setLayout(new GridLayout(2, 1));    
       
       imageCircle = new ImageAvatar();
       imageCircle.setPreferredSize(new Dimension(60, 60));
       imageCircle.setBorderColor(Color.WHITE);
       imageCircle.setBorderSize(4);
       
       lbName = new JLabel();
       lbName.setFont(new Font(null, Font.BOLD, 16));
       
       lbMessLast = new JLabel();
       lbMessLast.setFont(new Font(null, Font.PLAIN, 15));
       lbMessLast.setForeground(Color.DARK_GRAY);
       
       pnTxt.add(lbName);
       pnTxt.add(lbMessLast);
       
       pnAvatar.add(imageCircle);
       
        add(pnAvatar,BorderLayout.LINE_START);
        add(pnTxt,BorderLayout.CENTER);
    }
    @Override
    public Component getListCellRendererComponent(JList<? extends ListChatGroup> list, ListChatGroup val, int index, boolean isSelected, boolean cellHasFocus) {
        imageCircle.setImage(new ImageIcon(val.getGroup().getDataFileAvatar().getFile()));
        
        lbName.setText(val.getGroup().getName());
        
        if(SocketCommunication.user.getId() == val.getGroupMessage().getId_send())
        {
            if(val.getGroupMessage().getType() == 0){
                lbMessLast.setText("Bạn: "+val.getGroupMessage().getContent());
            }
            else if(val.getGroupMessage().getType() == 1){
                lbMessLast.setText("Bạn đã gửi một hình ảnh");
            }
            else if(val.getGroupMessage().getType() == 2){
                lbMessLast.setText("Bạn đã gửi một file");
            }
            else if(val.getGroupMessage().getType() == 3){
                lbMessLast.setText("Bạn đã gửi nhãn dán");
            }
        }
        else {
            if(val.getGroupMessage().getType() == 0){
                lbMessLast.setText(val.getGroupMessage().getContent());
            }
            else if(val.getGroupMessage().getType() == 1){
                lbMessLast.setText("Hình ảnh");
            }
            else if(val.getGroupMessage().getType() == 2){
                lbMessLast.setText("File");
            }
            else if(val.getGroupMessage().getType() == 3){
                lbMessLast.setText("Nhãn dán");
            }
        }
        
        if(isSelected){
            setBackground(new Color(249,249,249));
        }
        else{
            setBackground(Color.white);
        }
        return this;
    }
}