<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Site.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="chicken.GUI.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
    <div class="banner wrap-container">
        <div class="wrap-banner">
            <H2>Giỏi hàng</H2>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
      <section class="cart">
            <div class="wrap-container">
                <div class="wrap-cart">
                    <form runat="server">
                        <div class="row my-5">
                        <div class="col-lg-1"></div>
                        <div class="col-lg-6">
                            <div class="title">
                                <h3>Giỏi hàng của bạn</h3>
                            </div>
                            <div class="list-foods">
                                <asp:ListView ID="ListView1" runat="server">
                                    <ItemTemplate>
                                        <div class="item-food">
                                    <div class="header">
                                        <div class="name-food">
                                            <h5><%#Eval("NAME") %></h5>
                                            <span>-</span>
                                            <span class="price"><%# Eval("PRICE") %></span>
                                        </div>
                                        <div class="delete-food">
                                            <asp:HyperLink ID="linkDeleteItem" ForeColor="Black"     NavigateUrl='<%# "/gio-hang?id=" + Eval("ID") %>' runat="server"><i class="bi bi-x-octagon"></i></asp:HyperLink>
                                        </div>
                                    </div>
                                    <div class="main">
                                    </div>
                                    <div class="footer">
                                        <div class="number quantity">
                                            <a href="javascript:void(0);" class="click-number"id="minus">
                                                <i class="bi bi-patch-minus"></i>
                                            </a>
                                            <asp:Label ID="lbNumber" runat="server" Text='<%#Eval("QUANTITY") %>'></asp:Label>
                                            
                                            <a href="javascript:void(0);" class="click-number" id="plus">
                                                <i class="bi bi-patch-plus"></i>
                                            </a>
                                            <asp:HiddenField ID="HiddenFieldQuantity" runat="server" Value="0"/>
                                        </div>
                                        <div class="total-item">
                                            <span><%#Eval("TOTAL") %></span>
                                        </div>
                                        <asp:HiddenField ID="HiddenFieldID" Value='<%#Eval("ID") %>' runat="server" />
                                    </div>
                                </div>
                                    </ItemTemplate>
                                    <EmptyDataTemplate>
                                        <h4>Giỏ hàng trống</h4>
                                    </EmptyDataTemplate>
                                </asp:ListView>
                            </div>
                            <asp:Panel ID="Panel2" runat="server">
                            <div class="total">
                                <asp:Label ID="lbTotalNum" runat="server"></asp:Label>
                                <asp:Label ID="lbTotal" CssClass="price" runat="server"></asp:Label>
                            </div>
                            <div class="update-cart">
                                <asp:Button ID="btnUpdateCart" BackColor="#121619" BorderColor="Transparent" ForeColor="White" runat="server" Text="Cập nhật giỏ hàng" OnClick="btnUpdateCart_Click" />
                            </div>
                           </asp:Panel>
                        </div>
                        <div class="col-lg-4">
                            <div class="pay">
                                <asp:Panel ID="Panel1" runat="server">
                                <div class="title">
                                    <asp:Label ID="lbTitleThanhToan" runat="server" Text="Thanh toán"></asp:Label>
                                </div>
                                <div class="total">
                                    <asp:Label ID="lbTotalNum2" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="lbTotal2" CssClass="price" runat="server" Text="Label"></asp:Label>
                                </div>
                                <div class="promo-code p-2" style="border-bottom:0">
                                </div>
                                    </asp:Panel>
                                <div class="btn-pay">
                                    <asp:HyperLink CssClass="btn-click" NavigateUrl="/thanh-toan" ID="linkThanhToan" runat="server">Tiến hành thanh toán</asp:HyperLink>
                                    <a href="/thuc-don" class="btn-click">Tiếp tục mua hàng</a>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-1"></div>
                    </div>
                    </form>
                </div>
            </div>
        </section>
    <script>
        const quantity = document.querySelectorAll(".quantity");
        quantity.forEach(e => {
            let num = e.children[1].innerHTML;
            e.children[3].value = num;
            e.children[0].addEventListener("click", () => {
                if (num > 0) num--;
                console.log(num);
                e.children[1].innerHTML = num;
                e.children[3].value = num;
            })
            e.children[2].addEventListener("click", () => {
                num++;
                console.log(num);
                e.children[1].innerHTML = num;
                e.children[3].value = num;
            })
        })
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
