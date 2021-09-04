Imports System
Imports System.Data
Imports System.Xml

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub getinfo_Click(sender As Object, e As EventArgs) Handles getinfo.Click
		Dim bright As Integer

		Dim rgb As New List(Of Integer)

		Dim myRgbColor As New Color()


		Dim URL As String = "http://" & LEDaddr.Text & "/win"

		Dim xml = XElement.Load(URL)
		Dim all_cl = xml.<cl>
		For Each cl In all_cl
			Console.WriteLine($"cl = {cl.Value}")
			rgb.Add(cl.Value)
		Next

		Dim all_ac = xml.<ac>
		For Each ac In all_ac
			Console.WriteLine($"ac = {ac.Value}")
			bright = ac
		Next

		myRgbColor = Color.FromArgb(rgb(0), rgb(1), rgb(2))



		showInfo(rgb, bright)

	End Sub

	Private Sub redBar_Scroll(sender As Object, e As EventArgs) Handles redBar.Scroll
		lblred.Text = redBar.Value
	End Sub

	Private Sub greenBar_Scroll(sender As Object, e As EventArgs) Handles greenBar.Scroll
		lblgreen.Text = greenBar.Value
	End Sub

	Private Sub blueBar_Scroll(sender As Object, e As EventArgs) Handles blueBar.Scroll
		lblblue.Text = blueBar.Value
	End Sub
	Private Sub brightBar_Scroll(sender As Object, e As EventArgs) Handles brightBar.Scroll
		lblbright.Text = brightBar.Value
	End Sub

	Public Sub showInfo(rgb As List(Of Integer), bright As Integer)
		redBar.Value = rgb(0)
		greenBar.Value = rgb(1)
		blueBar.Value = rgb(2)
		brightBar.Value = bright

		lblred.Text = rgb(0)
		lblgreen.Text = rgb(1)
		lblblue.Text = rgb(2)
		lblbright.Text = bright

		Dim rgbInt As Integer = rgb(0) & rgb(1) & rgb(2)

		ledInfo.Text = $"Brightness: {(bright / 255) * 100}%{vbNewLine}R: {rgb(0)}, G: {rgb(1)}, B: {rgb(2)}{vbNewLine}#{rgbInt.ToString("X6")}"
	End Sub

	Private Sub btnColour_Click(sender As Object, e As EventArgs) Handles btnColour.Click
		Dim bright As Integer = brightBar.Value

		Dim rgb As New List(Of Integer)

		rgb.Add(redBar.Value)
		rgb.Add(greenBar.Value)
		rgb.Add(blueBar.Value)

		Dim URL As String = $"http://{LEDaddr.Text}/win&R={rgb(0)}&G={rgb(1)}&B={rgb(2)}&A={bright}"

		Dim xml = XElement.Load(URL)

		showInfo(rgb, bright)
	End Sub
End Class
