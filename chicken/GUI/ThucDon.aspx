<%@ Page Title="Thực đơn - Chicken" Language="C#" MasterPageFile="~/gui/Site.Master" AutoEventWireup="true" CodeBehind="ThucDon.aspx.cs" Inherits="chicken.ThucDon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
   <%-- <div class="back_image py-5" style="background-image:url(../Content/assets/imgs/back_4.jpg)">
        <div class="banner wrap-container">
            <div class="wrap-banner">
                <H2>Thực đơn</H2>
            </div>
        </div>
    </div>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
    <section class="list-menu">
        <asp:Panel ID="pnMenu" runat="server">
            <div class="wrap-container">
                <div class="special-tab" id="special-tab">
                    <ul class="sub-special">
                        <%=this.Categorys %>
                        <span class="present">
                        </span>
                    </ul>
                </div>
                <div class="wrap-tab"  id="tab-content">
                       <%=this.Menu %>
                </div>
            </div>
            </asp:Panel>
            <asp:Panel ID="pnSearch" runat="server">
            <div class="wrap-container">
                <div class="wrap-tab">
                    <div class="row">
                        <div class="col-lg-12 p-2">
                            <h4>Từ khóa tìm kiếm: <%=this.Search %></h4>
                        </div>
                        <%=this.MenuBySearch %>
                    </div>
                </div>
            </div>
        </asp:Panel>
        </section>
        </form>
        <div class="chef-section my-5">
            <div class="wrap-chef">
                <div class="header">
                    <div class="title">
                        <h3>Gặp gỡ đầu bếp của chúng tôi</h3>
                        <h1>Đầu bếp tốt nhất</h1>
                    </div>
                </div>
                <div class="main">
                    <div  class="container">
                        <div class="swiper-container mySwiper">
                            <div class="swiper-wrapper">
                              <div class="swiper-slide">
                                  <div class="item-chef">
                                      <div class="single-image">
                                        <img src="./Content/assets/imgs/chef-1.jpg" alt="">
                                      </div>
                                      <div class="name">
                                        <h4>Eric</h4>
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
                                        <h4>Albert</h4>
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
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
