<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pass
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pass))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.c = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.TextBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(327, 215)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(254, 257)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 42
        Me.TrackBar1.Value = 80
        Me.TrackBar1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(370, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(134, 32)
        Me.Panel2.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sblocca tramite Pendrive"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(321, 115)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(43, 32)
        Me.Panel6.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Accedi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Digita Password"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Soft_Files_Encrypted.My.Resources.Resources._3
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 84)
        Me.Panel1.TabIndex = 38
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(2, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(545, 83)
        Me.Panel5.TabIndex = 28
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Soft_Files_Encrypted.My.Resources.Resources.Senza_titolo
        Me.PictureBox5.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(54, 41)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(60, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 39)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.25!)
        Me.Label2.Location = New System.Drawing.Point(418, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 57)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.25!)
        Me.Label1.Location = New System.Drawing.Point(476, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(139, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 37
        '
        'Timer2
        '
        '
        'Timer7
        '
        '
        'Timer6
        '
        '
        'Timer5
        '
        '
        'Timer4
        '
        '
        'Timer3
        '
        '
        'Timer8
        '
        Me.Timer8.Interval = 4000
        '
        'Timer9
        '
        Me.Timer9.Interval = 4200
        '
        'Timer10
        '
        Me.Timer10.Interval = 2000
        '
        'c
        '
        Me.c.Location = New System.Drawing.Point(218, 88)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(100, 20)
        Me.c.TabIndex = 51
        Me.c.Visible = False
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(232, 37)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(100, 20)
        Me.b.TabIndex = 50
        Me.b.Text = "2"
        Me.b.Visible = False
        '
        'pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Soft_Files_Encrypted.My.Resources.Resources.Immagine_2022_06_13_203453
        Me.ClientSize = New System.Drawing.Size(547, 171)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pass"
        Me.Text = "pass"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer10 As Timer
    Friend WithEvents c As TextBox
    Friend WithEvents b As TextBox
End Class
