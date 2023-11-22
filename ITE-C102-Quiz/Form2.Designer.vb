<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        btnStart = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("AnglicanText", 51.7499924F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(200, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(483, 88)
        Label1.TabIndex = 0
        Label1.Text = "Crimson Resurgence"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("AnglicanText", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(293, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(297, 47)
        Label2.TabIndex = 1
        Label2.Text = "The Cursed Catacombs"
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.Maroon
        btnStart.FlatStyle = FlatStyle.Popup
        btnStart.Font = New Font("Old English Text MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnStart.ForeColor = Color.Goldenrod
        btnStart.Location = New Point(283, 536)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(316, 49)
        btnStart.TabIndex = 7
        btnStart.Text = "Start the Adventure"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-19, -65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(920, 719)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(884, 597)
        Controls.Add(btnStart)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
