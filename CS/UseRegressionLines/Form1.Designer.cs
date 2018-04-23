namespace UseRegressionLines {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StockSeriesLabel stockSeriesLabel2 = new DevExpress.XtraCharts.StockSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2008, 1, 14, 0, 0, 0, 0), new object[] {
            ((object)(24)),
            ((object)(25)),
            ((object)(25)),
            ((object)(24.875))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2008, 1, 15, 0, 0, 0, 0), new object[] {
            ((object)(23.625)),
            ((object)(25.125)),
            ((object)(24)),
            ((object)(24.875))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2008, 1, 16, 0, 0, 0, 0), new object[] {
            ((object)(26.25)),
            ((object)(28.25)),
            ((object)(26.75)),
            ((object)(27))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2008, 1, 17, 0, 0, 0, 0), new object[] {
            ((object)(26.5)),
            ((object)(27.875)),
            ((object)(26.875)),
            ((object)(27.25))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2008, 1, 18, 0, 0, 0, 0), new object[] {
            ((object)(26.375)),
            ((object)(27.5)),
            ((object)(27.375)),
            ((object)(26.75))});
            DevExpress.XtraCharts.StockSeriesView stockSeriesView2 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.RegressionLine regressionLine2 = new DevExpress.XtraCharts.RegressionLine();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram2.AxisX.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.Custom;
            xyDiagram2.AxisX.DateTimeOptions.FormatString = "dddd";
            xyDiagram2.AxisX.Label.Angle = 25;
            xyDiagram2.AxisX.Label.Antialiasing = true;
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.Auto = false;
            xyDiagram2.AxisY.Range.MaxValueSerializable = "29";
            xyDiagram2.AxisY.Range.MinValueSerializable = "23";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            stockSeriesLabel2.Visible = false;
            series2.Label = stockSeriesLabel2;
            series2.Name = "Series 1";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10});
            regressionLine2.Color = System.Drawing.Color.Crimson;
            regressionLine2.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash;
            regressionLine2.LineStyle.Thickness = 2;
            regressionLine2.ValueLevel = DevExpress.XtraCharts.ValueLevel.Open;
            series2.View = stockSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chartControl1.Size = new System.Drawing.Size(289, 174);
            this.chartControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 174);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}

