<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JokeManager
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JokeManager))
        Me.btnblocksys = New System.Windows.Forms.Button()
        Me.butpoweroff = New System.Windows.Forms.Button()
        Me.btnscream = New System.Windows.Forms.Button()
        Me.preventiontimer = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnblocksys
        '
        Me.btnblocksys.FlatAppearance.BorderSize = 3
        Me.btnblocksys.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnblocksys.Location = New System.Drawing.Point(25, 12)
        Me.btnblocksys.Name = "btnblocksys"
        Me.btnblocksys.Size = New System.Drawing.Size(172, 35)
        Me.btnblocksys.TabIndex = 0
        Me.btnblocksys.Text = "BLOCK SYSTEM JOKE"
        Me.btnblocksys.UseVisualStyleBackColor = True
        '
        'butpoweroff
        '
        Me.butpoweroff.FlatAppearance.BorderSize = 3
        Me.butpoweroff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butpoweroff.Location = New System.Drawing.Point(25, 53)
        Me.butpoweroff.Name = "butpoweroff"
        Me.butpoweroff.Size = New System.Drawing.Size(171, 35)
        Me.butpoweroff.TabIndex = 1
        Me.butpoweroff.Text = "SHUTDOWN TIMER"
        Me.butpoweroff.UseVisualStyleBackColor = True
        '
        'btnscream
        '
        Me.btnscream.FlatAppearance.BorderSize = 3
        Me.btnscream.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnscream.Location = New System.Drawing.Point(25, 94)
        Me.btnscream.Name = "btnscream"
        Me.btnscream.Size = New System.Drawing.Size(171, 35)
        Me.btnscream.TabIndex = 2
        Me.btnscream.Text = "SCREAM JOKE TIMER"
        Me.btnscream.UseVisualStyleBackColor = True
        '
        'preventiontimer
        '
        Me.preventiontimer.Interval = 60000
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(40, 261)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(130, 45)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'JokeManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 141)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnscream)
        Me.Controls.Add(Me.butpoweroff)
        Me.Controls.Add(Me.btnblocksys)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "JokeManager"
        Me.Text = "Joke Manager"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnblocksys As Button
    Friend WithEvents butpoweroff As Button
    Friend WithEvents btnscream As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents preventiontimer As Timer
End Class
