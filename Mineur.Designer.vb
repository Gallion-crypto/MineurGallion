<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mineur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mineur))
        Me.LancerMineur = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Adresse = New System.Windows.Forms.TextBox()
        Me.CreerAdresse = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImporterAdresse = New System.Windows.Forms.Button()
        Me.StopMinage = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statuts = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'LancerMineur
        '
        Me.LancerMineur.BackColor = System.Drawing.Color.Gray
        Me.LancerMineur.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LancerMineur.Location = New System.Drawing.Point(61, 66)
        Me.LancerMineur.Name = "LancerMineur"
        Me.LancerMineur.Size = New System.Drawing.Size(156, 38)
        Me.LancerMineur.TabIndex = 0
        Me.LancerMineur.Text = "Miner"
        Me.LancerMineur.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Votre adresse Gallion"
        '
        'Adresse
        '
        Me.Adresse.Location = New System.Drawing.Point(12, 38)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(706, 22)
        Me.Adresse.TabIndex = 2
        '
        'CreerAdresse
        '
        Me.CreerAdresse.BackColor = System.Drawing.Color.Gray
        Me.CreerAdresse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreerAdresse.Location = New System.Drawing.Point(273, 66)
        Me.CreerAdresse.Name = "CreerAdresse"
        Me.CreerAdresse.Size = New System.Drawing.Size(156, 38)
        Me.CreerAdresse.TabIndex = 3
        Me.CreerAdresse.Text = "Créer une adresse"
        Me.CreerAdresse.UseVisualStyleBackColor = false
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ImporterAdresse)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LancerMineur)
        Me.Panel1.Controls.Add(Me.Adresse)
        Me.Panel1.Controls.Add(Me.CreerAdresse)
        Me.Panel1.Controls.Add(Me.StopMinage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 115)
        Me.Panel1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(668, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(694, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(552, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "0"
        Me.Label2.Visible = false
        '
        'ImporterAdresse
        '
        Me.ImporterAdresse.BackColor = System.Drawing.Color.Gray
        Me.ImporterAdresse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ImporterAdresse.Location = New System.Drawing.Point(498, 66)
        Me.ImporterAdresse.Name = "ImporterAdresse"
        Me.ImporterAdresse.Size = New System.Drawing.Size(156, 38)
        Me.ImporterAdresse.TabIndex = 4
        Me.ImporterAdresse.Text = "Importer une adresse"
        Me.ImporterAdresse.UseVisualStyleBackColor = false
        '
        'StopMinage
        '
        Me.StopMinage.Location = New System.Drawing.Point(61, 66)
        Me.StopMinage.Name = "StopMinage"
        Me.StopMinage.Size = New System.Drawing.Size(156, 38)
        Me.StopMinage.TabIndex = 5
        Me.StopMinage.Text = "Stop"
        Me.StopMinage.UseVisualStyleBackColor = true
        Me.StopMinage.Visible = false
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = ".address"
        Me.OpenFileDialog1.Filter = ".address|*.address"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuts})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 514)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(733, 22)
        Me.StatusStrip1.SizingGrip = false
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statuts
        '
        Me.statuts.Name = "statuts"
        Me.statuts.Size = New System.Drawing.Size(0, 17)
        '
        'Mineur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(733, 536)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Mineur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mineur Gallion"
        Me.TopMost = true
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents LancerMineur As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Adresse As TextBox
    Friend WithEvents CreerAdresse As Button
    Friend WithEvents Log As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ImporterAdresse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents StopMinage As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statuts As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
