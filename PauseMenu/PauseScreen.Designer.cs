namespace Tetris.Menus
{
    partial class PauseScreen
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.labConfirm = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlConfirm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnlConfirm);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnResume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 215);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderSize = 4;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arcade Normal", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(29, 95);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(212, 53);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnResume
            // 
            this.btnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResume.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResume.FlatAppearance.BorderSize = 4;
            this.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Font = new System.Drawing.Font("Arcade Normal", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.Location = new System.Drawing.Point(51, 25);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(167, 53);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // labConfirm
            // 
            this.labConfirm.AutoSize = true;
            this.labConfirm.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfirm.ForeColor = System.Drawing.Color.White;
            this.labConfirm.Location = new System.Drawing.Point(3, 8);
            this.labConfirm.Name = "labConfirm";
            this.labConfirm.Size = new System.Drawing.Size(265, 11);
            this.labConfirm.TabIndex = 2;
            this.labConfirm.Text = "Return to main menu?";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.BorderSize = 2;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(36, 31);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(82, 29);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Yes";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(146, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "No";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.Controls.Add(this.labConfirm);
            this.pnlConfirm.Controls.Add(this.btnCancel);
            this.pnlConfirm.Controls.Add(this.btnConfirm);
            this.pnlConfirm.Location = new System.Drawing.Point(3, 148);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Size = new System.Drawing.Size(272, 64);
            this.pnlConfirm.TabIndex = 5;
            this.pnlConfirm.Visible = false;
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "PauseScreen";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(285, 225);
            this.panel1.ResumeLayout(false);
            this.pnlConfirm.ResumeLayout(false);
            this.pnlConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label labConfirm;
        private System.Windows.Forms.Panel pnlConfirm;
    }
}
