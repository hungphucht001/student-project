<%@ Page Title="" EnableEventValidation="true" Language="C#" MasterPageFile="~/gui/Site.Master" AutoEventWireup="true" CodeBehind="Chitietsanpham.aspx.cs" Inherits="chicken.Chitietsanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
    <div class="product-details">
            <div class="wrap-container">
                <asp:ListView ID="ListView1" runat="server">
                    <ItemTemplate>
                  <div class="row">
                    <div class="col-lg-5">
                        <div class="single-image">
                            <asp:Image ID="imgAvatar" ImageUrl='<%# "../"+Eval("AVATAR")%>' runat="server" />
                        </div> 
                    </div>
                    <div class="col-lg-7">
                        <div class="site-details">
                            <div class="title">
                                <h2>
                                    <asp:Label ID="lbName" runat="server" Text='<%#Eval("TENSP")%>'></asp:Label>
                                </h2>
                            </div>
                            <div class="price">
                                <asp:Label ID="lbPrice" runat="server" CssClass="primary" Text='<%#Eval("GIA")%>'></asp:Label>
                                <asp:Label ID="lbSale" runat="server" CssClass="sale"></asp:Label>
                            </div>
                            <div class="introduce">
                                <p><%#Eval("MOTA") %></p>
                            </div>
                            <div class="follow">
                                <h5>Theo dõi chúng tôi: </h5>
                                <div class="icons">
                                    <div class="icon">
                                        <a href="#"><i class="bi bi-facebook"></i></a>
                                    </div>
                                    <div class="icon">
                                        <a href="#"><i class="bi bi-instagram"></i></a>
                                    </div>
                                    <div class="icon">
                                        <a href="#"><i class="bi bi-facebook"></i></a>
                                    </div>
                                    <div class="icon">
                                        <a href="#"><i class="bi bi-instagram"></i></a>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="number">
                                    <div class="single-input">
                                        <asp:TextBox ID="txtQuantity" runat="server" Text="1" TextMode="Number" min="0" max="50"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="single-button">
                                    <asp:Button ID="Button1" BackColor="#ff9933" BorderColor="#ff9933" ForeColor="White" runat="server" OnClick="Button1_Click" Text="Thêm vào giỏ hàng" />
                                    
                                </div>
                            </div>
                            <hr>
                            <div class="search">
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-12">
                        <div class="tab p-0">
                            <ul class="nav">
                                <li class="nav-item">
                                  <a class="nav-link active" data-toggle="tab" href="#describe">Describe</a>
                                </li>
                              </ul>
                        </div>
                       
                          <!-- Tab panes -->
                          <div class="tab-content">
                            <div id="describe" class=" tab-pane active"><br>
                              <p><%#Eval("NOIDUNG") %></p>
                            </div>
                        </div>
                    </div>
                   </div>
                    </ItemTemplate>
                     </asp:ListView>
                <asp:Label ID="lbMessage" runat="server"></asp:Label>
                     <div class="row">
                    <div class="col-md-12 mt-5">
                        <div class="header">
                            <div class="title">
                                <h3>Thơm ngon từ chicken</h3>
                                <h1>Thực đơn liên quan</h1>
                            </div>
                        </div>
                        <div class="foods my-5">
                            <div class="row">
                                <asp:Repeater ID="RepeaterMenuByCategory" runat="server">
                                    <ItemTemplate>
                                        <div class="col-lg-3 col-md-6">
                                            <div class="item-food">
                                                <div class="single-image">
                                                    <a href="<%# "/"+Eval("TENKHONGGIAU")+"/"+Eval("ID_PRODUCTS") %>"><img src="../../<%#Eval("AVATAR") %>"></a>
                                                    <div class="price">
                                                        <asp:Label ID="lbPrice" runat="server" ForeColor="#e3e3e3" style="text-decoration:line-through" CssClass="primary"></asp:Label>
                                                        <asp:Label ID="lbSale" runat="server" ></asp:Label>
                                                    </div>
                                                    <asp:Panel ID="pnSale" CssClass="sale" runat="server">
                                                        <svg width= 70 viewBox="0 0 100 80"><image y="1" width="99" height="79" xlink:href="../../Content/assets/imgs/sale-img.png"/>
                                                            <text id="_50_" data-name="50%" class="cls-1" transform="translate(26.444 55.814) scale(0.418 0.418)"><%#Eval("SALE") %>%</text></svg>
                                                    </asp:Panel>
                                                    </div>
                                                <div class="article">
                                                    <h4 class="title">
                                                        <a href="<%# "/san-pham/"+Eval("TENKHONGGIAU")+"/"+Eval("ID_PRODUCTS") %>"><%#Eval("TENSP") %></a>
                                                    </h4>
                                                    <p class="introduction">
                                                        <%#Eval("MOTA") %>
                                                    </p>
                                                    <h5 class="order"><a href="<%# "/san-pham/"+Eval("TENKHONGGIAU")+"/"+Eval("ID_PRODUCTS") %>">Đặt hàng</a></h5>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </div>
        </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <script>
        var swiper = new Swiper(".mySwiper", {
          loop: true,
          spaceBetween: 10,
          slidesPerView: 4,
          freeMode: true,
          watchSlidesVisibility: true,
          watchSlidesProgress: true,
        });
        var swiper2 = new Swiper(".mySwiper2", {
          loop: true,
          spaceBetween: 10,
          navigation: {
            nextEl: ".swiper-button-next",
            prevEl: ".swiper-button-prev",
          },
          autoplay: {
          delay: 2500,
            },
          thumbs: {
            swiper: swiper,
          },
        });
    </script>
</asp:Content>
