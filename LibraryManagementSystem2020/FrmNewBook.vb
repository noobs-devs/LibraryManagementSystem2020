Imports System.Data.SqlClient
Public Class FrmNewBook

    ReadOnly SqlCon As New SqlConnection("server=(localdb)\mssqllocaldb;Database=LMS;Integrated Security=True")
    ReadOnly SqlCmd As New SqlCommand()
    ReadOnly DS As New DataSet()
    ReadOnly SqlDA As New SqlDataAdapter()
    Dim SqlDR As SqlDataReader()
    ReadOnly SqlCB As New SqlCommandBuilder(SqlDA)
    Dim DR As DataRow



    Private Sub FrmNewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        sqlcon.Open()

        sqlcmd.Connection = sqlcon

        sqlcmd.CommandText = "Select * from book"

        sqlDA.SelectCommand = sqlcmd

        sqlDA.Fill(DS, "book")

        DS.Tables("book").NewRow()

        DR("bookid") = TxtId.Text
        DR("booktitle") = TxtTitle.Text
        DR("bookedition") = TxtEdition.Text
        DR("bookpublisher") = TxtPublisher.Text
        DR("bookauthor") = TxtAuthor.Text
        DR("bookcompensationprice") = TxtCompensationPrice.Text
        DR("booktype") = TxtBookType.Text

        DS.Tables("book").Rows.Add(DR)

        sqlDA.Update(DS, "book")

        sqlcon.Close()
    End Sub

    Private Sub resetform()

        TxtId.Clear()
        TxtTitle.Clear()
        TxtEdition.Clear()
        TxtPublisher.Clear()
        TxtAuthor.Clear()
        TxtCompensationPrice.Clear()
        TxtBookType.Clear()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        resetform()
    End Sub

    Private Sub TxtPublisher_TextChanged(sender As Object, e As EventArgs) Handles TxtPublisher.TextChanged

    End Sub
End Class