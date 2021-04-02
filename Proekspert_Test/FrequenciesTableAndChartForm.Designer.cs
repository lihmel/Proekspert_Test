
namespace Proekspert_Test
{
    partial class FrequenciesTableAndChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.frequencyTable = new System.Windows.Forms.DataGridView();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // frequencyTable
            // 
            this.frequencyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.frequencyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frequencyTable.Location = new System.Drawing.Point(467, 37);
            this.frequencyTable.Name = "frequencyTable";
            this.frequencyTable.Size = new System.Drawing.Size(281, 171);
            this.frequencyTable.TabIndex = 0;
            // 
            // barChart
            // 
            chartArea4.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.barChart.Legends.Add(legend4);
            this.barChart.Location = new System.Drawing.Point(24, 37);
            this.barChart.Name = "barChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.barChart.Series.Add(series4);
            this.barChart.Size = new System.Drawing.Size(386, 371);
            this.barChart.TabIndex = 1;
            this.barChart.Text = "chart1";
            // 
            // FrequenciesTableAndChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.frequencyTable);
            this.Name = "FrequenciesTableAndChartForm";
            this.Text = "FrequenciesTableAndChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView frequencyTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
    }
}