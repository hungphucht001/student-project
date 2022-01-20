<%@ Page Title="Liên hệ - Chicken" Language="C#" MasterPageFile="~/gui/Site.Master" AutoEventWireup="true" CodeBehind="LienHe.aspx.cs" Inherits="chicken.LienHe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
     <div class="contact-section ">
            <div class="wrap-container">
                <div class="header mt-5">
                    <div class="title">
                        <h3>Liên hệ</h3>
                        <h1>Liên hệ với chúng tôi</h1>
                    </div>
                </div>
                <div class="main my-5">
                    <div class="row">
                        <div class="col-lg-5">
                            <div class="title">
                                <h2>Chi tiết liên hệ</h2>
                                <p>There are many variations of passages of Lorem Ipsum available,
                                     but the majority have suffered alteration in some form, by injected humour,
                                     or randomised words which don't look even slightly believable.
                                </p>
                            </div>
                            <div class="list-contact">
                                <ul>
                                    <li>
                                        <a href="#">
                                            <i class="bi bi-house-door"></i>
                                            <span>140 Lê Trọng Tấn, phường Tây Thạnh, quận Tân Phú, thành phố Hồ Chí Minh</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="bi bi-telephone"></i>
                                            <span>19001602</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="bi bi-envelope"></i>
                                            <span>contact@chicken.com</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="bi bi-clock"></i>
                                            <span>
                                                <span>Từ thứ 2 đến thứ thứ 7 hàng tuần (8h30 - 21h)</span>
                                                <br>
                                                <span>Chủ nhật: 8h30 - 12h30</span>
                                            </span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class="col-lg-7">
                            <form runat="server">
                                <div class="form-group">
                                    <div class="single-input mb-2">
                                        <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Tên của bạn"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="single-input mb-2">
                                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email" placeholder="Email của bạn"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtEmail" runat="server" ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <br />
                                        <asp:RegularExpressionValidator ID="revEmail" ForeColor="red" runat="server" Display="Dynamic" ErrorMessage="Định dạng email không đúng" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                    </div>
                                    <div class="single-input mb-2">
                                        <asp:TextBox ID="txtSDT" runat="server" class="form-control" placeholder="Số điện thoại của bạn"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtSDT" runat="server" ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="single-textarea mb-2">
                                        <asp:TextBox ID="txtContent" runat="server" class="form-control" placeholder="Nội dung" TextMode="MultiLine" rows="3"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtContent" runat="server" ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                    <asp:Label ID="lbMessage" CssClass="mb-2 d-flex" runat="server"></asp:Label>
                                    <div class="single-input">
                                        <asp:Button ID="btnSubmit" runat="server" Text="Gửi" class="form-control" OnClick="btnSubmit_Click"/>
                                    </div>
                                </div>
                            </form>
                        </div>
                        <div class="col-md-12 mt-5">
                            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d9627.07631140892!2d-74.66681299285774!3d40.71792379925937!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c397451dacecc1%3A0xb65da6dde85c0eed!2sGladstone%2C%20New%20Jersey%2C%20Hoa%20K%E1%BB%B3!5e0!3m2!1svi!2s!4v1625818611043!5m2!1svi!2s"height="450" style="border:0;width: 100%;" allowfullscreen="" loading="lazy"></iframe>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
