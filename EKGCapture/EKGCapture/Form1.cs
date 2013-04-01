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
using System.IO;

namespace EKGCapture
{
    public partial class Form1 : Form
    {
        GraphPane MyPane;
        PointPairList list1 = new PointPairList();
        StreamWriter writer;
        double Time_s = 0;
        double pastx;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            writer = new StreamWriter(saveFileDialog1.FileName);
            MyPane = WaveformGraph.GraphPane;

            MyPane.XAxis.Title.Text = "";
            MyPane.YAxis.Scale.Max = 5;
            MyPane.YAxis.Scale.Min = 0;
            MyPane.YAxis.Title.Text = "";
            MyPane.Title.Text = "";
            LineItem myCurve = MyPane.AddCurve("", list1, Color.Red, SymbolType.None);
            WaveformGraph.AxisChange();
            SerialReader.Open();
            Timer_ms.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list1.Clear();
            Time_s = 0;
        }

        private void Timer_ms_Tick(object sender, EventArgs e)
        {
            Time_s = Time_s + .01;
        }

        private void SerialReader_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            double y;
            if (double.TryParse(SerialReader.ReadLine(),out y) == true)
            {
                list1.Add(Time_s, y/204);
                writer.WriteLine(Time_s + "," + y / 204);
                pastx = y / 204;
                if (list1.Count > 500)
                {
                    list1.RemoveAt(0);
                }
                MyPane.XAxis.Scale.Max = Time_s + 1;
                MyPane.XAxis.Scale.Min = Time_s - 1;
                WaveformGraph.Invalidate();
                WaveformGraph.AxisChange();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialReader.Close();
            SerialReader.Dispose();
            Timer_ms.Stop();
        }
    }
}
