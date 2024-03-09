Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub renk()
        Dim cyan, magenta, yellow, black As Double
        cyan = HScrollBar1.Value / 100
        magenta = HScrollBar2.Value / 100
        yellow = HScrollBar3.Value / 100
        black = HScrollBar4.Value / 100

        r = 255 * (1 - cyan) * (1 - black)
        g = 255 * (1 - magenta) * (1 - black)
        b = 255 * (1 - yellow) * (1 - black)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "0%"
        Label2.Text = "0%"
        Label3.Text = "0%"
        Label4.Text = "0%"

        HScrollBar1.Maximum = 100
        HScrollBar1.Minimum = 0
        HScrollBar1.LargeChange = 1

        HScrollBar2.Maximum = 100
        HScrollBar2.Minimum = 0
        HScrollBar2.LargeChange = 1

        HScrollBar3.Maximum = 100
        HScrollBar3.Minimum = 0
        HScrollBar3.LargeChange = 1

        HScrollBar4.Maximum = 100
        HScrollBar4.Minimum = 0
        HScrollBar4.LargeChange = 1

    End Sub
    Dim c, m, y, k As Double

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll

        'burda scroolbar içindeki değerleri yüze bölüyoruz ondalık değere çeviriyoruz örneğin scroolbar değeri
        '32 100 bölüp 0.32 buluyoruz 
        c = HScrollBar1.Value / 100
        m = HScrollBar2.Value / 100
        y = HScrollBar3.Value / 100
        k = HScrollBar4.Value / 100

        r = 255 * (1 - c) * (1 - k)
        g = 255 * (1 - m) * (1 - k)
        b = 255 * (1 - y) * (1 - k)

        Label3.Text = HScrollBar3.Value.ToString + "%"

        PictureBox1.BackColor = System.Drawing.Color.FromArgb(r, g, b)
    End Sub

    Private Sub HScrollBar4_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar4.Scroll
        c = HScrollBar1.Value / 100
        m = HScrollBar2.Value / 100
        y = HScrollBar3.Value / 100
        k = HScrollBar4.Value / 100

        r = 255 * (1 - c) * (1 - k)
        g = 255 * (1 - m) * (1 - k)
        b = 255 * (1 - y) * (1 - k)

        Label4.Text = HScrollBar4.Value.ToString + "%"

        PictureBox1.BackColor = System.Drawing.Color.FromArgb(r, g, b)
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        c = HScrollBar1.Value / 100
        m = HScrollBar2.Value / 100
        y = HScrollBar3.Value / 100
        k = HScrollBar4.Value / 100

        r = 255 * (1 - c) * (1 - k)
        g = 255 * (1 - m) * (1 - k)
        b = 255 * (1 - y) * (1 - k)

        Label2.Text = HScrollBar2.Value.ToString + "%"

        PictureBox1.BackColor = System.Drawing.Color.FromArgb(r, g, b)
    End Sub

    Dim r, g, b As Double
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        c = HScrollBar1.Value / 100
        m = HScrollBar2.Value / 100
        y = HScrollBar3.Value / 100
        k = HScrollBar4.Value / 100

        r = 255 * (1 - c) * (1 - k)
        g = 255 * (1 - m) * (1 - k)
        b = 255 * (1 - y) * (1 - k)

        Label1.Text = HScrollBar1.Value.ToString + "%"

        PictureBox1.BackColor = System.Drawing.Color.FromArgb(r, g, b)

    End Sub
End Class
