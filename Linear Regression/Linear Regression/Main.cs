using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Linear_Regression
{
    public partial class FormLinearRegression : Form
    {
        // Declare variables.
        private Random random = new Random();
        private double[] xCoordinates = new double[] { };
        private double[] yCoordinates = new double[] { };

        /// <summary>
        /// Start the form.
        /// </summary>
        public FormLinearRegression()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Write coordinate data in diagram.
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">Event.</param>
        private void ButtonPlotData_Click(object sender, EventArgs e)
        {
            // Clear the chart.
            ChartLinearRegression.Titles.Clear();
            ChartLinearRegression.Series.Clear();

            // Get the amount of the coordinates.
            xCoordinates = new double[Convert.ToInt32(NumericUpDownDataPoints.Value)];
            yCoordinates = new double[Convert.ToInt32(NumericUpDownDataPoints.Value)];

            // Title of the chart.
            ChartLinearRegression.Titles.Add("Linear Regression");

            // Get the coordinates.
            for (int i = 0; i < Math.Floor(xCoordinates.GetLength(0) / 2.0d); i++)
                xCoordinates[i] = random.Next(i - xCoordinates.Length / 10, i + xCoordinates.Length / 10);

            for (int i = Convert.ToInt32(Math.Floor(xCoordinates.GetLength(0) / 2.0d)); i < xCoordinates.GetLength(0); i++)
                xCoordinates[i] = random.Next(i + xCoordinates.Length / 5, i + xCoordinates.Length / 2);

            for (int i = 0; i < Math.Floor(yCoordinates.GetLength(0) / 2.0d); i++)
                yCoordinates[i] = random.Next(i, i + yCoordinates.Length / 5);

            for (int i = Convert.ToInt32(Math.Floor(yCoordinates.GetLength(0) / 2.0d)); i < yCoordinates.GetLength(0); i++)
                yCoordinates[i] = random.Next(i - yCoordinates.Length / 10, i);

            // Set the settings of the coordinates and add the points in diagram. 
            ChartLinearRegression.Series.Add("Data Points");
            ChartLinearRegression.Series["Data Points"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            for (int i = 0; i < xCoordinates.Length; i++)
                ChartLinearRegression.Series["Data Points"].Points.AddXY(xCoordinates[i], yCoordinates[i]);

            ChartLinearRegression.Series["Data Points"].Color = Color.DarkOrange;

            ChartLinearRegression.Series.Add("QR Line");
            ChartLinearRegression.Series["QR Line"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChartLinearRegression.Series["QR Line"].Color = Color.DarkGreen;
        }

        /// <summary>
        /// Write the gradient triangle for the graph in diagram (machine learning).
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">Event.</param>
        private void ButtonPlotLine_Click(object sender, EventArgs e)
        {
            // Declare variables.
            int degree = Convert.ToInt32(NumericUpDownDegree.Value);
            double xMin, xMax, interval;
            double[] qrTheta;
            DenseMatrix x = new DenseMatrix(xCoordinates.Length, degree + 1);
            DenseMatrix y;

            // Clear the points.
            ChartLinearRegression.Series["QR Line"].Points.Clear();

            x.SetColumn(0, DenseVector.Create(xCoordinates.Length, i => 1));

            if (degree != 0)
                x.SetColumn(1, xCoordinates);

            for (int i = 2; i <= degree; i++)
                x.SetColumn(i, x.Column(1).PointwiseMultiply(x.Column(i - 1)));

            y = DenseMatrix.OfColumns(yCoordinates.Length, 1, new[] { new DenseVector(yCoordinates) });

            qrTheta = x.QR().Solve(y).ToColumnMajorArray();

            xMin = xCoordinates.Min();
            xMax = xCoordinates.Max();
            interval = (xMax - xMin) / Convert.ToDouble(NumericUpDownDegree.Value);

            // Set the points.
            for (int i = 0; i < xCoordinates.Length; i++)
                ChartLinearRegression.Series["QR Line"].Points.AddXY(xCoordinates[i], Yprediction(xCoordinates[i], qrTheta));
        }

        /// <summary>
        /// Determine the predition.
        /// </summary>
        /// <param name="xPlot">X plot of the diagram.</param>
        /// <param name="theta">Value for statistic.</param>
        /// <returns></returns>
        private static double Yprediction(double xPlot, double[] theta)
        {
            // Declare variables.
            double yPlot = 0.0d;

            for (int i = 0; i < theta.Length; i++)
                yPlot += theta[i] * Math.Pow(xPlot, i);

            return yPlot;
        }
    }
}