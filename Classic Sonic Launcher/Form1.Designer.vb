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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Sonic1 = New System.Windows.Forms.Button()
        Me.Sonic2 = New System.Windows.Forms.Button()
        Me.Sonic3 = New System.Windows.Forms.Button()
        Me.SonicCD = New System.Windows.Forms.Button()
        Me.SonicMania = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sonic1
        '
        Me.Sonic1.BackgroundImage = Global.Classic_Sonic_Launcher.My.Resources.Resources.sonic_artwork_0
        Me.Sonic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Sonic1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Sonic1.FlatAppearance.BorderSize = 7
        Me.Sonic1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonic1.Location = New System.Drawing.Point(12, 222)
        Me.Sonic1.Name = "Sonic1"
        Me.Sonic1.Size = New System.Drawing.Size(150, 150)
        Me.Sonic1.TabIndex = 0
        Me.Sonic1.UseVisualStyleBackColor = True
        '
        'Sonic2
        '
        Me.Sonic2.BackgroundImage = Global.Classic_Sonic_Launcher.My.Resources.Resources.Sonic_2_2013_icon
        Me.Sonic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Sonic2.FlatAppearance.BorderSize = 7
        Me.Sonic2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonic2.Location = New System.Drawing.Point(168, 222)
        Me.Sonic2.Name = "Sonic2"
        Me.Sonic2.Size = New System.Drawing.Size(150, 150)
        Me.Sonic2.TabIndex = 0
        Me.Sonic2.UseVisualStyleBackColor = True
        '
        'Sonic3
        '
        Me.Sonic3.BackgroundImage = Global.Classic_Sonic_Launcher.My.Resources.Resources.hRi1rum
        Me.Sonic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Sonic3.FlatAppearance.BorderSize = 7
        Me.Sonic3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonic3.Location = New System.Drawing.Point(480, 222)
        Me.Sonic3.Name = "Sonic3"
        Me.Sonic3.Size = New System.Drawing.Size(150, 150)
        Me.Sonic3.TabIndex = 0
        Me.Sonic3.UseVisualStyleBackColor = True
        '
        'SonicCD
        '
        Me.SonicCD.BackgroundImage = Global.Classic_Sonic_Launcher.My.Resources.Resources.cd2011
        Me.SonicCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SonicCD.FlatAppearance.BorderSize = 7
        Me.SonicCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SonicCD.Location = New System.Drawing.Point(324, 222)
        Me.SonicCD.Name = "SonicCD"
        Me.SonicCD.Size = New System.Drawing.Size(150, 150)
        Me.SonicCD.TabIndex = 0
        Me.SonicCD.UseVisualStyleBackColor = True
        '
        'SonicMania
        '
        Me.SonicMania.BackgroundImage = Global.Classic_Sonic_Launcher.My.Resources.Resources.Mania_Icon_JPG
        Me.SonicMania.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SonicMania.FlatAppearance.BorderSize = 7
        Me.SonicMania.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SonicMania.Location = New System.Drawing.Point(636, 222)
        Me.SonicMania.Name = "SonicMania"
        Me.SonicMania.Size = New System.Drawing.Size(150, 150)
        Me.SonicMania.TabIndex = 0
        Me.SonicMania.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Classic_Sonic_Launcher.My.Resources.Resources.logobig
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(214, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 204)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 443)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SonicMania)
        Me.Controls.Add(Me.SonicCD)
        Me.Controls.Add(Me.Sonic3)
        Me.Controls.Add(Me.Sonic2)
        Me.Controls.Add(Me.Sonic1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(814, 480)
        Me.MinimumSize = New System.Drawing.Size(814, 480)
        Me.Name = "Form1"
        Me.Text = "Classic Sonic Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Sonic1 As Button
    Friend WithEvents Sonic2 As Button
    Friend WithEvents Sonic3 As Button
    Friend WithEvents SonicCD As Button
    Friend WithEvents SonicMania As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
