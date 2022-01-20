<%@ Page Title="Chicken | Thống kê doanh thu" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="ThongKeDoanhThu.aspx.cs" Inherits="chicken.Admin.ThongKe.ThongKeDoanhThu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-lg-12">
        <span class="title-page">Thống kê / Thống kê doanh thu</span>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="box-chart">
            <canvas id="chartrevenue" width="400"  height="200"></canvas>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
     <script>
        var chartrevenue = document.getElementById('chartrevenue').getContext('2d');
        var myChart = new Chart(chartrevenue, {
            type: 'line',
            data: {
                labels: [<%=this.TitleTK%>],
                datasets: [{
                    label: 'Đơn hàng trong tháng',
                    data: [<%=this.SlTK%>],
                    borderColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)',
                        'rgba(153, 102, 255, 1)',
                        'rgba(255, 159, 64, 1)'
                    ],
                    borderWidth: 4
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
