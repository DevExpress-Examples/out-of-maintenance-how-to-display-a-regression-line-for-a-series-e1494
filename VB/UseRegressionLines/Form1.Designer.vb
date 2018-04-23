Imports Microsoft.VisualBasic
Imports System
Namespace UseRegressionLines
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim stockSeriesLabel2 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 1, 14, 0, 0, 0, 0), New Object() { (CObj(24)), (CObj(25)), (CObj(25)), (CObj(24.875))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 1, 15, 0, 0, 0, 0), New Object() { (CObj(23.625)), (CObj(25.125)), (CObj(24)), (CObj(24.875))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 1, 16, 0, 0, 0, 0), New Object() { (CObj(26.25)), (CObj(28.25)), (CObj(26.75)), (CObj(27))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 1, 17, 0, 0, 0, 0), New Object() { (CObj(26.5)), (CObj(27.875)), (CObj(26.875)), (CObj(27.25))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 1, 18, 0, 0, 0, 0), New Object() { (CObj(26.375)), (CObj(27.5)), (CObj(27.375)), (CObj(26.75))})
			Dim stockSeriesView2 As New DevExpress.XtraCharts.StockSeriesView()
			Dim regressionLine2 As New DevExpress.XtraCharts.RegressionLine()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(regressionLine2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram2.AxisX.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.Custom
			xyDiagram2.AxisX.DateTimeOptions.FormatString = "dddd"
			xyDiagram2.AxisX.Label.Angle = 25
			xyDiagram2.AxisX.Label.Antialiasing = True
			xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram2.AxisX.Range.SideMarginsEnabled = True
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.Range.Auto = False
			xyDiagram2.AxisY.Range.MaxValueSerializable = "29"
			xyDiagram2.AxisY.Range.MinValueSerializable = "23"
			xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram2.AxisY.Range.SideMarginsEnabled = True
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram2
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			stockSeriesLabel2.Visible = False
			series2.Label = stockSeriesLabel2
			series2.Name = "Series 1"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10})
			regressionLine2.Color = System.Drawing.Color.Crimson
			regressionLine2.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash
			regressionLine2.LineStyle.Thickness = 2
			regressionLine2.ValueLevel = DevExpress.XtraCharts.ValueLevel.Open
			series2.View = stockSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			sideBySideBarSeriesLabel2.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chartControl1.Size = New System.Drawing.Size(289, 174)
			Me.chartControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(289, 174)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(regressionLine2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

