<%@ Page Language="vb" AutoEventWireup="false"  MasterPageFile="~/Site.Master" CodeBehind="AsignarPersonal.aspx.vb" Inherits="GUI.AsignarPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            <script type="text/javascript">
                function openModal() {
                    $('#myModal').modal('show');
                }

        </script>
    <div class="container">

    <h2><asp:Label ID="lbl_AsignarPersonal" runat="server" Text="Asignar Personal"></asp:Label></h2>

<div class="card border-secondary mb-3">
  <div class="card-header"><asp:Label ID="lbl_eventos" runat="server" Text="Eventos"></asp:Label></div>
  <div class="card-body text-secondary">
    <h4 class="card-title"></h4>
    <p>

                                        <asp:GridView ID="dt_eventos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
                                            <Columns>
                                                <asp:CommandField ShowSelectButton="True" />
                                            </Columns>
                                            <EditRowStyle BackColor="#2461BF" />
                                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="Blue" />
                                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                            <RowStyle BackColor="#EFF3FB" />
                                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="Red" />
                                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                        </asp:GridView>

    </p>
        </div>
</div>


                                 
<div class="card border-secondary mb-3">
  <div class="card-header"><asp:Label ID="lbl_ListaEmpleados" runat="server" Text="Lista de Empleados"></asp:Label></div>
  <div class="card-body text-secondary">
    <h4 class="card-title"></h4>
    <p>

                                        <asp:GridView ID="dt_empleados" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
                                            <Columns>
                                                <asp:CommandField ShowSelectButton="True" />
                                            </Columns>
                                            <EditRowStyle BackColor="#2461BF" />
                                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="Blue" />
                                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                            <RowStyle BackColor="#EFF3FB" />
                                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="Red" />
                                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                        </asp:GridView>

                                      <asp:Button Class="btn btn-info btn-lg" onclientclick='btn_desasignarEmpleado_Click'  ID="btn_desasignarEmpleado" runat="server" Text="Desasignar Empleado" />

    </p>
    </div>
</div>
        <h3 style="padding-top:1em;"><asp:Label ID="lbl_datosEmpleados" runat="server" Text="Datos de los Empleados"></asp:Label></h3>
         <div class="bs-docs-section">
         <div class="row">
             <div class="col-lg-6">
                 <div class ="bs-component">

                                       <div class="card border-secondary mb-3">
                                       <div class="card-header"><asp:Label ID="lbl_Cocinero" runat="server" Text="Cocinero"></asp:Label></div>
                                       <div class="card-body text-secondary">
                                       <h4 class="card-title"></h4>
                                       <p>
                                         
                                        <asp:GridView ID="dt_cocineros" runat="server" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                                            <Columns>
                                                <asp:CommandField ShowSelectButton="True" />
                                            </Columns>
                                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="Blue" />
                                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                            <PagerTemplate>
                                                &nbsp;
                                            </PagerTemplate>
                                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="Red" />
                                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                            <SortedDescendingHeaderStyle BackColor="#242121" />
                                        </asp:GridView>
                                       </p>
                                       </div>
                                       </div>        
                 </div>
              </div>
              <div class="col-lg-6">
                 <div class ="bs-component">

                                       <div class="card border-secondary mb-3">
                                       <div class="card-header"><asp:Label ID="lbl_Camarero" runat="server" Text="Camarero"></asp:Label></div>
                                       <div class="card-body text-secondary">
                                       <h4 class="card-title"></h4>
                                       <p>
                                        <asp:GridView ID="dt_camareros" runat="server" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
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
                                       </p>
                                       </div>
                                       </div>

                 </div>
              </div>
        </div>
        

<div class="modal" id="myModal" style="overflow:scroll;">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">

        <table class="table-hover" style ="border-top: 0px;" >
           
         
                                <tbody>
                                    
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_id" runat="server" Text="ID Empleado"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="lbl_idEmpleado" runat="server" Text=""></asp:Label></td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_nombre" runat="server" Text="Nombre"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_nombre" runat="server" Text=""></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_apellido" runat="server" Text="Apellido"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_apellido" runat="server" Text=""></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_email" runat="server" Text="Email"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_email" runat="server" Text=""></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_domicilio" runat="server" Text="Domicilio"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_domicilio" runat="server" Text=""></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_telefono" runat="server" Text="Telefono"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_telefono" runat="server" Text=""></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_tipoEmpleado" runat="server" Text="Tipo Empleado"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_tipoEmpleado" runat="server" Text=""></asp:Label> <asp:Label ID="lbl_idTipoEmpleado" runat="server" Text="" Visible="false"></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td class="auto-style2"></td>
                                    <td style="padding-top:1em;" class="auto-style3"></td>
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

      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
        <asp:Button Class="btn btn-info btn-lg" onclientclick='btn_asignarEmpleado_Click' ID="btn_asignarEmpleado" runat="server" Text="Asignar Empleado" />
      </div>
    </div>
  </div>
</div>







      <footer>
      </footer>
</div>
</asp:Content>