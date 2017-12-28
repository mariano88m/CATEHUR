<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionBackup.aspx.vb" Inherits="GUI.GestionBackup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container">
      <!-- Main hero unit for a primary marketing message or call to action -->
     
      <!-- Example row of columns -->


 <div class="card border-primary mb-3" style="max-width: 20rem;">
  <div class="card-header"><asp:Label ID="lbl_realizarbackup" runat="server" Text="Realizar Backup"></asp:Label></div>
  <div class="card-body text-primary">

    <h4 class="card-title"></h4>
    <p class="card-text"><asp:Button Class="btn" ID="btnBackup" runat="server" Text="Realizar Backup" /></p>

  </div>
</div>

<div class="card border-secondary mb-3" style="max-width: 40rem;">
  <div class="card-header">Restore Backup</div>
  <div class="card-body text-secondary">
    <h4 class="card-title"></h4>
    <p class="card-text"><asp:ListBox ID="lstBackupfiles" runat="server" Height="177px" Width="338px"></asp:ListBox></p>
    <p><asp:Button Class="btn" ID="btnRestore" runat="server" Text="Restore Backup" /></p>
  </div>
</div>
      <hr>
      <div class="hero-unit">
          <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

      </div>


      <hr>

      <footer>
        <p>© CATEHUR</p>
      </footer>
</div> <!-- /container -->


</asp:Content>