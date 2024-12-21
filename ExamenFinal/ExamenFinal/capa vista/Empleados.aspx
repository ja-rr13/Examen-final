<%@ Page Title="" Language="C#" MasterPageFile="~/capa vista/Plantilla.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="ExamenFinal.capa_vista.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />
    Id:
   
    <asp:TextBox ID="id" runat="server"></asp:TextBox>
    <br />
    Numero Carnet:
    
     <asp:TextBox ID="NumeroC" runat="server"></asp:TextBox>
    <br />
    Nombre:
    
     <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
    <br />
    Fecha Nacimiento:
   
     <asp:TextBox ID="Fecha" runat="server"></asp:TextBox>
    <br />
    Categoria:
   
     <asp:TextBox ID="categoria" runat="server"></asp:TextBox>
    <br />
    Salario:
   
     <asp:TextBox ID="salario" runat="server"></asp:TextBox>
    <br />
   Direccion:
     <asp:TextBox ID="Direc" runat="server"></asp:TextBox>
    <br />
    Telefono:
   
     <asp:TextBox ID="Tel" runat="server"></asp:TextBox>
    <br />
    Correo:
        <asp:TextBox ID="correo" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Agregar" runat="server" Text="Agregar" OnClick="Agregar_Click1" />
     <asp:Button ID="Borrar" runat="server" Text="Borrar" OnClick="Borrar_Click1" />
    <asp:Button ID="Consultar" runat="server" Text="Consultar" OnClick="Consultar_Click" />



</asp:Content>
