/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.publicLoading;

/**
 *
 * @author Hùng Trần
 */
public class PublicLoading {
    private static PublicLoading publicLoading;
    private LoadListChat loadListChat;
    private LoadHome loadHome;
    private LoadSize loadSize;
    private UpdateList updateList;
    private LoadSizeGroup loadSizeGroup;
    private LoadGroupChat loadGroupChat;
    public static PublicLoading getPublicLoading() {
        if(publicLoading==null){publicLoading = new PublicLoading();}
        return publicLoading;
    }
    public LoadListChat getLoadListChat() {
        return loadListChat;
    }
    public void setLoadListChat(LoadListChat loadListChat) {
        this.loadListChat = loadListChat;
    }
    public LoadHome getLoadHome() {
        return loadHome;
    }
    public void setLoadHome(LoadHome loadHome) {
        this.loadHome = loadHome;
    }
    public LoadSize getLoadSize() {
        return loadSize;
    }
    public void setLoadSize(LoadSize loadSize) {
        this.loadSize = loadSize;
    }
    public UpdateList getUpdateList() {
        return updateList;
    }
    public void setUpdateList(UpdateList updateList) {
        this.updateList = updateList;
    }
    public LoadSizeGroup getLoadSizeGroup() {
        return loadSizeGroup;
    }
    public void setLoadSizeGroup(LoadSizeGroup loadSizeGroup) {
        this.loadSizeGroup = loadSizeGroup;
    }
    public LoadGroupChat getLoadGroupChat() {
        return loadGroupChat;
    }
    public void setLoadGroupChat(LoadGroupChat loadGroupChat) {
        this.loadGroupChat = loadGroupChat;
    }
    
}
