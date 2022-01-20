package gui;

import dao.Group_DAO;
import dao.User_DAO;
import static dao.User_DAO.insertUser;
import fun.Function;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.security.MessageDigest;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Random;
import java.util.Set;
import java.util.Timer;
import java.util.TimerTask;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.bind.DatatypeConverter;
import pojo.User_account;
/**
 *
 * @author Hùng Trần
 */
public class Server extends javax.swing.JFrame {
    private static final int DEFAULT_PORT = 1602;
    private ServerSocket serverSocket;
    private ObjectOutputStream oos;
    private String message = null;
    private ObjectInputStream ois;
    public static HashMap<Integer,Handler> hmUser;
    public static HashMap<Integer,pojo.Group> hmGroup;
    public Server() {
        initComponents();
        hmUser = User_DAO.hmUser();
        hmGroup = Group_DAO.hmGroup();
        this.setSize(1300, 900);
        txt.append("\n******************************WELCOME******************************\n\n");        
        txt.append("****************************Server is ready****************************\n");
    }
    private void createServer(){
        try {
            serverSocket = new ServerSocket(DEFAULT_PORT);
            Date date = new Date();
            txt.append("\n[ "+date+" ]: Server is run with port: "+DEFAULT_PORT);
                 Thread t = new Thread(new Runnable() {
                     @Override
                     public void run() {
                        while (true) {  
                            try {
                                Socket s = serverSocket.accept();
                                oos = new ObjectOutputStream(s.getOutputStream());
                                ois = new ObjectInputStream(s.getInputStream());
                                new Thread(new Runnable() {
                                    @Override
                                    public void run() {
                                        try {
                                            if((message = ois.readUTF())!= null){
                                                if(message.equals("login")){
                                                    String username = ois.readUTF();
                                                    String password = ois.readUTF ();
                                                    login(username, password, s);
                                                }
                                                else if(message.equals("Forgot password")){
                                                    String username = ois.readUTF();
                                                    String email = ois.readUTF();
                                                    forgotPassword(username, email);
                                                }
                                                else if(message.equals("Change Password")){
                                                    int id = ois.readInt();
                                                    String pass = ois.readUTF();
                                                    changePassword(id, pass);
                                                }
                                                else if(message.equals("Check username")){
                                                    checkUsername();
                                                }
                                                else if(message.equals("Regist")){
                                                    regist();
                                                }
                                            }
                                        } catch (Exception ex) {
                                        }
                                    }
                                }).start();
                            } catch (Exception e) {
                                txt.append("\nError: "+e);
                            }
                        }
                    }
                });
                t.start();     
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    public static void loadListChat(int id){
        Set<Integer> keySet = hmUser.keySet();
        for (Integer key : keySet) {
            if(key != id && hmUser.get(key).getUser().getStatus() == 1){
                try {
                    hmUser.get(key).getOos().writeUTF("loadListChat");
                    hmUser.get(key).getOos().writeObject(User_DAO.listChat(key));
                    hmUser.get(key).getOos().flush();
                } catch (IOException ex) {
                    Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
    }
    private void regist() {
        try {
            User_account user = (User_account) ois.readObject();
            Function fun = new Function();
            user.setPathBackground(fun.randomPathBackgound());
            int n = insertUser(user);
            if(n > 0){
                user = User_DAO.selectUser(user.getUsername());
                hmUser.put(user.getId(), new Handler(user));
                flush("Regist success");
            }
            else 
                flush("Regist error");
            
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    private void checkUsername() {
        try {
            String username = ois.readUTF();
            int result = User_DAO.checkUsername(username);
            if(result == -1) flush("Username does not exist");
            else flush("Username exists");
        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public void login(String username, String password, Socket s){
          try {
            int result = User_DAO.checkUsername(username);
            if(result > 0){
                User_account u = hmUser.get(result).getUser();
                if(u.getPassword().equals(password)){
                    txt.append("\n\n\n******************************----++*++----******************************\n");
                    txt.append("\n\n[ "+new Date()+" ] [User: "+username +"]: online\n");
                    Handler han = hmUser.get(result);
                    han.setS(s);        
                    han.getUser().setStatus(1);
                    User_DAO.updateOnline(1, result);
                    //Tạo luồng xử lý cho mỗi client khi đăng nhập thành công
                    Thread t = new Thread(han);
                    t.start();
                    flush("successful");
                    loadListChat(result);
                }
                else{
                    flush("Incorrect password");
                }
            }
            else{
                flush("Account does not exist");
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    public void forgotPassword(String username, String email){
        
        int result = User_DAO.checkUsername(username);
        if(result > 0){
            int id = User_DAO.checkEmail(username, email);
            if(id > 0) flush("Email successful_"+id);
            else flush("Email does not exist");
        }else flush("Account does not exist (email)");
    }
    public void changePassword(int id, String pass){
        if(User_DAO.updatePassword(id,pass) > 0)
        {
            hmUser.get(id).getUser().setPassword(pass);
            flush("Pass successful");
        }
        else 
            flush("An error occurred");  
    }
    private void flush(String str){
        try {
            oos.writeUTF(str);
            oos.flush();
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel2 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        jTextField2 = new javax.swing.JTextField();
        jPanel3 = new javax.swing.JPanel();
        jPanel5 = new javax.swing.JPanel();
        jButton1 = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        jPanel4 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        txt = new javax.swing.JTextArea();
        jPanel6 = new javax.swing.JPanel();
        jPanel7 = new javax.swing.JPanel();
        jButton2 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setBackground(new java.awt.Color(255, 255, 255));

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));
        jPanel2.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jPanel2.setPreferredSize(new java.awt.Dimension(919, 100));
        jPanel2.setLayout(new java.awt.BorderLayout());

        jLabel1.setBackground(new java.awt.Color(255, 255, 255));
        jLabel1.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N
        jLabel1.setText("SERVER SCHATZ");
        jPanel2.add(jLabel1, java.awt.BorderLayout.CENTER);

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setPreferredSize(new java.awt.Dimension(215, 80));

        jLabel3.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N
        jLabel3.setText("PORT:");

        jTextField2.setEditable(false);
        jTextField2.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N
        jTextField2.setText("1602");
        jTextField2.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addComponent(jLabel3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jTextField2, javax.swing.GroupLayout.DEFAULT_SIZE, 96, Short.MAX_VALUE)
                .addGap(0, 0, 0))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jLabel3, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jTextField2, javax.swing.GroupLayout.DEFAULT_SIZE, 79, Short.MAX_VALUE))
                .addGap(23, 23, 23))
        );

        jPanel2.add(jPanel1, java.awt.BorderLayout.LINE_END);

        getContentPane().add(jPanel2, java.awt.BorderLayout.PAGE_START);

        jPanel3.setBackground(new java.awt.Color(255, 255, 255));
        jPanel3.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jPanel3.setPreferredSize(new java.awt.Dimension(919, 100));
        jPanel3.setLayout(new java.awt.BorderLayout());

        jPanel5.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jPanel5.setOpaque(false);
        jPanel5.setPreferredSize(new java.awt.Dimension(300, 100));
        jPanel5.setLayout(new java.awt.GridLayout(1, 0));

        jButton1.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N
        jButton1.setText("Start Server");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        jPanel5.add(jButton1);

        jPanel3.add(jPanel5, java.awt.BorderLayout.LINE_END);

        jLabel2.setBackground(new java.awt.Color(255, 255, 255));
        jLabel2.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N
        jLabel2.setText("SERVER SCHATZ");
        jPanel3.add(jLabel2, java.awt.BorderLayout.CENTER);

        getContentPane().add(jPanel3, java.awt.BorderLayout.PAGE_END);

        jPanel4.setBackground(new java.awt.Color(255, 255, 255));
        jPanel4.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 10, 10, 10));
        jPanel4.setMinimumSize(new java.awt.Dimension(47, 507));
        jPanel4.setPreferredSize(new java.awt.Dimension(286, 507));
        jPanel4.setRequestFocusEnabled(false);
        jPanel4.setLayout(new java.awt.GridLayout(1, 0));

        txt.setEditable(false);
        txt.setBackground(new java.awt.Color(0, 0, 0));
        txt.setColumns(20);
        txt.setFont(new java.awt.Font("Arial", 0, 16)); // NOI18N
        txt.setForeground(new java.awt.Color(51, 204, 0));
        txt.setRows(5);
        jScrollPane1.setViewportView(txt);

        jPanel4.add(jScrollPane1);

        getContentPane().add(jPanel4, java.awt.BorderLayout.CENTER);

        jPanel6.setBackground(new java.awt.Color(255, 255, 255));
        jPanel6.setBorder(javax.swing.BorderFactory.createEmptyBorder(10, 0, 10, 10));
        jPanel6.setPreferredSize(new java.awt.Dimension(150, 605));
        jPanel6.setLayout(new java.awt.GridLayout(1, 0));

        jPanel7.setLayout(new javax.swing.BoxLayout(jPanel7, javax.swing.BoxLayout.Y_AXIS));

        jButton2.setText("Gửi thông báo");
        jButton2.setMaximumSize(new java.awt.Dimension(23233, 25));
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        jPanel7.add(jButton2);

        jPanel6.add(jPanel7);

        getContentPane().add(jPanel6, java.awt.BorderLayout.LINE_END);

        pack();
    }// </editor-fold>//GEN-END:initComponents
    private int randomCode(){
        Random rd = new Random();
        return 100000+rd.nextInt(899999);
    }
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        jButton1.setEnabled(false);
        createServer();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
       new Notification(null, true).setVisible(true);
    }//GEN-LAST:event_jButton2ActionPerformed
    public static void main(String args[]) {
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Server.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Server.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Server.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Server.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Server().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel7;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField jTextField2;
    public static javax.swing.JTextArea txt;
    // End of variables declaration//GEN-END:variables
}