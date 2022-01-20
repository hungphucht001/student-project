<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="chicken.Admin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chicken | Đăng nhập</title>
    <webopt:BundleReference runat="server" Path="~/Content/css/bootstrap" />
    <style>
        .wrapper{
            width:100vw;
            height:100vh;
            display:flex;
            justify-content:center;
            align-items:center;
            background-image:url("../Content/assets/imgs/back_ad.jpg");
            background-position:bottom;
            background-size:cover;
            background-repeat:no-repeat;
        }
        .box-login{
            width: 440px;
            padding: 20px 40px;
            border-radius:10px;
            background-color:#fff;
            box-shadow:0 0 7px 0 #ccc;
        }
        .box-login input:focus{
            box-shadow:none;
            border:1px solid #000;
        }
    </style>
</head>
<body>
    <%
        if(Session["HUAOJATQQ"] == null)
            {
    %>
    <div class="wrapper">
        <div class="box-login">
            <div class="title text-center mb-5 mt-3">
                <h3>Quản trị admin</h3>
            </div>
            <form id="form1" runat="server">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Tên đăng nhập: "></asp:Label>
                    <asp:TextBox ID="txtUsername" CssClass="form-control mt-2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="txtUsername" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group mt-1">
                    <asp:Label ID="Label2" runat="server" Text="Mật khẩu: "></asp:Label>
                    <asp:TextBox ID="txtPassword" CssClass="form-control mt-2" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="txtPassword" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group text-center mb-3 mt-4">
                    <asp:Button ID="btnDangKy" Width="100%" runat="server" CssClass="btn btn-warning " Text="Đăng nhập" OnClick="btnDangKy_Click" />
                </div>
                <asp:Label ID="lbMessage" runat="server" />
        </form>
            <div class="footer mt-3">
                <p>Mọi chi tiết xin vui lòng liên hệ: <span class="text-warning">19001602</span></p>
            </div>
        </div>
    </div>
    <%
        }
        else
        {
            Response.Redirect("/admin/dashboard");
        }
    %>
</body>
</html>
