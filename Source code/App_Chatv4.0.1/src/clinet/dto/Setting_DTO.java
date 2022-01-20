/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.dto;

/**
 *
 * @author Hùng Trần
 */
public class Setting_DTO {
    private String icon1, icon2, name;

    public Setting_DTO(String icon1, String icon2, String name) {
        this.icon1 = icon1;
        this.icon2 = icon2;
        this.name = name;
    }

    /**
     * @return the icon1
     */
    public String getIcon1() {
        return icon1;
    }

    /**
     * @param icon1 the icon1 to set
     */
    public void setIcon1(String icon1) {
        this.icon1 = icon1;
    }

    /**
     * @return the icon2
     */
    public String getIcon2() {
        return icon2;
    }

    /**
     * @param icon2 the icon2 to set
     */
    public void setIcon2(String icon2) {
        this.icon2 = icon2;
    }

    /**
     * @return the name
     */
    public String getName() {
        return name;
    }

    /**
     * @param name the name to set
     */
    public void setName(String name) {
        this.name = name;
    }
}
