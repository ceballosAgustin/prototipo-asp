<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DireccionForm.aspx.cs" Inherits="prototipo_asp.DireccionForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function confirmarEliminar() {
            return confirm("¿Está seguro qué quiere eliminar la dirección?");
        }
        function confirmarModificar() {
            return confirm("¿Está seguro qué quiere modificar la dirección?")
        }
    </script>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <%-- Primero el label que indica que es y después el txt para ponerlo --%>
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCalle" class="form-label">Calle</label>
                <asp:TextBox ID="txtCalle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtAltura" class="form-label">Altura</label>
                <asp:TextBox ID="txtAltura" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" CssClass="btn btn-primary" runat="server" Text="Aceptar" />
                <asp:Button ID="btnModificar" OnClick="btnModificar_Click" OnClientClick="confirmarModificar();" CssClass="btn btn-success" runat="server" Text="Modificar" />
                <asp:Button ID="btnEliminar" OnClick="btnEliminar_Click" OnClientClick="confirmarEliminar();" CssClass="btn btn-danger" runat="server" Text="Eliminar" />
                <asp:Button ID="btnCancelar" OnClick="btnCancelar_Click" CssClass="btn btn-secondary" runat="server" Text="Cancelar" />
            </div>
            <div class="mb-3">
            </div>
        </div>
    </div>

</asp:Content>
