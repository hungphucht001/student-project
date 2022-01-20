<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="chicken.Account.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/assets/css/bootstrap.css" rel="stylesheet" />
    <link href="../Content/assets/css/bootstrap-icons.css" rel="stylesheet" />
    <link href="../Content/assets/css/swiper-bundle.css" rel="stylesheet" />
    <link href="../Content/assets/css/login.css" rel="stylesheet" />

</head>
<body>
            <%
            if(Session["name"] != null){
                %>
                <div style="text-align:center;">
                    <h2>Bạn đã đăng nhập trước đó</h2>
                    <a href="/">Quay lại trang chủ</a>
                </div>
            <%
            }
            else
            {
            %>
            <form id="fLogin" runat="server">
          <div class="wrapper">
            <div class="wrapper">
            <section class="page-login">
                <div class="wrap container">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <div class="text-center">
                                    <div class="site-logo">
                                        <a href="/">
                                            <img src="../Content/assets/imgs/1x/logo-black.png" style="width: 300px; alt="Alternate Text" />
                                        </a>
                                    </div>
                                </div>
                                    <div class="single-input mt-5 mb-3">
                                        <asp:TextBox ID="txtUsername" runat="server" placeholder="Tên đăng nhập"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="mt-2" ForeColor="Red" ControlToValidate="txtUsername" runat="server" style="display:inline-block"  ErrorMessage="Phải nhập tài khoản"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="single-input my-1">
                                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Mật khẩu"></asp:TextBox>
                                        <div class="show-pass" id="show-pass">
                                            <i class="bi bi-eye"></i>
                                        </div>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="mt-2 pe-5" ForeColor="Red" ControlToValidate="txtPassword" runat="server" style="display:inline-block" ErrorMessage="Phải nhập mật khẩu"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="single-input mt-3">
                                        <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" OnClick="btnLogin_Click" />
                                    </div>
                                    <p style="color:red"> <%=this.Message %></p>
                                <div>
                                    <span>Chưa có tài khoản <a href="/dang-ky">đăng ký</a></span>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 pe-0">
                            <div class="swiper-container" style="height:100%">
                                <div class="swiper-wrapper" style="height:100%">
                                  <div class="swiper-slide" style="height:100%; width:100%">
                                      <div class="single_image">
                                            <img src="../Content/assets/imgs/g1.jfif" alt=""> 
                                    </div>
                                  </div>
                                  <div class="swiper-slide " style="height:100%">
                                      <div class="single_image">
                                            <img src="../Content/assets/imgs/g2.jfif" alt=""> 
                                    </div>
                                  </div>
                                  <div class="swiper-slide" style="height:100%">
                                     <div class="single_image">
                                            <img src="../Content/assets/imgs/g3.jfif" alt=""> 
                                    </div>
                                </div>
                                    <div class="swiper-slide" style="height:100%">
                                      <div class="single_image">
                                            <img src="../Content/assets/imgs/g4.jfif" alt=""> 
                                    </div>
                                  </div>
                              </div>
                        </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>

            </form>
            <%
            }
        %>
    <script src="../Scripts/WebForms/swiper-bundle.min.js"></script>
    <script>
            var swiper = new Swiper('.swiper-container', {
                pagination: {
                    el: '.swiper-pagination',
                    dynamicBullets: true,
                },
                autoplay: {
                    delay: 10000,
                },
            });
        const $ = document.querySelector.bind(document)
        const $$ = document.querySelectorAll.bind(document)

        const show_pass = $("#show-pass i"),
            password = $("#txtPassword");
        if (show_pass) {
            show_pass.onclick = () => {
                if (password.type == "password") {
                    show_pass.classList.remove("bi-eye");
                    show_pass.classList.add("bi-eye-slash");
                    password.type = "text";
                }
                else {
                    password.type = "password";
                    show_pass.classList.add("bi-eye");
                    show_pass.classList.remove("bi-eye-slash");
                }
            }
        }
    </script>
</body>
</html>
