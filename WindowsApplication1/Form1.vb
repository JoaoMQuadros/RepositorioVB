Imports System.Data.SqlClient

Public Class Form1
    Dim IDAlunoRecebe As Int64 = 0


    Private Sub btnConfirmaNome_Click(sender As Object, e As EventArgs) Handles btnConfirmaNome.Click
        Try
            Dim recebeNome As String = txtAlunoNome.Text

            If Not String.IsNullOrEmpty(recebeNome) Then
                Dim connection As String = "Data Source=(localdb)\mssqllocaldb;Initial Catalog=Notas];Integrated Security=True;Pooling=False"
                Using conexao As New SqlConnection(connection)
                    conexao.Open()
                    Dim query As String = "INSERT INTO Aluno(AlunoNome) OUTPUT INSERTED.AlunoID VALUES (@AlunoNome)"
                    Using cmdNomeAluno As New SqlCommand(query, conexao)
                        cmdNomeAluno.CommandType = CommandType.Text

                        cmdNomeAluno.Parameters.Add(New SqlParameter("@AlunoNome", SqlDbType.NVarChar, 40))
                        cmdNomeAluno.Parameters("@AlunoNome").Value = recebeNome

                        Try
                            IDAlunoRecebe = Convert.ToInt32(cmdNomeAluno.ExecuteScalar())

                        Catch ex As Exception
                            MessageBox.Show("Erro" & ex.Message)
                        End Try

                    End Using
                End Using
            Else
                MessageBox.Show("Por favor, insira um termo de pesquisa.")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro" & ex.Message)
        End Try
        MessageBox.Show("Aluno registrado com sucesso, ID:" & IDAlunoRecebe)

    End Sub

    Private Sub btnDeletarAluno_Click(sender As Object, e As EventArgs) Handles btnDeletarAluno.Click

    End Sub

    Private Sub btnPesquisaAluno_Click(sender As Object, e As EventArgs) Handles btnPesquisaAluno.Click
        Try
            Dim recebeNome As String = txtAlunoNome.Text

            If Not String.IsNullOrEmpty(recebeNome) Then
                Dim connString As String = "Data Source=(localdb)\mssqllocaldb;Initial Catalog=Notas];Integrated Security=True;Pooling=False"
                Using conexao As New SqlConnection(connString)
                    conexao.Open()

                    Dim query As String = "SELECT Aluno.AlunoNome, Notas.RecebeNotas, NomeMateria.NomeMateria " &
                      "FROM Notas " &
                      "INNER JOIN Aluno ON Notas.AlunoID = Aluno.AlunoID " &
                      "INNER JOIN NomeMateria ON Notas.NomeMateriaID = NomeMateria.IDNomeMateria " &
                      "WHERE Aluno.AlunoNome LIKE @RecebeNome"


                    Using adapter As New SqlDataAdapter(query, conexao)
                        adapter.SelectCommand.Parameters.AddWithValue("@RecebeNome", "%" & recebeNome & "%")

                        Dim dataSet As New DataSet()

                        adapter.Fill(dataSet, "ResultadoPesquisa")

                        dgvResultado.DataSource = dataSet.Tables("ResultadoPesquisa")
                    End Using
                End Using
            Else
                MessageBox.Show("Por favor, insira um termo de pesquisa.")

            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub btnConfirmaNota_Click(sender As Object, e As EventArgs) Handles btnConfirmaNota.Click
        Try
            Dim connectionString As String = "Data Source=(localdb)\mssqllocaldb;Initial Catalog=Notas];Integrated Security=True;Pooling=False"

            Using conexao As New SqlConnection(connectionString)
                conexao.Open()

                Dim queryNotMat As String = "INSERT INTO Notas(AlunoID, NomeMateriaID, RecebeNotas) VALUES (@AlunoID, 9, @Matematica)"
                Using cmdMat As New SqlCommand(queryNotMat, conexao)
                    cmdMat.CommandType = CommandType.Text
                    cmdMat.Parameters.Add(New SqlParameter("AlunoID", SqlDbType.Int))
                    cmdMat.Parameters("AlunoID").Value = IDAlunoRecebe

                    cmdMat.Parameters.Add(New SqlParameter("Matematica", SqlDbType.Int))
                    cmdMat.Parameters("Matematica").Value = Convert.ToInt32(txtMat.Text)
                    Try
                        cmdMat.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try
                End Using

                Dim queryNotPor As String = "INSERT INTO Notas(AlunoID, NomeMateriaID, RecebeNotas) VALUES (@AlunoID, 10, @Português)"
                Using cmdPor As New SqlCommand(queryNotPor, conexao)
                    cmdPor.CommandType = CommandType.Text

                    cmdPor.Parameters.Add(New SqlParameter("AlunoID", SqlDbType.Int))
                    cmdPor.Parameters("AlunoID").Value = IDAlunoRecebe

                    cmdPor.Parameters.Add(New SqlParameter("Portugues", SqlDbType.Int))
                    cmdPor.Parameters("Portugues").Value = Convert.ToInt32(txtPor.Text)
                    Try
                        cmdPor.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try
                End Using

                Dim queryNotArt = "INSERT INTO Notas(AlunoID, NomeMateriaID, RecebeNotas) VALUES (@AlunoID, 11, @Artes)"

                Using cmdArt = New SqlCommand(queryNotArt, conexao)
                    cmdArt.CommandType = CommandType.Text

                    cmdArt.Parameters.Add("AlunoID", SqlDbType.Int)
                    cmdArt.Parameters("AlunoID").Value = IDAlunoRecebe

                    cmdArt.Parameters.Add(New SqlParameter("Artes", SqlDbType.Int))
                    cmdArt.Parameters("Artes").Value = Convert.ToInt32(txtArt.Text)
                    Try
                        cmdArt.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try

                End Using

                Dim queryNotFis = "INSERT INTO Notas(AlunoID, NomeMateriaID, RecebeNotas) VALUES (@AlunoID, 12, @Fisica)"
                Using cmdNotFis As New SqlCommand(queryNotFis, conexao)
                    cmdNotFis.CommandType = CommandType.Text

                    cmdNotFis.Parameters.Add(New SqlParameter("AlunoID", SqlDbType.Int))
                    cmdNotFis.Parameters("AlunoID").Value = Convert.ToInt32(txtFis.Text)
                    Try
                        cmdNotFis.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try
                End Using

            End Using
            MessageBox.Show("Notas Registradas com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpaNota_Click(sender As Object, e As EventArgs) Handles btnLimpaNota.Click
        txtMat.Clear()
        txtPor.Clear()
        txtFis.Clear()
        txtArt.Clear()
    End Sub
End Class
