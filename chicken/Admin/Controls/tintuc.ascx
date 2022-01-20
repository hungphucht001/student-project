<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tintuc.ascx.cs" Inherits="chicken.Admin.Controls.tintuc" %>
<div class="col-lg-12">
        <span class="title-page">Bài viết / <%=this.Title1 %></span>
</div>
<div class="col-lg-12">
        <div class="wrap-form">
            <div class="header-add text-center py-3">
                <h4><%=this.Title2 %></h4>
            </div>
            <form runat="server" ID="form">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Tên bài viết:"></asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtName" placeholder="Tên bài viết"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator1" CssClass="mt-2 d-flex"  ControlToValidate="txtName" runat="server" ErrorMessage="Không được bỏ trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Giới thiệu:"></asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtGioiThieu" placeholder="Giới thiệu"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator2"  CssClass="mt-2 d-flex"  ControlToValidate="txtGioiThieu" runat="server" ErrorMessage="Không được bỏ trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="avatar">Ảnh đại diện:</label>
                    <asp:FileUpload ID="FileUploadAvatar" name="avatar" runat="server" />
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Nội dung:"></asp:Label>
                    <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator3" CssClass="mt-2 d-flex" ControlToValidate="txtContent" runat="server" ErrorMessage="Không được bỏ trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group d-flex align-center">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn px-5" Text="Thêm" OnClick="btnSubmit_Click"/>
                    <asp:HyperLink ID="HyperLink1" ForeColor="Black" CssClass="nav-link px-5 mt-1" NavigateUrl="/admin/tintuc/quanlytintuc" runat="server"><i class="bi bi-arrow-left-short"></i> Quay lại</asp:HyperLink>
                </div>
            </form>
        </div>
    </div>