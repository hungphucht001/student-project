package clinet.dto;
/**
 *
 * @author Hùng Trần
 */
public class CheckListItem_DTO{
    private boolean isSelected = false;
    private pojo.User_account user;
    
    public CheckListItem_DTO(pojo.User_account user){
        this.user = user;
    }
    /**
     * @return the isSelected
     */
    public boolean isSelected() {
        return isSelected;
    }

    /**
     * @param isSelected the isSelected to set
     */
    public void setIsSelected(boolean isSelected) {
        this.isSelected = isSelected;
    }

    /**
     * @return the user
     */
    public pojo.User_account getUser() {
        return user;
    }

    /**
     * @param user the user to set
     */
    public void setUser(pojo.User_account user) {
        this.user = user;
    }
}
