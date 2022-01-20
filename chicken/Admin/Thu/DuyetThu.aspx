<%@ Page Title="Chiken | Duyệt thư" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="DuyetThu.aspx.cs" Inherits="chicken.Admin.Thu.DuyetThu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-lg-12">
                                <span class="title-page">Thư / Duyệt thư</span>
                            </div>
                            <div class="col-lg-12 mt-5">
                                <div class="box-number">
                                    <div class="title">
                                        <span>
                                            Tổng số thư đã nhận
                                        </span>
                                    </div>
                                    <div class="number">
                                        <span>
                                            <%=this.TotalLeffter %>
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-12 mt-5">
                                <div class="wrap-table p-4">
                                    <form runat="server">
                                    <div class="header-table">
                                        <div class="title">
                                            <h5>Tất cả thư</h5>
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
                                    
                                    <asp:GridView ID="GridView1" CssClass="table table-dark table-striped" AutoGenerateColumns="false" runat="server">
                                        <Columns>
                                            <asp:BoundField DataField="ID_LETTER" HeaderText="Id" />
                                            <asp:BoundField DataField="NAME" HeaderText="Tên" />
                                            <asp:BoundField DataField="EMAIL" HeaderText="Email" />
                                            <asp:BoundField DataField="NUMBERPHONE" HeaderText="SĐT" />
                                            <asp:BoundField DataField="CONTENT" HeaderText="Nội dung" />
                                            <asp:TemplateField HeaderText="Tác vụ">
                                                <ItemTemplate>
                                                    <asp:HyperLink onclick="return confirm('Bạn có chắc muôn xóa không?')" NavigateUrl='<%# "/admin/thu/xoathu?id=" + Eval("ID_LETTER") %>' runat="server"><i class="bi bi-archive"></i></asp:HyperLink>
                                                    <asp:HyperLink runat="server"><i class="bi bi-reply"></i></asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <EmptyDataTemplate>
                                            <h6>Chưa có thư nào</h6>
                                        </EmptyDataTemplate>
                                    </asp:GridView>
                                        </form>
                                      <div class="wrap-pagination">
                                        <ul class="pagination justify-content-end">
                                            <%=this.Pag %>
                                          </ul>
                                      </div>
                                </div>
                            </div>
</asp:Content>
