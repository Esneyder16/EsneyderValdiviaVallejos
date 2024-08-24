<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/PaginaMaestra/PrincipalMenu.Master" AutoEventWireup="true" CodeBehind="Viajeros.aspx.cs" Inherits="EsneyderValdiviaVallejos.Vista.Viajeros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <h2>Agregar Viajero</h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:" AssociatedControlID="txtNombre" />
            <asp:TextBox ID="txtNombre" runat="server" />
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Nombre es requerido" Display="Dynamic" ForeColor="Red" />
            <br />
            <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento:" AssociatedControlID="txtFechaNacimiento" />
            <asp:TextBox ID="txtFechaNacimiento" runat="server" />
            <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="Fecha de Nacimiento es requerida" Display="Dynamic" ForeColor="Red" />
            <br />
            <asp:Label ID="lblNacionalidad" runat="server" Text="Nacionalidad:" AssociatedControlID="txtNacionalidad" />
            <asp:TextBox ID="txtNacionalidad" runat="server" />
            <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="txtNacionalidad" ErrorMessage="Nacionalidad es requerida" Display="Dynamic" ForeColor="Red" />
            <br />
            <asp:Label ID="lblDocumentoIdentidad" runat="server" Text="Documento de Identidad:" AssociatedControlID="txtDocumentoIdentidad" />
            <asp:TextBox ID="txtDocumentoIdentidad" runat="server" />
            <asp:RequiredFieldValidator ID="rfvDocumentoIdentidad" runat="server" ControlToValidate="txtDocumentoIdentidad" ErrorMessage="Documento de Identidad es requerido" Display="Dynamic" ForeColor="Red" />
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Guardar" OnClick="btnSave_Click" />
        </div>
    </form>
</asp:Content>