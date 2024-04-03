<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="prototipo_asp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col">
            <%-- DataGridView con las direcciones (ID, Dato Clave, Evento de este, Diseño CSS) --%>
            <asp:GridView runat="server" ID="dgvDirecciones" DataKeyNames="Id" OnSelectedIndexChanged="dgvDirecciones_SelectedIndexChanged" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Calle" DataField="Calle" />
                    <asp:BoundField HeaderText="Altura" DataField="Altura" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción" />
                </Columns>
            </asp:GridView>
            <%-- Nos lleva al Formulario --%>
            <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn btn-info" runat="server" Text="Agregar" />
        </div>
    </div>

</asp:Content>
