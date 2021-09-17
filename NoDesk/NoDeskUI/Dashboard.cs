using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Renderable;
namespace NoDeskUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
            TestCharts();
        }


        private void TestCharts()
        {
            // chart 1
            double[] values = { 15, 35, 12 };
            string[] labels = { "Solved", "Unresolved", "Past deadline"};
            var PlotDayPie = formsPlotDayPie.Plot.AddPie(values);
            PlotDayPie.SliceLabels = labels;
            PlotDayPie.ShowLabels = true;
            PlotDayPie.Explode = true;
            PlotDayPie.SliceFillColors = new Color[] { Color.Green, Color.SteelBlue, Color.DarkOrange };
            formsPlotDayPie.Render();

            // chart 2
            // generate random data to plot
            int groupCount = 7;
            Random rand = new(0);
            double[] values1 = DataGen.RandomNormal(rand, groupCount, 20, 5);
            double[] values2 = DataGen.RandomNormal(rand, groupCount, 20, 5);
            double[] values3 = DataGen.RandomNormal(rand, groupCount, 20, 5);
            double[] errors1 = DataGen.RandomNormal(rand, groupCount, 0, 0);
            double[] errors2 = DataGen.RandomNormal(rand, groupCount, 0, 0);
            double[] errors3 = DataGen.RandomNormal(rand, groupCount, 0, 0);

            // group all data together
            string[] groupNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] seriesNames = { "Unresolved", "Past deadline", "Resolved" };
            double[][] valuesBySeries = { values1, values2, values3 };
            double[][] errorsBySeries = { errors1, errors2, errors3 };

            chartWeek.ForeColor = Color.Red;

            // add the grouped bar plots and show a legend
            chartWeek.Plot.AddBarGroups(groupNames, seriesNames, valuesBySeries, errorsBySeries);
            chartWeek.Plot.Legend(location: Alignment.UpperRight);



            chartWeek.BackColor = Color.White;
            chartWeek.Plot.SetAxisLimits(yMin: 0);
            
            chartWeek.Render();
        }

    }
}
