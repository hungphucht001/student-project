package fun;

import dao.Message_DAO;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;
import pojo.DataFile;
/**
 *
 * @author Hùng Trần
 */
public class Function {
    private ArrayList<String> pathBackground = new ArrayList<String>();
    private Random randomIndexPath = new Random();
    private static byte[] convertFileToByte(File f) throws IOException{
        FileInputStream in = null;
        try {
            in = new FileInputStream(f);
            byte b[] = new byte[in.available()];
            in.read(b);
            return b;
        } catch (FileNotFoundException ex) {
            ex.printStackTrace();
        } finally {
            try {
                in.close();
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        }
        return null;
    }
    public static DataFile dataFileF(int type ,String path){
        try {
            File f =new File(path);
            if(f.exists())
                return new DataFile(type, convertFileToByte(f), f.getName(), f.length());
            else
                return new DataFile(5, null, "File không tồn tại", 0);
        } catch (IOException ex) {
            Logger.getLogger(Message_DAO.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
    private void loadBackgound(){
        File back = new File("./src/data/background");
        if(back.isDirectory()){
            File[] listEmoji=  back.listFiles();
            for(File item: listEmoji){
                pathBackground.add(item.getAbsolutePath());
            }
        }
    }
    public String randomPathBackgound(){
        loadBackgound();
        String path = null;
        int index = randomIndexPath.nextInt(pathBackground.size());
        path = pathBackground.get(index);
        return path;
    }
    public static int randomCode(){
        Random rd = new Random();
        return 100000+rd.nextInt(899999);
    }
}
 