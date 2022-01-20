/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.publicevent;

import java.util.ArrayList;
import pojo.DataFile;
import pojo.User_account;

/**
 *
 * @author Hùng Trần
 */
public interface EventSendToServer{
    public void eventSendMessageGroup(pojo.GroupMessage message);
    public void evendSendMessagePeopel(pojo.PeopelMessage message);
    public void evendSendListIdCreateGroup(String name, ArrayList<Integer> alId);
    public void evendSendInforUpdate(User_account user);
    public void evendOutGroup(int idGroup);
    public void evendChangPassword(String pass);
    public void evendUpdateAvatar(DataFile dataFile);
    public void eventLogout();
    public void eventLoadDataMessPeopel(int idUser);
    public void eventLoadDataMessageGroup(int group);
    public void eventRenameGroup(int idgroup, String newName);
}
