Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace UseRegressionLines
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a regression line for the Open value level.
			Dim myLine As New RegressionLine(ValueLevel.Open)

			' Access the series collection of indicators,
			' and add the regression line to it.
			CType(chartControl1.Series(0).View, StockSeriesView).Indicators.Add(myLine)

			' Customize the regression line's appearance.
			myLine.LineStyle.DashStyle = DashStyle.DashDot
			myLine.LineStyle.Thickness = 2
			myLine.Color = Color.Crimson
		End Sub

	End Class
End Namespace