<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Site.Master" AutoEventWireup="true" CodeBehind="ThanhToan.aspx.cs" Inherits="chicken.GUI.ThanhToan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <section>
        <div class="wrap-container my-5">
            <form runat="server">
                <div class="row">
                    <div class="col-lg-1">
                    </div>
                    <div class="col-lg-6">
                        <div class="title mb-4">
                            <h2>Thông tin đặt hàng</h2>
                        </div>
                        <div class="form-group mb-3">
                            <asp:TextBox ID="txtTen" runat="server" CssClass="form-control py-3" placeholder="Tên của bạn"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="txtTen" CssClass="mt-2 d-flex" ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group my-3">
                            <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control py-3" TextMode="Number" placeholder="Số điện thoại"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="txtSDT" CssClass="mt-2 d-flex" ID="RequiredFieldValidator2" ForeColor="Red" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group my-3">
                            <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control py-3" placeholder="Địa chỉ nhận hàng"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="txtDiaChi" CssClass="mt-2 d-flex" ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ErrorMessage="Không được để trống"></asp:RequiredFieldValidator>
                        </div>
                        <div class="single-textarea">
                            <asp:TextBox ID="txtNote" runat="server" CssClass="form-control py-3" placeholder="Ghi chú đơn hàng" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="title mb-4">
                            <h2>Đơn hàng của bạn</h2>
                        </div>
                        <div class="cart mb-4 pb-4" style="border-bottom:1px solid #000">
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <div class="item d-flex justify-content-between">
                                        <h5><%# Eval("NAME") %> <span style="font-size:16px">x <%# Eval("QUANTITY") %> </span></h5>
                                        <h6><%# fromatMoney(Eval("PRICE").ToString()) %></h6>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                         <div class="total d-flex justify-content-between pb-4" style="border-bottom:1px solid #000">
                            <asp:Label ID="lbTotalNum" Font-Bold="true" Font-Size="16" runat="server" Text="Tổng"></asp:Label>
                            <asp:Label ID="lbTotal" CssClass="price" Font-Bold="true" Font-Size="16" runat="server" Text="300.000đ"></asp:Label>
                        </div>
                        <div class="form-group my-5">
                            <asp:HyperLink ID="HyperLink2" NavigateUrl="/thuc-don" BackColor="#ff9933" BorderColor="#ff9933" ForeColor="White" CssClass="me-3" style="padding:12px 25px" runat="server">Đặt thêm</asp:HyperLink>
                             <asp:Button ID="btnSubmit" BackColor="#ff9933" BorderColor="#ff9933" ForeColor="White" CssClass="py-2 px-4" runat="server" Text="Thanh toán" OnClick="btnSubmit_Click"/>
                        </div>
                    </div>
                    <div class="col-lg-1">
                    </div>
                </div>
        </form>
        </div>
    </section>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server"></asp:Panel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
