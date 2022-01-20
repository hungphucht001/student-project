<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Site.Master" AutoEventWireup="true" CodeBehind="Taikhoan.aspx.cs" Inherits="chicken.GUI.Taikhoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
    <div class="wrap-container" style="padding:100px 0;">
        <div class="row">
            <div class="col-lg-3">
                <div class="sidebar p-5">
                    <div class="header">
                        <h3>Tài khoản</h3>
                    </div>
                    <div class="menu">
                        <ul class="p-0">
                            <li class="py-3">
                                <asp:HyperLink ID="HyperLink1" NavigateUrl="/tai-khoan/a" runat="server" CssClass="nav-link p-0 cl-black">Chỉnh sửa tài khoản</asp:HyperLink>
                            </li>
                            <li class="py-3">
                                <asp:HyperLink ID="HyperLink2" NavigateUrl="/tai-khoan/b"  runat="server" CssClass="nav-link p-0 cl-black">Đơn hàng</asp:HyperLink>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col-lg-9">
                <div class="wrap p-5">
                    <asp:Panel ID="pnContent" runat="server">

                    </asp:Panel>
                </div>
            </div>
        </div>
    </div>
</form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
