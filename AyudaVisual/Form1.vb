Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Data
Imports System.Threading
Imports CapaNegocios

Partial Public Class Form1
    'Inherits Datos
    Inherits DevExpress.XtraEditors.XtraForm

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 200
            Thread.Sleep(200)
        Next


    End Sub

    Private Sub DropDownButton1_Click(sender As Object, e As EventArgs) Handles DropDownButton1.Click

        'INSERT INTO `al5` (`Nombre`, `Descripcion`,`PDF`) VALUES ("HS-0254', 'cable crimpiado','Archivo.pdf")

    End Sub

End Class
