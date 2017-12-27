<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CronogramaEventos.aspx.vb" Inherits="GUI.CronogramaEventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<div class="container">

      <div class="row">
        <div class="span4">
          <h2><asp:Label ID="lbl_CronogramaEventos" runat="server" Text="Cronograma de Eventos"></asp:Label></h2>
          <p>
              <asp:TextBox ID="Txt_fechaDesde" runat="server"></asp:TextBox>
              <asp:Button Class="btn" ID="Btn_fechaDesde" runat="server" Text="Desde" />
              <asp:Calendar ID="Calendar1" runat="server" Visible="false"></asp:Calendar>
          </p>
          <p>
             <asp:TextBox ID="Txt_fechaHasta" runat="server"></asp:TextBox>
             <asp:Button Class="btn" ID="Btn_fechaHasta" runat="server" Text="Hasta" />
             <asp:Calendar ID="Calendar2" runat="server" Visible="false"></asp:Calendar>
          </p>
            
          </div>
      </div>
    <hr>
     
            <p><asp:Button Class="btn btn-primary btn-large" ID="Btn_buscar" runat="server" Text="Buscar" /></p>
      <hr>
      <div class="hero-unit">
             

             <asp:GridView ID="dt_eventos" runat="server"></asp:GridView>
      </div>


      <hr>

      <footer>
        <p>© CATEHUR</p>
      </footer>
</div> <!-- /container -->

</asp:Content>