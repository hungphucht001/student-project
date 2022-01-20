<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="modal.ascx.cs" Inherits="chicken.Admin.modal" %>
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
                    <asp:Button ID="btnSubmitSaleItem" runat="server" Text="Sale" OnClick="btnSubmitSaleItem_Click" />
                </div>
            </div>
        </div>
    </div>
    <script>
        const open_modal = document.querySelectorAll(".open_modal");
        const close_modal = document.querySelector("#close_modal");
        const modal = document.querySelector("#modal");
        const hidden_ID = document.querySelector("#Content_Modal_hidden_ID");

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