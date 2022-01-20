<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="chicken.Admin.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
     <div class="col-lg-12">
        <span class="title-page">Dashboard</span>
    </div>
    <div class="col-lg-3 mt-5">
        <div class="card">
            <div class="title">
                <span>Đơn hàng</span>
            </div>
            <div class="number">
                <span>
                    <%=this.SlDonHang %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-3 mt-5">
        <div class="card">
            <div class="title">
                <span>Khách hàng</span>
            </div>
            <div class="number">
                <span>
                    <%=this.SlKhachHang %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-3 mt-5">
        <div class="card">
            <div class="title">
                <span>Thực đơn</span>
            </div>
            <div class="number">
                <span>
                    <%=this.SlThucDon %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-3 mt-5">
        <div class="card">
            <div class="title">
                <span>Thành viên</span>
            </div>
            <div class="number">
                <span>
                    <%=this.SlThanhVien %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-8 mt-5">
        <div class="box-chart">
            <canvas id="chartNumberOrder" width="400"  height="200"></canvas>
        </div>
    </div>
    <div class="col-lg-4 mt-5">
        <div class="box-chart">
            <canvas id="chartNumberMember" width="400"  height="425"></canvas>
        </div>
    </div>
    <%--<div class="col-lg-8 mt-5">
        <div class="wrap-table">
            <div class="title">
                <h5>Đơn hàng mới nhất</h5>
                <a href="#" class="nav-link">Xem tất cả</a>
            </div>
         
                   <%-- <th>#</th>
                    <th>Tên</th>
                    <th>Số lượng</th>
                    <th>Giá</th>
                    <th>Địa chỉ</th>
                    <th>Trang thái</th>
                    <th>Tác vụ</th>
                   
          
        </div>
    </div>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
     <script>
        var chartNumberOrder = document.getElementById('chartNumberOrder').getContext('2d');
        var chartNumberMember = document.getElementById('chartNumberMember').getContext('2d');
        var myChart = new Chart(chartNumberOrder, {
            type: 'line',
            data: {
                labels: [<%=this.Thang%>],
                datasets: [{
                    label: 'Đơn hàng trong tháng',
                    data: [<%=this.SlThang%>],
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
                labels: [<%=this.TitleTK%>],
                datasets: [{
                    label: 'Nhân viên',
                    data: [<%= this.Number%>],
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
