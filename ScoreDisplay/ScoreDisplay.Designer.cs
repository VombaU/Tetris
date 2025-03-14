﻿namespace Tetris.Displays
{
    partial class ScoreDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.labTopScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arcade Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arcade Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Arcade Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.ForeColor = System.Drawing.Color.White;
            this.labScore.Location = new System.Drawing.Point(15, 154);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(166, 24);
            this.labScore.TabIndex = 2;
            this.labScore.Text = "000000";
            // 
            // labTopScore
            // 
            this.labTopScore.AutoSize = true;
            this.labTopScore.Font = new System.Drawing.Font("Arcade Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTopScore.ForeColor = System.Drawing.Color.White;
            this.labTopScore.Location = new System.Drawing.Point(15, 55);
            this.labTopScore.Name = "labTopScore";
            this.labTopScore.Size = new System.Drawing.Size(166, 24);
            this.labTopScore.TabIndex = 3;
            this.labTopScore.Text = "000000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labTopScore);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 214);
            this.panel1.TabIndex = 4;
            // 
            // Tetris.Displays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Tetris.Displays";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(224, 224);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labTopScore;
        private System.Windows.Forms.Panel panel1;
    }
}
