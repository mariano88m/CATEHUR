<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RegistrarPerdidas.aspx.vb" Inherits="GUI.RegistrarPerdidas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
   <table class="table-hover" style ="border-top: 0px;">
           <h2><asp:Label ID="lbl_registrarPerdidas" runat="server" Text="Registrar Perdidas"></asp:Label></h2>
                                <tbody>
                                  <tr>
                                    <td><asp:Label ID="lbl_Elemento"  runat="server" Text="Vajilla"></asp:Label></td>
                                    <td><asp:DropDownList ID="cmb_Elemento" runat="server" class="form-control input-lg"></asp:DropDownList> </td>
                                  </tr>
                                 <tr>
 
                                    <td><asp:Label ID="lbl_CantElemento" runat="server" Text="Cantidad"></asp:Label></td> 
                                    <td><asp:TextBox ID="txt_CantElemento" runat="server"></asp:TextBox></td>
                                    
                                 </tr>
                                 <tr>
                                    <td></td>
                                    <td><asp:Button Class="btn btn-info btn-lg" ID="Btn_registrarPerdida" runat="server" Text="Registrar Perdida" /></td> 
 
                                 </tr>

                                  </tbody>
                              </table>             
      <footer>
      </footer>

</div> <!-- /container -->






</asp:Content>
