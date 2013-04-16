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
            this.SerialReader = new System.IO.Ports.SerialPort(this.components);
            this.Timer_ms = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDataDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDataLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WaveformGraph
            // 
            this.WaveformGraph.Location = new System.Drawing.Point(12, 27);
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
            // SerialReader
            // 
            this.SerialReader.BaudRate = 115200;
            this.SerialReader.PortName = "COM5";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDataDestinationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setDataDestinationToolStripMenuItem
            // 
            this.setDataDestinationToolStripMenuItem.Name = "setDataDestinationToolStripMenuItem";
            this.setDataDestinationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDataDestinationToolStripMenuItem.Text = "Set Data Destination";
            this.setDataDestinationToolStripMenuItem.Click += new System.EventHandler(this.setDataDestinationToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableDataLoggingToolStripMenuItem,
            this.cOMPortToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // enableDataLoggingToolStripMenuItem
            // 
            this.enableDataLoggingToolStripMenuItem.Name = "enableDataLoggingToolStripMenuItem";
            this.enableDataLoggingToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.enableDataLoggingToolStripMenuItem.Text = "Enable Data Logging";
            // 
            // cOMPortToolStripMenuItem
            // 
            this.cOMPortToolStripMenuItem.Name = "cOMPortToolStripMenuItem";
            this.cOMPortToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cOMPortToolStripMenuItem.Text = "COM Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 456);
            this.Controls.Add(this.WaveformGraph);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl WaveformGraph;
        private System.IO.Ports.SerialPort SerialReader;
        private System.Windows.Forms.Timer Timer_ms;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDataDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableDataLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPortToolStripMenuItem;
    }
}

