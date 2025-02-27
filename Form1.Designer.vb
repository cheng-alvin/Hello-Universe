<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        helloBtn = New Button()
        txt = New TextBox()
        exitBtn = New Button()
        clear1 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' helloBtn
        ' 
        helloBtn.Location = New Point(29, 56)
        helloBtn.Name = "helloBtn"
        helloBtn.Size = New Size(162, 45)
        helloBtn.TabIndex = 0
        helloBtn.Text = "Hello"
        helloBtn.UseVisualStyleBackColor = True
        ' 
        ' txt
        ' 
        txt.Location = New Point(304, 79)
        txt.Name = "txt"
        txt.Size = New Size(519, 38)
        txt.TabIndex = 1
        ' 
        ' exitBtn
        ' 
        exitBtn.Location = New Point(29, 315)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(162, 45)
        exitBtn.TabIndex = 2
        exitBtn.Text = "Exit"
        exitBtn.UseVisualStyleBackColor = True
        ' 
        ' clear1
        ' 
        clear1.Location = New Point(29, 184)
        clear1.Name = "clear1"
        clear1.Size = New Size(162, 45)
        clear1.TabIndex = 3
        clear1.Text = "Clear"
        clear1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(304, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 31)
        Label1.TabIndex = 5
        Label1.Text = "Text output"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(29, 120)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 45)
        Button1.TabIndex = 6
        Button1.Text = "Goodbye"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 421)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(clear1)
        Controls.Add(exitBtn)
        Controls.Add(txt)
        Controls.Add(helloBtn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents helloBtn As Button
    Friend WithEvents txt As TextBox
    Friend WithEvents exitBtn As Button
    Friend WithEvents clear1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button

End Class
