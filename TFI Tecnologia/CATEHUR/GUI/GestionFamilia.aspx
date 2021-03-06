﻿<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionFamilia.aspx.vb" Inherits="GUI.GestionFamilia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
                <h3><asp:Label ID="lbl_gestionFamilia" runat="server" Text="Gestion Familia"></asp:Label></h3>
     <table class="table-hover" style ="border-top: 0px;" >

         
                                <tbody>

                                 <tr>
                                     <td></td>
                                    <td class="auto-style2" style="width: 526px"><asp:Label ID="lbl_familia" runat="server" Text="Familias: "></asp:Label><asp:DropDownList ID="cmb_Familia" runat="server"></asp:DropDownList>&nbsp;&nbsp;&nbsp; <asp:Button ID="btn_buscarFamilia" class="btn" runat="server" Text="Buscar Familia" /></td>
                                    <td class="auto-style3"></td>
                                 </tr>


                                 <tr>
                                     <td></td>
                                    <td class="auto-style2" style="width: 526px"><asp:Label ID="lbl_familiasAsignadas" runat="server" Text="Familias asignadas"></asp:Label></td>
                                    <td class="auto-style3"><asp:Label ID="lbl_familiasDisponibles" runat="server" Text="Familias disponibles"></asp:Label></td>
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
                                    <td style="padding-top:1em; width: 526px;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg"  ID="btn_QuitarFamilia" runat="server" Text="Quitar Familia" /> </td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Button Class="btn btn-info btn-lg"  ID="btn_AsignarFamilia" runat="server" Text="Asignar Familia" /> </td>

                                  </tr>
  
                                  </tbody>
                              </table>  

      <table class="table-hover" style ="border-top: 0px;" >
                                <tbody>
                                  <tr>

                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_NuevaFamilia" runat="server" Text="Nueva Familia"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:TextBox ID="txt_AltaFamilia" runat="server"></asp:TextBox></td>
                                    <td style="padding-top:2em;" class="auto-style2"><asp:Label ID="lbl_BajaFamilia" runat="server" Text= "Baja Familia"></asp:Label></td>
                                    <td style="padding-top:2em; width: 526px;" class="auto-style2"><asp:DropDownList ID="cmb_BajaFamilia" runat="server"></asp:DropDownList></td>
                                  </tr>
                                    <tr>
                                        <td></td>
                                        <td><asp:Button Class="btn btn-info btn-lg" onclientclick='btn_asignarEmpleado_Click' ID="btn_AltaFamilia" runat="server" Text="Alta familia" /> </td>
                                        <td></td>
                                        <td><asp:Button Class="btn btn-info btn-lg" onclientclick='btn_asignarEmpleado_Click' ID="btn_BajaFamilia" runat="server" Text="Baja familia" /> </td>
                                    </tr>
                                </tbody>
      </table>  
</asp:Content>
