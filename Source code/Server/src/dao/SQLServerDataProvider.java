/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author Hùng Trần
 */
public class SQLServerDataProvider {
    private Connection conn;
    public void open(){
        String  strDB = "SCHATZ",
                strServerName = "HUNGTRAN\\SQLEXPRESS",
                strUserName="sa",
                strPassWord = "123";
        String driver = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
        try {
            Class.forName(driver);
            String connectionURL ="jdbc:sqlserver://"+strServerName+":1433;databaseName= "+strDB+";user="+strUserName+";password="+strPassWord;
            setConn(DriverManager.getConnection(connectionURL));
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    public void close(){
        try {
            getConn().close();
        } catch (SQLException ex) {
            ex.printStackTrace();
        }
    }
    public ResultSet executeQuery(String sql){
        ResultSet rs = null;
        try {
            Statement sm = getConn().createStatement();
            rs = sm.executeQuery(sql);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return rs;
    }
    public int executeUpdate(String sql){
        int n = -1;
        try {
            Statement sm = conn.createStatement();
            n = sm.executeUpdate(sql);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return n;
    }
    public Connection getConn() {
        return conn;
    }
    public void setConn(Connection conn) {
        this.conn = conn;
    }
}
