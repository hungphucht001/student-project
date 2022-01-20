<%@ Page Title="Chicken | Thống kê nhân viên" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="ThongKeNhanVien.aspx.cs" Inherits="chicken.Admin.ThongKe.ThongKeNhanVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-lg-12">
        <span class="title-page">Thống kê / Thống kê nhân viên</span>
    </div>
    <div class="col-lg-6 mt-5">
        <div class="box-number">
            <div class="title">
                <span>Tổng số nhân viên
                </span>
            </div>
            <div class="number">
                <span>
                    <%=this.SlNV %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-6 mt-5">
        <div class="box-number">
            <div class="title">
                <span>Thêm nhân viên mới
                </span>
            </div>
            <div class="single-button">
                <a href="/admin/nhanvien/themnhanvien" class="btn">Thêm nhân viên</a>
            </div>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="box-chart p-4">
            <canvas id="chartmemberposition" width="400" height="200"></canvas>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
    <script>
        var chartmemberposition = document.getElementById('chartmemberposition').getContext('2d');
        var myChart = new Chart(chartmemberposition, {
            type: 'bar',
            data: {
                labels: [<%=this.TitletTK %>],
                datasets: [{
                    label: 'Nhân viên theo chức vụ',
                    data: [<%=this.Number %>],
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
    </script>
</asp:Content>
