/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.center.group;

import clinet.dto.CheckListItem_DTO;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridLayout;
import static java.awt.image.ImageObserver.WIDTH;
import javax.swing.ImageIcon;
import javax.swing.JCheckBox;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.ListCellRenderer;
import javax.swing.border.EmptyBorder;
import lib.ImageAvatar;

/**
 *
 * @author Hùng Trần
 */
public class ListFriendCheckRender extends JPanel implements ListCellRenderer<CheckListItem_DTO> {
    private JPanel pnAvatar, pnTxt, pnOnline, pnIsOnline,pnCheck;
    private JLabel lbName, lbMessLast;
    private boolean isOnline;
    private ImageAvatar imageCircle;
    private JCheckBox checkBox;
    public ListFriendCheckRender(){
       setLayout(new BorderLayout(0, 0));
       setBackground(Color.white);
        
       pnAvatar = new JPanel();
       pnAvatar.setOpaque(false);
       pnAvatar.setLayout(new BorderLayout(0,0));
       pnAvatar.setPreferredSize(new Dimension(100, 70));
       
        pnTxt = new JPanel();
        pnTxt.setOpaque(false);
        pnTxt.setPreferredSize(new Dimension(WIDTH, 60));
        pnTxt.setBorder(new EmptyBorder(25, 10, 25, 0));
        pnTxt.setLayout(new GridLayout(1, 1));

        imageCircle = new ImageAvatar();
        imageCircle.setPreferredSize(new Dimension(40, 40));
        imageCircle.setBounds(0, 0, 40, 40);
        imageCircle.setBorderColor(Color.WHITE);
        imageCircle.setBorderSize(5);

        lbName = new JLabel();
        lbName.setFont(new Font(null, Font.BOLD, 16));
        lbName.setPreferredSize(new Dimension(WIDTH, 60));

        pnCheck = new JPanel();

        pnTxt.add(lbName);
        pnAvatar.add(imageCircle,BorderLayout.CENTER);
       
        add(pnAvatar,BorderLayout.LINE_START);
        add(pnTxt,BorderLayout.CENTER);
        checkBox = new JCheckBox();
        pnCheck.setOpaque(false);
        pnCheck.setBorder(new EmptyBorder(24, 0, 24, 0));
        
        pnCheck.add(checkBox);
        pnAvatar.add(pnCheck,BorderLayout.LINE_START);
    }

    @Override
    public Component getListCellRendererComponent(JList<? extends CheckListItem_DTO> list, CheckListItem_DTO val, int index, boolean isSelected, boolean cellHasFocus) {
        imageCircle.setImage(new ImageIcon(val.getUser().getDataFileAvatar().getFile()));
        lbName.setText(val.getUser().fullName());
        setEnabled(list.isEnabled());
        checkBox.setSelected(val.isSelected());
        if(isSelected){
            setBackground(new Color(249,249,249));
        }
        else{
            setBackground(Color.white);
        }
    return this;
    }
}
