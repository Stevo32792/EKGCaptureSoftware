namespace EKGCapture
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.WaveformGraph = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SerialReader = new System.IO.Ports.SerialPort(this.components);
            this.Timer_ms = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // WaveformGraph
            // 
            this.WaveformGraph.Location = new System.Drawing.Point(12, 12);
            this.WaveformGraph.Name = "WaveformGraph";
            this.WaveformGraph.ScrollGrace = 0D;
            this.WaveformGraph.ScrollMaxX = 0D;
            this.WaveformGraph.ScrollMaxY = 0D;
            this.WaveformGraph.ScrollMaxY2 = 0D;
            this.WaveformGraph.ScrollMinX = 0D;
            this.WaveformGraph.ScrollMinY = 0D;
            this.WaveformGraph.ScrollMinY2 = 0D;
            this.WaveformGraph.Size = new System.Drawing.Size(866, 416);
            this.WaveformGraph.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ClearGraph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SerialReader
            // 
            this.SerialReader.BaudRate = 115200;
            this.SerialReader.PortName = "COM4";
            this.SerialReader.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialReader_DataReceived);
            // 
            // Timer_ms
            // 
            this.Timer_ms.Interval = 1;
            this.Timer_ms.Tick += new System.EventHandler(this.Timer_ms_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "EKGData";
            this.saveFileDialog1.Filter = "csv files|*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WaveformGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl WaveformGraph;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort SerialReader;
        private System.Windows.Forms.Timer Timer_ms;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

