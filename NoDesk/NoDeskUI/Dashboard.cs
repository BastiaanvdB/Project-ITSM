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

            double[] values = { 7, 15 };
            string centerTextpieUnresolved = $"{7}/{15}";
            
            var pieUnresolved = formsPlotUnresolved.plt.AddPie(values);
            pieUnresolved.DonutSize = .6;
            pieUnresolved.DonutLabel = centerTextpieUnresolved;
            pieUnresolved.CenterFont.Color = Color.Black;
            pieUnresolved.Explode = true;
            pieUnresolved.SliceFillColors = new Color[] { Color.Orange, Color.LightGray };
            formsPlotUnresolved.Render();

            // chart 2
 
            double[] values2 = { 7, 15 };
            string centerTextpiePastDeadline = $"{1}";

            var piePastDeadline = formsPlotPastDeadline.plt.AddPie(values);
            piePastDeadline.DonutSize = .6;
            piePastDeadline.DonutLabel = centerTextpiePastDeadline;
            piePastDeadline.CenterFont.Color = Color.Black;
            piePastDeadline.Explode = true;
            piePastDeadline.SliceFillColors = new Color[] { Color.Red, Color.LightGray };
            formsPlotPastDeadline.Render();

            // chart 3

            double[] valuesPieResolved = { 7, 15 };
            string centerTextPieResolved = $"{16}";

            var pieResolved = formsPlotResolved.plt.AddPie(values);
            pieResolved.DonutSize = .6;
            pieResolved.DonutLabel = centerTextPieResolved;
            pieResolved.CenterFont.Color = Color.Black;
            pieResolved.Explode = true;
            pieResolved.SliceFillColors = new Color[] { Color.Green, Color.LightGray };
            formsPlotResolved.Render();
        }

    }
}
