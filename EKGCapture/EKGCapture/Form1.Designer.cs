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
            this.WaveformGraph.Size = new System.Drawing.Size(567, 327);
            this.WaveformGraph.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 443);
            this.Controls.Add(this.WaveformGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl WaveformGraph;
    }
}

