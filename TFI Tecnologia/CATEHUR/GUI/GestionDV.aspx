<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionDV.aspx.vb" Inherits="GUI.GestionDV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
<div class="container">
      <!-- Main hero unit for a primary marketing message or call to action -->
     
      <!-- Example row of columns -->
      <div class="row">
        <div class="span4">
          <h2><asp:Label ID="lbl_gestionDV" runat="server" Text="Gestion Digito Verificador"></asp:Label></h2>

          <p>
             <asp:Button Class="btn" ID="btn_verificarDigitoVerificador" runat="server" Text="Verificar Digito Verificador" />
          </p> 

          <p>
             <asp:Button Class="btn" ID="btn_recomponerDigitoVerificador" runat="server" Text="Recomponer Digito Verificador" />
          </p> 
          </div>

      </div>

      <div class="hero-unit">
          <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
      </div>


      <hr>

      <footer>
        <p>© CATEHUR</p>
      </footer>
</div> <!-- /container -->




</asp:Content>
