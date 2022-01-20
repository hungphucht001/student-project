package clinet.gui.publicevent;

import java.util.ArrayList;

/**
 *
 * @author Hùng Trần
 */
public interface ReceiveMessageLoadDataChat {
    public void  receiveMessagePeopel(ArrayList<pojo.PeopelMessage> alMess);    
    public void  receiveMessageGroup(ArrayList<pojo.GroupMessage> alMess);
}
