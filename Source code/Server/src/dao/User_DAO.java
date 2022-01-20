/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import gui.Handler;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import pojo.ListChatPeople;
import pojo.Message;
import pojo.PeopelMessage;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */
public class User_DAO {
    public static HashMap<Integer,Handler> hmUser(){
        HashMap<Integer,Handler> hmUser = new HashMap();
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "SELECT * FROM USER_ACCOUNT";
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                pojo.User_account user = new User_account(
                        rs.getInt("ID"),
                        rs.getInt("SEX"), 
                        rs.getInt("STATUS"), 
                        rs.getString("NAME"), 
                        rs.getString("SURNAME"),
                        rs.getString("USERNAME"), 
                        rs.getString("PASSWORD"),
                        rs.getString("EMAIL"), 
                        rs.getString("ADDRESS"),
                        rs.getString("AVATAR"),
                        rs.getString("BACKGROUND"),
                        rs.getString("YEAR_OF_BIRTH")
                );
                hmUser.put(rs.getInt("ID"),new Handler(user));
            }
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return hmUser;
    }
    public static ArrayList<User_account> listUser(int id){
        ArrayList<User_account> listUser = new ArrayList<User_account>();
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "SELECT U.*, F.ID AS IDFRIEND FROM USER_ACCOUNT U, FRIENDS F WHERE U.ID <> "+id+" AND (F.USER1 = "+id+" OR F.USER2 = "+id+") AND (F.USER1 = U.ID OR F.USER2 = U.ID)";
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                pojo.User_account user = new User_account(
                        rs.getInt("ID"),
                        rs.getInt("SEX"), 
                        rs.getInt("STATUS"), 
                        rs.getString("NAME"), 
                        rs.getString("SURNAME"),
                        rs.getString("USERNAME"), 
                        rs.getString("PASSWORD"),
                        rs.getString("EMAIL"), 
                        rs.getString("ADDRESS"),
                        rs.getString("AVATAR"),
                        rs.getString("BACKGROUND"),
                        rs.getString("YEAR_OF_BIRTH")
                );
                user.setIdFriend(rs.getInt("IDFRIEND"));
                listUser.add(user);
            }
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return listUser;
    }
    public static int checkUsername(String username){
        int n = -1;
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "SELECT * FROM USER_ACCOUNT where USERNAME = '"+username+"'";
            ResultSet rs = provider.executeQuery(sql);
            if(rs.next()) n = rs.getInt(1);
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return n;
    }
    public static User_account selectUser(String username){
        User_account user = null;
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "SELECT * FROM USER_ACCOUNT where USERNAME = '"+username+"'";
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                user = new User_account(
                        rs.getInt("ID"),
                        rs.getInt("SEX"), 
                        rs.getInt("STATUS"), 
                        rs.getString("NAME"), 
                        rs.getString("SURNAME"),
                        rs.getString("USERNAME"), 
                        rs.getString("PASSWORD"),
                        rs.getString("EMAIL"), 
                        rs.getString("ADDRESS"),
                        rs.getString("AVATAR"),
                        rs.getString("BACKGROUND"),
                        rs.getString("YEAR_OF_BIRTH")
                );
            }
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return user;
    }
    public static int checkEmail(String username, String email){
    int n =-1;
    try {
        SQLServerDataProvider provider = new SQLServerDataProvider();
        provider.open();
        String sql = "SELECT * FROM USER_ACCOUNT where USERNAME = '"+username+"' AND EMAIL = '"+email+"'";
        ResultSet rs = provider.executeQuery(sql);
        if(rs.next()) n = rs.getInt(1);
        provider.close();
    } catch (Exception e) {
        e.printStackTrace();
    }
    return n;
}
    public static int insertUser(User_account user){
        int n = -1;
        String sql = "INSERT INTO USER_ACCOUNT (NAME,SURNAME,USERNAME, PASSWORD, EMAIL, SEX, AVATAR, BACKGROUND)"
                        + "VALUES (N'"+user.getName()+"',N'"+user.getSurname()+"',N'"+user.getUsername()+"','"+user.getPassword()+"','"+user.getEmail()+"',"+user.getSex()+",'a','"+user.getPathBackground()+"')";
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            n = provider.executeUpdate(sql);
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return n;
    }
    public static int checkPassword(String username, String pass){
        int a =0;
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "SELECT * FROM USER_ACCOUNT where USERNAME = '"+username+ "' AND PASSWORD = '"+pass+"'";
            ResultSet rs = provider.executeQuery(sql);
            if(rs.next()) a = rs.getInt("ID");
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return a;
    }
    public static int updatePassword(int id, String pass){
        int a = -1;
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "UPDATE USER_ACCOUNT SET PASSWORD = '"+pass+"' WHERE ID = "+id;
            a = provider.executeUpdate(sql);
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return a;
    }
    public static int updateAvatar(int id, String path){
        int a = -1;
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "UPDATE USER_ACCOUNT SET AVATAR = '"+path+"' WHERE ID = "+id;
            a = provider.executeUpdate(sql);
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return a;
    }
    public static int updateUser(User_account user){
        int a = 0;
        String sql = "UPDATE USER_ACCOUNT "
                + "SET NAME = N'"+user.getName()+"', "
                + "SURNAME = N'"+user.getSurname()+"', "
                + "SEX = "+user.getSex()+", "
                + "EMAIL = '"+user.getEmail()+"',"
                + " ADDRESS = N'"+user.getAddress()+"',"
                + "YEAR_OF_BIRTH = CONVERT(DATE,'"+user.getYearofbirth()+"',103) WHERE ID = '"+user.getId()+"'";
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
                a = provider.executeUpdate(sql);
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return a;
    }
    public static ArrayList<ListChatPeople> listChat(int id){
        ArrayList<ListChatPeople> l = new ArrayList<ListChatPeople>();
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "select * from  USER_ACCOUNT u, MESSAGE_S ms\n" +
                            " where u.ID <> "+id+" and (ms.ID_SEND = u.ID or ms.ID_RECEIVE = u.ID) and ms.ID_FRIEND in (\n" +
                            "select ID from FRIENDS \n" +
                            "where USER1 = "+id+" or USER2 ="+id+") \n" +
                            "and ms.id in (\n" +
                            "SELECT top 1 m.id \n" +
                            "FROM MESSAGE_S M \n" +
                            "WHERE ID_FRIEND = ms.ID_FRIEND  \n" +
                            "ORDER BY DATE_OF_SEND DESC)ORDER BY DATE_OF_SEND DESC";
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                pojo.User_account user = new User_account(
                        rs.getInt("ID"),
                        rs.getInt("SEX"), 
                        rs.getInt("STATUS"), 
                        rs.getString("NAME"), 
                        rs.getString("SURNAME"),
                        rs.getString("USERNAME"), 
                        rs.getString("PASSWORD"),
                        rs.getString("EMAIL"), 
                        rs.getString("ADDRESS"),
                        rs.getString("AVATAR"),
                        rs.getString("BACKGROUND"),
                        rs.getString("YEAR_OF_BIRTH")
                );
                PeopelMessage mess = new PeopelMessage(
                        rs.getInt("ID_RECEIVE"),
                        rs.getInt("ID"),
                        rs.getInt("ID_FRIEND"),
                        rs.getInt("ID_SEND"), 
                        rs.getInt("STATUS"), 
                        rs.getInt("TYPE"),
                        rs.getString("CONTENT"), 
                        (Date)rs.getObject("DATE_OF_SEND")
                );
               l.add(new ListChatPeople(user, mess));
            }
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return l;
    }
    public static int updateOnline(int status, int id){
        int n = 0;
        try {
            String sql = "update USER_ACCOUNT set STATUS = "+status+" where ID = "+id;
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            n = provider.executeUpdate(sql);
        } catch (Exception e) {
        }
        return n;
    }
}
