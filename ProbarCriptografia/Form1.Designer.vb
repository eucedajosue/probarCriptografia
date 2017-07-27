<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValorTXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValorEncriptadoTXT = New System.Windows.Forms.TextBox()
        Me.EncriptarCMD = New System.Windows.Forms.Button()
        Me.DesencriptarCMD = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValorDesencriptadoTXT = New System.Windows.Forms.TextBox()
        Me.CerrarCMD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor"
        '
        'ValorTXT
        '
        Me.ValorTXT.Location = New System.Drawing.Point(22, 41)
        Me.ValorTXT.Name = "ValorTXT"
        Me.ValorTXT.Size = New System.Drawing.Size(100, 20)
        Me.ValorTXT.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Valor Encriptado"
        '
        'ValorEncriptadoTXT
        '
        Me.ValorEncriptadoTXT.Location = New System.Drawing.Point(22, 86)
        Me.ValorEncriptadoTXT.Name = "ValorEncriptadoTXT"
        Me.ValorEncriptadoTXT.ReadOnly = True
        Me.ValorEncriptadoTXT.Size = New System.Drawing.Size(250, 20)
        Me.ValorEncriptadoTXT.TabIndex = 2
        '
        'EncriptarCMD
        '
        Me.EncriptarCMD.Location = New System.Drawing.Point(128, 38)
        Me.EncriptarCMD.Name = "EncriptarCMD"
        Me.EncriptarCMD.Size = New System.Drawing.Size(75, 23)
        Me.EncriptarCMD.TabIndex = 1
        Me.EncriptarCMD.Text = "Desencriptar"
        Me.EncriptarCMD.UseVisualStyleBackColor = True
        '
        'DesencriptarCMD
        '
        Me.DesencriptarCMD.Location = New System.Drawing.Point(278, 83)
        Me.DesencriptarCMD.Name = "DesencriptarCMD"
        Me.DesencriptarCMD.Size = New System.Drawing.Size(75, 23)
        Me.DesencriptarCMD.TabIndex = 3
        Me.DesencriptarCMD.Text = "Desencriptar"
        Me.DesencriptarCMD.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Valor Desencriptado"
        '
        'ValorDesencriptadoTXT
        '
        Me.ValorDesencriptadoTXT.Location = New System.Drawing.Point(22, 126)
        Me.ValorDesencriptadoTXT.Name = "ValorDesencriptadoTXT"
        Me.ValorDesencriptadoTXT.ReadOnly = True
        Me.ValorDesencriptadoTXT.Size = New System.Drawing.Size(100, 20)
        Me.ValorDesencriptadoTXT.TabIndex = 4
        '
        'CerrarCMD
        '
        Me.CerrarCMD.Location = New System.Drawing.Point(307, 158)
        Me.CerrarCMD.Name = "CerrarCMD"
        Me.CerrarCMD.Size = New System.Drawing.Size(75, 23)
        Me.CerrarCMD.TabIndex = 5
        Me.CerrarCMD.Text = "Cerrar"
        Me.CerrarCMD.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 193)
        Me.Controls.Add(Me.CerrarCMD)
        Me.Controls.Add(Me.DesencriptarCMD)
        Me.Controls.Add(Me.EncriptarCMD)
        Me.Controls.Add(Me.ValorDesencriptadoTXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ValorEncriptadoTXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ValorTXT)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Prueba de encriptación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ValorTXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ValorEncriptadoTXT As TextBox
    Friend WithEvents EncriptarCMD As Button
    Friend WithEvents DesencriptarCMD As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ValorDesencriptadoTXT As TextBox
    Friend WithEvents CerrarCMD As Button
End Class
