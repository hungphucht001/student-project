<%@ Page Title="Chicken | Quản lý bài viết" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="QuanLyBaiViet.aspx.cs" Inherits="chicken.Admin.BaiViet.QuanLyBaiViet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
        <div class="row">
    <div class="col-lg-12">
        <span class="title-page">Bài viết / Quản lý bài viết</span>
    </div>
    <div class="col-lg-6 mt-5">
        <div class="box-number">
            <div class="title">
                <span>
                    Tổng số bài viết
                </span>
            </div>
            <div class="number">
                <span>
                    <%=this.TotalNews %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-6 mt-5">
        <div class="box-number">
            <div class="title">
                <span>
                    Thêm bài viết
                </span>
            </div>
            <div class="single-button">
                <a href="/admin/tintuc/thembaiviet" class="btn">Thêm bài viết mới</a>
            </div>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="wrap-table p-4">
            <div class="header-table">
                <div class="title">
                    <h5>Tất cả bài viết</h5>
                </div>
                <div class="search">
                        <div class="form-group">
                            <div class="single-input">
                                <asp:TextBox ID="txtTimBaiViet" runat="server" placeholder="Tìm kiếm"></asp:TextBox>
                            </div>
                            <div class="single-button">
                                <asp:Button ID="btnTimBaiViet" runat="server" Text="Tìm" OnClick="btnTimBaiViet_Click" />
                            </div>
                        </div>
                </div>
            </div>
            <asp:GridView ID="GridViewTinTuc" AutoGenerateColumns="false" runat="server" CssClass="table table-dark table-striped">
                <Columns>
                        <asp:BoundField DataField="ID_NEWS" HeaderText="Id" ReadOnly="true" />
                        <asp:BoundField DataField="TEN" HeaderText="Tên" />
                        <asp:BoundField DataField="FULLNAME" HeaderText="Người đăng" />
                        <asp:BoundField DataField="NGAYDANG" HeaderText="Ngày đăng" />
                        <asp:BoundField DataField="NGAYSUA" HeaderText="Ngày sửa" />
                    <asp:TemplateField HeaderText="Tác vụ">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" Target="_blank" NavigateUrl='<%# "/tin-tuc/" + Eval("TENKHONGDAU") +"/"+ Eval("ID_NEWS") %>' runat="server"><i class="bi bi-eye-fill"></i></asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" onclick="return confirm('Bạn có chắc muôn xóa không?')" NavigateUrl='<%# "/admin/tintuc/xoabaiviet?id=" + Eval("ID_NEWS")  %>' runat="server"><i class="bi bi-archive"></i></asp:HyperLink>
                            <asp:HyperLink ID="HyperLink3" NavigateUrl='<%# "/admin/tintuc/chinhsuabaiviet?id=" + Eval("ID_NEWS") %>' runat="server"><i class="bi bi-pencil-square"></i></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                </Columns>
                 <EmptyDataTemplate>
                    <h6>Chưa có bài viết nào</h6>
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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server" >
    <script>
        var chartNumberOrder = document.getElementById('chartNumberOrder').getContext('2d');
        var chartNumberMember = document.getElementById('chartNumberMember').getContext('2d');
        var myChart = new Chart(chartNumberOrder, {
            type: 'line',
            data: {
                labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange','đá'],
                datasets: [{
                    label: 'Đơn hàng trong tháng',
                    data: [12, 19, 3, 5, 2, 3,0],
                    borderColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)',
                        'rgba(153, 102, 255, 1)',
                        'rgba(255, 159, 64, 1)'
                    ],
                    borderWidth: 2
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
        var myChart = new Chart(chartNumberMember, {
            type: 'bar',
            data: {
                labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange',],
                datasets: [{
                    label: 'Khách hàng',
                    data: [12, 19, 50, 5, 2, 3,0],
                    backgroundColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)',
                        'rgba(153, 102, 255, 1)',
                        'rgba(255, 159, 64, 1)'
                        ],
                    
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
    </script>
</asp:Content>