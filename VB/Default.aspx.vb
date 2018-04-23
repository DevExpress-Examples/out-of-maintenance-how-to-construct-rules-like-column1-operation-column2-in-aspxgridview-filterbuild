Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class T300128
    Inherits System.Web.UI.Page

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        grid.DataSource = GetData()
        grid.DataBind()
    End Sub

    Public Function GetData() As IEnumerable(Of TestModel)
        Return Enumerable.Range(0, 100).Select(Function(i) New TestModel() With {.Income1 = i * 10, .Income2 = i * 10 + i Mod 11})
    End Function
End Class

Public Class TestModel
    Public Property Income1() As Decimal
    Public Property Income2() As Decimal
End Class