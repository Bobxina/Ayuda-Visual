Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.AyudaVisual.SplashScreen1), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.DropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DropDownButton2 = New DevExpress.XtraEditors.DropDownButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.AyudaVisual.My.Resources.Resources.Logo4
        Me.PictureEdit1.Location = New System.Drawing.Point(300, 15)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(1036, 132)
        Me.PictureEdit1.TabIndex = 0
        '
        'DropDownButton1
        '
        Me.DropDownButton1.ActAsDropDown = False
        Me.DropDownButton1.AllowDrop = True
        Me.DropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
        Me.DropDownButton1.Location = New System.Drawing.Point(33, 204)
        Me.DropDownButton1.Name = "DropDownButton1"
        Me.DropDownButton1.Size = New System.Drawing.Size(191, 43)
        Me.DropDownButton1.TabIndex = 5
        Me.DropDownButton1.Text = "Productos"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(52, 154)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(158, 23)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Seleccione Producto:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(52, 291)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(113, 23)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Sub Ensamble:"
        '
        'DropDownButton2
        '
        Me.DropDownButton2.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
        Me.DropDownButton2.Location = New System.Drawing.Point(33, 338)
        Me.DropDownButton2.Name = "DropDownButton2"
        Me.DropDownButton2.Size = New System.Drawing.Size(191, 43)
        Me.DropDownButton2.TabIndex = 8
        Me.DropDownButton2.Text = "Ensambles"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(268, 154)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(795, 368)
        Me.PanelControl1.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(45, 144)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "ENSAMBLE 3"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(45, 101)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "ENSAMBLE 2"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(45, 50)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "ENSAMBLE 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 557)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.DropDownButton2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.DropDownButton1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DropDownButton1 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DropDownButton2 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl

#End Region

End Class
