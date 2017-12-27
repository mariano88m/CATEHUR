'------------------------------------------------------------------------------
' <generado automáticamente>
'     Este código fue generado por una herramienta.
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código. 
' </generado automáticamente>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class Presupuesto

    '''<summary>
    '''Control lbl_SolicitudPresupuesto.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_SolicitudPresupuesto As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_Cliente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_Cliente As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control cmb_cliente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cmb_cliente As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control btn_altaCliente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_altaCliente As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control lbl_NombreEvento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_NombreEvento As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control Txt_NombreEvento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_NombreEvento As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control lbl_DireccionEvento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_DireccionEvento As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_direccionEvento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_direccionEvento As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control lbl_localidad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_localidad As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control cmb_localidad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cmb_localidad As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control lbl_TipoCatering.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_TipoCatering As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control rd_catering.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents rd_catering As Global.System.Web.UI.WebControls.RadioButtonList

    '''<summary>
    '''Control lbl_PrecioPersona.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_PrecioPersona As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_PrecioXPersona.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_PrecioXPersona As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control btn_SeleccionarMenu.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_SeleccionarMenu As Global.System.Web.UI.HtmlControls.HtmlButton

    '''<summary>
    '''Control ModalCatering.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents ModalCatering As Global.System.Web.UI.HtmlControls.HtmlInputHidden

    '''<summary>
    '''Control lbl_cantPersonas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_cantPersonas As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_cantPersonas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_cantPersonas As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control lbl_fecha.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_fecha As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control Txt_fecha.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_fecha As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Calendar1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Calendar1 As Global.System.Web.UI.WebControls.Calendar

    '''<summary>
    '''Control Btn_fecha.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_fecha As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control lbl_comentarios.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_comentarios As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_comentarios.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_comentarios As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Btn_Limpiar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Limpiar As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control btn_GenerarPresupuesto.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_GenerarPresupuesto As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control lbl_Entrada.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_Entrada As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_PlatoPrincipal.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_PlatoPrincipal As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_postre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_postre As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_bebida.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_bebida As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control Chk_Entrada.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Chk_Entrada As Global.System.Web.UI.WebControls.CheckBoxList

    '''<summary>
    '''Control chk_PlatoPrincipal.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents chk_PlatoPrincipal As Global.System.Web.UI.WebControls.CheckBoxList

    '''<summary>
    '''Control chk_Postre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents chk_Postre As Global.System.Web.UI.WebControls.CheckBoxList

    '''<summary>
    '''Control chk_bebida.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents chk_bebida As Global.System.Web.UI.WebControls.CheckBoxList

    '''<summary>
    '''Control btn_ConfirmarMenu.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_ConfirmarMenu As Global.System.Web.UI.HtmlControls.HtmlButton
End Class
