using Tetris.Displays;
namespace Tetris
{
    partial class TetrisGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TetrisGame));
            this.panel69 = new System.Windows.Forms.Panel();
            this.pnlDropTimeWindowSelection = new System.Windows.Forms.Panel();
            this.labMaxDropTimeWindow = new System.Windows.Forms.Label();
            this.labMinDropTimeWindow = new System.Windows.Forms.Label();
            this.btnDropTimeWindowSlider = new System.Windows.Forms.Button();
            this.txtDropTimeWindow = new System.Windows.Forms.TextBox();
            this.labDropTimeWindowBar = new System.Windows.Forms.Label();
            this.pnlFreefallDelaySelection = new System.Windows.Forms.Panel();
            this.labFreefallMaxDelay = new System.Windows.Forms.Label();
            this.labFreefallMinDelay = new System.Windows.Forms.Label();
            this.btnFreefallDelaySlider = new System.Windows.Forms.Button();
            this.txtFreefallDelay = new System.Windows.Forms.TextBox();
            this.labFreefallDelayBar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlWidthSelection = new System.Windows.Forms.Panel();
            this.widthMaxValue = new System.Windows.Forms.Label();
            this.widthMinValue = new System.Windows.Forms.Label();
            this.btnWidthSlider = new System.Windows.Forms.Button();
            this.txtWidthValue = new System.Windows.Forms.TextBox();
            this.labWidthBar = new System.Windows.Forms.Label();
            this.pnlHeightSelection = new System.Windows.Forms.Panel();
            this.heightMaxValue = new System.Windows.Forms.Label();
            this.heightMinValue = new System.Windows.Forms.Label();
            this.btnHeightSlider = new System.Windows.Forms.Button();
            this.txtHeightValue = new System.Windows.Forms.TextBox();
            this.labHeightBar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlGameModeSelection = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClassic = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlCustomGameModeOptions = new System.Windows.Forms.Panel();
            this.panel69.SuspendLayout();
            this.pnlDropTimeWindowSelection.SuspendLayout();
            this.pnlFreefallDelaySelection.SuspendLayout();
            this.pnlWidthSelection.SuspendLayout();
            this.pnlHeightSelection.SuspendLayout();
            this.pnlGameModeSelection.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlCustomGameModeOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel69
            // 
            this.panel69.BackColor = System.Drawing.Color.Black;
            this.panel69.Controls.Add(this.pnlDropTimeWindowSelection);
            this.panel69.Controls.Add(this.pnlFreefallDelaySelection);
            this.panel69.Controls.Add(this.label4);
            this.panel69.Controls.Add(this.label1);
            this.panel69.Controls.Add(this.btnCancel);
            this.panel69.Controls.Add(this.btnOk);
            this.panel69.Controls.Add(this.pnlWidthSelection);
            this.panel69.Controls.Add(this.pnlHeightSelection);
            this.panel69.Controls.Add(this.label3);
            this.panel69.Controls.Add(this.label2);
            this.panel69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel69.Location = new System.Drawing.Point(3, 3);
            this.panel69.Name = "panel69";
            this.panel69.Size = new System.Drawing.Size(254, 296);
            this.panel69.TabIndex = 5;
            // 
            // pnlDropTimeWindowSelection
            // 
            this.pnlDropTimeWindowSelection.BackColor = System.Drawing.Color.Black;
            this.pnlDropTimeWindowSelection.Controls.Add(this.labMaxDropTimeWindow);
            this.pnlDropTimeWindowSelection.Controls.Add(this.labMinDropTimeWindow);
            this.pnlDropTimeWindowSelection.Controls.Add(this.btnDropTimeWindowSlider);
            this.pnlDropTimeWindowSelection.Controls.Add(this.txtDropTimeWindow);
            this.pnlDropTimeWindowSelection.Controls.Add(this.labDropTimeWindowBar);
            this.pnlDropTimeWindowSelection.Location = new System.Drawing.Point(28, 203);
            this.pnlDropTimeWindowSelection.Name = "pnlDropTimeWindowSelection";
            this.pnlDropTimeWindowSelection.Size = new System.Drawing.Size(200, 41);
            this.pnlDropTimeWindowSelection.TabIndex = 14;
            // 
            // labMaxDropTimeWindow
            // 
            this.labMaxDropTimeWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMaxDropTimeWindow.AutoSize = true;
            this.labMaxDropTimeWindow.BackColor = System.Drawing.Color.Black;
            this.labMaxDropTimeWindow.Font = new System.Drawing.Font("Arcade Normal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaxDropTimeWindow.ForeColor = System.Drawing.Color.White;
            this.labMaxDropTimeWindow.Location = new System.Drawing.Point(174, 6);
            this.labMaxDropTimeWindow.Name = "labMaxDropTimeWindow";
            this.labMaxDropTimeWindow.Size = new System.Drawing.Size(16, 10);
            this.labMaxDropTimeWindow.TabIndex = 12;
            this.labMaxDropTimeWindow.Text = "3";
            // 
            // labMinDropTimeWindow
            // 
            this.labMinDropTimeWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMinDropTimeWindow.AutoSize = true;
            this.labMinDropTimeWindow.BackColor = System.Drawing.Color.Black;
            this.labMinDropTimeWindow.Font = new System.Drawing.Font("Arcade Normal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMinDropTimeWindow.ForeColor = System.Drawing.Color.White;
            this.labMinDropTimeWindow.Location = new System.Drawing.Point(1, 5);
            this.labMinDropTimeWindow.Name = "labMinDropTimeWindow";
            this.labMinDropTimeWindow.Size = new System.Drawing.Size(16, 10);
            this.labMinDropTimeWindow.TabIndex = 2;
            this.labMinDropTimeWindow.Text = "0";
            // 
            // btnDropTimeWindowSlider
            // 
            this.btnDropTimeWindowSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDropTimeWindowSlider.BackColor = System.Drawing.Color.White;
            this.btnDropTimeWindowSlider.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDropTimeWindowSlider.FlatAppearance.BorderSize = 3;
            this.btnDropTimeWindowSlider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDropTimeWindowSlider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDropTimeWindowSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropTimeWindowSlider.Location = new System.Drawing.Point(5, 21);
            this.btnDropTimeWindowSlider.Name = "btnDropTimeWindowSlider";
            this.btnDropTimeWindowSlider.Size = new System.Drawing.Size(12, 12);
            this.btnDropTimeWindowSlider.TabIndex = 2;
            this.btnDropTimeWindowSlider.UseVisualStyleBackColor = false;
            this.btnDropTimeWindowSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDropTimeWindowSlider_MouseDown);
            this.btnDropTimeWindowSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDropTimeWindowSlider_MouseUp);
            // 
            // txtDropTimeWindow
            // 
            this.txtDropTimeWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDropTimeWindow.BackColor = System.Drawing.Color.Black;
            this.txtDropTimeWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDropTimeWindow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDropTimeWindow.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDropTimeWindow.ForeColor = System.Drawing.Color.White;
            this.txtDropTimeWindow.Location = new System.Drawing.Point(61, 5);
            this.txtDropTimeWindow.MaxLength = 4;
            this.txtDropTimeWindow.Name = "txtDropTimeWindow";
            this.txtDropTimeWindow.Size = new System.Drawing.Size(79, 17);
            this.txtDropTimeWindow.TabIndex = 1;
            this.txtDropTimeWindow.Text = "0";
            this.txtDropTimeWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDropTimeWindow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatableTextBox_KeyPress);
            this.txtDropTimeWindow.Leave += new System.EventHandler(this.txtDropTimeWindow_Leave);
            // 
            // labDropTimeWindowBar
            // 
            this.labDropTimeWindowBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDropTimeWindowBar.BackColor = System.Drawing.Color.White;
            this.labDropTimeWindowBar.Location = new System.Drawing.Point(6, 25);
            this.labDropTimeWindowBar.Name = "labDropTimeWindowBar";
            this.labDropTimeWindowBar.Size = new System.Drawing.Size(178, 3);
            this.labDropTimeWindowBar.TabIndex = 0;
            // 
            // pnlFreefallDelaySelection
            // 
            this.pnlFreefallDelaySelection.BackColor = System.Drawing.Color.Black;
            this.pnlFreefallDelaySelection.Controls.Add(this.labFreefallMaxDelay);
            this.pnlFreefallDelaySelection.Controls.Add(this.labFreefallMinDelay);
            this.pnlFreefallDelaySelection.Controls.Add(this.btnFreefallDelaySlider);
            this.pnlFreefallDelaySelection.Controls.Add(this.txtFreefallDelay);
            this.pnlFreefallDelaySelection.Controls.Add(this.labFreefallDelayBar);
            this.pnlFreefallDelaySelection.Location = new System.Drawing.Point(28, 126);
            this.pnlFreefallDelaySelection.Name = "pnlFreefallDelaySelection";
            this.pnlFreefallDelaySelection.Size = new System.Drawing.Size(200, 41);
            this.pnlFreefallDelaySelection.TabIndex = 13;
            // 
            // labFreefallMaxDelay
            // 
            this.labFreefallMaxDelay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labFreefallMaxDelay.AutoSize = true;
            this.labFreefallMaxDelay.BackColor = System.Drawing.Color.Black;
            this.labFreefallMaxDelay.Font = new System.Drawing.Font("Arcade Normal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFreefallMaxDelay.ForeColor = System.Drawing.Color.White;
            this.labFreefallMaxDelay.Location = new System.Drawing.Point(174, 6);
            this.labFreefallMaxDelay.Name = "labFreefallMaxDelay";
            this.labFreefallMaxDelay.Size = new System.Drawing.Size(16, 10);
            this.labFreefallMaxDelay.TabIndex = 12;
            this.labFreefallMaxDelay.Text = "3";
            // 
            // labFreefallMinDelay
            // 
            this.labFreefallMinDelay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labFreefallMinDelay.AutoSize = true;
            this.labFreefallMinDelay.BackColor = System.Drawing.Color.Black;
            this.labFreefallMinDelay.Font = new System.Drawing.Font("Arcade Normal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFreefallMinDelay.ForeColor = System.Drawing.Color.White;
            this.labFreefallMinDelay.Location = new System.Drawing.Point(1, 5);
            this.labFreefallMinDelay.Name = "labFreefallMinDelay";
            this.labFreefallMinDelay.Size = new System.Drawing.Size(38, 10);
            this.labFreefallMinDelay.TabIndex = 2;
            this.labFreefallMinDelay.Text = "0.5";
            // 
            // btnFreefallDelaySlider
            // 
            this.btnFreefallDelaySlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFreefallDelaySlider.BackColor = System.Drawing.Color.White;
            this.btnFreefallDelaySlider.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFreefallDelaySlider.FlatAppearance.BorderSize = 3;
            this.btnFreefallDelaySlider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFreefallDelaySlider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFreefallDelaySlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreefallDelaySlider.Location = new System.Drawing.Point(5, 21);
            this.btnFreefallDelaySlider.Name = "btnFreefallDelaySlider";
            this.btnFreefallDelaySlider.Size = new System.Drawing.Size(12, 12);
            this.btnFreefallDelaySlider.TabIndex = 2;
            this.btnFreefallDelaySlider.UseVisualStyleBackColor = false;
            this.btnFreefallDelaySlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFreefallDelaySlider_MouseDown);
            this.btnFreefallDelaySlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFreefallDelaySlider_MouseUp);
            // 
            // txtFreefallDelay
            // 
            this.txtFreefallDelay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFreefallDelay.BackColor = System.Drawing.Color.Black;
            this.txtFreefallDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFreefallDelay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFreefallDelay.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreefallDelay.ForeColor = System.Drawing.Color.White;
            this.txtFreefallDelay.Location = new System.Drawing.Point(61, 5);
            this.txtFreefallDelay.MaxLength = 4;
            this.txtFreefallDelay.Name = "txtFreefallDelay";
            this.txtFreefallDelay.Size = new System.Drawing.Size(79, 17);
            this.txtFreefallDelay.TabIndex = 1;
            this.txtFreefallDelay.Text = "0.5";
            this.txtFreefallDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFreefallDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatableTextBox_KeyPress);
            this.txtFreefallDelay.Leave += new System.EventHandler(this.txtFreefallDelay_Leave);
            // 
            // labFreefallDelayBar
            // 
            this.labFreefallDelayBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labFreefallDelayBar.BackColor = System.Drawing.Color.White;
            this.labFreefallDelayBar.Location = new System.Drawing.Point(6, 25);
            this.labFreefallDelayBar.Name = "labFreefallDelayBar";
            this.labFreefallDelayBar.Size = new System.Drawing.Size(178, 3);
            this.labFreefallDelayBar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 11);
            this.label4.TabIndex = 16;
            this.label4.Text = "Drop Time Window";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 11);
            this.label1.TabIndex = 15;
            this.label1.Text = "Freefall Delay";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arcade Normal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(144, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Arcade Normal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(12, 259);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlWidthSelection
            // 
            this.pnlWidthSelection.BackColor = System.Drawing.Color.Black;
            this.pnlWidthSelection.Controls.Add(this.widthMaxValue);
            this.pnlWidthSelection.Controls.Add(this.widthMinValue);
            this.pnlWidthSelection.Controls.Add(this.btnWidthSlider);
            this.pnlWidthSelection.Controls.Add(this.txtWidthValue);
            this.pnlWidthSelection.Controls.Add(this.labWidthBar);
            this.pnlWidthSelection.Location = new System.Drawing.Point(52, 3);
            this.pnlWidthSelection.Name = "pnlWidthSelection";
            this.pnlWidthSelection.Size = new System.Drawing.Size(200, 41);
            this.pnlWidthSelection.TabIndex = 13;
            // 
            // widthMaxValue
            // 
            this.widthMaxValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.widthMaxValue.AutoSize = true;
            this.widthMaxValue.BackColor = System.Drawing.Color.Black;
            this.widthMaxValue.Font = new System.Drawing.Font("Arcade Normal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthMaxValue.ForeColor = System.Drawing.Color.White;
            this.widthMaxValue.Location = new System.Drawing.Point(170, 6);
            this.widthMaxValue.Name = "widthMaxValue";
            this.widthMaxValue.Size = new System.Drawing.Size(27, 10);
            this.widthMaxValue.TabIndex = 12;
            this.widthMaxValue.Text = "32";
            // 
            // widthMinValue
            // 
            this.widthMinValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.widthMinValue.AutoSize = true;
            this.widthMinValue.BackColor = System.Drawing.Color.Black;
            this.widthMinValue.Font = new System.Drawing.Font("Arcade Normal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthMinValue.ForeColor = System.Drawing.Color.White;
            this.widthMinValue.Location = new System.Drawing.Point(5, 5);
            this.widthMinValue.Name = "widthMinValue";
            this.widthMinValue.Size = new System.Drawing.Size(16, 10);
            this.widthMinValue.TabIndex = 2;
            this.widthMinValue.Text = "8";
            // 
            // btnWidthSlider
            // 
            this.btnWidthSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWidthSlider.BackColor = System.Drawing.Color.White;
            this.btnWidthSlider.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnWidthSlider.FlatAppearance.BorderSize = 3;
            this.btnWidthSlider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnWidthSlider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnWidthSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWidthSlider.Location = new System.Drawing.Point(5, 21);
            this.btnWidthSlider.Name = "btnWidthSlider";
            this.btnWidthSlider.Size = new System.Drawing.Size(12, 12);
            this.btnWidthSlider.TabIndex = 2;
            this.btnWidthSlider.UseVisualStyleBackColor = false;
            this.btnWidthSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWidthSlider_MouseDown);
            this.btnWidthSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWidthSlider_MouseUp);
            // 
            // txtWidthValue
            // 
            this.txtWidthValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWidthValue.BackColor = System.Drawing.Color.Black;
            this.txtWidthValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWidthValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtWidthValue.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidthValue.ForeColor = System.Drawing.Color.White;
            this.txtWidthValue.Location = new System.Drawing.Point(61, 5);
            this.txtWidthValue.MaxLength = 2;
            this.txtWidthValue.Name = "txtWidthValue";
            this.txtWidthValue.Size = new System.Drawing.Size(79, 17);
            this.txtWidthValue.TabIndex = 1;
            this.txtWidthValue.Tag = "2";
            this.txtWidthValue.Text = "8";
            this.txtWidthValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidthValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtWidthValue.Leave += new System.EventHandler(this.txtWidthValue_Leave);
            // 
            // labWidthBar
            // 
            this.labWidthBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labWidthBar.BackColor = System.Drawing.Color.White;
            this.labWidthBar.Location = new System.Drawing.Point(6, 25);
            this.labWidthBar.Name = "labWidthBar";
            this.labWidthBar.Size = new System.Drawing.Size(178, 3);
            this.labWidthBar.TabIndex = 0;
            // 
            // pnlHeightSelection
            // 
            this.pnlHeightSelection.BackColor = System.Drawing.Color.Black;
            this.pnlHeightSelection.Controls.Add(this.heightMaxValue);
            this.pnlHeightSelection.Controls.Add(this.heightMinValue);
            this.pnlHeightSelection.Controls.Add(this.btnHeightSlider);
            this.pnlHeightSelection.Controls.Add(this.txtHeightValue);
            this.pnlHeightSelection.Controls.Add(this.labHeightBar);
            this.pnlHeightSelection.Location = new System.Drawing.Point(52, 50);
            this.pnlHeightSelection.Name = "pnlHeightSelection";
            this.pnlHeightSelection.Size = new System.Drawing.Size(200, 41);
            this.pnlHeightSelection.TabIndex = 2;
            // 
            // heightMaxValue
            // 
            this.heightMaxValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightMaxValue.AutoSize = true;
            this.heightMaxValue.BackColor = System.Drawing.Color.Black;
            this.heightMaxValue.Font = new System.Drawing.Font("Arcade Normal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightMaxValue.ForeColor = System.Drawing.Color.White;
            this.heightMaxValue.Location = new System.Drawing.Point(170, 6);
            this.heightMaxValue.Name = "heightMaxValue";
            this.heightMaxValue.Size = new System.Drawing.Size(27, 10);
            this.heightMaxValue.TabIndex = 12;
            this.heightMaxValue.Text = "32";
            // 
            // heightMinValue
            // 
            this.heightMinValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightMinValue.AutoSize = true;
            this.heightMinValue.BackColor = System.Drawing.Color.Black;
            this.heightMinValue.Font = new System.Drawing.Font("Arcade Normal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightMinValue.ForeColor = System.Drawing.Color.White;
            this.heightMinValue.Location = new System.Drawing.Point(5, 5);
            this.heightMinValue.Name = "heightMinValue";
            this.heightMinValue.Size = new System.Drawing.Size(27, 10);
            this.heightMinValue.TabIndex = 2;
            this.heightMinValue.Text = "20";
            // 
            // btnHeightSlider
            // 
            this.btnHeightSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHeightSlider.BackColor = System.Drawing.Color.White;
            this.btnHeightSlider.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHeightSlider.FlatAppearance.BorderSize = 3;
            this.btnHeightSlider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHeightSlider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHeightSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeightSlider.Location = new System.Drawing.Point(5, 21);
            this.btnHeightSlider.Name = "btnHeightSlider";
            this.btnHeightSlider.Size = new System.Drawing.Size(12, 12);
            this.btnHeightSlider.TabIndex = 2;
            this.btnHeightSlider.UseVisualStyleBackColor = false;
            this.btnHeightSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeightSlider_MouseDown);
            this.btnHeightSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeightSlider_MouseUp);
            // 
            // txtHeightValue
            // 
            this.txtHeightValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeightValue.BackColor = System.Drawing.Color.Black;
            this.txtHeightValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeightValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtHeightValue.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightValue.ForeColor = System.Drawing.Color.White;
            this.txtHeightValue.Location = new System.Drawing.Point(61, 5);
            this.txtHeightValue.MaxLength = 2;
            this.txtHeightValue.Name = "txtHeightValue";
            this.txtHeightValue.Size = new System.Drawing.Size(79, 17);
            this.txtHeightValue.TabIndex = 1;
            this.txtHeightValue.Text = "20";
            this.txtHeightValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeightValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtHeightValue.Leave += new System.EventHandler(this.txtHeightValue_Leave);
            // 
            // labHeightBar
            // 
            this.labHeightBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labHeightBar.BackColor = System.Drawing.Color.White;
            this.labHeightBar.Location = new System.Drawing.Point(6, 25);
            this.labHeightBar.Name = "labHeightBar";
            this.labHeightBar.Size = new System.Drawing.Size(178, 3);
            this.labHeightBar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arcade Normal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "H:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arcade Normal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "W:";
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 4;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arcade Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(139, 204);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 55);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOptions.FlatAppearance.BorderSize = 4;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Arcade Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(121, 281);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(158, 55);
            this.btnOptions.TabIndex = 10;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 4;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arcade Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(151, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 55);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlGameModeSelection
            // 
            this.pnlGameModeSelection.BackColor = System.Drawing.Color.White;
            this.pnlGameModeSelection.Controls.Add(this.panel1);
            this.pnlGameModeSelection.Location = new System.Drawing.Point(105, 47);
            this.pnlGameModeSelection.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGameModeSelection.Name = "pnlGameModeSelection";
            this.pnlGameModeSelection.Padding = new System.Windows.Forms.Padding(3);
            this.pnlGameModeSelection.Size = new System.Drawing.Size(196, 110);
            this.pnlGameModeSelection.TabIndex = 12;
            this.pnlGameModeSelection.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnClassic);
            this.panel1.Controls.Add(this.btnCustom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 104);
            this.panel1.TabIndex = 2;
            // 
            // btnClassic
            // 
            this.btnClassic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClassic.FlatAppearance.BorderSize = 2;
            this.btnClassic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClassic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClassic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassic.Font = new System.Drawing.Font("Arcade Normal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassic.ForeColor = System.Drawing.Color.White;
            this.btnClassic.Location = new System.Drawing.Point(14, 12);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(163, 34);
            this.btnClassic.TabIndex = 0;
            this.btnClassic.Text = "Classic";
            this.btnClassic.UseVisualStyleBackColor = true;
            this.btnClassic.Click += new System.EventHandler(this.btnClassic_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustom.FlatAppearance.BorderSize = 2;
            this.btnCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.Font = new System.Drawing.Font("Arcade Normal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.ForeColor = System.Drawing.Color.White;
            this.btnCustom.Location = new System.Drawing.Point(14, 55);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(163, 38);
            this.btnCustom.TabIndex = 1;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(73, 35);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(258, 141);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 13;
            this.pctLogo.TabStop = false;
            // 
            // pnlCustomGameModeOptions
            // 
            this.pnlCustomGameModeOptions.BackColor = System.Drawing.Color.White;
            this.pnlCustomGameModeOptions.Controls.Add(this.panel69);
            this.pnlCustomGameModeOptions.Location = new System.Drawing.Point(73, 47);
            this.pnlCustomGameModeOptions.Name = "pnlCustomGameModeOptions";
            this.pnlCustomGameModeOptions.Padding = new System.Windows.Forms.Padding(3);
            this.pnlCustomGameModeOptions.Size = new System.Drawing.Size(260, 302);
            this.pnlCustomGameModeOptions.TabIndex = 14;
            this.pnlCustomGameModeOptions.Visible = false;
            // 
            // TetrisGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(414, 419);
            this.Controls.Add(this.pnlCustomGameModeOptions);
            this.Controls.Add(this.pnlGameModeSelection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pctLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TetrisGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TetrisGame_Paint);
            this.panel69.ResumeLayout(false);
            this.panel69.PerformLayout();
            this.pnlDropTimeWindowSelection.ResumeLayout(false);
            this.pnlDropTimeWindowSelection.PerformLayout();
            this.pnlFreefallDelaySelection.ResumeLayout(false);
            this.pnlFreefallDelaySelection.PerformLayout();
            this.pnlWidthSelection.ResumeLayout(false);
            this.pnlWidthSelection.PerformLayout();
            this.pnlHeightSelection.ResumeLayout(false);
            this.pnlHeightSelection.PerformLayout();
            this.pnlGameModeSelection.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlCustomGameModeOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel69;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHeightSelection;
        private System.Windows.Forms.TextBox txtHeightValue;
        private System.Windows.Forms.Label labHeightBar;
        private System.Windows.Forms.Label heightMaxValue;
        private System.Windows.Forms.Label heightMinValue;
        private System.Windows.Forms.Button btnHeightSlider;
        private System.Windows.Forms.Panel pnlWidthSelection;
        private System.Windows.Forms.Label widthMaxValue;
        private System.Windows.Forms.Label widthMinValue;
        private System.Windows.Forms.Button btnWidthSlider;
        private System.Windows.Forms.TextBox txtWidthValue;
        private System.Windows.Forms.Label labWidthBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlGameModeSelection;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCustomGameModeOptions;
        private System.Windows.Forms.Panel pnlFreefallDelaySelection;
        private System.Windows.Forms.Label labFreefallMaxDelay;
        private System.Windows.Forms.Label labFreefallMinDelay;
        private System.Windows.Forms.Button btnFreefallDelaySlider;
        private System.Windows.Forms.TextBox txtFreefallDelay;
        private System.Windows.Forms.Label labFreefallDelayBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDropTimeWindowSelection;
        private System.Windows.Forms.Label labMaxDropTimeWindow;
        private System.Windows.Forms.Label labMinDropTimeWindow;
        private System.Windows.Forms.Button btnDropTimeWindowSlider;
        private System.Windows.Forms.TextBox txtDropTimeWindow;
        private System.Windows.Forms.Label labDropTimeWindowBar;
    }
}
