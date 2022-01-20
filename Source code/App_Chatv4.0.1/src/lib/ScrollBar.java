/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lib;

import java.awt.Dimension;
import javax.swing.JScrollBar;

/**
 *
 * @author Hùng Trần
 */
public class ScrollBar extends JScrollBar{
    public ScrollBar(){
        setUI(new ModernScrollBarUI());
        setPreferredSize(new Dimension(8, 5));
    }
}
