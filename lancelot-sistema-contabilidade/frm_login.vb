Public Class frm_login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_nome.Text = "admin" And txt_nome.Text = "admin" Then
            Dim frm_menu_principal As frm_menu_principal
            frm_menu_principal = New frm_menu_principal()
            frm_menu_principal.Show()
            Me.Visible = False
        End If
    End Sub
End Class
