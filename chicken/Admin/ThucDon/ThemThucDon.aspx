<%@ Page Title="Chicken | Thêm thực đơn" ValidateRequest="false" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="ThemThucDon.aspx.cs" Inherits="chicken.Admin.ThucDon.ThemThucDon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-lg-12">
        <span class="title-page">Thực đơn / Thêm thực đơn</span>
    </div>
     <form runat="server">
         <ctl:thucdon ID="ctlThuDon" IsUpdate ="false" runat="server" Title="Thêm món ăn mới"/>
     </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server" >
    <script>
        CKEDITOR.replace('Content_ctlThuDon_txtNoiDung');
    </script>
</asp:Content>
