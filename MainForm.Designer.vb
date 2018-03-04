<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CounterLabel = New System.Windows.Forms.Label()
        Me.UpPictureBox = New System.Windows.Forms.PictureBox()
        Me.DownPictureBox = New System.Windows.Forms.PictureBox()
        Me.ResetMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.UpPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DownPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResetMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CounterLabel
        '
        Me.CounterLabel.AutoSize = True
        Me.CounterLabel.Font = New System.Drawing.Font("Consolas", 72.0!)
        Me.CounterLabel.Location = New System.Drawing.Point(20, 15)
        Me.CounterLabel.Name = "CounterLabel"
        Me.CounterLabel.Size = New System.Drawing.Size(153, 112)
        Me.CounterLabel.TabIndex = 0
        Me.CounterLabel.Text = "00"
        '
        'UpPictureBox
        '
        Me.UpPictureBox.Image = CType(resources.GetObject("UpPictureBox.Image"), System.Drawing.Image)
        Me.UpPictureBox.Location = New System.Drawing.Point(180, 15)
        Me.UpPictureBox.Name = "UpPictureBox"
        Me.UpPictureBox.Size = New System.Drawing.Size(50, 50)
        Me.UpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UpPictureBox.TabIndex = 1
        Me.UpPictureBox.TabStop = False
        '
        'DownPictureBox
        '
        Me.DownPictureBox.Image = CType(resources.GetObject("DownPictureBox.Image"), System.Drawing.Image)
        Me.DownPictureBox.Location = New System.Drawing.Point(180, 82)
        Me.DownPictureBox.Name = "DownPictureBox"
        Me.DownPictureBox.Size = New System.Drawing.Size(50, 50)
        Me.DownPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DownPictureBox.TabIndex = 2
        Me.DownPictureBox.TabStop = False
        '
        'ResetMenuStrip
        '
        Me.ResetMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetMenuItem})
        Me.ResetMenuStrip.Name = "ResetMenuStrip"
        Me.ResetMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ResetMenuStrip.ShowImageMargin = False
        Me.ResetMenuStrip.Size = New System.Drawing.Size(129, 26)
        '
        'ResetMenuItem
        '
        Me.ResetMenuItem.Name = "ResetMenuItem"
        Me.ResetMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ResetMenuItem.Text = "Reset counter"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 145)
        Me.ContextMenuStrip = Me.ResetMenuStrip
        Me.Controls.Add(Me.DownPictureBox)
        Me.Controls.Add(Me.UpPictureBox)
        Me.Controls.Add(Me.CounterLabel)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Easy Counter"
        CType(Me.UpPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DownPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResetMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CounterLabel As System.Windows.Forms.Label
    Friend WithEvents UpPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DownPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ResetMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResetMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
