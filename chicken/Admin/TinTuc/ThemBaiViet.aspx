<%@ Page Title="Chicken | Thêm bài viết" ValidateRequest="false" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="ThemBaiViet.aspx.cs" Inherits="chicken.Admin.BaiViet.ThemBaiViet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <ctl:tintuc runat="server" Title1="Thêm bài viết" IsUpdate="false" Title2="Thêm bài viết mới"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server" >
    <script>
        CKEDITOR.replace('Content_ctl00_txtContent');
    </script>
</asp:Content>
 