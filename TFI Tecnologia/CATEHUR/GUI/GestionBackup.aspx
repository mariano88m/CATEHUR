<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionBackup.aspx.vb" Inherits="GUI.GestionBackup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container">
      <!-- Main hero unit for a primary marketing message or call to action -->
     
      <!-- Example row of columns -->
      <div class="row">
        <div class="span4">
          <h2>
              <asp:Label ID="lbl_realizarbackup" runat="server" Text="Realizar Backup"></asp:Label></h2>
          <p>
              &nbsp;</p>
          <p>
             <asp:Button Class="btn" ID="btnBackup" runat="server" Text="Realizar Backup" />
          </p> 
          </div>
          <div class="span4">
          <h2>Restore Backup</h2>
          <p>

             <asp:ListBox ID="lstBackupfiles" runat="server" Height="177px" Width="338px"></asp:ListBox>
          </p>
              <p>

                  &nbsp;</p>
          <p>
              &nbsp;</p> 



          <p>
             <asp:Button Class="btn" ID="btnRestore" runat="server" Text="Restore Backup" />
          </p> 
          </div>

      </div>
    <hr>
     
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