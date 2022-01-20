<%@ Page Title="Chicken | Quản lý thực đơn" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="QuanLyThucDon.aspx.cs" Inherits="chicken.Admin.ThucDon.QuanLyThucDon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col-lg-12">
          <span class="title-page">Thưc đơn / Quản lý thực đơn</span>
     </div>
    <div class="col-lg-6 mt-5">
        <div class="box-number">
            <div class="title">
                <span>Số lượng món ăn</span>
            </div>
            <div class="number">
                <span>
                    <%=this.SoLuongMonAn %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-6 mt-5">
        <div class="card card-sale">
            <div class="title">
                <span>
                    Giảm giá tất cả (đơn vị %)
                </span>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtSale" TextMode="Number" min ="0" max="100" Text="0" runat="server"></asp:TextBox>
                <asp:Button ID="btnSubmit" runat="server" Text="Sale" OnClick="btnSubmit_Click" />
            </div>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="box-chart p-4">
            <canvas id="chartNumberMenu" width="400"  height="200"></canvas>
        </div>
    </div>
    <div class="col-lg-12 mt-5">
        <div class="wrap-table p-4">
            <div class="header-table">
                <div class="title">
                    <h5>Thực đơn</h5>
                </div>
                <div class="search">
                    <div class="form-group">
                        <div class="single-input">
                            <asp:TextBox ID="txtTimMonAn" runat="server"  placeholder="Tìm kiếm"></asp:TextBox>
                        </div>
                        <div class="single-button">
                            <asp:Button ID="btnTimMonAn" runat="server" Text="Tìm" OnClick="btnTimMonAn_Click"/>
                        </div>
                    </div>
                </div>
            </div>
                <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" CssClass="table table-dark table-striped">
                <Columns>
                        <asp:BoundField DataField="ID_PRODUCTS" HeaderText="Id" ReadOnly="true" />
                        <asp:BoundField DataField="TENSP" HeaderText="Tên" />
                        <asp:BoundField DataField="GIA" HeaderText="Giá" />
                        <asp:BoundField DataField="SALE" HeaderText="Giảm giá" />
                        <asp:BoundField DataField="TEN_CATEGORY" HeaderText="Thể loại" />
                    <asp:TemplateField HeaderText="Tác vụ">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" Target="_blank" NavigateUrl='<%# "/"+Eval("TENKHONGGIAU")+"/"+Eval("ID_PRODUCTS")%>' runat="server"><i class="bi bi-eye-fill"></i></asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" data_id='<%#Eval("ID_PRODUCTS") %>'  CssClass="open_modal"  runat="server">Sale</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink3" onclick="return confirm('Bạn có chắc muôn xóa không? Nếu xóa sẽ mất tất cả đơn đặt hàng có đặt món này')" NavigateUrl='<%# "/admin/thucdon/xoathucdon?id="+Eval("ID_PRODUCTS")%>' runat="server"><i class="bi bi-archive"></i></asp:HyperLink>
                            <asp:HyperLink ID="HyperLink4" NavigateUrl='<%# "/admin/thucdon/suathucdon?id="+Eval("ID_PRODUCTS")%>' runat="server"><i class="bi bi-pencil-square"></i></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                    <EmptyDataTemplate>
                    <h6>Chưa có món ăn nào</h6>
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
    <div class="wrap_modal" id="modal">
        <div class="modal_hl">
            <div class="header_hl">
                <span class="title">
                    Sale
                </span>
                <i class="bi bi-x" id="close_modal"></i>
            </div>
            <div class="content">
                <div class="wrap-content">
                    <asp:HiddenField ID="hidden_ID" Value="" runat="server" />
                    <asp:TextBox ID="txtNumber" runat="server" TextMode="Number" min="0" max="100" Text="0"></asp:TextBox>
                    <asp:Button ID="btnSubmitSaleItem" runat="server" Text="Sale" OnClick="btnSubmitSaleItem_Click"/>
                </div>
            </div>
        </div>
    </div>
</form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
     <script>
        var chartNumberMember = document.getElementById('chartNumberMenu').getContext('2d');
        var myChart = new Chart(chartNumberMember, {
            type: 'bar',
            data: {
                labels: [<%=this.TitleTK%>],
                datasets: [{
                    label: 'Top món ăn được ưa thích nhất trong tháng',
                    data: [<%=this.SlTK%>],
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
    <script>
        const open_modal = document.querySelectorAll(".open_modal");
        const close_modal = document.querySelector("#close_modal");
        const modal = document.querySelector("#modal");
        const hidden_ID = document.querySelector("#Content_hidden_ID");

        if (open_modal || close_modal || modal) {

            open_modal.forEach(e => {

                e.onclick = () => {
                    modal.style.display = "flex";
                    hidden_ID.value = e.getAttribute("data_id");
                }
            });

            close_modal.onclick = () => {
                modal.style.display = "none";
            }
        }
    </script>
</asp:Content>