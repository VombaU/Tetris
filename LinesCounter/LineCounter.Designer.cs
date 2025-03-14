namespace Tetris.Displays
{
    partial class LineCounter
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labLineCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labLineCounter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 54);
            this.panel1.TabIndex = 0;
            // 
            // labLineCounter
            // 
            this.labLineCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labLineCounter.AutoSize = true;
            this.labLineCounter.Font = new System.Drawing.Font("Arcade Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLineCounter.ForeColor = System.Drawing.Color.White;
            this.labLineCounter.Location = new System.Drawing.Point(191, 14);
            this.labLineCounter.Name = "labLineCounter";
            this.labLineCounter.Size = new System.Drawing.Size(88, 24);
            this.labLineCounter.TabIndex = 1;
            this.labLineCounter.Text = "000";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arcade Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LINES-";
            // 
            // LineCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "LineCounter";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(320, 64);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labLineCounter;
        private System.Windows.Forms.Label label1;
    }
}
