<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionBitacora.aspx.vb" Inherits="GUI.GestionBitacora" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container">

        <h2><asp:Label ID="lbl_GestionBitacora" runat="server" Text="Gestion Bitacora"></asp:Label></h2>
         <div class="bs-docs-section">
         <div class="row">
             <div class="col-lg-4">
                 <div class ="bs-component">                  
                    <div class="card border-secondary mb-3" >
                        <div class="card-header"><asp:Label ID="lbl_fechas" runat="server" Text="Fechas"></asp:Label></div>
                            <div class="card-body text-secondary">
                                <h4 class="card-title"></h4>
                                <p class="card-text">
                                    <asp:TextBox ID="Txt_fechaDesde" runat="server"></asp:TextBox>
                                    <asp:Button Class="btn" ID="Btn_fechaDesde" runat="server" Text="Desde" />
                                    <asp:Calendar ID="Calendar1" runat="server" Visible="false"></asp:Calendar>
                                </p>
                                <p class="card-text">
                                    <asp:TextBox ID="Txt_fechaHasta" runat="server"></asp:TextBox>
                                    <asp:Button Class="btn" ID="Btn_fechaHasta" runat="server" Text="Hasta" />
                                    <asp:Calendar ID="Calendar2" runat="server" Visible="false"></asp:Calendar>
                                </p>
                            </div>

                            </div>
                        </div>
                    </div>
              
              <div class="col-lg-4">
                 <div class ="bs-component">
                    <div class="card border-secondary mb-3">
                        <div class="card-header"><asp:Label ID="lbl_usuario" runat="server" Text="Usuario"></asp:Label></div>
                            <div class="card-body text-secondary">
                                <h4 class="card-title"></h4>
                                <p class="card-text"><asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox></p>
                            </div>
                        </div>
                    </div>
              </div>
              <div class="col-lg-4">
                 <div class ="bs-component">
                    <div class="card border-secondary mb-3" >
                        <div class="card-header"><asp:Label ID="lbl_Accion" runat="server" Text="Accion"></asp:Label></div>
                            <div class="card-body text-secondary">
                                <h4 class="card-title"></h4>
                                <p class="card-text"><asp:DropDownList ID="cmd_Accion" runat="server"></asp:DropDownList></p>

                            </div>
                        </div>       
                    </div>
                 </div>
              </div>
     </div>
    <div class="row">

                     <p><asp:Button Class="btn btn-primary btn-large" ID="Btn_buscar" runat="server" Text="Buscar" /></p>



     </div>
    <div class="row">

          

            <asp:GridView ID="dtBitacora" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="Blue" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>


     </div>
  

  
  <footer>
        <p>© CATEHUR</p>
      </footer>
</div> <!-- /container -->
</asp:Content>