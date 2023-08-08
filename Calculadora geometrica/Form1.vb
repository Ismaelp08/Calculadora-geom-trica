Public Class Form1
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles Txtrectangulo.Click
        TabControl1.SelectedTab = rectangulo
    End Sub
    Private Sub Txttriangulo_Click(sender As Object, e As EventArgs) Handles Txttriangulo.Click
        TabControl1.SelectedTab = triangulo
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles Txtcuadrado.Click
        TabControl1.SelectedTab = cuadrado
    End Sub

    Private Sub Txtcirculo_Click(sender As Object, e As EventArgs) Handles Txtcirculo.Click
        TabControl1.SelectedTab = circulo
    End Sub

    Private Sub Txttrapecio_Click(sender As Object, e As EventArgs) Handles Txttrapecio.Click
        TabControl1.SelectedTab = trapecio
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim base, altura, area As Single
        base = TxtBase.Text
        altura = TxtAltura.Text
        area = base * altura / 2
        LblResultado.Text = area

    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        TxtBase.Text = ""
        TxtAltura.Text = ""
        LblResultado.Text = ""

    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Close()

    End Sub

    Private Sub Calcular2_Click(sender As Object, e As EventArgs) Handles Calcular2.Click
        Dim lado, area As Single
        lado = TxtLado.Text
        area = (lado * lado)
        LblResulatdo2.Text = area

    End Sub

    Private Sub Limpiar2_Click(sender As Object, e As EventArgs) Handles Limpiar2.Click
        TxtLado.Text = ""
        LblResulatdo2.Text = ""

    End Sub

    Private Sub Cerrar2_Click(sender As Object, e As EventArgs) Handles Cerrar2.Click
        Close()
    End Sub

    Private Sub Calcular3_Click(sender As Object, e As EventArgs) Handles Calcular3.Click
        Dim base, altura, area As Single
        base = TxtBase3.Text
        altura = TxtAltura3.Text
        area = base * altura
        LblResultado3.Text = area

    End Sub

    Private Sub Limpiar3_Click(sender As Object, e As EventArgs) Handles Limpiar3.Click
        TxtBase3.Text = ""
        TxtAltura3.Text = ""
        LblResultado3.Text = ""

    End Sub

    Private Sub Cerrar3_Click(sender As Object, e As EventArgs) Handles Cerrar3.Click
        Close()
    End Sub

    Private Sub Calcular4_Click(sender As Object, e As EventArgs) Handles Calcular4.Click
        Dim radio, area As Single
        radio = TxtRadio.Text
        LblResultado4.Text = 3.1416 * (radio * radio)

    End Sub

    Private Sub Limpiar4_Click(sender As Object, e As EventArgs) Handles Limpiar4.Click
        TxtRadio.Text = ""
        LblResultado4.Text = ""

    End Sub

    Private Sub Cerrar4_Click(sender As Object, e As EventArgs) Handles Cerrar4.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Calcular5.Click
        Dim basemy, basemn, altura, area As Single
        basemy = Txtbasemy.Text
        basemn = Txtbasemn.Text
        altura = TxtAltura5.Text
        area = ((basemy + basemn) * altura) / 2
        LblResultado5.Text = area

    End Sub

    Private Sub Limpiar5_Click(sender As Object, e As EventArgs) Handles Limpiar5.Click
        Txtbasemy.Text = ""
        Txtbasemn.Text = ""
        TxtAltura5.Text = ""
        LblResultado5.Text = ""

    End Sub

    Private Sub Cerrar5_Click(sender As Object, e As EventArgs) Handles Cerrar5.Click
        Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        TxtBase.Text = ""
        TxtAltura.Text = ""
        LblResultado.Text = ""
        TxtLado.Text = ""
        LblResulatdo2.Text = ""
        TxtBase3.Text = ""
        TxtAltura3.Text = ""
        LblResultado3.Text = ""
        TxtRadio.Text = ""
        LblResultado4.Text = ""
        Txtbasemy.Text = ""
        Txtbasemn.Text = ""
        TxtAltura5.Text = ""
        LblResultado5.Text = ""
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acercade.Show()
    End Sub
End Class
