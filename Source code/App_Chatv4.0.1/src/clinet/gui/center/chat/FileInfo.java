package clinet.gui.center.chat;

import java.io.File;
import javax.swing.ImageIcon;

/**
 *
 * @author Hùng Trần
 */
public class FileInfo {
    public String setLogoFile(String name){
        String a = "./src/data/assets/iconfile/";
        int dot = name.indexOf(".");
        name = name.substring(dot+1, name.length()).toLowerCase();
        switch(name){
            case "docx":
            case "doc":
            case "docm":
            case "dotx":
            case "dotm":
            case "dot":{a +="word.png";break;}
            case "xlsx":
            case "xlsm":
            case "xlsb":
            case "xls":
            case "xltx":
            case "xltm":
            case "xlt":{a +="excel.png";break;}
            case "pptx":
            case "pptm":
            case "ppt":
            case "potx":
            case "potm":
            case "pot":
            case "ppsx":
            case "ppsm":
            case "pps":
            case "ppam":{a +="pp.png";break;}
            case "txt":{a +="txt.png"; break;}
            case "xml":{a +="xml.png"; break;}
            case "png":{a +="png.png";break;}
            case "jpg":{a +="jpg.png"; break;}
            case "psd":{a +="psd.png";break;}
            case "pdf":{a +="pdf.png"; break;}
            case "ai":{a +="ai.png";break;}
            case "svg":{a +="svg.png";break;}
            case "zip":{a +="zip.png";break;}
            case "rar":{a +="rar.png";break;}
            case "html":{a +="svg.png";break;}
            case "css":{a +="zip.png";break;}
            case "jar":{a +="rar.png";break;}
            case "java":{a +="java.png";break;}
            case "sql":{a +="sql.png";break;}
            case "bak":{a +="bak.png";break;}
            case "asp":{a +="asp.png";break;}
            case "bat":{a +="bat.png";break;}
            case "js":{a +="js.png";break;}
            case "mdf":{a +="mdf.png";break;}
            case "py":{a +="py.png";break;}
            default:{a +="file.png";break;}
        }
        return a;
    }
    public String setNameFile(String name,int limit){
        if(name.length() > limit){
            int dot = name.indexOf(".");
            String b = name.substring(dot-3, name.length());
            String c = name.substring(0, limit - (b.length() + 3));
           return c.concat("..."+b);
        }
        return name;
    }
    public double setSizeFile(double bytes){
        double kilobytes = (bytes / 1024);
        double megabytes = (kilobytes / 1024);
        megabytes = Math.round(megabytes * 100.0) / 100.0;
        return megabytes;
    }
}
