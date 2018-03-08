Imports System.IO
Imports System.Text
Imports System.Threading

Public Class Mineur
    Dim command As String
    Dim p As new Process
    Dim thread As System.Threading.Thread
    Public output As String
    Public input As String
    Public erreur As String
    Dim taille As String = Me.size.ToString

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adresse.text =  My.Settings("adresse")
    End Sub

    Sub miner()
        Try
        Adresse.text =  My.Settings("adresse")
        If Adresse.Text <> "" then
        p = new Process
        p.StartInfo.FileName = "cmd" 
        p.StartInfo.Arguments = nothing 
        p.StartInfo.CreateNoWindow = true
        p.StartInfo.UseShellExecute = false
        p.StartInfo.RedirectStandardError = True
        p.StartInfo.RedirectStandardInput = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850)
        p.Start()

        ExecuteLaCommande("cd " & Application.StartupPath & "\binaire\miner\")
        ExecuteLaCommande("minergate-cli -o stratum+tcp://gallion.ddns.net:6012 -u " & adresse.text & " -t 11")
     
        StopMinage.visible = true
        LancerMineur.Visible = false
        CreerAdresse.Enabled = False
        ImporterAdresse.Enabled = false
        Label2.Text = -1
        Timer1.start
        Else
             MsgBox("Le champ adresse New peut pas être vide")
        End If
        Catch ex as Exception
            'msgBox(ex.Tostring)
        End try
    End Sub

    Private Sub LancerMineur_Click(sender As Object, e As EventArgs) Handles LancerMineur.Click
       
    End Sub

    Private Sub StopMinage_Click(sender As Object, e As EventArgs) Handles StopMinage.Click
        Try
        Label2.Text = -1
        StopMinage.visible = false
        LancerMineur.Visible = true
        CreerAdresse.Enabled = true
        ImporterAdresse.Enabled = true
         For Each prog As Process In Process.GetProcesses
        If prog.ProcessName = "minergate-cli" Then
                prog.Kill()
                Else
                Timer1.stop
                statuts.Text = "Minage arrêté"
        End If
    Next
        Catch ex as Exception
            'msgBox(ex.Tostring)
        End try       
    End Sub

    Public Sub ExecuteLaCommande(ByVal Command As String)
        Try
            p.StandardInput.WriteLine(Command)
            p.StandardInput.Flush()
        Catch ex as Exception
            'msgBox(ex.Tostring)
        End try
        End Sub

    Private Sub CreerAdresse_Click(sender As Object, e As EventArgs) Handles CreerAdresse.Click
        CréerAdresse.show
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ImporterAdresse.Click

        OpenFileDialog1.ShowDialog
        Dim monStreamReader As StreamReader
        try
            monStreamReader = New StreamReader(OpenFileDialog1.FileName)
        Dim ligne As String 
        ligne = monStreamReader.ReadLine
        adresse.Text = ligne
        monStreamReader.Close()
        Catch ex as Exception
            'msgBox(ex.Tostring)
        End try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
        My.Settings("adresse") = Adresse.text
        My.Settings.Save
          For Each prog As Process In Process.GetProcesses
        If prog.ProcessName = "minergate-cli" Then
                prog.Kill()
                Else
                Timer1.stop
                statuts.Text = "Minage arrêté"
        End If
    Next
        Catch ex as Exception
            'msgBox(ex.Tostring)
        End try    
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings("adresse") = Adresse.text
        My.Settings.Save
      

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        try
         For Each prog As Process In Process.GetProcesses
        If prog.ProcessName = "minergate-cli" Then
                If Label2.Text = -1 then
                statuts.Text = "Minage en cours"
             End If 
        End If
    Next
        Label2.Text += 1

        If statuts.Text = "Minage en cours" Then
            statuts.Text = "Minage en cours."
        End If
            If Label2.Text = 10 Then
            statuts.Text = "Minage en cours.."
        End If
            If Label2.Text = 20 Then
            statuts.Text = "Minage en cours..."
        End If
            If Label2.Text = 30 Then
            statuts.Text = "Minage en cours"
        End If
        If Label2.Text = 31 Then
            Label2.Text = 0
        End if
        Catch ex as Exception
            'msgBox(ex.Tostring)
        End try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Dim mouse_offset
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        try
            mouse_offset = New Point(-e.X, -e.Y)
        Catch ex as Exception
            'msgBox(ex.Tostring)
        End try 
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouse_offset.X, mouse_offset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        mouse_offset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouse_offset.X, mouse_offset.Y)
            Location = mousePos
        End If
    End Sub
end Class
