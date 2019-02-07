namespace Linear_Regression
{
    partial class FormLinearRegression
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LabelDataPoints = new System.Windows.Forms.Label();
            this.LabelDegree = new System.Windows.Forms.Label();
            this.ButtonPlotData = new System.Windows.Forms.Button();
            this.ButtonPlotLine = new System.Windows.Forms.Button();
            this.ChartLinearRegression = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NumericUpDownDataPoints = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownDegree = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ChartLinearRegression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDataPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDataPoints
            // 
            this.LabelDataPoints.AutoSize = true;
            this.LabelDataPoints.Location = new System.Drawing.Point(75, 37);
            this.LabelDataPoints.Name = "LabelDataPoints";
            this.LabelDataPoints.Size = new System.Drawing.Size(96, 20);
            this.LabelDataPoints.TabIndex = 0;
            this.LabelDataPoints.Text = "Data Points:";
            // 
            // LabelDegree
            // 
            this.LabelDegree.AutoSize = true;
            this.LabelDegree.Location = new System.Drawing.Point(105, 79);
            this.LabelDegree.Name = "LabelDegree";
            this.LabelDegree.Size = new System.Drawing.Size(66, 20);
            this.LabelDegree.TabIndex = 1;
            this.LabelDegree.Text = "Degree:";
            // 
            // ButtonPlotData
            // 
            this.ButtonPlotData.Location = new System.Drawing.Point(423, 37);
            this.ButtonPlotData.Name = "ButtonPlotData";
            this.ButtonPlotData.Size = new System.Drawing.Size(85, 27);
            this.ButtonPlotData.TabIndex = 4;
            this.ButtonPlotData.Text = "Plot Data";
            this.ButtonPlotData.UseVisualStyleBackColor = true;
            this.ButtonPlotData.Click += new System.EventHandler(this.ButtonPlotData_Click);
            // 
            // ButtonPlotLine
            // 
            this.ButtonPlotLine.Location = new System.Drawing.Point(423, 76);
            this.ButtonPlotLine.Name = "ButtonPlotLine";
            this.ButtonPlotLine.Size = new System.Drawing.Size(85, 27);
            this.ButtonPlotLine.TabIndex = 5;
            this.ButtonPlotLine.Text = "Plot Line";
            this.ButtonPlotLine.UseVisualStyleBackColor = true;
            this.ButtonPlotLine.Click += new System.EventHandler(this.ButtonPlotLine_Click);
            // 
            // ChartLinearRegression
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartLinearRegression.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartLinearRegression.Legends.Add(legend3);
            this.ChartLinearRegression.Location = new System.Drawing.Point(12, 141);
            this.ChartLinearRegression.Name = "ChartLinearRegression";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartLinearRegression.Series.Add(series3);
            this.ChartLinearRegression.Size = new System.Drawing.Size(586, 444);
            this.ChartLinearRegression.TabIndex = 6;
            this.ChartLinearRegression.Text = "Linear Regression";
            // 
            // NumericUpDownDataPoints
            // 
            this.NumericUpDownDataPoints.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownDataPoints.Location = new System.Drawing.Point(231, 35);
            this.NumericUpDownDataPoints.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NumericUpDownDataPoints.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownDataPoints.Name = "NumericUpDownDataPoints";
            this.NumericUpDownDataPoints.Size = new System.Drawing.Size(120, 26);
            this.NumericUpDownDataPoints.TabIndex = 7;
            this.NumericUpDownDataPoints.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // NumericUpDownDegree
            // 
            this.NumericUpDownDegree.Location = new System.Drawing.Point(231, 77);
            this.NumericUpDownDegree.Name = "NumericUpDownDegree";
            this.NumericUpDownDegree.Size = new System.Drawing.Size(120, 26);
            this.NumericUpDownDegree.TabIndex = 8;
            // 
            // FormLinearRegression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 597);
            this.Controls.Add(this.NumericUpDownDegree);
            this.Controls.Add(this.NumericUpDownDataPoints);
            this.Controls.Add(this.ChartLinearRegression);
            this.Controls.Add(this.ButtonPlotLine);
            this.Controls.Add(this.ButtonPlotData);
            this.Controls.Add(this.LabelDegree);
            this.Controls.Add(this.LabelDataPoints);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormLinearRegression";
            this.ShowIcon = false;
            this.Text = "Linear Regression";
            ((System.ComponentModel.ISupportInitialize)(this.ChartLinearRegression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDataPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDataPoints;
        private System.Windows.Forms.Label LabelDegree;
        private System.Windows.Forms.Button ButtonPlotData;
        private System.Windows.Forms.Button ButtonPlotLine;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartLinearRegression;
        private System.Windows.Forms.NumericUpDown NumericUpDownDataPoints;
        private System.Windows.Forms.NumericUpDown NumericUpDownDegree;
    }
}

