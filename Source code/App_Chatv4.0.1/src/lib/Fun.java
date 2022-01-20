package lib;

import java.awt.Button;
import java.awt.Color;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.event.FocusEvent;
import java.awt.event.FocusListener;
import java.io.File;
import java.security.MessageDigest;
import java.util.ArrayList;
import java.util.Random;
import java.util.regex.Pattern;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.border.EmptyBorder;
import javax.xml.bind.DatatypeConverter;

/**
 *
 * @author Hùng Trần
 */
public class Fun {
 
    public Fun(){
         
    }

    public static boolean isEmail(String txtEmail){
        String t = "^[a-zA-Z][\\w-]+@([\\w]+\\.[\\w]+|[\\w]+\\.[\\w]{2,}\\.[\\w]{2,})$";
        return Pattern.matches(t,txtEmail);
    }
    public static void setButton(JButton btn, Color clBg, Color txt){
//        btn.setPreferredSize(new Dimension(150, 60));
        btn.setBackground(clBg);
        btn.setFont(new Font("Arial", Font.BOLD, 16));
        btn.setForeground(txt);
        btn.setBorder(new EmptyBorder(0,0,0,0));
        btn.setBorderPainted(false);
        btn.setCursor(new Cursor(Cursor.HAND_CURSOR) {
        });
    }
    public static void clickTextField(JTextField txtSearchChat,String content){
         txtSearchChat.addFocusListener(new FocusListener() {

             @Override
            public void focusGained(FocusEvent e) {
                if (txtSearchChat.getText().equals(content)) {
                    txtSearchChat.setText("");
                    txtSearchChat.setForeground(Color.BLACK);
                }
            }
            @Override
            public void focusLost(FocusEvent e) {
                if (txtSearchChat.getText().isEmpty()) {
                    txtSearchChat.setForeground(Color.GRAY);
                    txtSearchChat.setText(content);
                }
            }
        });
    }
    public static int checkFile(String fileName){
        int n = -1;
        if(fileName.endsWith(".mp3")){
            n = 4;
        }
        else if(fileName.endsWith(".jpg") || fileName.endsWith(".png") || fileName.endsWith(".grid")){
            n = 1;
        }
        else {
            n = 2;
        }
        return n;
    }
    public static String myHash(String password) {
       try {
           MessageDigest md = MessageDigest.getInstance("MD5");
           md.update(password.getBytes());
           byte[] digest = md.digest();
           String myHash = DatatypeConverter.printHexBinary(digest).toUpperCase();
           return myHash;
       } catch (Exception ex) {
           ex.printStackTrace();
       }
       return null;
    }
    public static int randomCode(){
        Random rd = new Random();
        return 100000+rd.nextInt(899999);
    }
}
