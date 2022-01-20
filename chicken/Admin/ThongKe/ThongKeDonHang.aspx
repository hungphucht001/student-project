<%@ Page Title="Chicken | Thống kê đơn hàng" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="ThongKeDonHang.aspx.cs" Inherits="chicken.Admin.ThongKe.ThongKeDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-lg-12">
        <span class="title-page">Thống kê / Thống kê đơn hàng</span>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="box-chart p-4">
            <canvas id="chartordersbymonth" width="400"  height="200"></canvas>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="box-chart p-4">
            <canvas id="charttopitems" width="400"  height="200"></canvas>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
    <script>
        var chartordersbymonth = document.getElementById('chartordersbymonth').getContext('2d');
        var charttopitems = document.getElementById('charttopitems').getContext('2d');
        var myChart = new Chart(chartordersbymonth, {
            type: 'bar',
            data: {
                labels: [<%=this.TitleTK2%>],
                datasets: [{
                    label: 'Thống kê đơn hàng trong năm',
                    data: [<%=this.SlTK2%>],
                    backgroundColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)'
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
        var myChart = new Chart(charttopitems, {
            type: 'bar',
            data: {
                labels: [<%=this.TitleTK%>],
                datasets: [{
                    label: 'Mặt hàng được mua nhiều nhất trong tháng',
                    data: [<%=this.SlTK%>],
                    backgroundColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
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
