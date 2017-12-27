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


Partial Public Class ElaboracionPlatos

    '''<summary>
    '''Control Lbl_ElaboracionPlatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Lbl_ElaboracionPlatos As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_platos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_platos As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control cmb_Plato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cmb_Plato As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control btn_buscarPlato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_buscarPlato As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control lbl_nombrePlato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_nombrePlato As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_NombrePlato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_NombrePlato As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control idPlato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idPlato As Global.System.Web.UI.WebControls.HiddenField

    '''<summary>
    '''Control lbl_manodeobra.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_manodeobra As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_Manodeobra.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_Manodeobra As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control lbl_precio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_precio As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_precio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_precio As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control lbl_tipomenu.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_tipomenu As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control cmb_tipomenu.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cmb_tipomenu As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control lbl_ingredientesAsignados.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_ingredientesAsignados As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_IngredientesDiponibles.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_IngredientesDiponibles As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control dt_IngredientesAsignados.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dt_IngredientesAsignados As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control lbl_ingrediente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_ingrediente As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control cmb_Ingredientes.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cmb_Ingredientes As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control btn_AgregarNuevoIngrediente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_AgregarNuevoIngrediente As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control btn_BajaIngrediente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_BajaIngrediente As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control lbl_NuevoIngrediente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_NuevoIngrediente As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_NuevoIngrediente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_NuevoIngrediente As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control lbl_NuevoIngredientePrecio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_NuevoIngredientePrecio As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_NuevoIngredientePrecio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_NuevoIngredientePrecio As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control btn_AltaIngrediente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_AltaIngrediente As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control lbl_cantidad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_cantidad As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txt_cantidad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_cantidad As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control btn_QuitarIngrediente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_QuitarIngrediente As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control btn_AgregarIngrediente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_AgregarIngrediente As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control dt_cateringAsignados.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dt_cateringAsignados As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control lbl_catering.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_catering As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control cmb_catering.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents cmb_catering As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control btn_quitarCatering.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_quitarCatering As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control btn_asignarCatering.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_asignarCatering As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control btn_AltaPlato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_AltaPlato As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control btn_modificarPlato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_modificarPlato As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control btn_bajaPlato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_bajaPlato As Global.System.Web.UI.WebControls.Button
End Class
