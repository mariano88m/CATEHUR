<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Presupuesto.aspx.vb" Inherits="GUI.Presupuesto" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
             <script type="text/javascript">
                 function openModal() {
                     $('#myModal').modal('show');
                 }

    </script>
    <h2><asp:Label ID="lbl_SolicitudPresupuesto" runat="server" Text="Solicitud de Presupuesto"></asp:Label></h2>
     <table class ="table-hover"  style ="border-top: 5px solid white;">


    <tbody>
      <tr>
        <td><asp:Label ID="lbl_Cliente"  runat="server" Text="Cliente"></asp:Label></td>
        <td><asp:DropDownList ID="cmb_cliente" runat="server" class="form-control input-sm"></asp:DropDownList> </td>
          <td><asp:Button Class="btn btn-primary btn-sm" ID="btn_altaCliente" runat="server" Text="Alta Cliente" /></td>

      </tr>
      <tr>
        <td><asp:Label ID="lbl_NombreEvento" runat="server" Text="Nombre del Evento"></asp:Label></td>
        <td><asp:TextBox ID="Txt_NombreEvento" runat="server" class="form-control input-sm"></asp:TextBox></td>
      </tr>
      <tr>
        <td><asp:Label ID="lbl_DireccionEvento" runat="server" Text="Direccion"></asp:Label></td>
        <td><asp:TextBox ID="txt_direccionEvento" runat="server" class="form-control input-sm"></asp:TextBox></td>
        <td><asp:Label ID="lbl_localidad" runat="server" Text="Localidad"></asp:Label></td>
        <td><asp:DropDownList ID="cmb_localidad" runat="server" class="form-control input-sm"></asp:DropDownList></td>
      </tr>
      <tr>
        <td><asp:Label ID="lbl_TipoCatering" runat="server" Text="Tipo de Catering"></asp:Label></td>
        <td><asp:RadioButtonList ID="rd_catering" runat="server" CssClass="radio inline"></asp:RadioButtonList></td>
        <td><asp:Label ID="lbl_PrecioPersona" runat="server" Text="Precio por Persona"></asp:Label></td>
        <td><asp:Label ID="lbl_PrecioXPersona" runat="server" Text=""></asp:Label></td>
      </tr>
      <tr>
          <td></td>
               
          <td style ="padding-bottom:2em; padding-top:2em;"> 
 
<%--          <button type="button" id="btn_SeleccionarMenu" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#myModal" runat="server" style="width:200px;" >Menu</button>--%>
               <button type="button" id="btn_SeleccionarMenu" class="btn btn-primary btn-sm" runat="server" style="width:200px;" >Menu</button>

              <input type="hidden" id="ModalCatering" runat="server" />
              
                 </td>
          <td></td>
      </tr>

      <tr>
        <td><asp:Label ID="lbl_cantPersonas" runat="server" Text="Cantidad de Personas" style ="padding-right:1em;"></asp:Label></td>
        <td><asp:TextBox ID="txt_cantPersonas" runat="server" class="form-control input-sm" ></asp:TextBox></td>
        <td></td>
        <td></td>   
     </tr>
      <tr>
        <td><asp:Label ID="lbl_fecha" runat="server" Text="Fecha del Evento" style ="padding-right:1em;"></asp:Label></td>
        <td><asp:TextBox ID="Txt_fecha" runat="server" style ="padding-right:1em;" class="form-control input-sm"></asp:TextBox>
            <asp:Calendar ID="Calendar1" runat="server" Visible="false"></asp:Calendar>
            <asp:Button Class="btn" ID="Btn_fecha" runat="server" Text="Seleccionar" /></td>
      </tr>
      <tr>
        <td><asp:Label ID="lbl_comentarios" runat="server" Text="Comentarios" style ="padding-right:1em;"></asp:Label></td>
        <td><asp:TextBox ID="txt_comentarios" runat="server" class="form-control input-sm"></asp:TextBox></td>
      </tr>

      <tr>
        <td style ="padding-bottom:2em; padding-top:2em;"><asp:Button Class="btn btn-default btn-sm" ID="Btn_Limpiar" runat="server" Text="Limpiar" /></td>
        <td style ="padding-bottom:2em; padding-top:2em;"><asp:Button Class="btn btn-success btn-sm " ID="btn_GenerarPresupuesto" runat="server" Text="Generar Presupuesto" /></td>
      </tr>
    </tbody>
  </table>


      <footer>
        <p>© CATEHUR</p>
      </footer>

<!-- Modal -->

    
<div class="modal" id="myModal">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
           <table class="table-hover" style ="border-top: 0px;">

                                <tbody>
                                  <tr>
                                    <td><asp:Label ID="lbl_Entrada" runat="server" Text="Entrada"></asp:Label></td>
                                    <td><asp:Label ID="lbl_PlatoPrincipal" runat="server" Text="Plato Principal"></asp:Label></td>
                                    <td><asp:Label ID="lbl_postre" runat="server" Text="Postre"></asp:Label></td>
                                    <td><asp:Label ID="lbl_bebida" runat="server" Text="Bebida"></asp:Label></td>

                                  </tr>
                                 <tr>
                                    <td><asp:CheckBoxList ID="Chk_Entrada" runat="server" CssClass="radio inline"></asp:CheckBoxList></td>
                                    <td><asp:CheckBoxList ID="chk_PlatoPrincipal" runat="server" CssClass="radio inline"></asp:CheckBoxList></td> 
                                    <td><asp:CheckBoxList ID="chk_Postre" runat="server" CssClass="radio inline"></asp:CheckBoxList></td> 
                                    <td><asp:CheckBoxList ID="chk_bebida" runat="server" CssClass="radio inline"></asp:CheckBoxList></td> 
 
                                 </tr>
                         
                                </tbody>
          </table>

      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
        <button type="button" class="btn btn-primary" id="btn_ConfirmarMenu" runat="server">Confirmar Menu</button>
      </div>
    </div>
  </div>
</div>

 </div>

</asp:Content>
