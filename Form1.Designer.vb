<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Crv_visor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteTejido1 = New vbcrystalreports.reporteTejido()
        Me.SuspendLayout()
        '
        'Crv_visor
        '
        Me.Crv_visor.ActiveViewIndex = -1
        Me.Crv_visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv_visor.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv_visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crv_visor.Location = New System.Drawing.Point(0, 0)
        Me.Crv_visor.Name = "Crv_visor"
        Me.Crv_visor.Size = New System.Drawing.Size(839, 602)
        Me.Crv_visor.TabIndex = 0
        Me.Crv_visor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 602)
        Me.Controls.Add(Me.Crv_visor)
        Me.Name = "Form1"
        Me.Text = "Visor de reportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Crv_visor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteTejido1 As reporteTejido
End Class
