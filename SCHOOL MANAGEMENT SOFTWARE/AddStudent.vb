Public Class AddStudent

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtregno.Clear()
        txtaddress.Clear()
        txtemail.Clear()
        txtfullname.Clear()
        txtphone.Clear()
        cboclass.Text = ""
        cbostream.Text = ""
        cbogender.Text = ""
        PictureBox1.Image = Nothing
        nudage.Value = 0
        txtregno.Focus()

    End Sub

    Private Sub btnclrimage_Click(sender As Object, e As EventArgs) Handles btnclrimage.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub btnloadpic_Click(sender As Object, e As EventArgs) Handles btnloadpic.Click
        With OpenFileDialog1
            .Title = "Select a jpeg image"
            .Filter = "jpeg image only *.jpeg"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()

            If .FileName <> "" Then
                PictureBox1.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtregno.Text = "" Or txtfullname.Text = "" Or cboclass.Text = "" Or cbostream.Text = "" Then
            MsgBox("Registration Number, Full Name, Class & Stream are Required Fields complete them to Proced", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim db As New SMSDataContext
        Dim CheckStudentDetails = From p In db.Students
                                Where p.Register = txtregno.Text
                                Select p

        If CheckStudentDetails.Count <> 0 Then
            MsgBox("A student is already registered with the registration number you have specified please correct the Reg Number")
            Exit Sub
        End If

        Dim NewStudent As New Student With {.Address = txtaddress.Text, .Age = nudage.Value, .Class = cboclass.Text, .Contact_Ph_No = txtphone.Text, .Email_Address = txtemail.Text, .Full_Name = txtfullname.Text, .Gender = cbogender.Text, .Picture = PictureBox1.ImageLocation, .Register = txtregno.Text, .Stream = cbostream.Text}
        db.Students.InsertOnSubmit(NewStudent)
        db.SubmitChanges()
        MsgBox("Student Record successfully Added", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
        btnclear_Click(sender, e)



    End Sub

    Private Sub txtregno_TextChanged(sender As Object, e As EventArgs) Handles txtregno.TextChanged

    End Sub

    Private Sub cbogender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbogender.SelectedIndexChanged

    End Sub

    Private Sub AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class