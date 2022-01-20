/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import pojo.DataFile;
import pojo.Message;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */
public class Message_DAO {
    public static int insertMessagePeopel(pojo.PeopelMessage mess){
        int n = 0;
        try {
            String sql = "INSERT INTO MESSAGE_S "
                    + "(ID_FRIEND,ID_SEND,ID_RECEIVE,CONTENT,STATUS,DATE_OF_SEND,TYPE) "
                    + "VALUES ("+mess.getId_frgr()+","+mess.getId_send()+","+mess.getId_receive()+",N'"+mess.getContent()+"',"+mess.getId_frgr()+",GETDATE(),"+mess.getType()+")";
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            n = provider.executeUpdate(sql);
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return n;
    }
    public static int insertMessageGroup(pojo.GroupMessage mess){
        int n = 0;
        try {
            String sql = "INSERT INTO GROUP_MESSAGES (ID_GROUP, ID_USER, CONTENT, TYPE, DATE_OF_SEND)\n" +
                        "VALUES("+mess.getId_frgr()+","+mess.getId_send()+",N'"+mess.getContent()+"',"+mess.getType()+",GETDATE())";
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            n = provider.executeUpdate(sql);
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return n;
    }
    public static ArrayList<pojo.PeopelMessage> ListMessageByIDFriend(int idFriend){
        ArrayList<pojo.PeopelMessage> listMessageByIDFriend = new ArrayList<pojo.PeopelMessage>();
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "SELECT * FROM MESSAGE_S WHERE ID_FRIEND = "+idFriend+" ORDER BY DATE_OF_SEND ASC";
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                pojo.PeopelMessage mess = new pojo.PeopelMessage();
                mess.setId(rs.getInt("ID"));
                mess.setId_frgr(idFriend);
                mess.setId_send(rs.getInt("ID_SEND"));
                mess.setId_receive(rs.getInt("ID_RECEIVE"));
                mess.setContent(rs.getString("CONTENT"));
                mess.setStatus(rs.getInt("STATUS"));
                mess.setType(rs.getInt("TYPE"));
                mess.setDateofsend((Date)rs.getObject("DATE_OF_SEND"));
                if(rs.getInt("TYPE") == 1 || rs.getInt("TYPE")== 2 || rs.getInt("TYPE")== 4){
                    
                    mess.setDataFile(fun.Function.dataFileF(rs.getInt("TYPE"), rs.getString("CONTENT")));
                }
                listMessageByIDFriend.add(mess);
            }
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return listMessageByIDFriend;
    }
    public static ArrayList<pojo.GroupMessage> ListMessageByIDGroup(int idGroup){
        ArrayList<pojo.GroupMessage> listMessageByIDGroup= new ArrayList<pojo.GroupMessage>();
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "SELECT * FROM GROUP_MESSAGES WHERE ID_GROUP = "+idGroup+" ORDER BY DATE_OF_SEND ASC";
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
//                ID_FRIEND,ID_SEND,ID_RECEIVE,CONTENT,STATUS,DATE_OF_SEND,
                pojo.GroupMessage mess = new pojo.GroupMessage();
                mess.setId(rs.getInt("ID"));
                mess.setId_frgr(idGroup);
                mess.setId_send(rs.getInt("ID_USER"));
                mess.setContent(rs.getString("CONTENT"));
                mess.setStatus(1);
                mess.setType(rs.getInt("TYPE"));
                mess.setDateofsend((Date)rs.getObject("DATE_OF_SEND"));
                if(rs.getInt("TYPE") == 1 || rs.getInt("TYPE")== 2 || rs.getInt("TYPE")== 4){
                    mess.setDataFile(fun.Function.dataFileF(rs.getInt("TYPE"), rs.getString("CONTENT")));
                }
                listMessageByIDGroup.add(mess);
            }
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return listMessageByIDGroup;
    }
}
