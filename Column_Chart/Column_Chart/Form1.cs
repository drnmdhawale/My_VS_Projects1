using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Column_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string chart_data = Properties.Resources.TextFile1;
            
            string[] dates = new string[5] { 
                "2007-08", "2008-09", "2009-10", "2010-11", "2011-12" };

            string[] arrayData = chart_data.Split(',');
            
            CustomLabel customLabel;
            Axis axisX = chart1.ChartAreas[0].AxisX;

            int endLoop = arrayData.Length;
            double axelLabelPos = 0.5;

            for (int i = 0; i < endLoop; i++)
            {
                int x = Int32.Parse(arrayData[i]);
                
                this.chart1.Series["Series1"].Points.Add(x);
                
                customLabel = axisX.CustomLabels.Add(axelLabelPos,
                axelLabelPos + 1, dates[i]);
                
                axelLabelPos = axelLabelPos + 1.0;

            }
        }
    }
}
