<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtMinecraftFolderPath = New System.Windows.Forms.TextBox()
        Me.txtModpackPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMinecraftFolderPath
        '
        Me.txtMinecraftFolderPath.Enabled = False
        Me.txtMinecraftFolderPath.Location = New System.Drawing.Point(114, 9)
        Me.txtMinecraftFolderPath.Name = "txtMinecraftFolderPath"
        Me.txtMinecraftFolderPath.Size = New System.Drawing.Size(233, 20)
        Me.txtMinecraftFolderPath.TabIndex = 0
        '
        'txtModpackPath
        '
        Me.txtModpackPath.Enabled = False
        Me.txtModpackPath.Location = New System.Drawing.Point(114, 59)
        Me.txtModpackPath.Name = "txtModpackPath"
        Me.txtModpackPath.Size = New System.Drawing.Size(233, 20)
        Me.txtModpackPath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ".minecraft Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modpack location:"
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(272, 109)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.Text = "Go"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 109)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(139, 109)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "Help!"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtModpackPath)
        Me.Controls.Add(Me.txtMinecraftFolderPath)
        Me.Name = "Form1"
        Me.Text = "Kronk's ModLoader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMinecraftFolderPath As TextBox
    Friend WithEvents txtModpackPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExecute As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnHelp As Button
End Class
