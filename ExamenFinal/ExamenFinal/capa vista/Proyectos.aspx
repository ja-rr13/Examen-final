<%@ Page Title="" Language="C#" MasterPageFile="~/capa vista/Plantilla.Master" AutoEventWireup="true" CodeBehind="Proyectos.aspx.cs" Inherits="ExamenFinal.capa_vista.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />
    Id:
   
    <asp:TextBox ID="id" type="number" runat="server"></asp:TextBox>
    <br />
    Codigo:
    
     <asp:TextBox ID="Codigo" runat="server"></asp:TextBox>
    <br />
    Nombre:
    
     <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
    <br />
    Fecha Inicio:
   
     <asp:TextBox ID="Fechainicio" Type="date" runat="server"></asp:TextBox>
    <br />
    Fecha Fin:
     <asp:TextBox ID="fechafin"  Type="date" runat="server"></asp:TextBox>
<br />
    <br />
     <asp:Button ID="Agregar" runat="server" Text="Agregar" OnClick="Agregar_Click" />
  <asp:Button ID="Borrar" runat="server" Text="Borrar" OnClick="Borrar_Click" />
   

</asp:Content>
