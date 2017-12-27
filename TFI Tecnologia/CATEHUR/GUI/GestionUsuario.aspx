<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionUsuario.aspx.vb" Inherits="GUI.GestionUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="container">
                <h3><asp:Label ID="lbl_gestionUsuario" runat="server" Text="Gestion Usuario"></asp:Label></h3>
  
           
              <table class="table-hover" style ="border-top: 0px;" >
                                <tbody>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_usuario" runat="server" Text="Usuario"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:DropDownList ID="cmb_usuario" runat="server"></asp:DropDownList><asp:Button Class="btn" ID="btn_buscarUsuario" runat="server" Text="Buscar usuario" style="margin-bottom:1em;margin-left:1em;"/> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_nombreUsuario" runat="server" Text="Nombre de Usuario"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_NombreUsuario" runat="server"></asp:TextBox><asp:HiddenField ID="idUsuario" runat="server" />
                                    </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_contraseña" runat="server" Text="Contraseña"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_contraseña" runat="server" TextMode="Password"></asp:TextBox></td>
                                 </tr>
                                  <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_nombre" runat="server" Text="Nombre"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox></td>
                                 </tr>
                                 <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_apellido" runat="server" Text="Apellido"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_apellido" runat="server"></asp:TextBox></td>
                                 </tr>
                                 <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_email" runat="server" Text="E-Mail"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_email" runat="server"></asp:TextBox></td>
                                 </tr>
                                <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_domicilio" runat="server" Text="Domicilio"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_domicilio" runat="server"></asp:TextBox></td>
                                 </tr>
                                <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_Telefono" runat="server" Text="Telefono"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox></td>
                                 </tr>
                                 <tr>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_tipoEmpleado" runat="server" Text="Tipo Empleado"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:DropDownList ID="cmb_tipoempleado" runat="server"></asp:DropDownList></td>
                                    <td></td>
                                    <td></td>
                                 </tr>                                  

                                </tbody>
             </table> 
                       
              <table class="table-hover" style ="border-top: 0px;" >

         
                                <tbody>

                                 <tr>
                                     <td></td>
                                    <td class="auto-style2" style="width: 526px"><asp:Label ID="lbl_PermisosAsignados" runat="server" Text="Permisos Asignados"></asp:Label></td>
                                    <td class="auto-style3"><asp:Label ID="lbl_PermisosDisponibles" runat="server" Text="Permisos Disponibles"></asp:Label></td>
                                 </tr>
                                  <tr>
                                    <td class="auto-style2"></td>
                                    <td class="auto-style3" style="width: 526px">
                                        <asp:GridView ID="dt_FamiliasAsignadas" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
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
                                        <asp:GridView ID="dt_FamiliasDisponibles" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
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
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"></td>
                                    <td style="padding-top:1em; width: 526px;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg"  ID="btn_QuitarPermiso" runat="server" Text="Quitar Permiso" /> </td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg"  ID="btn_AsignarPermiso" runat="server" Text="Asignar Permiso" /> </td>

                                  </tr>

                                 <tr>
                                    <td></td>
                                    <td><asp:Button Class="btn btn-info btn-lg" ID="btn_AltaUsuario" runat="server" Text="Alta usuario" /> <asp:Button Class="btn btn-info btn-lg"  ID="btn_ModificarUsuario" runat="server" Text="Modificar usuario" style="margin-left:1em;" /> <asp:Button Class="btn btn-info btn-lg"  ID="btn_BajaUsuario" runat="server" Text="Baja usuario" style="margin-left:1em;" /> </td>
                                    <td></td>
                                    <td>&nbsp;</td>
                                 </tr>

  
                                  </tbody>
                              </table>  





</asp:Content>
