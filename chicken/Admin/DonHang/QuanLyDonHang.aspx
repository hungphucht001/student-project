    <%@ Page Title="Chicken | Quản lý đơn hàng" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="QuanLyDonHang.aspx.cs" Inherits="chicken.Admin.DonHang.QuanLyDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
          <asp:ScriptManager ID="ScriptManager2" runat="server" EnableCdn="true"></asp:ScriptManager>
        <div class="row">
    <div class="col-lg-12">
        <span class="title-page">Thực đơn / Quản lý đơn hàng</span>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="box-number">
            <div class="title">
                <span>
                    Tổng số đơn hàng
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
            <div class="header-table">
                <div class="title">
                    <h5>Đơn hàng chờ xét duyệt</h5>
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" OnTick="Timer1_Tick" Interval="1000" runat="server"></asp:Timer>
                <asp:GridView ID="GridViewPending" AutoGenerateColumns="false" CssClass="table table-dark table-striped"  runat="server">
                <Columns>
                    <asp:BoundField DataField="ID_ORDER" HeaderText="Id" />
                    <asp:BoundField DataField="HOTEN" HeaderText="Tên" />
                    <asp:BoundField DataField="SDT" HeaderText="SDT" />
                    <asp:BoundField DataField="DIACHI" HeaderText="Địa chỉ" />
                    <asp:BoundField DataField="NGAYMUA" HeaderText="Ngay mua" />
                    <asp:BoundField DataField="Gia" HeaderText="Giá" />
                    <asp:BoundField DataField="STATUS" HeaderText="Trạng thái" />
                    <asp:TemplateField HeaderText="Tác vụ">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink2" onclick="return confirm('Bạn có chắc muôn xóa đơn hàng này không không?')" NavigateUrl='<%# "/admin/donhang/xoadonhang?id=" + Eval("ID_ORDER") %>' runat="server"><i class="bi bi-archive"></i></asp:HyperLink>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "/admin/donhang/quanlydonhang?dpending_id=" +Eval("ID_ORDER") %>' runat="server">Duyệt</asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <h6>Chưa có đơn hàng nào</h6>
                </EmptyDataTemplate>
            </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="wrap-table p-4">
            <div class="header-table">
                <div class="title">
                    <h5>Đơn hàng đang làm</h5>
                </div>
            </div>
            <asp:GridView ID="GridViewDoing" AutoGenerateColumns="false" CssClass="table table-dark table-striped"  runat="server">
                <Columns>
                    <asp:BoundField DataField="ID_ORDER" HeaderText="Id" />
                    <asp:BoundField DataField="HOTEN" HeaderText="Tên" />
                    <asp:BoundField DataField="SDT" HeaderText="SDT" />
                    <asp:BoundField DataField="DIACHI" HeaderText="Địa chỉ" />
                    <asp:BoundField DataField="NGAYMUA" HeaderText="Ngay mua" />
                    <asp:BoundField DataField="Gia" HeaderText="Giá" />
                    <asp:BoundField DataField="STATUS" HeaderText="Trạng thái" />
                    <asp:TemplateField HeaderText="Tác vụ">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "/admin/donhang/quanlydonhang?ddonging_id=" +Eval("ID_ORDER") %>' runat="server">Duyệt</asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <h6>Chưa có đơn hàng nào</h6>
                </EmptyDataTemplate>
            </asp:GridView>
            </div>
        </div>
             <div class="col-lg-12 mt-5">
        <div class="wrap-table p-4">
            <div class="header-table">
                <div class="title">
                    <h5>Đơn hàng đang vận chuyển</h5>
                </div>
            </div>
            <asp:GridView ID="GridViewTransported" AutoGenerateColumns="false" CssClass="table table-dark table-striped"  runat="server">
                <Columns>
                    <asp:BoundField DataField="ID_ORDER" HeaderText="Id" />
                    <asp:BoundField DataField="HOTEN" HeaderText="Tên" />
                    <asp:BoundField DataField="SDT" HeaderText="SDT" />
                    <asp:BoundField DataField="DIACHI" HeaderText="Địa chỉ" />
                    <asp:BoundField DataField="NGAYMUA" HeaderText="Ngay mua" />
                    <asp:BoundField DataField="Gia" HeaderText="Giá" />
                    <asp:BoundField DataField="STATUS" HeaderText="Trạng thái" />
                    <asp:TemplateField HeaderText="Tác vụ">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "/admin/donhang/quanlydonhang?dtransported_id=" +Eval("ID_ORDER") %>' runat="server">Duyệt</asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <h6>Chưa có đơn hàng nào</h6>
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="wrap-table p-4">
            
            <div class="header-table">
                <div class="title">
                    <h5>Tất cả đơn hàng</h5>
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
            <asp:GridView ID="GridViewTotal" AutoGenerateColumns="false" CssClass="table table-dark table-striped"  runat="server">
                <Columns>
                    <asp:BoundField DataField="ID_ORDER" HeaderText="Id" />
                    <asp:BoundField DataField="HOTEN" HeaderText="Tên" />
                    <asp:BoundField DataField="SDT" HeaderText="SDT" />
                    <asp:BoundField DataField="DIACHI" HeaderText="Địa chỉ" />
                    <asp:BoundField DataField="NGAYMUA" HeaderText="Ngay mua" />
                    <asp:BoundField DataField="Gia" HeaderText="Giá" />
                    <asp:BoundField DataField="STATUS" HeaderText="Trạng thái" />
                    <asp:TemplateField HeaderText="Tác vụ">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink2" onclick="return confirm('Bạn có chắc muôn xóa đơn hàng này không không?')" NavigateUrl='<%# "/admin/donhang/xoadonhang?id=" + Eval("ID_ORDER") %>' runat="server"><i class="bi bi-archive"></i></asp:HyperLink>
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
        </div>
    </div>
            
        </div>
    </form>
</asp:Content>
