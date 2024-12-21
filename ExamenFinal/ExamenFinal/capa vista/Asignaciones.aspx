<%@ Page Title="" Language="C#" MasterPageFile="~/capa vista/Plantilla.Master" AutoEventWireup="true" CodeBehind="Asignaciones.aspx.cs" Inherits="ExamenFinal.capa_vista.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />
    Id:
   
    <asp:TextBox ID="id" type="number" runat="server"></asp:TextBox>
    <br />
    Empleado ID:
    
     <asp:TextBox ID="Eid" type="number" runat="server"></asp:TextBox>
    <br />
   Proyecto ID:
    
     <asp:TextBox ID="Pid" type="number" runat="server"></asp:TextBox>
    <br />
    Fecha Asignacion:
   
     <asp:TextBox ID="FechaA" Type="date" runat="server"></asp:TextBox>
   
<br />
    <br />
     <asp:Button ID="Agregar" runat="server" Text="Agregar" OnClick="Agregar_Click1"  />
  <asp:Button ID="Borrar" runat="server" Text="Borrar" OnClick="Borrar_Click1"  />
   
</asp:Content>
