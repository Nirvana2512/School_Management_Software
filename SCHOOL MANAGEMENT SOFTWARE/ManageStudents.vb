Public Class ManageStudents

    Private Sub ManageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.SMS.Student)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class