using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace UseRegressionLines {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a regression line for the Open value level.
            RegressionLine myLine = new RegressionLine(ValueLevel.Open);

            // Access the series collection of indicators,
            // and add the regression line to it.
            ((StockSeriesView)chartControl1.Series[0].View).Indicators.Add(myLine);

            // Customize the regression line's appearance.
            myLine.LineStyle.DashStyle = DashStyle.DashDot;
            myLine.LineStyle.Thickness = 2;
            myLine.Color = Color.Crimson;
        }

    }
}