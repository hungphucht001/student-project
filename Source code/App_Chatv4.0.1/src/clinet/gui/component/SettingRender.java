/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.component;

import clinet.dto.Setting_DTO;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.Font;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.ListCellRenderer;
import javax.swing.border.EmptyBorder;

/**
 *
 * @author Hùng Trần
 */
public class SettingRender extends JPanel implements ListCellRenderer<Setting_DTO>{
    private JLabel lbIcon1, lbIcon2, lbName;
    public SettingRender(){
        setBorder(new EmptyBorder(5, 0, 5, 0));
        setBackground(Color.white);
        setLayout(new BorderLayout(0,0));
        
        lbIcon1 = new JLabel();
        lbIcon1.setPreferredSize(new Dimension(50, 50));
        lbIcon1.setBounds(0, 0, 50, 50);
        lbIcon1.setVerticalAlignment(JLabel.CENTER);
        lbIcon1.setHorizontalAlignment(JLabel.CENTER);
        
        lbIcon2 = new JLabel();
        lbIcon2.setPreferredSize(new Dimension(50, 50));
        lbIcon2.setBounds(0, 0, 50, 50);
        lbIcon2.setVerticalAlignment(JLabel.CENTER);
        lbIcon2.setHorizontalAlignment(JLabel.CENTER);
        
        lbName = new JLabel();
        lbName.setPreferredSize(new Dimension(50, 50));
        lbName.setFont(new Font(null,WIDTH , 16));
        
    }
    @Override
    public Component getListCellRendererComponent(JList<? extends Setting_DTO> list, Setting_DTO value, int index, boolean isSelected, boolean cellHasFocus) {
        lbIcon1.setIcon(new ImageIcon(value.getIcon1()));
        lbIcon2.setIcon(new ImageIcon(value.getIcon2()));
        lbName.setText(value.getName());
        
        if(!value.getIcon1().equals("")){
             add(lbIcon1,BorderLayout.LINE_START);
        }
        else {
            lbName.setBorder(new EmptyBorder(0, 10, 0, 0));
        }
        if(!value.getIcon2().equals("")){
             add(lbIcon2,BorderLayout.LINE_END);
        }
        
        add(lbName,BorderLayout.CENTER);
        
        if(isSelected){
            setBackground(new Color(249,249,249));
        }
        else{
            setBackground(Color.WHITE);
        }
        return this;
    }
}
