<%@ Page Language="vb" AutoEventWireup="false"  MasterPageFile="~/Site.Master" CodeBehind="AsignarPersonal.aspx.vb" Inherits="GUI.AsignarPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
   <table class="table-hover" style ="border-top: 0px;">
           <h2><asp:Label ID="lbl_AsignarPersonal" runat="server" Text="Asignar Personal"></asp:Label></h2>
                                <tbody>
                                  <tr>
                                     <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_eventos" runat="server" Text="Eventos"></asp:Label></td>
                                       <td class="auto-style3">
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
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_ListaEmpleados" runat="server" Text="Lista de Empleados"></asp:Label></td>
                                     <td class="auto-style3">
                                        <asp:GridView ID="dt_empleados" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                                        <td></td>
                                        <td style="padding-top:1em;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg" onclientclick='btn_desasignarEmpleado_Click'  ID="btn_desasignarEmpleado" runat="server" Text="Desasignar Empleado" /> </td>
                                    </tr>
                                  </tbody>
                              </table>  
     <table class="table-hover" style ="border-top: 0px;" >
           <h4 style="padding-top:5em;"><asp:Label ID="lbl_datosEmpleados" runat="server" Text="Datos de los Empleados"></asp:Label></h4>
         
                                <tbody>

                                 <tr>
                                     <td></td>
                                    <td class="auto-style2"><asp:Label ID="lbl_Camarero" runat="server" Text="Camarero"></asp:Label></td>
                                    <td class="auto-style3"><asp:Label ID="lbl_Cocinero" runat="server" Text="Cocinero"></asp:Label></td>
                                 </tr>
                                  <tr>
                                    <td class="auto-style2"></td>
                                    <td class="auto-style3">
                                        <asp:GridView ID="dt_cocineros" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
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
                                        <asp:GridView ID="dt_camareros" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
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
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_id" runat="server" Text="ID Empleado"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="lbl_idEmpleado" runat="server" Text=""></asp:Label></td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_nombre" runat="server" Text="Nombre"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_apellido" runat="server" Text="Apellido"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:TextBox ID="txt_apellido" runat="server"></asp:TextBox> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_email" runat="server" Text="Email"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:TextBox ID="txt_email" runat="server"></asp:TextBox> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_domicilio" runat="server" Text="Domicilio"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:TextBox ID="txt_domicilio" runat="server"></asp:TextBox> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_telefono" runat="server" Text="Telefono"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_tipoEmpleado" runat="server" Text="Tipo Empleado"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:TextBox ID="txt_tipoEmpleado" runat="server"></asp:TextBox> <asp:Label ID="lbl_idTipoEmpleado" runat="server" Text="" Visible="false"></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td class="auto-style2"></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg" onclientclick='btn_asignarEmpleado_Click' ID="btn_asignarEmpleado" runat="server" Text="Asignar Empleado" /> </td>
                                  </tr>
                                  <tr>
                                    <td class="auto-style2"></td>
                                       
                                    <td class="auto-style3">&nbsp;</td> 
                                    <td>&nbsp;</td>
                                    <td style="padding-top:1em;" class="auto-style1">&nbsp;</td>
                                   
                                    <td>&nbsp;</td> 
                                    <td>&nbsp;</td>
                                  </tr>
                                  </tbody>
                              </table>             
      <footer>
      </footer>
</div>
</asp:Content>