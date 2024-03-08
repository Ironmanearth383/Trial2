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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AttachButton = New System.Windows.Forms.Button()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.send = New System.Windows.Forms.Button()
        Me.ChatBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.connect = New System.Windows.Forms.Button()
        Me.clientport = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.start = New System.Windows.Forms.Button()
        Me.ServerPort = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.AttachButton)
        Me.Panel1.Controls.Add(Me.MessageTextBox)
        Me.Panel1.Controls.Add(Me.send)
        Me.Panel1.Controls.Add(Me.ChatBox)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(361, 319)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'AttachButton
        '
        Me.AttachButton.Location = New System.Drawing.Point(671, 345)
        Me.AttachButton.Name = "AttachButton"
        Me.AttachButton.Size = New System.Drawing.Size(108, 58)
        Me.AttachButton.TabIndex = 5
        Me.AttachButton.Text = "Files"
        Me.AttachButton.UseVisualStyleBackColor = True
        '
        'MessageTextBox
        '
        Me.MessageTextBox.Location = New System.Drawing.Point(565, 201)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(214, 90)
        Me.MessageTextBox.TabIndex = 4
        '
        'send
        '
        Me.send.Location = New System.Drawing.Point(563, 345)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(108, 58)
        Me.send.TabIndex = 4
        Me.send.Text = "send"
        Me.send.UseVisualStyleBackColor = True
        '
        'ChatBox
        '
        Me.ChatBox.Location = New System.Drawing.Point(12, 161)
        Me.ChatBox.Multiline = True
        Me.ChatBox.Name = "ChatBox"
        Me.ChatBox.Size = New System.Drawing.Size(508, 277)
        Me.ChatBox.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.connect)
        Me.Panel3.Controls.Add(Me.clientport)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Location = New System.Drawing.Point(12, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(776, 70)
        Me.Panel3.TabIndex = 2
        '
        'connect
        '
        Me.connect.Location = New System.Drawing.Point(680, 32)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(75, 23)
        Me.connect.TabIndex = 4
        Me.connect.Text = "connect"
        Me.connect.UseVisualStyleBackColor = True
        '
        'clientport
        '
        Me.clientport.Location = New System.Drawing.Point(338, 33)
        Me.clientport.Name = "clientport"
        Me.clientport.Size = New System.Drawing.Size(321, 22)
        Me.clientport.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 33)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(307, 22)
        Me.TextBox5.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.start)
        Me.Panel2.Controls.Add(Me.ServerPort)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 67)
        Me.Panel2.TabIndex = 1
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(680, 32)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 3
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'ServerPort
        '
        Me.ServerPort.Location = New System.Drawing.Point(338, 33)
        Me.ServerPort.Name = "ServerPort"
        Me.ServerPort.Size = New System.Drawing.Size(321, 22)
        Me.ServerPort.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(307, 22)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server"
        '
        'BackgroundWorker2
        '
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MessageTextBox As TextBox
    Friend WithEvents send As Button
    Friend WithEvents ChatBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents connect As Button
    Friend WithEvents clientport As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents start As Button
    Friend WithEvents ServerPort As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AttachButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
