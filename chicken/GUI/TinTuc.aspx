<%@ Page Title="Tin tức - Chicken" Language="C#" MasterPageFile="~/gui/Site.Master" AutoEventWireup="true" CodeBehind="TinTuc.aspx.cs" Inherits="chicken.TinTuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
     <div class="news-section mt-4">
            <div class="wrap-container">
                <div class="row">
                    <div class="col-lg-3">
                        <div class="wrap-sidebar">
                            <div class="search">
                                <form action="/tin-tuc">
                                    <div class="form-group">
                                        <input type="text" name="search" placeholder="Tìm kiếm">
                                        <button type="submit">
                                            <i class="bi bi-search"></i>
                                        </button>
                                    </div>
                                </form>
                            </div>
                            <div class="new mt-5">
                                <div class="title">
                                    <h5>BÀI ĐĂNG NGẪU NHIÊN</h5>
                                </div>
                                <hr>
                                <div class="new-content">
                                    <asp:ListView ID="ListViewRand" runat="server">
                                        <ItemTemplate>
                                            <div class="new-item">
                                        <div class="single-image">
                                            <a href="tin-tuc/<%#Eval("TENKHONGDAU") %>/<%#Eval("ID_NEWS") %>">
                                                <img src="<%#Eval("AVATAR") %>" alt="">
                                            </a>
                                        &nbsp;</div>
                                        <div class="content">
                                            <a href="tin-tuc/<%#Eval("TENKHONGDAU") %>/<%#Eval("ID_NEWS") %>">
                                                <span class="name">
                                                <%#Eval("TEN") %>
                                                </span>
                                            </a>
                                            <span class="by">
                                                Bởi: <%#Eval("FULLNAME") %>
                                            </span>
                                            <span class="date">
                                                <%#Eval("NGAYDANG",DateTime.Now.ToString("dd/MM/yyyy")) %>
                                            </span>
                                        </div>
                                    </div>
                                    </ItemTemplate>
                                    <EmptyDataTemplate>
                                        <h5 class="text-center">Chưa có bài viết nào</h5>
                                    </EmptyDataTemplate>
                                    </asp:ListView>
                                </div>
                            </div>
                            <div class="advertisement my-5">
                                <div class="single-image">
                                    <img src="./Content/assets/imgs/poster1.jpg" alt="">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-9 px-5">
                        <asp:ListView ID="ListViewNews" runat="server">
                            <ItemTemplate>
                            <div class="box-post">
                                        <div class="single-image">
                                            <img src="<%#Eval("AVATAR") %>" alt="">
                                        </div>
                                        <div class="content mt-3">
                                            <div class="title">
                                                <span class="by">
                                                    Bởi: <%#Eval("FULLNAME")%>
                                                </span>
                                                <span class="date">
                                                    <%#Eval("NGAYDANG",DateTime.Now.ToString("dd/MM/yyyy"))%>
                                                </span>
                                                <h3 class="my-1"><a href="/tin-tuc/<%#Eval("TENKHONGDAU") %>/<%#Eval("ID_NEWS") %>">
                                                    <%#Eval("TEN") %>
                                                </a></h3>
                                            </div>
                                            <div class="article">
                                                <p><%#Eval("GIOITHIEU") %></p>
                                            </div>
                                            <div class="btn">
                                                <a href="/tin-tuc/<%#Eval("TENKHONGDAU") %>/<%#Eval("ID_NEWS") %>">Xem thêm</a>
                                            </div>
                                        </div>
                                    </div>
                            </ItemTemplate>
                             <EmptyDataTemplate>
                                  <h2 class="text-center">Chưa có bài viết nào</h2>
                            </EmptyDataTemplate>
                        </asp:ListView>
                        <div class="my-5">
                            <ul class="pagination pagination-sm">
                                <%=this.Pag %>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
