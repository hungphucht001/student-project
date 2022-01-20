package clinet.gui.publicevent;

/**
 *
 * @author Hùng Trần
 */
public interface EventReceiveMess{
    public void eventReceiveMessGroup(pojo.GroupMessage message);
    public void eventReceiveMessPeople(pojo.PeopelMessage message);
}
