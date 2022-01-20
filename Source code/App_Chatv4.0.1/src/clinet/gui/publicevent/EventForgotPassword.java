/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.publicevent;

/**
 *
 * @author Hùng Trần
 */
public interface EventForgotPassword {
    public void eventForgotPassword(String username, String email);
    public void eventChangePassword(int id,String pasword);
}
