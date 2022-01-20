<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DonHangDangDat.ascx.cs" Inherits="chicken.Controls.DonHangDangDat" %>

<asp:ScriptManager ID="ScriptManager1" EnableCdn="true" runat="server"></asp:ScriptManager>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Timer ID="Timer1" Interval="1000" OnTick="Timer1_Tick" runat="server"></asp:Timer>
<asp:ListView ID="ListView1" runat="server">
    <ItemTemplate>
        <div class="row">
    <div class="col-lg-12 mb-5">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title mb-5">Mã đơn hàng: <%#Eval("ID_ORDER") %></h4>
                <div class="hori-timeline" dir="ltr">
                    <ul class="list-inline events">
                        <li class="list-inline-item event-list">
                            <div class="px-4">
                                <div class="event-date bg-soft-<%# int.Parse(Eval("STATUS").ToString())>0?"success":"dark" %> text-danger "><i class="bi bi-check2"></i></div>
                                <h6>Chờ xét duyệt</h6>
                            </div>
                        </li>
                        <li class="list-inline-item event-list">
                            <div class="px-4">
                                <div class="event-date bg-soft-<%# int.Parse(Eval("STATUS").ToString())>1?"success":"dark" %> text-warning "><i class="bi bi-check2"></i></div>
                                <h6>Đang chuẩn bị đơn hàng</h6>
                            </div>
                        </li>
                        <li class="list-inline-item event-list">
                            <div class="px-4">
                                <div class="event-date bg-soft-<%# int.Parse(Eval("STATUS").ToString())>2?"success":"dark" %> text-primary"><i class="bi bi-check2"></i></div>
                                <h6>Đang giao tới bạn</h6>
                            </div>
                        </li>
                        <li class="list-inline-item event-list">
                            <div class="px-4">
                                <div class="event-date bg-soft-<%# int.Parse(Eval("STATUS").ToString())>=3?"success":"dark" %> text-success"><i class="bi bi-check2"></i></div>
                                <h6>Giao hàng thành công</h6>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div style="text-align:right">
            <asp:HyperLink ID="LinkButton1" onclick="return confirm('Bạn có chắc muốn hủy đơn hàng này không')" Visible='<%# int.Parse(Eval("STATUS").ToString()) >1? false : true %>' NavigateUrl='<%# "/tai-khoan/"+Eval("ID_ORDER") %>' BackColor="Red" ForeColor="White" CssClass="py-3 px-4" runat="server">Hủy đơn hàng</asp:HyperLink>
        </div>
        <!-- end card -->
    </div>
</div>
    </ItemTemplate>
    <EmptyDataTemplate>
        <h4>Chưa có đơn hàng nào</h4>
    </EmptyDataTemplate>
</asp:ListView>
    </ContentTemplate>
</asp:UpdatePanel>
