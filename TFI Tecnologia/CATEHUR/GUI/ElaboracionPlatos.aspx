<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ElaboracionPlatos.aspx.vb" Inherits="GUI.ElaboracionPlatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
           <div class="container">
                <h3><asp:Label ID="Lbl_ElaboracionPlatos" runat="server" Text="Elaboracion de Platos"></asp:Label></h3>
  
           
              <table class="table-hover" style ="border-top: 0px;" >
                                <tbody>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_platos" runat="server" Text="Platos"></asp:Label></td>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:DropDownList ID="cmb_Plato" runat="server"></asp:DropDownList><asp:Button Class="btn" ID="btn_buscarPlato" runat="server" Text="Buscar Plato" style="margin-bottom:1em;margin-left:1em;"/> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_nombrePlato" runat="server" Text="Nombre del Plato"></asp:Label></td>
                                    <td style="padding-top:2em; " class="auto-style2"><asp:TextBox ID="txt_NombrePlato" runat="server"></asp:TextBox><asp:HiddenField ID="idPlato" runat="server" Value="0" />
                                    </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_manodeobra" runat="server" Text="Mano de obra"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_Manodeobra" runat="server" ></asp:TextBox></td>
                                 </tr>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_precio" runat="server" Text="Precio"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_precio" runat="server"></asp:TextBox></td>
                                 </tr>
                                 <tr>   
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_tipomenu" runat="server" Text="Tipo Menu"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:DropDownList ID="cmb_tipomenu" runat="server"></asp:DropDownList></td>

                                 </tr>                                  

                                </tbody>
             </table> 
                       
              <table class="table-hover" style ="border-top: 0px;" >

         
                                <tbody>

                                 <tr>
                                     <td></td>
                                    <td class="auto-style2" style="width: 526px"><asp:Label ID="lbl_ingredientesAsignados" runat="server" Text="Ingredientes"></asp:Label></td>
                                    <td class="auto-style3"><asp:Label ID="lbl_IngredientesDiponibles" runat="server" Text="Nuevo Ingrediente"></asp:Label></td>
                                 </tr>
                                  <tr>
                                    <td class="auto-style2"></td>
                                    <td class="auto-style3" style="width: 526px">
                                        <asp:GridView ID="dt_IngredientesAsignados" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
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
                                          <asp:Label ID="lbl_ingrediente" runat="server" Text="Ingrediente: "></asp:Label>                                 
                                          <asp:DropDownList ID="cmb_Ingredientes" runat="server" Width="165px"></asp:DropDownList><asp:Button ID="btn_AgregarNuevoIngrediente" runat="server" Text="+" />
                                          <asp:Button ID="btn_BajaIngrediente" runat="server" Text="-" style="margin-left:5%;"/>                                      
                                      </p>
                                      <p>
                                          <asp:Label ID="lbl_NuevoIngrediente" runat="server" Text="Nuevo Ingrediente:" style="padding-right:3%;" Visible="false"></asp:Label>
                                          <asp:TextBox ID="txt_NuevoIngrediente" runat="server" Width="157px" Visible="false"></asp:TextBox>
                                      </p>
                                      <p>
                                          <asp:Label ID="lbl_NuevoIngredientePrecio" runat="server" Text="Precio:" style="padding-right:3%;" Visible="false"></asp:Label>
                                          <asp:TextBox ID="txt_NuevoIngredientePrecio" runat="server" Width="157px" Visible="false"></asp:TextBox>
                                      </p>
                                      <p>
                                                                            
                                      <asp:Button ID="btn_AltaIngrediente" runat="server" Text="Alta Ingrediente" Visible="false" />
                                      </p>
                                      <p>
                                          <asp:Label ID="lbl_cantidad" runat="server" Text="Cantidad:" style="padding-right:3%;"></asp:Label>
                                          <asp:TextBox ID="txt_cantidad" runat="server" Width="157px"></asp:TextBox>
                                      </p>
                                      </td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"></td>
                                    <td style="padding-top:1em; width: 526px;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg"  ID="btn_QuitarIngrediente" runat="server" Text="Quitar Ingrediente" /> </td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg"  ID="btn_AgregarIngrediente" runat="server" Text="Agregar Ingrediente" /> </td>

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
                                          <asp:Label ID="lbl_catering" runat="server" Text="Catering: "></asp:Label>                                 
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
                    <asp:Button Class="btn btn-info btn-lg" ID="btn_AltaPlato" runat="server" Text="Alta Plato" /> <asp:Button Class="btn btn-info btn-lg"  ID="btn_modificarPlato" runat="server" Text="Modificar Plato" style="margin-left:1em;" /> <asp:Button Class="btn btn-info btn-lg"  ID="btn_bajaPlato" runat="server" Text="Baja plato" style="margin-left:1em;" /> 
                </div>
                               


</div>

</asp:Content>
