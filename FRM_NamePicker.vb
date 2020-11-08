Imports System
Imports System.Windows.Forms

Namespace RandomNamePicker
    Public Partial Class FRM_NamePicker
        Inherits Form

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim ctr = Convert.ToInt32("2")

            While ctr <> 1
                Dim names As String = RandName()
                ctr += 1
            End While
        End Sub

        Public Function RandName() As String
            Dim names = {"Name 1", "Name 2", "Name 3", "Name 4"}
            Dim rand As Random = New Random()
            Dim index = rand.Next(names.Length)
            Return $"{names(index)}"
        End Function
    End Class
End Namespace
