<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionCliente.aspx.vb" Inherits="GUI.GestionCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container">

      <div class="row">
            <div class="span2">
            <p>
                  <asp:Label ID="lbl_NroCliente" runat="server" Text="Nro. Cliente"></asp:Label>
                  <asp:Label ID="lbl_idCliente" runat="server" Text="Label"></asp:Label>
            </p>
            </div>
      </div>
      
      <div class="row">
          <div class="span2">
            <p>
                  <asp:Label ID="lbl_NombreCliente" runat="server" Text="Nombre del Cliente"></asp:Label>
                  <asp:TextBox ID="Txt_NombreCliente" runat="server"></asp:TextBox>     
            </p>
          </div>
      </div>
          
    
    
      <div class="row">
              <div class="span2">
                    <p>
                          <asp:Label ID="lbl_dni" runat="server" Text="DNI/CUIT/CUIL"></asp:Label>
                          <asp:TextBox ID="txt_dni" runat="server"></asp:TextBox>     
                    </p>
              </div>
      </div>
      
      <div class="row">
              <div class="span2">
                     <p>
                          <asp:Label ID="lbl_direccion" runat="server" Text="Direccion"></asp:Label>
                          <asp:TextBox ID="txt_direccion" runat="server"></asp:TextBox>     
                          <asp:Label ID="lbl_localidad" runat="server" Text="Localidad"></asp:Label>
                          <asp:DropDownList ID="cmb_localidad" runat="server"></asp:DropDownList>
                    </p>
              </div>
      </div>
      <div class="row">
            <div class="span2">
            <p>
                  <asp:Label ID="lbl_email" runat="server" Text="Email"></asp:Label>
                  <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>     
            </p>
            </div>
      </div>
      <div class="row">
            <div class="span2">
            <p>
                  <asp:Label ID="lbl_Telefono" runat="server" Text="Telefono"></asp:Label>
                  <asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox>     
            </p>
            </div>        
      </div>
 
      <hr>
            <asp:Button Class="btn btn-primary btn-large" ID="Btn_limpiar" runat="server" Text="Limpiar" />
            <asp:Button Class="btn btn-primary btn-large" ID="btn_Alta" runat="server" Text="Alta" />
            <asp:Button Class="btn btn-primary btn-large" ID="btn_baja" runat="server" Text="Baja" />
            <asp:Button Class="btn btn-primary btn-large" ID="btn_modificacion" runat="server" Text="Modificacion" />

            <asp:GridView ID="dt_Clientes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>

      <hr>
      

      <hr>

      <footer>
        <p>© CATEHUR</p>
      </footer>

</div> <!-- /container -->

</asp:Content>