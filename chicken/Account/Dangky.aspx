<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangky.aspx.cs" Inherits="chicken.Account.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/assets/css/bootstrap.css" rel="stylesheet" />
    <link href="../Content/assets/css/bootstrap-icons.css" rel="stylesheet" />
    <link href="../Content/assets/css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="page_signup">
                <div class="wrap">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="single-image">
                                <img src="../Content/assets/imgs/welcome-2.jpg" alt="Background">
                            </div>
                        </div>
                        <div class="col-lg-6 d-flex justify-content-center align-items-center">
                            <div class="form-group" style="width:100%">
                                <div class="single-image text-center mb-5">
                                    <img style="width:280px" src="../Content/assets/imgs/1x/logo-black.png" alt="Alternate Text" />
                                </div>
                                <asp:MultiView ID="MultiView" runat="server">
                                    <asp:View ID="ViewAccount" runat="server">
                                        <div class="single-input">
                                            <asp:TextBox ID="txtUsername" runat="server" placeholder="Tên đăng nhập"></asp:TextBox>
                                            <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtUsername" ID="RequiredFieldValidatorUsername" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                                        </div>
                                        <div class="single-input">
                                        <asp:TextBox ID="txtPassword1" runat="server" placeholder="Mật khẩu"></asp:TextBox>
                                         <asp:RequiredFieldValidator ForeColor="Red"  ControlToValidate="txtPassword1" ID="RequiredFieldValidatorPass1" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="single-input">
                                        <asp:TextBox ID="txtPassword2" runat="server" placeholder="Nhập lại mật khẩu"></asp:TextBox>
                                         <asp:RequiredFieldValidator ForeColor="Red"  ControlToValidate="txtPassword2" ID="RequiredFieldValidatorPass2" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                                        <br />
                                        <asp:CompareValidator ForeColor="Red"  ID="CompareValidator1" ControlToValidate="txtPassword1" ControlToCompare="txtPassword2" runat="server" ErrorMessage="Mật khẩu không trùng khớp. Vui lòng nhập lại"></asp:CompareValidator>
                                        <br />
                                        <asp:RegularExpressionValidator 
                                         ForeColor="Red" 
                                         Display="Dynamic"
			                            ID="RegularExpressionValidator12"
			                            runat="server" 
			                            ErrorMessage="Độ dài phải từ 6 đến 20 kí tự"
			                            ControlToValidate="txtPassword1" 
			                            ValidationExpression=".{6,20}"></asp:RegularExpressionValidator>
                                    </div>
                                    <div class="single-input mt-5 fbetween">
                                        <asp:Button ID="btnNext" BackColor="Black" runat="server" Text="Tiếp" OnClick="btnNext_Click"/>
                                        <a href="/Account/Dangnhap">Đăng nhập <i class="bi bi-arrow-right"></i></a>
                                    </div>
                                    </asp:View>
                                    <asp:View ID="ViewInfor" runat="server">
                                    <div class="single-input">
                                            <asp:TextBox ID="txtName" runat="server" placeholder="Họ tên"></asp:TextBox>
                                        <asp:RequiredFieldValidator ForeColor="Red"  ControlToValidate="txtName" ID="RequiredFieldValidatorName" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="single-input">
                                        <asp:TextBox ID="txtSDT" runat="server" placeholder="Số điện thoại"></asp:TextBox>
                                        <asp:RequiredFieldValidator ForeColor="Red"  ControlToValidate="txtSDT" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                                    <div class="single-input">
                                        <asp:TextBox ID="txtDiaChi" runat="server" placeholder="Địa chỉ"></asp:TextBox>
                                        <asp:RequiredFieldValidator ForeColor="Red"  ControlToValidate="txtDiaChi" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="single-input">
                                        <asp:TextBox ID="txtNgaySinh" runat="server" TextMode="Date" placeholder="Địa chỉ"></asp:TextBox>
                                        <asp:RequiredFieldValidator ForeColor="Red"  ControlToValidate="txtNgaySinh" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="single-select">
                                        <asp:DropDownList ID="DropDownListSex" runat="server">
                                            <asp:ListItem Value="0" Text="Nam" />
                                            <asp:ListItem Value="1" Text="Nữ" />
                                            <asp:ListItem Value="2" Text="Khác" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="single-input mt-5 fbetween">
                                        <asp:Button ID="btnPre" BackColor="Black"  runat="server" Text="Quay lại" OnClick="btnPre_Click"/>
                                        <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" OnClick="btnDangKy_Click" />
                                        <a href="/Account/Dangnhap">Đăng nhập <i class="bi bi-arrow-right"></i></a>
                                    </div>
                                    </asp:View>
                                </asp:MultiView>
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
