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
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 14, 0, 0, 0, 0), New Object() { (DirectCast(24R, Object)), (DirectCast(25R, Object)), (DirectCast(25R, Object)), (DirectCast(24.875R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 15, 0, 0, 0, 0), New Object() { (DirectCast(23.625R, Object)), (DirectCast(25.125R, Object)), (DirectCast(24R, Object)), (DirectCast(24.875R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 16, 0, 0, 0, 0), New Object() { (DirectCast(26.25R, Object)), (DirectCast(28.25R, Object)), (DirectCast(26.75R, Object)), (DirectCast(27R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 17, 0, 0, 0, 0), New Object() { (DirectCast(26.5R, Object)), (DirectCast(27.875R, Object)), (DirectCast(26.875R, Object)), (DirectCast(27.25R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 1, 18, 0, 0, 0, 0), New Object() { (DirectCast(26.375R, Object)), (DirectCast(27.5R, Object)), (DirectCast(27.375R, Object)), (DirectCast(26.75R, Object))})
            Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.Label.TextPattern = "{A:dddd}"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisualRange.Auto = False
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "28.25"
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "23"
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
            series1.View = stockSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartControl1.Size = New System.Drawing.Size(676, 382)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(676, 382)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

