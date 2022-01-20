<%@ Page Title="Khuyến mãi - Chicken" Language="C#" MasterPageFile="~/gui/Site.Master" AutoEventWireup="true" CodeBehind="KhuyenMai.aspx.cs" Inherits="chicken.KhuyenMai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
       <section class="list-promotion" id="list-promotion">
           <asp:ListView ID="ListView1" runat="server">
               <ItemTemplate>
                   <div class="box-promption" style="background-image: url(./Content/assets/imgs/1x/back1-100.jpg);"> 
                <div class="wrap-container">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="content">
                                <h1><%# Eval("TENSP") %></h1>
                                <h5><%# Eval("MOTA") %></h5>
                                <a href="<%# "/san-pham/"+Eval("TENKHONGGIAU") +"/"+Eval("ID_PRODUCTS") %>">Xem ngay</a>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="single-image">
                                <img src="<%# Eval("AVATAR") %>" alt="">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
               </ItemTemplate>
               <EmptyDataTemplate>
                   <h2>Chưa có khuyến mãi nào</h2>
               </EmptyDataTemplate>
           </asp:ListView>
        </section>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
