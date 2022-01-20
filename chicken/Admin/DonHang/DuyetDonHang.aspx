<%@ Page Title="Chicken | Duyệt đơn hàng" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="DuyetDonHang.aspx.cs" Inherits="chicken.Admin.DonHang.ThemDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-lg-12">
        <span class="title-page">Thực đơn / Duyệt đơn hàng</span>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="box-number">
            <div class="title">
                <span>
                    Tổng số đơn hàng chưa duyệt
                </span>
            </div>
            <div class="number">
                <span>
                    <asp:Label ID="lbTotal" runat="server" Text="Label"></asp:Label>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="wrap-table p-4">
            <form runat="server">
            <div class="header-table">
                <div class="title">
                    <h5>Đơn hàng chưa được duyệt</h5>
                </div>
                <div class="search">
                    <div class="form-group">
                        <div class="single-input">
                            <asp:TextBox ID="txtSearch" placeholder="Tìm kiếm" runat="server"></asp:TextBox>
                        </div>
                        <div class="single-button">
                            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Tìm" />
                        </div>
                    </div>
                </div>
            </div>
            <asp:GridView ID="GridView1" AutoGenerateColumns="false" CssClass="table table-dark table-striped"  runat="server">
                <Columns>
                    <asp:BoundField DataField="ID_ORDER" HeaderText="Id" />
                    <asp:BoundField DataField="HOTEN" HeaderText="Tên" />
                    <asp:BoundField DataField="SDT" HeaderText="SDT" />
                    <asp:BoundField DataField="DIACHI" HeaderText="Địa chỉ" />
                    <asp:BoundField DataField="NGAYMUA" HeaderText="Ngay mua" />
                    <asp:BoundField DataField="Gia" HeaderText="Giá" />
                    <asp:BoundField DataField="STATUS" HeaderText="Trạng thái" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "/admin/donhang/duyetdonhang?duyet_id="+ Eval("ID_ORDER") %>' runat="server">Duyệt</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" onclick="return confirm('Bạn có chắc muôn xóa không?')" NavigateUrl='<%# "/admin/donhang/xoadonhang?id=" + Eval("ID_ORDER") %>' runat="server"><i class="bi bi-archive"></i></asp:HyperLink>
                            <asp:HyperLink ID="HyperLink3" runat="server"><i class="bi bi-pencil-square"></i></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <h6>Chưa có đơn hàng nào</h6>
                </EmptyDataTemplate>
            </asp:GridView>
                <div class="wrap-pagination">
                <ul class="pagination justify-content-end">
                    <%=this.Pag %>
                    </ul>
                </div>
                </form>
        </div>
    </div>
</asp:Content>
