using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using ZedGraph.Web;

namespace EKGCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateGraph();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateGraph()
        {
            GraphPane MyPane = WaveformGraph.GraphPane;

            MyPane.XAxis.Title.Text = "";

            MyPane.YAxis.Title.Text = "";
            MyPane.Title.Text = "";
            WaveformGraph.AxisChange();
        }
    }
}
