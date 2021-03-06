﻿namespace EKGCapture
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDataLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCOMPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableCOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAUDRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerialTimeout = new System.Windows.Forms.Timer(this.components);
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
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDataDestinationToolStripMenuItem,
            this.exitToolStripMenuItem});
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableDataLoggingToolStripMenuItem,
            this.refreshCOMPortsToolStripMenuItem,
            this.disableCOMPortToolStripMenuItem,
            this.cOMPortToolStripMenuItem,
            this.bAUDRateToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // enableDataLoggingToolStripMenuItem
            // 
            this.enableDataLoggingToolStripMenuItem.Name = "enableDataLoggingToolStripMenuItem";
            this.enableDataLoggingToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.enableDataLoggingToolStripMenuItem.Text = "Enable Data Logging";
            this.enableDataLoggingToolStripMenuItem.Click += new System.EventHandler(this.enableDataLoggingToolStripMenuItem_Click);
            // 
            // refreshCOMPortsToolStripMenuItem
            // 
            this.refreshCOMPortsToolStripMenuItem.Name = "refreshCOMPortsToolStripMenuItem";
            this.refreshCOMPortsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.refreshCOMPortsToolStripMenuItem.Text = "Refresh COM Ports";
            this.refreshCOMPortsToolStripMenuItem.Click += new System.EventHandler(this.refreshCOMPortsToolStripMenuItem_Click);
            // 
            // disableCOMPortToolStripMenuItem
            // 
            this.disableCOMPortToolStripMenuItem.Name = "disableCOMPortToolStripMenuItem";
            this.disableCOMPortToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.disableCOMPortToolStripMenuItem.Text = "Disable COM Port";
            this.disableCOMPortToolStripMenuItem.Click += new System.EventHandler(this.disableCOMPortToolStripMenuItem_Click);
            // 
            // cOMPortToolStripMenuItem
            // 
            this.cOMPortToolStripMenuItem.Name = "cOMPortToolStripMenuItem";
            this.cOMPortToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cOMPortToolStripMenuItem.Text = "COM Port";
            // 
            // bAUDRateToolStripMenuItem
            // 
            this.bAUDRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.bAUDRateToolStripMenuItem.Name = "bAUDRateToolStripMenuItem";
            this.bAUDRateToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bAUDRateToolStripMenuItem.Text = "BAUD Rate";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "9600";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "14400";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "19200";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "28800";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "38400";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "57600";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem8.Text = "115200";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBoutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aBoutToolStripMenuItem
            // 
            this.aBoutToolStripMenuItem.Name = "aBoutToolStripMenuItem";
            this.aBoutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aBoutToolStripMenuItem.Text = "About";
            this.aBoutToolStripMenuItem.Click += new System.EventHandler(this.aBoutToolStripMenuItem_Click);
            // 
            // SerialTimeout
            // 
            this.SerialTimeout.Interval = 1000;
            this.SerialTimeout.Tick += new System.EventHandler(this.SerialTimeout_Tick);
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
            this.Text = "Wireless EKG Front Interface";
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCOMPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableCOMPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAUDRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.Timer SerialTimeout;
    }
}

