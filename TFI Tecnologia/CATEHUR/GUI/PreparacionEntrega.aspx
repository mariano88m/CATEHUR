<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PreparacionEntrega.aspx.vb" Inherits="GUI.PreparacionEntrega" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container">

   <table class="table-hover" style ="border-top: 0px;">
           <h2><asp:Label ID="lbl_PreparacionEntrega" runat="server" Text="Preparacion de la Entrega"></asp:Label></h2>
                                <tbody>
                                  <tr>
                                    <td><asp:Label ID="lbl_NroEvento" runat="server" Text="Nro. Evento"></asp:Label></td>
                                    <td><asp:TextBox ID="txt_idevento" runat="server"></asp:TextBox></td>
                                  </tr>
                                 <tr>
 
                                    <td><asp:Label ID="lbl_NombreEvento" runat="server" Text="Nombre del Evento"></asp:Label></td> 
                                    <td><asp:TextBox ID="Txt_NombreEvento" runat="server"></asp:TextBox></td>
                                    
                                 </tr>
                                 <tr>
                                    <td></td>
                                    <td><asp:Button Class="btn btn-info btn-lg" ID="Btn_buscar" runat="server" Text="Buscar" /></td> 
 
                                 </tr>
                                 <tr>
                                     <td style="padding-top:2em;"><asp:Label ID="lbl_eventos" runat="server" Text="Eventos"></asp:Label></td>
                                     <td>
                                        <asp:GridView ID="dt_eventos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                                    </td>
                                  </tr>
                                  <tr>
                                  
                                    <td style="padding-top:2em;"></td>
                                    <td style="padding-top:2em;"><asp:Button Class="btn btn-info btn-lg" ID="btn_ConfeccionOrdenCompra" runat="server" Text="Confeccionar orden de compra" /></td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;"></td>
                                    <td style="padding-top:1em;"><asp:CheckBox ID="chk_ingredientes" runat="server" CssClass="checkbox inline" Width="165px" Text="Ingredientes comprados" />  </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;"></td>
                                    <td style="padding-top:1em;"><asp:CheckBox ID="chk_platos" runat="server" CssClass="checkbox inline" Width="165px" Text="Platos preparados" />  </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;"></td>
                                    <td style="padding-top:1em;"><asp:CheckBox ID="chk_vajillas" runat="server" CssClass="checkbox inline" Width="165px" Text="Asignar vajillas" />  </td>
                                  </tr>
                                   <tr>
                                    <td></td>
                                    <td style="padding-top:1em;"><asp:Button Class="btn btn-info btn-lg" ID="btn_confirmarEntrega" runat="server" Text="Confirmar Entrega" /></td>
                                   
                                  </tr>
                                  </tbody>
                              </table>             
      <footer>
      </footer>
</div> <!-- /container -->

</asp:Content>