package dao;

import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pojo.Notifications;

/**
 *
 * @author Hùng Trần
 */
public class Notification_DAO {
    public static ArrayList<pojo.Notifications> listNotification(int iduser){
        ArrayList<pojo.Notifications> listNotification = new ArrayList<pojo.Notifications>();
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            String sql = "SELECT * FROM NOTIFICATIONS WHERE ID_USER IS NULL OR ID_USER = "+iduser+" ORDER BY DATE_TIME DESC";
            ResultSet rs = provider.executeQuery(sql);
            while (rs.next()) {
                pojo.Notifications no = new Notifications(rs.getInt("ID"), rs.getInt("ID_USER"), rs.getString("CONTENT"), (Date)rs.getObject("DATE_TIME"),rs.getString("TITLE"));
                listNotification.add(no);
            }
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return listNotification;
    }
}
