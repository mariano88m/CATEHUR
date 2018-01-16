<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionFamilia.aspx.vb" Inherits="GUI.GestionFamilia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
     
     <h3><asp:Label ID="lbl_gestionFamilia" runat="server" Text="Gestion Familia"></asp:Label></h3>
   
     <div class="bs-docs-section">
         <div class="row">
             <div class="col-lg-4">
                 <div class ="bs-component">
                     
                    <div class="card border-secondary mb-3" >
                    <div class="card-header"><asp:Label ID="Label1" runat="server" Text="Modificar Familia"></asp:Label></div>
                    <div class="card-body text-secondary">
                    <h4 class="card-title"></h4>
                    <p class="card-text"><asp:Label ID="lbl_familia" runat="server" Text="Familias: "></asp:Label><asp:DropDownList ID="cmb_Familia" runat="server"></asp:DropDownList></p>
                    <p><asp:Button ID="btn_buscarFamilia" class="btn" runat="server" Text="Buscar Familia" /></p>
                    </div>
                    </div>





                 </div>
              </div>
              <div class="col-lg-4">
                 <div class ="bs-component">
                    <div class="card border-secondary mb-3">
  <div class="card-header"><asp:Label ID="lbl_NuevaFamilia" runat="server" Text="Nueva Familia"></asp:Label></div>
  <div class="card-body text-secondary">
    <h4 class="card-title"></h4>
    <p class="card-text"><asp:TextBox ID="txt_AltaFamilia" runat="server"></asp:TextBox></p>
    <p><asp:Button Class="btn btn-info btn-lg" onclientclick='btn_asignarEmpleado_Click' ID="btn_AltaFamilia" runat="server" Text="Alta familia" /></p>
  </div>
</div>

                 </div>
              </div>

                          <div class="col-lg-4">
                 <div class ="bs-component">
<div class="card border-secondary mb-3" >
  <div class="card-header"><asp:Label ID="lbl_BajaFamilia" runat="server" Text= "Baja Familia"></asp:Label></div>
  <div class="card-body text-secondary">
    <h4 class="card-title"></h4>
    <p class="card-text"><asp:DropDownList ID="cmb_BajaFamilia" runat="server"></asp:DropDownList></p>
    <p><asp:Button Class="btn btn-info btn-lg" onclientclick='btn_asignarEmpleado_Click' ID="btn_BajaFamilia" runat="server" Text="Baja familia" /></p>
  </div>
</div>       
 





                 </div>
              </div>

            </div>
     </div>
 
  
                              

        
                           


 








<div class="card border-secondary mb-3">
  <div class="card-header"><asp:Label ID="Label2" runat="server" Text="Asignacion de Permisos"></asp:Label></div>
  <div class="card-body text-secondary">
    <h4 class="card-title"></h4>
    <p class="card-text"><asp:Label ID="Label3" runat="server" Text="Familias: " /></p>
    <p>
        <table class="table-hover" style ="border-top: 0px;" >
                                <tbody>
                                    
                                 <tr>
                                     <td></td>
                                    <td class="auto-style2" style="width: 526px"><asp:Label ID="lbl_familiasAsignadas" runat="server" Text="Familias asignadas"></asp:Label></td>
                                    <td class="auto-style3"><asp:Label ID="lbl_familiasDisponibles" runat="server" Text="Familias disponibles"></asp:Label></td>
                                 </tr>
                                  <tr>
                                    <td class="auto-style2"></td>
                                    <td class="auto-style3" style="width: 526px">
                                        <asp:GridView ID="dt_FamiliasAsignadas" runat="server" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                                            <Columns>
                                                <asp:CommandField ShowSelectButton="True" />
                                            </Columns>
                                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="Blue" />
                                            <PagerSettings Position="Top" />
                                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="Red" />
                                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                            <SortedDescendingHeaderStyle BackColor="#242121" />
                                        </asp:GridView>
                                    </td>
                                      <td>
                                        <asp:GridView ID="dt_FamiliasDisponibles" runat="server" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                                            <Columns>
                                                <asp:CommandField ShowSelectButton="True" />
                                            </Columns>
                                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="Blue" />
                                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="Red" />
                                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                            <SortedDescendingHeaderStyle BackColor="#242121" />
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
       </p>
  </div>
</div>
            
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
               
        
        
        
        
      






        
</asp:Content>
