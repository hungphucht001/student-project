package clinet.gui.menuleft.home_three;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import javax.swing.BoxLayout;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.ListCellRenderer;
import javax.swing.border.EmptyBorder;
import javax.swing.border.MatteBorder;
import lib.DateTimeFormat;
import pojo.Notifications;

/**
 *
 * @author Hùng Trần
 */
public class NotificationRender extends JPanel implements ListCellRenderer<Notifications>{
    private JLabel date,time,title,content,avatar;
    public NotificationRender(){
        setBackground(Color.white);
        setLayout(new BorderLayout(0, 0));
        setPreferredSize(new Dimension(WIDTH, 90));
        
        date = new JLabel();
        time = new JLabel();
        title = new JLabel();
        content = new JLabel();
        avatar = new JLabel();
        
        title.setFont(new Font(null, Font.BOLD, 16));
        content.setFont(new Font(null, Font.PLAIN, 14));
        
        JPanel pnDate = new JPanel();
        JPanel pnTime = new JPanel();
        JPanel pnTitle = new JPanel();
        JPanel pnText = new JPanel();
        JPanel pnContent = new JPanel();
        JPanel pnAvatar = new JPanel();
        
        pnDate.add(date);
        pnDate.setOpaque(true);
        pnDate.setBackground(Color.white);
        pnDate.setLayout(new FlowLayout(FlowLayout.LEFT));
        pnDate.setBorder(new EmptyBorder(0, 10, 0, 0));
        
        pnAvatar.add(avatar);
        pnAvatar.setOpaque(false);
        pnAvatar.setLayout(new GridLayout(1, 1));
        pnAvatar.setPreferredSize(new Dimension(80, 70));
        pnAvatar.setBorder(new EmptyBorder(0, 10, 0, 0));
        avatar.setVerticalAlignment(JLabel.CENTER);
        avatar.setHorizontalAlignment(JLabel.CENTER);
        avatar.setText("G");
        avatar.setFont(new Font(null , Font.BOLD, 25));
        
        pnText.setLayout(new BoxLayout(pnText, BoxLayout.Y_AXIS));
        pnText.setPreferredSize(new Dimension(WIDTH, 70));
        setBorder(new MatteBorder(0, 0, 1, 0, new Color(208,208,208)));
        pnTitle.add(title);
        pnTitle.setLayout(new FlowLayout(FlowLayout.LEFT));
        pnTitle.setOpaque(false);
        
        pnContent.setLayout(new FlowLayout(FlowLayout.LEFT));
        pnContent.setBorder(new EmptyBorder(0, 0, 10, 0));
        pnContent.add(content);
        pnContent.setOpaque(false);
        pnText.add(pnTitle);
        pnText.setOpaque(false);
        pnText.add(pnContent);
        
        pnTime.add(time);
        pnTime.setLayout(new GridLayout(1, 1));
        pnTime.setOpaque(false);
        pnTime.setBorder(new EmptyBorder(0, 0, 0, 10));
        
        add(pnAvatar,BorderLayout.LINE_START);
        add(pnText,BorderLayout.CENTER);
        add(pnTime,BorderLayout.LINE_END);
        add(pnDate,BorderLayout.PAGE_START);
    }
    @Override
    public Component getListCellRendererComponent(JList<? extends Notifications> list, Notifications val, int index, boolean isSelected, boolean cellHasFocus) {
        DateTimeFormat dateTimeFormat = new DateTimeFormat();
        date.setText(dateTimeFormat.getDateInDateTime(val.getDatetime()));
        time.setText(dateTimeFormat.getTimeInDateTime(val.getDatetime()));
        title.setText(val.getTitle());
        content.setText(val.getContent());
        
        if(isSelected){
            setBackground(new Color(208,208,208));
        }
        else setBackground(Color.white);
    return this;
    }
}
