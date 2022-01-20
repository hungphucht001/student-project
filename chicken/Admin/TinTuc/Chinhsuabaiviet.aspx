<%@ Page Title="" Language="C#" ValidateRequest="false"  MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Chinhsuabaiviet.aspx.cs" Inherits="chicken.Admin.TinTuc.Chinhsuabaiviet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <ctl:tintuc runat="server" IsUpdate="true" Title1="Chỉnh sửa bài viết" Title2="Chỉnh sửa bài viết" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
      <script>
        CKEDITOR.replace('Content_ctl00_txtContent');
      </script>
</asp:Content>
