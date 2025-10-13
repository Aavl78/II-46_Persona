<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FormPersona.aspx.vb" Inherits="Persona.FormPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID= "Txt_nombre" placeholder="Nombre" runat="server"></asp:TextBox>
    <asp:TextBox ID="Txt_apellido" placeholder="Apellido" runat="server"></asp:TextBox>
    <asp:TextBox ID="Txt_edad" placeholder="Edad" runat="server"></asp:TextBox>
    <asp:Button ID="btn_guardar" CssClass = "btn btn-primary" runat="server" Text="Guardar" OnClick="btn_guardar_Click" />
    <asp:Label ID="Lbl_mensaje" runat="server" Text=""></asp:Label>
    <asp:GridView ID="Gv_personas" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource" Width="1120px" OnRowDeleting="Gv_personas_RowDeleting" OnRowEditing ="Gv_personas_RowEditing" OnRowCancelingEdit="Gv_personas_RowCancelingEdit" OnRowUpdating="Gv_personas_RowUpdating">
        <Columns>
            <asp:CommandField showselectButton="true" ControlStyle-CssClass="btn btn-success"/>
            <asp:CommandField ShowEditButton="true" ControlStyle-CssClass="btn btn-primary"/>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
            <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad" />
            <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass="btn btn-danger"/>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:II-46ConnectionString %>" ProviderName="<%$ ConnectionStrings:II-46ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Personas]"></asp:SqlDataSource>
</asp:Content>

