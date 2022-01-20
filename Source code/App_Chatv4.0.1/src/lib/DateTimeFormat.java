package lib;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Hùng Trần
 */
public class DateTimeFormat {
    private Date now;
    private SimpleDateFormat sdf;
    private static final String DATETIME ="dd-MM-yyyy' 'HH:mm";
    private static final String DATE ="dd-MM-yyyy";
    private static final String TIME ="HH:mm";
    public DateTimeFormat(){
        now = new Date();
        sdf = new SimpleDateFormat();
    }
    public String getCurrentDate(){
        sdf.applyPattern(DATE);
        String dateString = sdf.format(now);
        return dateString;
    }
    public String getCurrentTime(){
        sdf.applyPattern(TIME);
        String dateString = sdf.format(now);
        return dateString;
    }
    public String getCurrentTime(Date a){
        sdf.applyPattern(TIME);
        String dateString = sdf.format(a);
        return dateString;
    }
    public String getCurrentDateTime(){
        sdf.applyPattern(DATETIME);
        String dateString = sdf.format(now);
        System.out.println(dateString);
        return dateString;
    }
    public String getDateInDateTime(Date date){
        sdf.applyPattern(DATETIME);
        String dateString = sdf.format(date);
        dateString = dateString.substring(0,dateString.indexOf(" "));
        return dateString;
    }
    public String getTimeInDateTime(Date date){
        sdf.applyPattern(DATETIME);
        String dateString = sdf.format(date);
        dateString = dateString.substring(dateString.indexOf(" ")+1);
        return dateString;
    }
    public int compareWithCurrentDate(Date date){
        sdf.applyPattern(DATE);
        String currentDate = sdf.format(now);
        String dateAM = sdf.format(date);
        if(dateAM.equals(currentDate)){
            return 1;
        }
        return 0;
    }
    public Date convertStrToDate(String strDate){
        Date date = null;
        try {
            sdf.applyPattern(DATE);
            date = sdf.parse(strDate);
            } catch (Exception ex) {
        }
        return date;
    }
    public int compareDateWithDate(String date1,String date2){
        if(date1.equals(date2)){
            return 1;
        }
        return 0;
    }
}
