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
using System.IO.Ports;

namespace EKGCapture
{
    public partial class Form1 : Form
    {
        GraphPane MyPane;
        PointPairList list1 = new PointPairList();
        StreamWriter writer;
        double Time_s = 0;
        double y;
        string[] ports;
        string activePort;

        bool ChangePortFlag;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddCommPorts();
            MyPane = WaveformGraph.GraphPane;
            MyPane.XAxis.Title.Text = "";
            MyPane.YAxis.Scale.Max = 5;
            MyPane.YAxis.Scale.Min = 0;
            MyPane.YAxis.Title.Text = "";
            MyPane.Title.Text = "";
            LineItem myCurve = MyPane.AddCurve("", list1, Color.Red, SymbolType.None);
            WaveformGraph.AxisChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list1.Clear();
            Time_s = 0;
        }

        private void Timer_ms_Tick(object sender, EventArgs e)
        {
            Time_s = Time_s + .025;
            WaveformGraph.Invalidate();
            WaveformGraph.AxisChange();
            if (list1.Count > 5000)
            {
                list1.RemoveAt(0);
            }
        }

        private void SerialReader_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (ChangePortFlag == false)
            {
                if (double.TryParse(SerialReader.ReadLine(), out y))
                {
                    list1.Add(Time_s, y / 204);
                }
                MyPane.XAxis.Scale.Max = Time_s + 1;
                MyPane.XAxis.Scale.Min = Time_s - 1;
            }
            else
            {
                if (double.TryParse(SerialReader.ReadLine(), out y))
                {
                    list1.Add(Time_s, y / 204);
                }
                SerialReader.Close();
                ChangePortFlag = false;
                ChangeCommPort();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialReader.Close();
            SerialReader.Dispose();
            Timer_ms.Stop();
        }

        private void AddCommPorts()
        {
            ports = SerialPort.GetPortNames();
            ToolStripMenuItem[] items = new ToolStripMenuItem[ports.Length];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = "Port" + ports[i];
                items[i].Text = ports[i];    
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }
            
            cOMPortToolStripMenuItem.DropDownItems.AddRange(items);
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            if (activePort == null)
            {
                ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
                activePort = clickedItem.Text;
                SerialReader.PortName = activePort;
                SerialReader.Open();
                Timer_ms.Start();
            }
            else
            {
                ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
                activePort = clickedItem.Text;
                ChangePortFlag = true;
            }
        }

        private void ChangeCommPort()
        {
            Timer_ms.Stop();
            list1.Clear();
            Time_s = 0;
            SerialReader.PortName = activePort;
            SerialReader.Open();
            Timer_ms.Start();
        }

        private void setDataDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            writer = new StreamWriter(saveFileDialog1.FileName);
        }
    }
}
