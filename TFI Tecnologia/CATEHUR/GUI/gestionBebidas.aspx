<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="gestionBebidas.aspx.vb" Inherits="GUI.gestionBebidas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
               <div class="container">
                <h3>Gestion de Bebidas</h3>
  
           
              <table class="table-hover" style ="border-top: 0px;" >
                                <tbody>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="Label5" runat="server" Text="Bebida"></asp:Label></td>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:DropDownList ID="cmb_bebida" runat="server"></asp:DropDownList><asp:Button Class="btn" ID="btn_buscarBebida" runat="server" Text="Buscar bebida" style="margin-bottom:1em;margin-left:1em;"/> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="Label2" runat="server" Text="Nombre de la bebida"></asp:Label></td>
                                    <td style="padding-top:2em; " class="auto-style2"><asp:TextBox ID="txt_NombreBebida" runat="server"></asp:TextBox><asp:HiddenField ID="idBebida" runat="server" Value="0" />
                                    </td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="Label1" runat="server" Text="Precio"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_precio" runat="server"></asp:TextBox></td>
                                 </tr>
                                 <tr>   
                                    <td style="padding-top:2em;" class="auto-style2">&nbsp;</td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2">&nbsp;</td>

                                 </tr>                                  

                                </tbody>
             </table> 
                       
              <table class="table-hover" style ="border-top: 0px;" >

         
                                <tbody>

                                 <tr>
                                     <td></td>
                                    <td class="auto-style2" style="width: 526px"><asp:Label ID="lbl_ingredientesAsignados" runat="server" Text="Catering asignados"></asp:Label></td>
                                 </tr>
                          


                              <tr>
                                    <td class="auto-style2"></td>
                                    <td class="auto-style3" style="width: 526px">
                                        <asp:GridView ID="dt_cateringAsignados" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
                                            <AlternatingRowStyle BackColor="#CCCCCC" />
                                            <Columns>
                                                <asp:CommandField ShowSelectButton="True" />
                                            </Columns>
                                            <FooterStyle BackColor="#CCCCCC" />
                                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                            <SortedAscendingHeaderStyle BackColor="#808080" />
                                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                            <SortedDescendingHeaderStyle BackColor="#383838" />
                                        </asp:GridView>
                                    </td>
                                      <td>
                                      <p>
                                          <asp:Label ID="Label4" runat="server" Text="Catering: "></asp:Label>                                 
                                          <asp:DropDownList ID="cmb_catering" runat="server" Width="165px"></asp:DropDownList>
                                                                         
                                      </p>

                                      </td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"></td>
                                    <td style="padding-top:1em; width: 526px;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg"  ID="btn_quitarCatering" runat="server" Text="Quitar Catering" /> </td>
                                    <td style="padding-top:1em; width: 526px;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg"  ID="btn_asignarCatering" runat="server" Text="Asignar Catering" /> </td>

                                  </tr>
                                 <tr style="padding-bottom:30%; padding-top:55%;">
                                    <td></td>
                               
                                 </tr>  
  
                                  </tbody>
                              </table>  
                <div style="margin-left:10%; margin-top:5%;">
                    <asp:Button Class="btn btn-info btn-lg" ID="btn_AltaBebida" runat="server" Text="Alta Bebida" /> <asp:Button Class="btn btn-info btn-lg"  ID="btn_ModificarBebida" runat="server" Text="Modificar Bebida" style="margin-left:1em;" /> <asp:Button Class="btn btn-info btn-lg"  ID="btn_bajabebida" runat="server" Text="Baja bebida" style="margin-left:1em;" /> 
                </div>
                               


</div>


































</asp:Content>
