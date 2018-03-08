Imports System.IO
Imports System.Text
Imports System.Threading

Public Class CréerAdresse

    Dim p As Process
    Dim thread As System.Threading.Thread
    Public output As String

    Private Sub Créer_Click(sender As Object, e As EventArgs) Handles Créer.Click
        If Nom.Text = ""
            MsgBox("Le champ nom ne peut pas être vide")

        ElseIf Password.Text = ""
            MsgBox("Le champ mot de passe ne peut pas être vide")
        Else
            Try
                'créerAdresse()
                créerAdresse()
            Catch ex As Exception
                'MsgBox("6 " & ex.ToString)
            End Try
        End If
    End Sub

    Sub créerAdresse()
        Try
        p = New Process
        p.StartInfo.FileName = Application.StartupPath & "\binaire\wallet\simplewallet.exe"
        p.StartInfo.Arguments = Nothing
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardError = True
        p.StartInfo.RedirectStandardInput = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850)

        p.Start()
        thread = New Thread(AddressOf ObtientText)
        thread.IsBackground = True
        thread.Start()

        ExecuteLaCommande("g")
        'Specify wallet file name (e.g., wallet.bin).
        'ExecuteLaCommande(Nom.Text)
        'ExecuteLaCommande(password.Text)
        Catch ex as Exception
            'msgBox("1 " & ex.Tostring)
        End try
    End Sub

    Sub ObtientText()

        While True

            Try
                output = p.StandardOutput.ReadLine


                If output <> Nothing Then

                    'RichTextBox1.Text &= output & vbNewLine
                End If



            Log.Invoke(New Action(Of String)(AddressOf ChangeValue), output)
            'TextBox1.Text += output & vbNewLine
                    Catch ex as Exception
           Log.Dispose
        End try
        End While

    End Sub

    Private Sub ChangeValue(ByVal value As String)
        try
        If value <> ""
            If value.Contains("Your wallet has been generated.") Then
            For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "simplewallet" Then
                prog.Kill()

            End If
                  Next
                Dim monStreamReader As StreamReader
                Mineur.show()              
                Try
                    monStreamReader = New StreamReader(Application.StartupPath & "/" & Nom.Text & ".address")
                    Dim ligne As String
                    ligne = monStreamReader.ReadLine
                    Mineur.show
                    Mineur.Adresse.Text = ligne


                    monStreamReader.Close()
                Catch
                End Try
                Me.Close()
            End If
            If value.Contains(".wallet already exists") Then
                Dim monStreamReader As StreamReader
                'Mineur.show()              
                    monStreamReader = New StreamReader(Application.StartupPath & "/" & Nom.Text & ".address")
                    Dim ligne As String
                    ligne = monStreamReader.ReadLine
                    Mineur.show
                    Mineur.Adresse.Text = ligne
                    monStreamReader.Close()
                Me.hide()
            End If
            If value.Contains("password:")
                'MsgBox("Mot de passe")
            End If
            If value.Contains("Specify wallet file name (e.g., wallet.bin).")
                ExecuteLaCommande(Nom.Text)
                ExecuteLaCommande(Password.Text)
            Label3.Visible = true
            End If
            Log.Text += value & vbNewLine

            Log.SelectionStart = Log.TextLength
            Log.ScrollToCaret()


        End If
        Catch ex as Exception
            'msgBox("4 " & ex.Tostring)
        End try
    End Sub

    Public Sub ExecuteLaCommande(ByVal Command As String)
        Try
            p.StandardInput.WriteLine(Command)
            p.StandardInput.Flush()
        Catch ex as Exception
            'msgBox("3 " & ex.Tostring)
        End try
    End Sub

    Private Sub CréerAdresse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        try
        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "simplewallet" Then
                ExecuteLaCommande("exit")
                    p.Close

            End If
        Next
        Catch ex as Exception
            'msgBox("2 " & ex.Tostring)
        End try
    End Sub
End Class