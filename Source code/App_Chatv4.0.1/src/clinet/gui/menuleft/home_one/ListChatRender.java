/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.menuleft.home_one;

import clinet.gui.SocketCommunication;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.ListCellRenderer;
import javax.swing.border.EmptyBorder;
import lib.DateTimeFormat;
import lib.ImageAvatar;

/**
 *
 * @author Hùng Trần
 */
public class ListChatRender extends JPanel implements ListCellRenderer<pojo.ListChatPeople>{
    private JPanel pnAvatar, pnTxt, pnOnline, pnIsOnline;
    private JLabel lbName, lbMessLast;
    private boolean isOnline;
    private ImageAvatar imageCircle;
    DateTimeFormat dtf = new DateTimeFormat();
    public ListChatRender(){
        setLayout(new BorderLayout(0, 0));
        setBackground(Color.white);
        setBorder(new EmptyBorder(0, 0, 0, 10));

        pnAvatar = new JPanel();
        pnAvatar.setPreferredSize(new Dimension(60, 60));
        pnAvatar.setOpaque(false);
        pnAvatar.setBorder(new EmptyBorder(0, WIDTH, WIDTH, WIDTH));
        
        pnTxt = new JPanel();
        pnTxt.setOpaque(false);
        pnTxt.setBorder(new EmptyBorder(10, 10, 7, 0));
        pnTxt.setLayout(new GridLayout(2, 1));

        pnOnline = new JPanel();
        pnOnline.setLayout(new FlowLayout(FlowLayout.CENTER));
        pnOnline.setBorder(new EmptyBorder(25, 0, 25, 0));
        pnOnline.setOpaque(false);

        pnIsOnline = new JPanel();
        pnIsOnline.setPreferredSize(new Dimension(10, 10));

        pnOnline.add(pnIsOnline);
       
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
        add(pnOnline,BorderLayout.LINE_END);
        setCursor(new Cursor(Cursor.HAND_CURSOR));
    }
    @Override
    public Component getListCellRendererComponent(JList<? extends pojo.ListChatPeople> list, pojo.ListChatPeople val, int index, boolean isSelected, boolean cellHasFocus) {
        imageCircle.setImage(new ImageIcon(val.getUser().getDataFileAvatar().getFile()));
        lbName.setText(val.getUser().fullName());
        
        setToolTipText(dtf.getDateInDateTime(val.getMessage().getDateofsend()));
        
        String lassMess = val.getMessage().getContent();

        if(lassMess.length()>24){
            lassMess = lassMess.substring(0,24)+"...";
        }
        if(SocketCommunication.user.getId() == val.getMessage().getId_send())
        {
            if(val.getMessage().getType() == 0){
                lbMessLast.setText("Bạn: "+lassMess);
            }
            else if(val.getMessage().getType() == 1){
                lbMessLast.setText("Bạn đã gửi một hình ảnh");
            }
            else if(val.getMessage().getType() == 2){
                lbMessLast.setText("Bạn đã gửi một file");
            }
            else if(val.getMessage().getType() == 3){
                lbMessLast.setText("Bạn đã gửi nhãn dán");
            }
        }
        else {
            if(val.getMessage().getType() == 0){
                lbMessLast.setText(lassMess);
            }
            else if(val.getMessage().getType() == 1){
                lbMessLast.setText("Hình ảnh");
            }
            else if(val.getMessage().getType() == 2){
                lbMessLast.setText("File");
            }
            else if(val.getMessage().getType() == 3){
                lbMessLast.setText("Nhãn dán");
            }
        }
        if(val.getUser().getStatus()== 1){
            pnIsOnline.setBackground(Color.GREEN);
        }
        else pnIsOnline.setBackground(Color.GRAY);
        
        if(isSelected){
            setBackground(new Color(249,249,249));
        }
        else{
            setBackground(Color.white);
        }
        return this;
    }
}
