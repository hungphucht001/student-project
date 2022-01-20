<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="nhanvien.ascx.cs" Inherits="chicken.Admin.Controls.nhanvien" %>
<div class="col-lg-12">
        <span class="title-page">Nhân viên / <%=this.Title1 %></span>
    </div>
    <div class="col-lg-12">
        <div class="wrap-form">
            <div class="header-add text-center py-3">
                <h4><%=this.Title2 %></h4>
            </div>
            <form runat="server">
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Tên:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtName" class="form-control" placeholder="Tên" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="txtName" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Ngày sinh:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtNgaySinh" class="form-control" placeholder="Ngày sinh" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="txtNgaySinh" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-line mt-4 d-flex justify-content-between">
                    <div class="form-group m-0" style="width:49%">
                        <asp:Label ID="Label1" runat="server" Text="Giới Tính:" CssClass="mb-1 d-flex"></asp:Label>
                        <asp:DropDownList ID="DropDownListGT" class="form-control" runat="server">
                            <asp:ListItem Text="Nam" Value ="0" />
                            <asp:ListItem Text="Nữ" Value ="1" />
                            <asp:ListItem Text="Khác" Value ="2" />
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ForeColor="Red" ControlToValidate="DropDownListGT" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group m-0" style="width:49%">
                        <asp:Label ID="Label2" runat="server" Text="Chức vụ:" CssClass="mb-1 d-flex"></asp:Label>
                        <asp:DropDownList ID="DropDownListCV" class="form-control" runat="server">
                            <asp:ListItem Text="Giám đốc" Value ="Giám đốc" />
                            <asp:ListItem Text="Quản lý" Value ="Quản lý" />
                            <asp:ListItem Text="Đầu bếp" Value ="Đầu bếp" />
                            <asp:ListItem Text="Nhân viên tư vấn & duyệt đơn hàng" Value ="Nhân viên tư vấn & duyệt đơn hàng" />
                            <asp:ListItem Text="Nhân viên giao hàng" Value ="Nhân viên giao hàng" />
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ForeColor="Red" ControlToValidate="DropDownListCV" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Tên đăng nhập:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtTenDangNhap" class="form-control" placeholder="Tên đăng nhập" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="txtTenDangNhap" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                        <asp:Label ID="Label6" runat="server" Text="Mật khẩu:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtMatKhau" class="form-control" placeholder="Mật khẩu" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="Red" ControlToValidate="txtMatKhau" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                        <asp:Label ID="Label7" runat="server" Text="Số điện thoại:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtSDT" class="form-control" placeholder="Số điện thoại" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ForeColor="Red" ControlToValidate="txtSDT" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                        <asp:Label ID="Label8" runat="server" Text="Địa chỉ:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtDiaChi" class="form-control" placeholder="Địa chỉ" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ForeColor="Red" ControlToValidate="txtDiaChi" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group d-flex align-center">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn px-5" Text="Thêm" OnClick="btnSubmit_Click"/>
                    <asp:HyperLink ID="HyperLink1" ForeColor="Black" CssClass="nav-link px-5 mt-1" NavigateUrl="/admin/nhanvien/quanlynhanvien" runat="server"><i class="bi bi-arrow-left-short"></i> Quay lại</asp:HyperLink>
                </div>
                <asp:Label ID="lbMessage" runat="server"></asp:Label>
            </form>
        </div>
    </div>