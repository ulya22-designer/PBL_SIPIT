Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class CRUDaturan

    Public Property mode As String
    Public Property ruleID As Integer
    Public Property profesiID As Integer
    Public Property rulePattern As String
    Public Property keterangan As String

    Private Sub CRUDaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True   ' ID tidak boleh diedit

        LoadProfesiToCombo()

        If mode = "tambah" Then
            Me.Text = "Tambah Aturan"
            TextBox1.Text = "(Auto)"
            ComboBox1.SelectedIndex = -1
            TextBox5.Text = ""
            TextBox6.Text = ""

        ElseIf mode = "edit" Then
            Me.Text = "Edit Aturan"
            TextBox1.Text = ruleID.ToString()
            ComboBox1.SelectedValue = profesiID
            TextBox5.Text = rulePattern
            TextBox6.Text = keterangan
        End If
    End Sub


    ' ======================================================
    '  LOAD PROFESI KE COMBOBOX
    ' ======================================================
    Private Sub LoadProfesiToCombo()
        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                Dim dt As New DataTable
                Dim query As String =
                    "SELECT profesi_id, nama_profesi FROM Profesi ORDER BY nama_profesi"

                Using da As New SqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using

                ComboBox1.DataSource = dt
                ComboBox1.DisplayMember = "nama_profesi"
                ComboBox1.ValueMember = "profesi_id"
                ComboBox1.SelectedIndex = -1

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memuat profesi: " & ex.Message)
        End Try
    End Sub


    ' ======================================================
    '  CHECK UNIQUE PATTERN
    ' ======================================================
    Private Function IsPatternDuplicate(pattern As String, Optional id As Integer = -1) As Boolean
        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String

            If id = -1 Then
                ' MODE TAMBAH
                query = "SELECT COUNT(*) FROM Aturan WHERE rule_pattern = @pattern"
            Else
                ' MODE EDIT
                query = "SELECT COUNT(*) FROM Aturan WHERE rule_pattern = @pattern AND rule_id <> @id"
            End If

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@pattern", pattern)

                If id <> -1 Then
                    cmd.Parameters.AddWithValue("@id", id)
                End If

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function


    ' ======================================================
    '  TOMBOL SIMPAN
    ' ======================================================
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click

        If ComboBox1.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("Profesi dan rule pattern harus diisi.")
            Exit Sub
        End If

        Dim newPattern As String = TextBox5.Text.Trim()

        ' 🔍 CEK DUPLIKASI POLA RULE
        If mode = "tambah" Then
            If IsPatternDuplicate(newPattern) Then
                MessageBox.Show("Pola rule sudah digunakan oleh aturan lain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        ElseIf mode = "edit" Then
            If IsPatternDuplicate(newPattern, ruleID) Then
                MessageBox.Show("Pola rule sudah digunakan oleh aturan lain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If


        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                Dim cmd As SqlCommand

                If mode = "tambah" Then
                    cmd = New SqlCommand("
                        INSERT INTO Aturan (profesi_id, rule_pattern, Keterangan)
                        VALUES (@profesi, @pattern, @ket)", conn)

                ElseIf mode = "edit" Then
                    cmd = New SqlCommand("
                        UPDATE Aturan 
                        SET profesi_id = @profesi,
                            rule_pattern = @pattern,
                            Keterangan = @ket
                        WHERE rule_id = @id", conn)

                    cmd.Parameters.AddWithValue("@id", ruleID)
                End If

                ' Ambil profesi_id dari ComboBox
                cmd.Parameters.AddWithValue("@profesi", Convert.ToInt32(ComboBox1.SelectedValue))
                cmd.Parameters.AddWithValue("@pattern", newPattern)
                cmd.Parameters.AddWithValue("@ket", TextBox6.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil disimpan.")

            Dim f As New adminPanel()
            f.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)
        End Try
    End Sub


    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        Dim f As New adminPanel()
        f.Show()
        Me.Hide()
    End Sub

End Class
