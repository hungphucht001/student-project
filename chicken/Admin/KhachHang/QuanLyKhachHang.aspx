<%@ Page Title="Chicken | Quản lý khách hàng" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="QuanLyKhachHang.aspx.cs" Inherits="chicken.Admin.KhachHang.QuanLyKhacHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
    <div class="row">
        <div class="col-lg-12">
        <span class="title-page">Nhân viên / Quản lý khách hàng</span>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="box-number">
            <div class="title">
                <span>
                    Tổng số khách hàng
                </span>
            </div>
            <div class="number">
                <span>
                    <%=this.TotalCustomer %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="wrap-table p-4">
            <div class="header-table">
                <div class="title">
                    <h5>Tất cả Khách hàng</h5>
                </div>
                <div class="search">
                    <div class="form-group">
                        <div class="single-input">
                            <asp:TextBox ID="txtSearch" runat="server" placeholder="Tìm kiếm"></asp:TextBox>
                        </div>
                        <div class="single-button">
                            <asp:Button ID="btnSearch" OnClick="btnSearch_Click" runat="server" Text="Tìm" Height="16px" />
                        </div>
                    </div>
            </div>
                </div>
            <asp:GridView ID="GridView1" AutoGenerateColumns="false" CssClass="table table-dark table-striped" runat="server">
                <Columns>
                    <asp:BoundField DataField="ID_USER" HeaderText="Id" />
                    <asp:BoundField DataField="FULLNAME" HeaderText="Tên" />
                    <asp:BoundField DataField="GIOITINH" HeaderText="Giới Tính" />
                    <asp:BoundField DataField="NGAYSINH" HeaderText="Ngày sinh" />
                    <asp:BoundField DataField="SDT" HeaderText="SDT" />
                    <asp:BoundField DataField="DIACHI" HeaderText="Địa chỉ" />
                    <asp:BoundField DataField="" HeaderText="Số đơn hàng" />
                    <asp:TemplateField HeaderText="Tác vụ">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" onclick="return confirm('Bạn có chắc muôn xóa không?')" NavigateUrl='<%# "/admin/khachhang/xoakhachhang?id=" + Eval("ID_KHACHHANG") %>' runat="server"><i class="bi bi-archive"></i></asp:HyperLink>
                            <asp:HyperLink ID="HyperLink3" NavigateUrl="a" runat="server"><i class="bi bi-eye"></i></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <h2>Chưa có khách hàng nào</h2>
                </EmptyDataTemplate>
            </asp:GridView>
                <div class="wrap-pagination">
                    <ul class="pagination justify-content-end">
                        <%=this.Pag %>
                    </ul>
                </div>
        </div>
    </div>
    </div>
</form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>