<%@ Page Title="Chicken | Quản lý nhân viên" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="QuanLyNhanVien.aspx.cs" Inherits="chicken.Admin.NhanVien.QuanLyNhanVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
        <div class="row">
     <div class="col-lg-12">
        <span class="title-page">Nhân viên / Quản lý nhân viên</span>
    </div>
    <div class="col-lg-6 mt-5">
        <div class="box-number">
            <div class="title">
                <span>
                    Tổng số nhân viên
                </span>
            </div>
            <div class="number">
                <span>
                    <%=this.TotalMember %>
                </span>
            </div>
        </div>
    </div>
    <div class="col-lg-6 mt-5">
        <div class="box-number">
            <div class="title">
                <span>
                    Thêm nhân viên mới
                </span>
            </div>
            <div class="single-button">
                <a href="/admin/nhanvien/themnhanvien" class="btn">Thêm nhân viên</a>
            </div>
        </div>
    </div>
   
    <div class="col-lg-12 mt-5">
        <div class="wrap-table p-4">
            <div class="header-table">
                <div class="title">
                    <h5>Tất cả nhân viên</h5>
                </div>
                <div class="search">
                 
                        <div class="form-group">
                            <div class="single-input">
                                <asp:TextBox ID="txtSearch" runat="server" placeholder="Tìm kiếm"></asp:TextBox>
                            </div>
                            <div class="single-button">
                                <asp:Button ID="btnSubmit" runat="server" Text="Tìm" OnClick="btnSubmit_Click"/>
                            </div>
                        </div>
             
                </div>
            </div>
            
                <asp:GridView ID="GridViewMember" CssClass="table table-dark table-striped" AutoGenerateColumns="false" runat="server">
                    <Columns>
                        <asp:BoundField DataField="ID_MEMBER" HeaderText="Id"/>
                        <asp:BoundField DataField="FULLNAME" HeaderText="Tên" />
                        <asp:BoundField DataField="CHUCVU" HeaderText="Chức vụ" />
                        <asp:BoundField DataField="NGAYSINH" HeaderText="Ngày sinh" />
                        <asp:BoundField DataField="SDT" HeaderText="SDT" />
                        <asp:BoundField DataField="DIACHI" HeaderText="Địa chỉ" />

                        <asp:TemplateField HeaderText="Tác vụ">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink3" runat="server"><i class="bi bi-bookmark-plus"></i></asp:HyperLink>
                                <%if (this.Quyen == 1){ %>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "/admin/nhanvien/suanhanvien?id=" + Eval("ID_USER") %>' runat="server"><i class="bi bi-pencil-square"></i></asp:HyperLink>
                                <asp:HyperLink ID="HyperLink1" onclick="return confirm('Bạn có chắc muôn xóa không?')" NavigateUrl='<%# "/admin/nhanvien/xoanhanvien?id=" + Eval("ID_MEMBER") %>' Visible='<%# !Eval("CHUCVU").ToString().Equals("Giám đốc") %>' runat="server"><i class="bi bi-archive"></i></asp:HyperLink>
                                <%} %>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>