<%@ Page EnableEventValidation="true" Title="" Language="C#" ValidateRequest="false" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="SuaThucDon.aspx.cs" Inherits="chicken.Admin.ThucDon.SuaThucDon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-lg-12">
        <span class="title-page">Thực đơn / Sửa thực đơn</span>
    </div>
     <form runat="server">
         <ctl:thucdon ID="ctlThuDon" IsUpdate="true" runat="server" Title="Sửa thông tin món ăn mới"/>
     </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server" >
    <script>
        CKEDITOR.replace('Content_ctlThuDon_txtNoiDung');
    </script>
</asp:Content>