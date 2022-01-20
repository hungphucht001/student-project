/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clinet.gui.publicevent;

import pojo.ListChatGroup;

/**
 *
 * @author Hùng Trần
 */
public class PublicEvent {
    private static PublicEvent publicEvent;
    private EventImageView eventImageView;
    private ShowSetting showSetting;
    private SeeAllInfoGroup seeAllInfoGroup;
    private ChatStickerEvent chatStickerEvent;
    //các
    private EventPersonChat eventPersonChat;
    private EventDisposeFrame eventDisposeFrame;
    private EventViewModal eventViewModal;
    private EventGroupChat eventGroupChat;
    private EventSendToServer eventSendToServer;
    private EventReceiveMess eventReceiveMess;
    private ReceiveMessageLoadDataChat receiveMessageLoadDataChat;
    private EventForgotPassword eventForgotPassword;
    public static PublicEvent getPublicEvent() {
        if(publicEvent==null){publicEvent = new PublicEvent();}
        return publicEvent;
    }
    public EventImageView getEventImageView() {
        return eventImageView;
    }
    public void addEventImageView(EventImageView eventImageView) {
        this.eventImageView = eventImageView;
    }
    public ShowSetting getShowSetting() {
        return showSetting;
    }
    public void addShowSetting(ShowSetting showSetting) {
        this.showSetting = showSetting;
    }
    public SeeAllInfoGroup getSeeAllInfoGroup() {
        return seeAllInfoGroup;
    }
    public void addSeeAllInfoGroup(SeeAllInfoGroup seeAllInfoGroup) {
        this.seeAllInfoGroup = seeAllInfoGroup;
    }
    public ChatStickerEvent getChatStickerEvent() {
        return chatStickerEvent;
    }
    public void addChatStickerEvent(ChatStickerEvent chatStickerEvent) {
        this.chatStickerEvent = chatStickerEvent;
    }
    public EventPersonChat getEventPersonChat() {
        return eventPersonChat;
    }
    public void setEventPersonChat(EventPersonChat eventPersonChat) {
        this.eventPersonChat = eventPersonChat;
    }
    public EventDisposeFrame getEventDisposeFrame() {
        return eventDisposeFrame;
    }
    public void setEventDisposeFrame(EventDisposeFrame eventDisposeFrame) {
        this.eventDisposeFrame = eventDisposeFrame;
    }
    public EventViewModal getEventViewModal() {
        return eventViewModal;
    }
    public void setEventViewModal(EventViewModal eventViewModal) {
        this.eventViewModal = eventViewModal;
    }
    public EventGroupChat getEventGroupChat() {
        return eventGroupChat;
    }
    public void setEventGroupChat(EventGroupChat eventGroupChat) {
        this.eventGroupChat = eventGroupChat;
    }
    public EventReceiveMess getEventReceiveMess() {
        return eventReceiveMess;
    }
    public void setEventReceiveMess(EventReceiveMess eventReceiveMess) {
        this.eventReceiveMess = eventReceiveMess;
    }
    public ReceiveMessageLoadDataChat getReceiveMessageLoadDataChat() {
        return receiveMessageLoadDataChat;
    }
    public void setReceiveMessageLoadDataChat(ReceiveMessageLoadDataChat receiveMessageLoadDataChat) {
        this.receiveMessageLoadDataChat = receiveMessageLoadDataChat;
    }
    public EventSendToServer getEventSendToServer() {
        return eventSendToServer;
    }
    public void setEventSendToServer(EventSendToServer eventSendToServer) {
        this.eventSendToServer = eventSendToServer;
    }

    /**
     * @return the eventForgotPassword
     */
    public EventForgotPassword getEventForgotPassword() {
        return eventForgotPassword;
    }

    /**
     * @param eventForgotPassword the eventForgotPassword to set
     */
    public void setEventForgotPassword(EventForgotPassword eventForgotPassword) {
        this.eventForgotPassword = eventForgotPassword;
    }
}
