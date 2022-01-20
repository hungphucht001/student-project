<%@ Page Title="Chicken | Thêm nhân viên" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="ThemNhanVien.aspx.cs" Inherits="chicken.Admin.NhanVien.ThemNhanVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
   <ctl:nhanvien isUpdate = "false" runat="server"/>
</asp:Content>
