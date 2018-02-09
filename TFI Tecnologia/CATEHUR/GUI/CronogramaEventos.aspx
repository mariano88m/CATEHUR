<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CronogramaEventos.aspx.vb" Inherits="GUI.CronogramaEventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <script type="text/javascript">
                function openModal() {
                    $('#myModal').modal('show');
                }

                function modificarEvento() {

                    $('#ModalModificacion').modal('show');

                }

                function modificarMenu() {

                    $('#ModalMenu').modal('show');

                }
            </script>

<div class="container">
     <asp:Label ID="lbl_CronogramaEventos" runat="server" Text="Cronograma de Eventos"></asp:Label>
     
    <div class="bs-docs-section">
         <div class="row">
             <div class="col-lg-4">
                 <div class ="bs-component">
                        <asp:TextBox ID="Txt_fechaDesde" runat="server"></asp:TextBox>
                        <asp:Button Class="btn" ID="Btn_fechaDesde" runat="server" Text="Desde" />
                        <asp:Calendar ID="Calendar1" runat="server" Visible="false"></asp:Calendar>
                </div>
            </div>
             <div class="col-lg-4">
                 <div class ="bs-component">
                        <asp:TextBox ID="Txt_fechaHasta" runat="server"></asp:TextBox>
                        <asp:Button Class="btn" ID="Btn_fechaHasta" runat="server" Text="Hasta" />
                        <asp:Calendar ID="Calendar2" runat="server" Visible="false"></asp:Calendar>
                </div>
            </div>
             <div class="col-lg-4">
                 <div class ="bs-component">
                        <asp:Button Class="btn btn-primary btn-large" ID="Btn_buscar" runat="server" Text="Buscar" />
                 </div>
            </div>
        </div>
    </div>

         
    <div class="hero-unit">
             
             <asp:GridView ID="dt_eventos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                 <Columns>
                     <asp:CommandField SelectText="Ver evento" ShowSelectButton="True">
                     <ControlStyle CssClass="btn btn-outline-info" />
                     </asp:CommandField>
                 </Columns>
                 <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                 <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="Blue" />
                 <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                 <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="Black" />
                 <SortedAscendingCellStyle BackColor="#F7F7F7" />
                 <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                 <SortedDescendingCellStyle BackColor="#E5E5E5" />
                 <SortedDescendingHeaderStyle BackColor="#242121" />
             </asp:GridView>
    
    </div>

 <div class="modal" id="myModal" style="overflow:scroll;">
  <div class="modal-dialog modal-lg" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title"><asp:Label ID="lbl_idEvento" runat="server" Text=""></asp:Label> - <asp:Label ID="txt_nombreEvento" runat="server" Text=""></asp:Label> - <asp:Label ID="txt_fecha" runat="server" Text=""></asp:Label></h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">

        <table class="table-hover" style ="border-top: 0px;" >
           
                                  <tbody>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_Direccion" runat="server" Text="Direccion"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_Direccion" runat="server" Text=""></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_telefono" runat="server" Text="Telefono"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_telefono" runat="server" Text=""></asp:Label> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_Catering" runat="server" Text="Catering"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_tipoCatering" runat="server" Text=""></asp:Label></td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_platos" runat="server" Text="Platos"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"> 
                                        <asp:GridView ID="dt_platos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
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
                                    </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_Bebidas" runat="server" Text="Bebidas"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3">
                                        <asp:GridView ID="dt_bebidas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
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

                                    </td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_cantPersonas" runat="server" Text="Cantidad de Personas"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_cantPersonas" runat="server" Text=""></asp:Label></td>
                                  </tr>
                                                                        
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_comentarios" runat="server" Text="Comentarios"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_comentarios" runat="server" Text="" Height="250" Width="450"></asp:Label></td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_estado" runat="server" Text="Estado del Evento"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_estado" runat="server" Text=""></asp:Label></td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_precioEvento" runat="server" Text="Precio del Evento"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="txt_precioEvento" runat="server" Text=""></asp:Label></td>
                                  </tr>


                                  </tbody>
                              </table>             

      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
        <asp:Button Class="btn btn-info btn-lg"  ID="btn_modificarEvento" runat="server" Text="Modificar Evento" />
      </div>
    </div>
  </div>
</div>

 <div class="modal" id="ModalModificacion" style="overflow:scroll;">
  <div class="modal-dialog modal-lg" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title"><asp:label ID="lbl_MidEvento" runat="server" Text=""></asp:label> - <asp:label ID="txt_MNombre" runat="server" Text=""></asp:label> - <asp:Label ID="lbl_MFecha" runat="server" Text=""></asp:Label></h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">

        <table class="table-hover" style ="border-top: 0px;" >
           
                                  <tbody>
                                    
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_MDireccion" runat="server" Text="Direccion"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:textbox ID="txt_MDireccion" runat="server" Text=""></asp:textbox> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_MTelefono" runat="server" Text="Telefono"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:textbox ID="txt_MTelefono" runat="server" Text=""></asp:textbox> </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_MCatering" runat="server" Text="Catering"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:DropDownList ID="cmb_Mcatering" runat="server"></asp:DropDownList></td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_MPlatos" runat="server" Text="Platos"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"> 
                                        <asp:GridView ID="dt_mplatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />

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
                                    </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="Label14" runat="server" Text="Bebidas"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3">
                                        <asp:GridView ID="dt_mbebidas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
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

                                    </td>
                                  </tr>
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style3"></td>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Button Class="btn btn-success btn-lg"  ID="btn_ModificarMenu" runat="server" Text="ModificarMenu" /></td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_MCantPersonas" runat="server" Text="Cantidad de Personas"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:textbox ID="txt_MCantPersonas" runat="server" OnTextChanged="txt_OnTextChanged" AutoPostBack="true" Text=""></asp:textbox></td>
                                  </tr>
                                                                        
                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_MComentarios" runat="server" Text="Comentarios"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:textbox ID="txt_MComentarios" runat="server" Text="" TextMode="MultiLine" Wrap="False" Height="250" Width="450"></asp:textbox></td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_MEstado" runat="server" Text="Estado del Evento"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:DropDownList ID="cmb_estado" runat="server"></asp:DropDownList></td>
                                  </tr>

                                  <tr>
                                    <td style="padding-top:1em;" class="auto-style2"><asp:Label ID="lbl_MPrecio" runat="server" Text="Precio del Evento"></asp:Label></td>
                                    <td style="padding-top:1em;" class="auto-style3"><asp:Label ID="lbl_MMPrecio" runat="server" Text=""></asp:Label></td>
                                  </tr>


                                  </tbody>
                              </table>             

      </div>
      <div class="modal-footer">


        <asp:Button Class="btn btn-success btn-lg"  ID="btn_aceptar" runat="server" Text="Aceptar" />
        <asp:Button Class="btn btn-danger btn-lg"  ID="btn_Cancelar" runat="server" Text="Cancelar" data-dismiss="modal" />
      </div>
    </div>
  </div>
</div>
    
<div class="modal" id="ModalMenu" style="overflow:scroll;">
  <div class="modal-dialog " role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
          <table class="table table-hover">
          <thead>
                <tr class="table-dark">
                    <th scope="col"><asp:Label ID="lbl_Entrada" runat="server" Text="Entrada"></asp:Label></th>
                </tr>
          </thead>
          <tbody>
                 <tr class="table-active">
                    <th scope="row"><asp:CheckBoxList ID="Chk_Entrada" runat="server" CssClass="radio inline"></asp:CheckBoxList></th>
                  </tr>
          </tbody>
        </table>
        <table class="table table-hover">
          <thead>
                <tr class="table-dark">
                    <th scope="col"><asp:Label ID="lbl_PlatoPrincipal" runat="server" Text="Plato Principal"></asp:Label></th>
                </tr>
          </thead>
          <tbody>
                 <tr class="table-active">
                    <th scope="row"><asp:CheckBoxList ID="chk_PlatoPrincipal" runat="server" CssClass="radio inline"></asp:CheckBoxList></th>
                  </tr>
          </tbody>
        </table>
        <table class="table table-hover">
        <thead>
                <tr class="table-dark">
                    <th scope="col"><asp:Label ID="lbl_postre" runat="server" Text="Postre"></asp:Label></th>
                </tr>
          </thead>
          <tbody>
                 <tr class="table-active">
                    <th scope="row"><asp:CheckBoxList ID="chk_Postre" runat="server" CssClass="radio inline"></asp:CheckBoxList></th>
                  </tr>
          </tbody>
        </table>              
        <table class="table table-hover">
          <thead>
                <tr class="table-dark">
                    <th scope="col"><asp:Label ID="lbl_bebida" runat="server" Text="Bebida"></asp:Label></th>
                </tr>
          </thead>
          <tbody>
                 <tr class="table-active">
                    <th scope="row"><asp:CheckBoxList ID="chk_bebida" runat="server" CssClass="radio inline"></asp:CheckBoxList></th>
                 </tr>
          </tbody>
        </table>                        
          
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" id="btn_CerrarMenu" runat="server">Cerrar</button>
        <button type="button" class="btn btn-primary" id="btn_ConfirmarMenu" runat="server">Confirmar Menu</button>
      </div>
    </div>
  </div>
</div>









      <footer>
        <p>© CATEHUR</p>
      </footer>

</div> <!-- /container -->










</asp:Content>