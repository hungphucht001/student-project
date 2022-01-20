/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import pojo.Group;
import pojo.GroupMember;
import pojo.GroupMessage;
import pojo.ListChatGroup;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */
public class Group_DAO {
    public static HashMap<Integer,Group> hmGroup(){
        HashMap<Integer,Group> hmGroup = new HashMap<Integer, Group>();
        String sql ="SELECT * FROM GROUPS";
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            
            ResultSet rs = provider.executeQuery(sql);
            
            while (rs.next()) {
                Group g = new Group();
                g.setNumberMember(rs.getInt("NUMBERMEMBER"));
                g.setId(rs.getInt("ID"));
                g.setAvatar(rs.getString("AVATAR"));
                g.setName(rs.getString("Name"));
                g.setDatetime((Date)rs.getObject("DATE_TIME"));
                g.setAlMember(listMember(rs.getInt("ID")));
                hmGroup.put(rs.getInt("ID"), g);
            }
            rs.close();
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return hmGroup;
    }
    public static Group alGroup(int id){
        Group g = new Group();
        String sql ="SELECT * FROM GROUPS WHERE ID = "+ id;
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                g.setNumberMember(rs.getInt("NUMBERMEMBER"));
                g.setId(rs.getInt("ID"));
                g.setAvatar(rs.getString("AVATAR"));
                g.setName(rs.getString("Name"));
                g.setDatetime((Date)rs.getObject("DATE_TIME"));
                g.setAlMember(listMember(g.getId()));
            }
            rs.close();
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return g;
    }
    public static ArrayList<pojo.Group> memberInGroup(int id){
        ArrayList<Group> al = new ArrayList<Group>();
        String sql ="SELECT * FROM GROUPS G, GROUP_MEMBER GM WHERE G.ID = GM.ID_GROUP AND ID_USER = "+id;
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            
            ResultSet rs = provider.executeQuery(sql);
            
            while (rs.next()) {
                Group g = new Group();
                g.setNumberMember(rs.getInt("NUMBERMEMBER"));
                g.setId(rs.getInt("ID"));
                g.setAvatar(rs.getString("AVATAR"));
                g.setName(rs.getString("Name"));
                g.setDatetime((Date)rs.getObject("DATE_TIME"));
                g.setAlMember(listMember(g.getId()));
                al.add(g);
            }
            rs.close();
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return al;
    }

    public static ArrayList<pojo.ListChatGroup> listChatGroup(int id){
        ArrayList<ListChatGroup> al = new ArrayList<ListChatGroup>();
        String sql ="SELECT * FROM GROUPS G, GROUP_MESSAGES GM, GROUP_MEMBER GMEM\n" +
                    "WHERE G.ID = GMEM.ID_GROUP AND G.ID = GM.ID_GROUP AND GM.ID IN (\n" +
                    "select top 1 id from GROUP_MESSAGES where ID_GROUP = GM.ID_GROUP order by DATE_OF_SEND desc)\n" +
                    "AND GMEM.ID_USER = "+id+" order by DATE_OF_SEND desc";
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                ListChatGroup item = new ListChatGroup();
                Group g = new Group();
                g.setNumberMember(rs.getInt("NUMBERMEMBER"));
                g.setId(rs.getInt("ID"));
                g.setAvatar(rs.getString("AVATAR"));
                g.setName(rs.getString("Name"));
                g.setDatetime((Date)rs.getObject("DATE_TIME"));
                GroupMessage gMess = new GroupMessage(rs.getInt("ID"), rs.getInt("ID_GROUP"), rs.getInt("ID_USER"), 0,rs.getInt("TYPE"), rs.getString("CONTENT"), (Date)rs.getObject("DATE_OF_SEND"));
                g.setAlMember(listMember(rs.getInt("ID_GROUP")));
                item.setGroup(g);
                item.setGroupMessage(gMess);
                al.add(item);
            }
            rs.close();
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return al;
    }
    public static ArrayList<pojo.GroupMember> listMember(int idGroup){
        ArrayList<pojo.GroupMember> al = new ArrayList<pojo.GroupMember>();
        String sql ="select U.*, TYPE from GROUP_MEMBER GM, USER_ACCOUNT U where ID_GROUP = "+idGroup+" AND GM.ID_USER = U.ID";
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
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
                GroupMember gm = new GroupMember(user, rs.getInt("type"));
                gm.setId_group(idGroup);
                gm.setId_user(rs.getInt("ID"));
                al.add(gm);
            }
            rs.close();
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return al;
    }
    public static ArrayList<pojo.GroupMessage> listMessage(int idGroup){
        ArrayList<pojo.GroupMessage> al = new ArrayList<pojo.GroupMessage>();
        String sql ="select * from GROUP_MESSAGES where ID_GROUP = "+idGroup+" order by DATE_OF_SEND asc";
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                GroupMessage gm = new GroupMessage(rs.getInt("ID"), rs.getInt("ID_GROUP"), rs.getInt("ID_USER"),0, rs.getInt("TYPE"), rs.getString("CONTENT"), (Date)rs.getObject("DATE_OF_SEND"));
                al.add(gm);
            }
            rs.close();
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return al;
    }
    public static int createGroup(String name){
        int n = -1;
        String sql ="insert into GROUPS (NAME, DATE_TIME, AVATAR, NUMBERMEMBER)\n" +
                "VALUES (N'"+name+"',GETDATE(),'./src/data/data_default/icon-group.png',0)";
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            ResultSet resultSet = null;
            PreparedStatement prepsInsertProduct = provider.getConn().prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
            prepsInsertProduct.execute();
            resultSet = prepsInsertProduct.getGeneratedKeys();
            
            while (resultSet.next()) {
                n = resultSet.getInt(1);
            }
            
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return n;
    }
    public static int insertMember(int id_group, int id_user, int type){
        int n = -1;
        String sql ="INSERT INTO GROUP_MEMBER (ID_GROUP,ID_USER,TYPE) VALUES("+id_group+","+id_user+","+type+")";
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
     public static int renameGroup(int id_group, String newName){
        int n = -1;
        String sql ="UPDATE GROUPS SET Name = '"+newName+"' WHERE ID = "+id_group;
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
     public static int deleteMember(int idUser, int idGroup){
        int n = -1;
        String sql ="delete GROUP_MEMBER where ID_GROUP = "+idGroup+" and ID_USER = "+idUser;
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
}
