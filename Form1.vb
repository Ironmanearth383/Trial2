Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Drawing

Public Class Form1
    Private client As TcpClient
    Public STR As StreamReader
    Public STW As StreamWriter
    Public recieve As String
    Public TextToSend As String
    Public ImageToSend As Image

    Private Sub AttachButton_Click(sender As Object, e As EventArgs) Handles AttachButton.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imageFilePath As String = openFileDialog.FileName
            ImageToSend = Image.FromFile(imageFilePath)
            PictureBox1.Image = ImageToSend
        End If
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Dim listener As New TcpListener(IPAddress.Any, Integer.Parse(ServerPort.Text))
        listener.Start()
        client = listener.AcceptTcpClient()
        STR = New StreamReader(client.GetStream())
        STW = New StreamWriter(client.GetStream())
        STW.AutoFlush = True

        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.WorkerSupportsCancellation = True
    End Sub

    Private Sub connect_Click(sender As Object, e As EventArgs) Handles connect.Click
        client = New TcpClient()
        Dim IpEnd As New IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234)
        Try
            client.Connect(IpEnd)
            If (client.Connected) Then
                ChatBox.AppendText("Connected to server " + Environment.NewLine)
                STW = New StreamWriter(client.GetStream())
                STR = New StreamReader(client.GetStream())
                STW.AutoFlush = True
                BackgroundWorker1.RunWorkerAsync()
                BackgroundWorker2.WorkerSupportsCancellation = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While (client.Connected)
            Try
                recieve = STR.ReadLine
                If recieve.StartsWith("IMAGE:") Then
                    Dim imageData As Byte() = Convert.FromBase64String(recieve.Substring(6))
                    Using ms As New MemoryStream(imageData)
                        Dim receivedImage As Image = Image.FromStream(ms)
                        Me.ChatBox.Invoke(Sub() AppendImage(receivedImage, "You"))
                    End Using
                Else
                    Me.ChatBox.Invoke(Sub() AppendText("You: " + recieve))
                End If
                recieve = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End While
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If client IsNot Nothing AndAlso client.Connected Then
            If ImageToSend IsNot Nothing Then
                Using ms As New MemoryStream()
                    ImageToSend.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim imageData As Byte() = ms.ToArray()
                    Dim imageString As String = "IMAGE:" + Convert.ToBase64String(imageData)
                    STW.WriteLine(imageString)
                    Me.ChatBox.Invoke(Sub() AppendImage(ImageToSend, "ME"))
                End Using
            Else
                If TextToSend <> "" Then
                    STW.WriteLine(TextToSend)
                    Me.ChatBox.Invoke(Sub() AppendText("ME: " + TextToSend))
                End If
            End If
        Else
            MessageBox.Show("Sending Failed")
        End If
        BackgroundWorker2.CancelAsync()
    End Sub

    Private Sub send_Click(sender As Object, e As EventArgs) Handles send.Click
        If MessageTextBox.Text <> "" Then
            TextToSend = MessageTextBox.Text
            BackgroundWorker2.RunWorkerAsync()
        End If
        MessageTextBox.Text = ""
    End Sub

    Private Sub AppendText(ByVal text As String)
        ChatBox.AppendText(text + Environment.NewLine)
    End Sub

    Private Sub AppendImage(ByVal image As Image, ByVal senderName As String)
        ChatBox.AppendText(senderName & ": [Image Sent]" + Environment.NewLine)
        ChatBox.SelectionStart = ChatBox.TextLength
        ChatBox.ReadOnly = False

        Clipboard.SetImage(image)
        ChatBox.Paste()
        ChatBox.ReadOnly = True
    End Sub
End Class
