package clinet.gui.menuleft.home_two;

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
import pojo.User_account;
/**
 *
 * @author Hùng Trần
 */
public class ListFriendRender extends JPanel implements ListCellRenderer<User_account>{
private JPanel pnAvatar, pnTxt, pnOnline, pnIsOnline;
    private JLabel lbAvatar, lbName, lbMessLast;
    private boolean isOnline;
    private ImageAvatar imageCircle;
    public ListFriendRender(){
       setLayout(new BorderLayout(0, 0));
       setBackground(Color.white);
        
       pnAvatar = new JPanel();
       pnAvatar.setOpaque(false);
       
       pnTxt = new JPanel();
       pnTxt.setOpaque(false);
       pnTxt.setPreferredSize(new Dimension(WIDTH, 60));
       pnTxt.setBorder(new EmptyBorder(25, 0, 25, 0));
       pnTxt.setLayout(new GridLayout(1, 1));
       
       imageCircle = new ImageAvatar();
       imageCircle.setPreferredSize(new Dimension(60, 60));
       imageCircle.setBorderColor(Color.WHITE);
       imageCircle.setBorderSize(4);
       
       lbName = new JLabel();
       lbName.setFont(new Font(null, Font.BOLD, 16));
       lbName.setPreferredSize(new Dimension(WIDTH, 60));
       
       pnTxt.add(lbName);
       pnAvatar.add(imageCircle);
       
        add(pnAvatar,BorderLayout.LINE_START);
        add(pnTxt,BorderLayout.CENTER);
    }
    @Override
    public Component getListCellRendererComponent(JList<? extends User_account> list, User_account val, int index, boolean isSelected, boolean cellHasFocus) {
        imageCircle.setImage(new ImageIcon(val.getDataFileAvatar().getFile()));
        lbName.setText(val.fullName());

        if(isSelected){
            setBackground(new Color(249,249,249));
        }
        else{
            setBackground(Color.white);
        }
        return this;
    }
}
