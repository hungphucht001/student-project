package dao;

import java.sql.ResultSet;
import pojo.Group;

/**
 *
 * @author Hùng Trần
 */
public class Friend_DAO {
    public static int selectIDFriend(int idUser1, int idUser2){
       int n = 0;
        String sql ="select * from FRIENDS where (USER1 = "+idUser1+" or USER2 = "+idUser1+") and (USER1 = "+idUser2+" or USER2 = "+idUser2+")";
        try {
            SQLServerDataProvider provider = new SQLServerDataProvider();
            provider.open();
            
            ResultSet rs = provider.executeQuery(sql);
            
            if(rs.next()){
                n = rs.getInt("ID");
            }
            rs.close();
            provider.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return n;
    }
}
