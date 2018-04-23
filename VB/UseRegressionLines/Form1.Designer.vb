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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim StockSeriesLabel1 As DevExpress.XtraCharts.StockSeriesLabel = New DevExpress.XtraCharts.StockSeriesLabel()
            Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 14, 0, 0, 0, 0), New Object() {CType(24.0R, Object), CType(25.0R, Object), CType(25.0R, Object), CType(24.875R, Object)})
            Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 15, 0, 0, 0, 0), New Object() {CType(23.625R, Object), CType(25.125R, Object), CType(24.0R, Object), CType(24.875R, Object)})
            Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 16, 0, 0, 0, 0), New Object() {CType(26.25R, Object), CType(28.25R, Object), CType(26.75R, Object), CType(27.0R, Object)})
            Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 17, 0, 0, 0, 0), New Object() {CType(26.5R, Object), CType(27.875R, Object), CType(26.875R, Object), CType(27.25R, Object)})
            Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 18, 0, 0, 0, 0), New Object() {CType(26.375R, Object), CType(27.5R, Object), CType(27.375R, Object), CType(26.75R, Object)})
            Dim StockSeriesView1 As DevExpress.XtraCharts.StockSeriesView = New DevExpress.XtraCharts.StockSeriesView()
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            XyDiagram1.AxisX.Label.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.Custom
            XyDiagram1.AxisX.Label.DateTimeOptions.FormatString = "dddd"
            XyDiagram1.AxisX.Range.AlwaysShowZeroLevel = True
            XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisX.Range.SideMarginsEnabled = True
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Range.AlwaysShowZeroLevel = True
            XyDiagram1.AxisY.Range.Auto = False
            XyDiagram1.AxisY.Range.MaxValueSerializable = "29"
            XyDiagram1.AxisY.Range.MinValueSerializable = "23"
            XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisY.Range.SideMarginsEnabled = True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = XyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Series1.Label = StockSeriesLabel1
            Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Series1.Name = "Series 1"
            Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4, SeriesPoint5})
            Series1.View = StockSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
            SideBySideBarSeriesLabel1.LineVisible = True
            Me.chartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
            Me.chartControl1.Size = New System.Drawing.Size(765, 452)
            Me.chartControl1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(765, 452)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

