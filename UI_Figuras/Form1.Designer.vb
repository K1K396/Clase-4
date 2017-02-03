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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxSelector = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLabel2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLabel3 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la figura a calcular: "
        '
        'cbxSelector
        '
        Me.cbxSelector.FormattingEnabled = True
        Me.cbxSelector.Items.AddRange(New Object() {"Cuadrado", "Rectangulo", "Triangulo", "Paralelogramo"})
        Me.cbxSelector.Location = New System.Drawing.Point(16, 30)
        Me.cbxSelector.Name = "cbxSelector"
        Me.cbxSelector.Size = New System.Drawing.Size(121, 21)
        Me.cbxSelector.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'txtLabel2
        '
        Me.txtLabel2.Location = New System.Drawing.Point(16, 91)
        Me.txtLabel2.Name = "txtLabel2"
        Me.txtLabel2.Size = New System.Drawing.Size(100, 20)
        Me.txtLabel2.TabIndex = 3
        Me.txtLabel2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'txtLabel3
        '
        Me.txtLabel3.Location = New System.Drawing.Point(166, 91)
        Me.txtLabel3.Name = "txtLabel3"
        Me.txtLabel3.Size = New System.Drawing.Size(100, 20)
        Me.txtLabel3.TabIndex = 5
        Me.txtLabel3.Visible = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(104, 146)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(55, 175)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(165, 20)
        Me.txtResultado.TabIndex = 7
        Me.txtResultado.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtLabel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLabel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxSelector)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbxFiguras As ComboBox
    Friend WithEvents cbxSelector As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLabel2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLabel3 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtResultado As TextBox
End Class
