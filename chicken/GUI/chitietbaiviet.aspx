<%@ Page Title="" Language="C#" MasterPageFile="~/gui/Site.Master" AutoEventWireup="true" CodeBehind="chitietbaiviet.aspx.cs" Inherits="chicken.chitietbaiviet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
       <div class="news-section mt-5">
            <div class="wrap-container mt-5">
                <div class="row">
                    <div class="col-lg-1">
                    </div>
                    <asp:ListView ID="ListView" runat="server">
                        <ItemTemplate>
                            <div class="col-lg-10 px-5">
                                <div class="box-post">
                                    <div class="single-image">
                                        <img src="<%#Eval("AVATAR")%>" alt="<%#Eval("AVATAR")%>">
                                    </div>
                                    <div class="content mt-3">
                                        <div class="title text-center mb-4">
                                            <h3 class="my-2 ">
                                                <%#Eval("TEN")%>
                                            </h3>
                                            <span class="by">
                                                Bởi: <%#Eval("FULLNAME")%>
                                            </span>
                                            <span class="date">
                                                <%# DateTime.Parse(Eval("NGAYDANG").ToString()).ToString("d") %>
                                            </span>
                                        </div>
                                        <div class="article">
                                            <%#Eval("MOTA")%>
                                        </div>
                                    </div>
                                </div>
                            </div>
                    </ItemTemplate>
                        </asp:ListView>
                    <div class="col-lg-1">
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
