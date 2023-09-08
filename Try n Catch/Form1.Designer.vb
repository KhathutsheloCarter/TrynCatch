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
        btnClick = New Button()
        txtNumber = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnClick
        ' 
        btnClick.Location = New Point(339, 256)
        btnClick.Name = "btnClick"
        btnClick.Size = New Size(94, 29)
        btnClick.TabIndex = 0
        btnClick.Text = "Click"
        btnClick.UseVisualStyleBackColor = True
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(319, 114)
        txtNumber.MaxLength = 8
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(171, 27)
        txtNumber.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 2
        Label1.Text = "input Number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtNumber)
        Controls.Add(btnClick)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label1 As Label
End Class
