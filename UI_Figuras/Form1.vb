Public Class Form1
    Private Sub cbxSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSelector.SelectedIndexChanged
        Dim figuras As Integer = cbxSelector.SelectedIndex
        Select Case figuras
            Case 0
                Label2.Visible = True
                txtLabel2.Visible = True
                Label2.Text = "Lado: "
                txtLabel2.Text = "0"
            Case 1
                Label2.Visible = True
                txtLabel2.Visible = True
                Label3.Visible = True
                txtLabel3.Visible = True
                Label2.Text = "Largo: "
                txtLabel2.Text = "0"
                Label3.Text = "Ancho: "
                txtLabel3.Text = "0"
            Case 2
                Label2.Visible = True
                txtLabel2.Visible = True
                Label3.Visible = True
                txtLabel3.Visible = True
                Label2.Text = "Base: "
                txtLabel2.Text = "0"
                Label3.Text = "Altura: "
                txtLabel3.Text = "0"
            Case 3
                Label2.Visible = True
                txtLabel2.Visible = True
                Label3.Visible = True
                txtLabel3.Visible = True
                Label2.Text = "Base: "
                txtLabel2.Text = "0"
                Label3.Text = "Altura: "
                txtLabel3.Text = "0"
        End Select
    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim figuras As Integer = cbxSelector.SelectedIndex
        Select Case figuras
            Case 0
                txtResultado.Text = "El area del cuadrado es de " & txtLabel2.Text * txtLabel2.Text & "."
            Case 1
                txtResultado.Text = "El area del rectangulo es de " & txtLabel2.Text * txtLabel3.Text & "."
            Case 2
                txtResultado.Text = "El area del triangulo es de " & (txtLabel2.Text * txtLabel3.Text) / 2 & "."
            Case 3
                txtResultado.Text = "El area del paralelogramo es de " & txtLabel2.Text * txtLabel3.Text & "."
        End Select
        txtResultado.Visible = True
    End Sub
End Class