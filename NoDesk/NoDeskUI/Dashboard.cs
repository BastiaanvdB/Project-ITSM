using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot.Renderable;
namespace NoDeskUI
{
    public partial class NoDesk : Form
    {
        public NoDesk()
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
            double[] values1 = { 7, 15 };
            formsPlotUnresolved.Plot.AddPie(values1, true);
            formsPlotUnresolved.Render();

            // chart 2
            double[] values2 = { 7, 15 };
            formsPlotPastDeadline.Plot.AddPie(values2, true);
            formsPlotPastDeadline.Render();

            // chart 3
            double[] values3 = { 7, 15 };
            formsPlotResolved.Plot.AddPie(values3, true);
            formsPlotResolved.Render();
        }

    }
}
