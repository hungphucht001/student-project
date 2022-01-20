<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaiKhoan.ascx.cs" Inherits="chicken.Controls.TaiKhoan" %>
<asp:MultiView ID="MultiView1" runat="server">
    <asp:View ID="View1" runat="server">
        <table class="table table-hover table-borderless">
    <tbody>
      <tr>
        <th>Tên:</th>
        <td>Trần Hòa Thuận</td>
      </tr>
       <tr>
        <th>Ngày sinh:</th>
        <td>2001/03/03</td>
      </tr>
       <tr>
        <th>Giới tính:</th>
        <td>Nam</td>
      </tr>
       <tr>
        <th>Địa chỉ:</th>
        <td>TP HCM</td>
      </tr>
       <tr>
        <th>Số điên thoại:</th>
        <td>0961078372</td>
      </tr>
        <tr>
        <th>Tên đăng nhập:</th>
        <td>thuan001</td>
      </tr>
    </tbody>
  </table>
        <div>
            <asp:LinkButton ID="LinkBtnEdit" OnClick="LinkBtnEdit_Click" ForeColor="Blue" CssClass="px-2" BorderWidth="0" BackColor="Transparent" runat="server">Đổi mật khẩu</asp:LinkButton>
        </div>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <div class="col-lg-6">
        <div class="wrap-form">
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Mật khẩu cũ:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtOldPassword" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="txtOldPassword" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Nhập mật khẩu mới:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtNewPassword" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="txtNewPassword" CssClass="mt-2 d-block" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                 <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Nhập lại mật khẩu:" CssClass="mb-1 d-flex"></asp:Label>
                    <asp:TextBox ID="txtNewPassword2" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator3" ForeColor="Red" ControlToValidate="txtNewPassword2" CssClass="mt-2" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                     <br />
                     <asp:CompareValidator ForeColor="Red" Display="Dynamic" ID="CompareValidator1" ControlToValidate="txtNewPassword" ControlToCompare="txtNewPassword2" runat="server" ErrorMessage="Mật khẩu không trùng khớp. Vui lòng nhập lại"></asp:CompareValidator>
                 </div>
                <div class="form-group mt-2 mb-4">
                    <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" CssClass="px-5 py-1" Text="Lưu" runat="server" />
                </div>
            <asp:Label ID="lbMessage" runat="server"></asp:Label>
        </div>
    </div>
    </asp:View>
</asp:MultiView>