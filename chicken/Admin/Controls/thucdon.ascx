<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="thucdon.ascx.cs" Inherits="chicken.Admin.Controls.thucdon" %>
<div class="col-lg-12">
    <div class="wrap-form">
        <div class="header-add text-center py-3">
            <h4><%=this.Title %></h4>
        </div>
        
            <div class="form-group">
                <asp:Label ID="Label1" CssClass="mb-2 d-flex" runat="server" Text="Tên món ăn"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Tên món ăn"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtName" ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" CssClass="mb-2 d-flex" runat="server" Text="Thể loại"></asp:Label>
                <asp:DropDownList ID="DropDownListCategory" CssClass="form-control" runat="server">
                </asp:DropDownList>
            </div>
            <div class="form-inline mt-5 d-flex justify-content-between;">
                <div class="form-group my-0" style="width:49%; margin-right:2%">
                <asp:Label ID="Label3" CssClass="mb-2 d-flex" runat="server" Text="Giá món ăn"></asp:Label>
                    <asp:TextBox ID="txtGia" runat="server" CssClass="form-control" placeholder="Giá món ăn" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtGia" ID="RequiredFieldValidator2" ForeColor="Red" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group my-0"style="width:49%;">
                <asp:Label ID="Label4" CssClass="mb-2 d-flex" runat="server" Text="Giảm giá (%)"></asp:Label>
                    <asp:TextBox ID="txtGiamGia" runat="server" CssClass="form-control" placeholder="Giảm giá (%)" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtGiamGia" ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                    
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" CssClass="mb-2 d-flex" runat="server" Text="Mô tả"></asp:Label>
                <asp:TextBox ID="txtMoTa" runat="server" CssClass="form-control" placeholder="Mô tả"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtMoTa" ID="RequiredFieldValidator4" ForeColor="Red" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" CssClass="mb-2 d-flex" runat="server" Text="Nội dung chi tiết"></asp:Label>
                <asp:TextBox ID="txtNoiDung" runat="server" TextMode="MultiLine"  placeholder="Nội dung"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtNoiDung" ID="RequiredFieldValidator5" ForeColor="Red" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="avatar">Ảnh đại diện</label>
                <asp:FileUpload ID="FileUpload" runat="server" />

            </div>
        <div class="form-group d-flex align-center">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn px-5" Text="Thêm" OnClick="btnSubmit_Click"/>
                    <asp:HyperLink ID="HyperLink1" ForeColor="Black" CssClass="nav-link px-5 mt-1" NavigateUrl="/admin/thucdon/quanlythucdon" runat="server"><i class="bi bi-arrow-left-short"></i> Quay lại</asp:HyperLink>
                </div>
    </div>
</div>