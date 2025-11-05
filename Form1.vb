Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nom As String = InputBox("Entrez votre nom :", "Saisie du nom")
        Dim age As String = InputBox("Entrez votre âge :", "Saisie de l'âge")


        MessageBox.Show("Bonjour " & nom & ", vous avez " & age & " ans.", "Message")
    End Sub
End Class


