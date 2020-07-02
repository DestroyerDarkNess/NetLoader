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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GameOpenMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.AnimaForm1 = New CustomLoader.AnimaForm()
        Me.AnimaButton1 = New CustomLoader.AnimaButton()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProcessTextBox = New CustomLoader.AnimaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnimaForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameOpenMonitor
        '
        Me.GameOpenMonitor.Interval = 1
        '
        'AnimaForm1
        '
        Me.AnimaForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.AnimaForm1.Controls.Add(Me.AnimaButton1)
        Me.AnimaForm1.Controls.Add(Me.StatusLabel)
        Me.AnimaForm1.Controls.Add(Me.Label2)
        Me.AnimaForm1.Controls.Add(Me.ProcessTextBox)
        Me.AnimaForm1.Controls.Add(Me.Label1)
        Me.AnimaForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimaForm1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AnimaForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaForm1.Location = New System.Drawing.Point(0, 0)
        Me.AnimaForm1.Name = "AnimaForm1"
        Me.AnimaForm1.Size = New System.Drawing.Size(301, 157)
        Me.AnimaForm1.TabIndex = 0
        Me.AnimaForm1.Text = "Custom Loader"
        '
        'AnimaButton1
        '
        Me.AnimaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AnimaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaButton1.ImageLocation = New System.Drawing.Point(30, 6)
        Me.AnimaButton1.ImageSize = New System.Drawing.Size(14, 14)
        Me.AnimaButton1.Location = New System.Drawing.Point(269, 0)
        Me.AnimaButton1.Name = "AnimaButton1"
        Me.AnimaButton1.Size = New System.Drawing.Size(32, 28)
        Me.AnimaButton1.TabIndex = 4
        Me.AnimaButton1.Text = "X"
        Me.AnimaButton1.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.Location = New System.Drawing.Point(50, 105)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(91, 15)
        Me.StatusLabel.TabIndex = 3
        Me.StatusLabel.Text = "Waiting Game..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "State : "
        '
        'ProcessTextBox
        '
        Me.ProcessTextBox.Dark = False
        Me.ProcessTextBox.ForeColor = System.Drawing.Color.White
        Me.ProcessTextBox.Location = New System.Drawing.Point(108, 50)
        Me.ProcessTextBox.MaxLength = 32767
        Me.ProcessTextBox.MultiLine = False
        Me.ProcessTextBox.Name = "ProcessTextBox"
        Me.ProcessTextBox.Numeric = False
        Me.ProcessTextBox.ReadOnly = False
        Me.ProcessTextBox.Size = New System.Drawing.Size(181, 27)
        Me.ProcessTextBox.TabIndex = 1
        Me.ProcessTextBox.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Process Name : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(301, 157)
        Me.Controls.Add(Me.AnimaForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomLoader for NetLoader"
        Me.AnimaForm1.ResumeLayout(False)
        Me.AnimaForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AnimaForm1 As CustomLoader.AnimaForm
    Friend WithEvents ProcessTextBox As CustomLoader.AnimaTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GameOpenMonitor As System.Windows.Forms.Timer
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AnimaButton1 As CustomLoader.AnimaButton

End Class
