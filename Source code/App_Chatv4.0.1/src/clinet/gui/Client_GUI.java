package clinet.gui;

import lib.Fun;
import clinet.gui.component.LoadingFrame;
import clinet.gui.component.Home_GUI;
import clinet.gui.component.Login_GUI;
import clinet.gui.dialog.ForgotPassword;
import clinet.gui.dialog.ChangePassword;
import clinet.gui.component.Setting;
import clinet.gui.component.Sigin_GUI;
import clinet.gui.component.View_Image;
import clinet.gui.publicLoading.LoadHome;
import clinet.gui.publicLoading.PublicLoading;
import clinet.gui.publicevent.EventDisposeFrame;
import clinet.gui.publicevent.EventForgotPassword;
import clinet.gui.publicevent.EventImageView;
import clinet.gui.publicevent.EventViewModal;
import clinet.gui.publicevent.PublicEvent;
import clinet.gui.publicevent.ShowSetting;
import java.awt.CardLayout;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.image.ImageObserver;
import java.awt.image.ImageProducer;
import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.PrintWriter;
import java.net.Socket;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Date;
import java.util.Random;
import java.util.Timer;
import java.util.TimerTask;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JLayeredPane;
import javax.swing.JOptionPane;
import javax.swing.SwingUtilities;
import javax.xml.bind.DatatypeConverter;
import lib.sendMail;
import pojo.DataFile;
import pojo.User_account;
public class Client_GUI extends javax.swing.JFrame{
    private int idMe = 1;
    private Socket s;
    private PrintWriter out;
    private ObjectOutputStream oos;
    private CardLayout crdL;
    private Setting setting;
    private DataOutputStream dos;
    private Login_GUI login;
    private View_Image view_Image;
    private Sigin_GUI sigin;
    private JLayeredPane jLayeredPane1;
    private LoadingFrame loadingFrame;
    private pojo.User_account user;
    private SocketCommunication n;
    private Home_GUI home;
    private int codeForgotPassword, codeNewRegistration;
    private ForgotPassword forgotPass;
    private ChangePassword changePassword;

    public Client_GUI() {
            initComponents();
            runClient();
            crdL = new CardLayout();
            sigin = new Sigin_GUI();
            sigin.setVisible(false);
            login = new Login_GUI();
            
            jLayeredPane1 = new JLayeredPane();
            this.getContentPane().add(jLayeredPane1);
            
            jLayeredPane1.setLayout(crdL);
            jLayeredPane1.add(login,"login");
            jLayeredPane1.setLayer(login, javax.swing.JLayeredPane.DEFAULT_LAYER);
            crdL.show(jLayeredPane1, "login");
            
            jLayeredPane1.add(sigin,"sigin");
            jLayeredPane1.setLayer(sigin, javax.swing.JLayeredPane.DEFAULT_LAYER);
            
            loadingFrame = new LoadingFrame();
            jLayeredPane1.add(loadingFrame, "loadingFrame");
            jLayeredPane1.setLayer(loadingFrame, javax.swing.JLayeredPane.POPUP_LAYER);
            loadingFrame.setVisible(false);
            
            guiLogin();
            initEvent();
            
            PublicEvent.getPublicEvent().setEventForgotPassword(new EventForgotPassword() {

                @Override
                public void eventForgotPassword(String username, String email) {
                    Vector<Object> vt = forgotPassword(username, email);
                    String message;
                    message = (String) vt.get(0);
                    if(message.contains("Email successful_")){
                        int id = Integer.parseInt(message.substring(message.indexOf("_")+1, message.length()));
                        codeForgotPassword = Fun.randomCode();
                        String txt  = "Đây là mã dùng để lấy lại mật khẩu của schatz. Mã của bạn là: "+codeForgotPassword;
                        sendMail sendmail = new sendMail(email, "SchatZ", txt);
                        
                        checkCode(codeForgotPassword, id);
                    }
                    else if(message.equals("Email does not exist")){
                        JOptionPane.showMessageDialog(null, "Email của bạn không chính xác");return;
                        
                    }
                    else if(message.equals("Account does not exist (email)")){
                        JOptionPane.showMessageDialog(null, "Tài khoản của bạn không chính xác");return;
                    }
                }
                @Override
                public void eventChangePassword(int id, String pasword) {
                    
                    Vector<Object> vt = changePassword(id, pasword);
                    String message;
                    message = (String) vt.get(0);
                    if(message.equals("Pass successful")){
                        JOptionPane.showMessageDialog(null, "Đổi mật khẩu thành công");
                        changePassword.dispose();
                    }
                    else{
                        JOptionPane.showMessageDialog(null, "Có lỗi xảy ra vui lòng thử lại");return;
                    }
                }
            });
            sigin.getBtnSignIn().addActionListener((ActionEvent e) -> {
                sigin();
            });
    }
        
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().setLayout(new java.awt.GridLayout(1, 0));

        pack();
    }// </editor-fold>//GEN-END:initComponents
    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Client_GUI().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables
    private void runClient() {
        Dimension screen = Toolkit.getDefaultToolkit().getScreenSize();
        this.setTitle("SchatZ");
        this.setIconImage(new ImageIcon("./src/data/assets/icons/icon/logo/icon.png").getImage());
        int w = screen.width - 100;
        int h = screen.height - 100;
        this.setSize(new Dimension(w, h));
        this.setLocationRelativeTo(null);
        this.setDefaultCloseOperation(DISPOSE_ON_CLOSE);
    }
    private void guiLogin(){
        this.setSize(new Dimension(1200,700));
        this.setLocationRelativeTo(null);
    }
    private void disposeF(){
            home.invalidate();
            home.validate();
            home.repaint();
            dispose();
            new Client_GUI().setVisible(true);
        }
    private void initEvent(){
        PublicEvent.getPublicEvent().addEventImageView((DataFile dataFile) -> {
            view_Image.setDataFile(dataFile);
        });
        PublicEvent.getPublicEvent().addShowSetting(() -> {setting.setVisible(true);});
            login.getBtnDangNhap().addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    if(login.getTxtUsername().getText().equals("") || String.valueOf(login.getTxtPassword().getPassword()).equals("")) return;
                    else{
                        Vector<Object> a = Login();
                        String message;
                        message = (String) a.get(0);

                        if(message.equals("Account does not exist")){
                            JOptionPane.showMessageDialog(null, "Tài khoản không tồn tại!");
                            login.getTxtUsername().selectAll();
                            login.getTxtUsername().requestFocus();
                            login.getTxtPassword().setText("");
                            return;
                        }
                        else if(message.equals("Incorrect password")){
                            JOptionPane.showMessageDialog(null, "Mật khẩu không chính xác!");
                            login.getTxtPassword().selectAll();
                            login.getTxtPassword().requestFocus();
                            return;
                        }
                        else{
                            login.getTxtUsername().setText("");
                            login.getTxtPassword().setText("");
                            login.setVisible(false);
                            n = new SocketCommunication();
                            n.setS(s);
                            new Thread(n).start();
                            return;
                        }
                    }
                }
            });
            login.getBtnSigIn().addActionListener(((e) -> {
                crdL.show(jLayeredPane1, "sigin");
                sigin.setVisible(true);
            }));
            sigin.getBtnBackLogin().addActionListener(((e) -> {
                sigin.setVisible(false);
                crdL.show(jLayeredPane1, "login");
                login.setVisible(true);
            }));
            login.getBtnForgotPassword().addActionListener((ActionEvent e) -> {
                forgotPass = new ForgotPassword(this, true);
                forgotPass.setVisible(true);
            });
            PublicEvent.getPublicEvent().setEventDisposeFrame(this::disposeF);
            PublicLoading.getPublicLoading().setLoadHome(() -> {
                home = new Home_GUI();
                jLayeredPane1.add(home, "cardHome");
                jLayeredPane1.setLayer(home, JLayeredPane.DEFAULT_LAYER);
                crdL.show(jLayeredPane1, "cardHome");
                home.setVisible(true);

                Dimension ds = Toolkit.getDefaultToolkit().getScreenSize();
                setSize(ds.width - 100, ds.height - 100);
                setLocationRelativeTo(null);

                view_Image = new View_Image();
                jLayeredPane1.add(view_Image, "view_image");
                jLayeredPane1.setLayer(view_Image, javax.swing.JLayeredPane.POPUP_LAYER);
                view_Image.setVisible(false);

                setting = new Setting();
                jLayeredPane1.add(setting, "setting");
                jLayeredPane1.setLayer(setting, javax.swing.JLayeredPane.POPUP_LAYER);
                setting.setVisible(false);

            });
            this.addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent e) {
                    if(home != null) PublicEvent.getPublicEvent().getEventSendToServer().eventLogout();
                    System.exit(0);
                }
            });
        }
    private void Connect() {
        try {
            if (s != null) {
                s.close();
            }
            s = new Socket("localhost", 1602);
            oos = new ObjectOutputStream(s.getOutputStream());
            } catch (IOException ex) {
                int tl = JOptionPane.showConfirmDialog(null, "Server đang bảo trì.\n" + ex, "SchatZ", JOptionPane.CANCEL_OPTION,JOptionPane.WARNING_MESSAGE);
                if(tl == JOptionPane.CANCEL_OPTION || tl == JOptionPane.OK_OPTION){
                    System.exit(0);
                }
            }
	}
    private void sigin(){
        
        String surname = sigin.getTxtSurname().getText();
        String name = sigin.getTxtName().getText();
        String username = sigin.getTxtUsername().getText();
        String pass1 = String.valueOf(sigin.getTxtPass1().getPassword());
        String pass2 = String.valueOf(sigin.getTxtPass2().getPassword());
        String email = sigin.getTxtEmail().getText();
    
        int sex = 1;    
        if(sigin.getRdoKhac().isSelected()) sex = 2;
        else if(sigin.getRdoNam().isSelected()) sex = 0;
      
        if( isEmty(username)|| isEmty(surname)|| isEmty(name)|| isEmty(email)|| isEmty(pass1)|| isEmty(pass2)|| (sex < 0)){
            JOptionPane.showMessageDialog(null, "Không được để trống");
        }else {
            if(pass1.equals(pass2)){
                if(Fun.isEmail(sigin.getTxtEmail().getText())){
           
                    User_account userSigin = new User_account(1);
                        userSigin.setSurname(surname);
                        userSigin.setName(name);
                        userSigin.setUsername(username);
                        userSigin.setEmail(email);
                        userSigin.setPassword(Fun.myHash(pass1));
                        userSigin.setSex(sex);
                        
                        Vector vt = checkUsername(username);
                        String message = (String) vt.get(0);
                        
                        if(message.equals("Username does not exist")){
                            
                            codeNewRegistration = Fun.randomCode();
                            
                            String txt  = "Đây là mã dùng để đăng ký tài khoản schatz. Mã của bạn là: "+codeNewRegistration;
                            new sendMail(email, "SchatZ", txt);
                            if(checkCode(codeNewRegistration, -1)){
                                try {
                                    Connect();
                                    oos.writeUTF("Regist");
                                    oos.writeObject(userSigin);
                                    oos.flush();
                                    
                                    ObjectInputStream ois = new ObjectInputStream(s.getInputStream());
                                    String result = ois.readUTF();
                                    
                                    if(result.equals("Regist success")) 
                                        JOptionPane.showMessageDialog(null, "Đăng ký thành công");
                                    else
                                        JOptionPane.showMessageDialog(null, "Đăng ký không thành công vui lòng thử lại");
                    
                                } catch (IOException ex) {
                                    Logger.getLogger(Client_GUI.class.getName()).log(Level.SEVERE, null, ex);
                                }
                            }
                        }
                        else{
                            JOptionPane.showMessageDialog(null, "Tên đăng nhập đã tồn tại");
                        }
                }
                else JOptionPane.showMessageDialog(null, "Định dạng email không chính xác");
            }
            else  JOptionPane.showMessageDialog(null, "Mật khẩu không trùng khớp");  
        }
    }
    private Vector<Object> Login() {
        Vector<Object> a = new Vector<Object>();
            try {
                Connect();
                oos.writeUTF("login");
                oos.writeUTF(login.getTxtUsername().getText());
                oos.writeUTF(Fun.myHash(String.valueOf(login.getTxtPassword().getPassword())));
                oos.flush();
                try {
                    ObjectInputStream ois = new ObjectInputStream(s.getInputStream());
                    a.add((String)ois.readUTF());
                } catch (IOException ex) {
                    Logger.getLogger(Client_GUI.class.getName()).log(Level.SEVERE, null, ex);
                }
            } catch (IOException ex) {
                Logger.getLogger(Client_GUI.class.getName()).log(Level.SEVERE, null, ex);
            }
        return a;
    }
    private Vector<Object> changePassword(int id, String password) {
        Vector<Object> a = new Vector<Object>();
            try {
                Connect();
                oos.writeUTF("Change Password");
                oos.writeInt(id);
                oos.writeUTF(Fun.myHash(password));
                oos.flush();
                try {
                    ObjectInputStream ois = new ObjectInputStream(s.getInputStream());
                    a.add((String)ois.readUTF());
                } catch (IOException ex) {
                    Logger.getLogger(Client_GUI.class.getName()).log(Level.SEVERE, null, ex);
                }
            } catch (IOException ex) {
                Logger.getLogger(Client_GUI.class.getName()).log(Level.SEVERE, null, ex);
            }
        return a;
    }
    private Vector<Object> forgotPassword(String username, String email) {
        Vector<Object> a = new Vector<Object>();
            try {
                Connect();
                oos.writeUTF("Forgot password");
                oos.writeUTF(username);
                oos.writeUTF(email);
                oos.flush();
                try {
                    ObjectInputStream ois = new ObjectInputStream(s.getInputStream());
                    a.add((String)ois.readUTF());
                } catch (IOException ex) {
                    Logger.getLogger(Client_GUI.class.getName()).log(Level.SEVERE, null, ex);
                }
            } catch (IOException ex) {
                Logger.getLogger(Client_GUI.class.getName()).log(Level.SEVERE, null, ex);
            }
        return a;
    }
    private Vector<Object> checkUsername(String username) {
        Vector<Object> a = new Vector<Object>();
            try {
                Connect();
                oos.writeUTF("Check username");
                oos.writeUTF(username);
                oos.flush();
                    ObjectInputStream ois = new ObjectInputStream(s.getInputStream());
                    a.add((String)ois.readUTF());
            } catch (Exception ex) {
                ex.printStackTrace();
            }
        return a;
    }
    private boolean isEmty(String txt){
        if(txt.trim().equals("")) return true;
        return false;
    }
    private boolean checkCode(int code, int id){
        String n = JOptionPane.showInputDialog(null, "Nhập mã của bạn: ");
        if (n == null) {
            return false;
        }
        else{
            try {
            if(code == Integer.parseInt(n)){
                if(id > 0 ){
                    forgotPass.dispose();
                    changePassword = new ChangePassword(this, true, id);
                    changePassword.setVisible(true);
                    return true;
                }
                else{
                    
                    return true;
                }
                     
            }else{
                JOptionPane.showMessageDialog(null, "Mã của bạn nhập không đúng. Nhâp lại mã"); 
                checkCode(code, id);
            }
            } catch (Exception e) {
                JOptionPane.showMessageDialog(null, "Bạn phải nhập số");
                checkCode(code, id);
            }
            return false;
        }
    }
}
