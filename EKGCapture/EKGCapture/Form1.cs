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
using System.Collections;

namespace EKGCapture
{
    public partial class Form1 : Form
    {
        GraphPane MyPane;
        PointPairList list1 = new PointPairList();
        aboutForm aboutform = new aboutForm();
        StreamWriter writer;
        ToolStripMenuItem lastClickedItem;
        double Time_s = 0;
        double y;
        double x;
        string[] ports;
        string activePort;
        bool write = false;
        bool ChangingCOM;
        bool ChangePortFlag;
        bool locationSelected = false;
        double elapsedSeconds = -1;

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
            writer = new StreamWriter(saveFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list1.Clear();
            Time_s = 0;
        }

        private void Timer_ms_Tick(object sender, EventArgs e)
        {
            Time_s = Time_s + .015;
            WaveformGraph.Invalidate();
            WaveformGraph.AxisChange();
            while (list1.Count > 550)
            {
                list1.RemoveAt(0);
            }
        }

        private void SerialReader_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string[] readdata = SerialReader.ReadLine().Split(',');
            if (ChangePortFlag == false)
            {
                if (readdata.Count() == 2)
                {
                    if (double.TryParse(readdata[0], out y) == true)
                    {
                        if (double.TryParse(readdata[1], out x) == true)
                        {
                            if (x == 0)
                            { 
                                elapsedSeconds++; 
                            }
                            list1.Add(x / 1000 + elapsedSeconds, y / 204);
                            if (write == true)
                            {
                                writer.WriteLine(x / 1000 + elapsedSeconds + "," + y / 204);
                            }
                            MyPane.XAxis.Scale.Max = x / 1000 + elapsedSeconds + 5;
                            MyPane.XAxis.Scale.Min = x / 1000 + elapsedSeconds - 5;
                        }
                    }
                }
            }
            else
            {
                if (readdata.Count() == 2)
                {
                    if (double.TryParse(readdata[0], out y) == true)
                    {
                        if (double.TryParse(readdata[1], out x) == true)
                        {
                            if (x == 0)
                            {
                                elapsedSeconds++;
                            }
                            list1.Add(x / 1000 + elapsedSeconds, y / 204);
                            if (write == true)
                            {
                                writer.WriteLine(x / 1000 + elapsedSeconds + "," + y / 204);
                            }
                            MyPane.XAxis.Scale.Max = x / 1000 + elapsedSeconds + 5;
                            MyPane.XAxis.Scale.Min = x / 1000 + elapsedSeconds - 5;
                        }
                    }
                }
                SerialReader.Close();
                ChangePortFlag = false;
                if (ChangingCOM == true)
                {
                    ChangeCommPort();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialReader.IsOpen == true)
            {
                ChangePortFlag = true;
                while (ChangePortFlag == true) { };
            }
            SerialReader.Dispose();
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void AddCommPorts()
        {
            cOMPortToolStripMenuItem.DropDownItems.Clear();
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
                clickedItem.Checked = true;
                SerialReader.PortName = activePort;
                SerialReader.Open();
                Timer_ms.Start();
                lastClickedItem = clickedItem;
            }
            else
            {
                ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
                if (clickedItem.Checked == true) { }
                else
                {
                    activePort = clickedItem.Text;
                    clickedItem.Checked = true;
                    lastClickedItem.Checked = false;
                    ChangePortFlag = true;
                    ChangingCOM = true;
                }
                lastClickedItem = clickedItem;
            }
        }

        private void ChangeCommPort()
        {
            Timer_ms.Stop();
            list1.Clear();
            Time_s = 0;
            elapsedSeconds = 0;
            MyPane.XAxis.Scale.Max = Time_s + 5;
            MyPane.XAxis.Scale.Min = Time_s - 5;
            WaveformGraph.Invalidate();
            WaveformGraph.AxisChange();
            SerialReader.PortName = activePort;
            SerialReader.Open();
            Timer_ms.Start();
        }

        private void setDataDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                writer = new StreamWriter(saveFileDialog1.FileName);
                locationSelected = true;
            }
            catch
            {
                MessageBox.Show("Invalid Location");
                return;
            }
        }

        private void enableDataLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (locationSelected == false)
            {
                try
                {
                    saveFileDialog1.ShowDialog();
                    writer = new StreamWriter(saveFileDialog1.FileName);
                    locationSelected = true;
                }
                catch
                {
                    MessageBox.Show("Invalid Location");
                    return;
                }
            }
            if (enableDataLoggingToolStripMenuItem.Checked == false)
            {
                enableDataLoggingToolStripMenuItem.Checked = true;
                if (saveFileDialog1.FileName == null)
                {
                    MessageBox.Show("Set a destination for the log file");
                    enableDataLoggingToolStripMenuItem.Checked = false;
                }
                else
                {
                    write = true;
                }
            }
            else
            {
                enableDataLoggingToolStripMenuItem.Checked = false;
                write = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerialReader.IsOpen == true)
            {
                ChangePortFlag = true;
                while (ChangePortFlag == true) { };
            }
            SerialReader.Dispose();
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void refreshCOMPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCommPorts();
            if (SerialReader.IsOpen == true)
            {
                ChangePortFlag = true;
                while (ChangePortFlag == true) { };
            }
            SerialReader.Close();
            list1.Clear();
            Timer_ms.Stop();
            Time_s = 0;
            elapsedSeconds = 0;
            MyPane.XAxis.Scale.Max = Time_s + 5;
            MyPane.XAxis.Scale.Min = Time_s - 5;
            WaveformGraph.Invalidate();
            WaveformGraph.AxisChange();
            if (lastClickedItem == null) { }
            else
            {
                lastClickedItem.Checked = false;
            }
            lastClickedItem = null;
            activePort = null;
        }

        private void disableCOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerialReader.IsOpen == true)
            {
                ChangePortFlag = true;
                while (ChangePortFlag == true) { };
            }
            SerialReader.Close();
            list1.Clear();
            Timer_ms.Stop();
            Time_s = 0;
            elapsedSeconds = 0;
            MyPane.XAxis.Scale.Max = Time_s + 5;
            MyPane.XAxis.Scale.Min = Time_s - 5;
            WaveformGraph.Invalidate();
            WaveformGraph.AxisChange();
            if (lastClickedItem == null) { }
            else
            {
                lastClickedItem.Checked = false;
            }
            lastClickedItem = null;
            activePort = null;
        }

        private void aBoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutform.Show();
        }
    }
}
