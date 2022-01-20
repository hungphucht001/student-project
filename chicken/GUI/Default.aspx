<%@ Page Title="" Language="C#" MasterPageFile="~/gui/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="chicken.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
    <div class="back_image pt-5" style="background-image:url(../Content/assets/imgs/back_3.jpg)">
    <div class="banner wrap-container pt-5">
        <div class="wrap-banner">
            <div class="row">
                <div class="col-lg-6 col-md-6" data-aos="fade-down-left" data-aos-duration="1500">
                    <%--<img src="./Content/assets/imgs/garan-banner.png" alt="">--%>
                </div>
                <div class="col-lg-6 col-md-6" style="text-align:right" data-aos="fade-up-right" data-aos-duration="1500">
                    <h2>
                        <span>
                            CH<span class="cl">Ấ</span>T <br> L<span class="cl">ƯỢ</span>NG
                        </span>
                        <span>
                            MÓN <span class="cl">Ă</span>N
                        </span>
                    </h2>
                </div>
                
            </div>
        </div>
    </div>
        <div class="back_image py-5" style="background-image:url(../Content/assets/imgs/menu-bottom-bg.png)"></div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <form ID="formEmail" runat="server">
    <div class="order-section">
            <div class="top">
                <img src="./Content/assets/imgs/order-top.png" alt="">
            </div>
            <div class="center">
               <div class="wrap-container">
                <div class="row">
                    <div class="col-lg-4 col-md-4 " data-aos="flip-up"  data-aos-duration="1000">
                        <div class="item-order">
                            <div class="icon">
                                <i class="fas fa-utensils"></i>
                            </div>
                            <div class="introduce">
                                <h3 class="title">Đặt hàng</h3>
                                <p>Nhấc điện thoại của bạn lên. Truy cập vào Chicken và chọn món ăn ngay</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4" data-aos="flip-up"  data-aos-duration="1000">
                        <div class="item-order">
                            <div class="icon">
                                <i class="fas fa-truck"></i>
                            </div>
                            <div class="introduce">
                                <h3 class="title">Giao hàng</h3>
                                <p>Chỉ với 2 bước đơn giản bạn đã đặt hàng thành công. Nhân viên sẽ liên hệ bạn ngay</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4" data-aos="flip-up" data-aos-duration="1000">
                        <div class="item-order">
                            <div class="icon">
                                <i class="fas fa-drumstick-bite"></i>
                            </div>
                            <div class="introduce">
                                <h3 class="title">Thưởng thức</h3>
                                <p>Sau khi đặt hàng thành công bạn chỉ cần chờ đợi cuộc gọi từ nhân viên giao hàng và thưởng thức.</p>
                            </div>
                        </div>
                    </div>
                </div>
               </div>
            </div>
            <div class="bottom">
                <img src="./Content/assets/imgs/order-bottom.png" alt="">
            </div>
        </div>
        <div class="speciality-section my-5">
            <div class="header">
                <div class="title">
                    <h3>Thơm ngon từ chicken</h3>
                    <h1>Đặc sản của chúng tôi</h1>
                </div>
            </div>
            <div class="main">
                <div class="wrap-container">
                    <div class="row">
                        <asp:Repeater ID="RepRandDish" runat="server">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-4">
                                    <div class="item-speciality">
                                        <div class="single-image">
                                            <img src="<%#Eval("AVATAR") %>" alt="">
                                        </div>
                                        <div class="title-speciality">
                                            <a href="<%# "/san-pham/"+Eval("TENKHONGGIAU")+"/"+Eval("ID_PRODUCTS") %>">
                                                <h5><%#Eval("TENSP") %></h5>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
            <div class="bottom">
                <a href="/thuc-don" class="btn-click">Xem thêm</a>
            </div>
        </div>
        <div class="menu-section my-5">
            <div class="top-back">
                <img src="./Content/assets/imgs/menu-top-bg.png" alt="">
            </div>
            <div class="header">
                <div class="title">
                    <h3>Thơm ngon từ chicken</h3>
                    <h1>Thực đơn đặc biệt của chúng tôi</h1>
                </div>
            </div>
            <div class="main">
                <div class="special-tab" id="special-tab">
                    <ul class="sub-special">
                        <%=this.Categorys %>
                        <span class="present">
                        </span>
                    </ul>
                </div>
                <div class="wrap-container">
                    <div class="tab" id="tab-content">
                        <%=this.Menu %>
                    </div>
                </div>
            </div>
            <div class="bottom-back">
                <img src="./Content/assets/imgs/menu-bottom-bg.png" alt="">
            </div>
        </div>
        <div class="online-order">
            <div class="wrap-container">
                <div class="row">
                    <div class="col-lg-6 col-md-6">
                        <div class="box-order">
                            <div class="header">
                                <div class="title">
                                    <h3>Thơm ngon từ chicken</h3>
                                    <h1>Đặt hàng ngay</h1>
                                </div>
                            </div>
                            <div class="describe">
                                <p>Chỉ 1 click bạn sẽ được kết nối với nhân viên bên chúng tôi để được đặt hàng trực tiếp</p>
                            </div>
                            <div class="phone-contact">
                                <div class="wrap">
                                    <i class="fas fa-blender-phone"></i>
                                    <span>+19001602</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6">
                        <div class="single-image">
                            <img src="./Content/assets/imgs/order-online.png" alt="">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="receive-section mt-5">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="box-receive">
                            <div class="header">
                                <div class="title">
                                    <h3>Nhận tin tức về món ăn mới</h3>
                                    <p>Nhập email của bạn ngay nào</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-12">
                       
                           <div class="center">
                                <div class="form-group">
                                <div class="single-input">
                                    <asp:TextBox ID="emailRegistra" runat="server" TextMode="Email" placeholder="Nhập email"></asp:TextBox>
                                </div>
                                <div class="single-button">
                                    <asp:Button ID="Button1" runat="server" Text="Gửi" CssClass="btn-submit" OnClick="Button1_Click"/>
                                </div>
                            </div>
                           </div>
                           <div class="notification-form">
                               <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="emailRegistra" runat="server" ErrorMessage="Phải nhập nội dung" ForeColor="red"></asp:RequiredFieldValidator>
                               <asp:RegularExpressionValidator ID="revEmail" ForeColor="red" runat="server" ErrorMessage="Định dạng email không đúng" ControlToValidate="emailRegistra" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                               <asp:Label ForeColor="White" ID="Label1" runat="server"></asp:Label>
                           </div>
                       
                    </div>
                </div>
            </div>
        </div>
        <div class="chef-section my-5">
            <div class="wrap-chef">
                <div class="header">
                    <div class="title">
                        <h3>Gặp gỡ đầu bếp của chúng tôi</h3>
                        <h1>Đầu bếp tốt nhất</h1>
                    </div>
                </div>
                <div class="main">
                    <div class="container">
                        <div class="swiper-container mySwiper">
                            <div class="swiper-wrapper">
                              <div class="swiper-slide">
                                  <div class="item-chef">
                                      <div class="single-image">
                                        <img src="./Content/assets/imgs/chef-1.jpg" alt="">
                                      </div>
                                      <div class="name">
                                        <h4>Frederick</h4>
                                      </div>
                                  </div>
                              </div>
                              <div class="swiper-slide">
                                  <div class="item-chef">
                                      <div class="single-image">
                                        <img src="./Content/assets/imgs/chef-2.jpg" alt="">
                                      </div>
                                      <div class="name">
                                        <h4>Stephen</h4>
                                      </div>
                                  </div>
                              </div>
                              <div class="swiper-slide">
                                  <div class="item-chef">
                                      <div class="single-image">
                                        <img src="./Content/assets/imgs/chef-3.jpg" alt="">
                                      </div>
                                      <div class="name">
                                        <h4>Robert</h4>
                                      </div>
                                  </div>
                              </div>
                              <div class="swiper-slide">
                                <div class="item-chef">
                                    <div class="single-image">
                                      <img src="./Content/assets/imgs/chef-4.jpg" alt="">
                                    </div>
                                    <div class="name">
                                      <h4>Maximus</h4>
                                    </div>
                                </div>
                            </div>
                            </div>
                            <div class="swiper-button-next"></div>
                            <div class="swiper-button-prev"></div>
                          </div>
                    </div>
                </div>
            </div>
             </form>
        </div>
</asp:Content>
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        var swiper = new Swiper(".mySwiper", {
            breakpoints: {
          320: {
            slidesPerView: 1,
            spaceBetween: 10,
          },
          425: {
            slidesPerView: 1,
            spaceBetween: 20,
          },
          768: {
            slidesPerView: 3,
            spaceBetween: 20,
          },
          1024: {
            slidesPerView: 4,
            spaceBetween: 20,
          },
          2024: {
            slidesPerView: 4,
            spaceBetween: 20,
          },
        },
          autoplay: {
          delay: 2500,
          disableOnInteraction: false,
            },
          navigation: {
          nextEl: ".swiper-button-next",
          prevEl: ".swiper-button-prev",
        },
        });
      </script>
      <script>
        AOS.init();
      </script>
</asp:Content>

