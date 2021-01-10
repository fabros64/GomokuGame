namespace GomokuGame
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthTB = new System.Windows.Forms.TextBox();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthBar = new System.Windows.Forms.TrackBar();
            this.HeightBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.BlackFigureBtn = new System.Windows.Forms.Button();
            this.WhiteFigureBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.WidthTB);
            this.groupBox1.Controls.Add(this.WidthLbl);
            this.groupBox1.Controls.Add(this.HeightLbl);
            this.groupBox1.Controls.Add(this.HeightTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WidthBar);
            this.groupBox1.Controls.Add(this.HeightBar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose board size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "x";
            // 
            // WidthTB
            // 
            this.WidthTB.Location = new System.Drawing.Point(199, 119);
            this.WidthTB.Name = "WidthTB";
            this.WidthTB.ReadOnly = true;
            this.WidthTB.Size = new System.Drawing.Size(47, 22);
            this.WidthTB.TabIndex = 8;
            this.WidthTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLbl.Location = new System.Drawing.Point(311, 74);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(19, 20);
            this.WidthLbl.TabIndex = 7;
            this.WidthLbl.Text = "5";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLbl.Location = new System.Drawing.Point(311, 23);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(19, 20);
            this.HeightLbl.TabIndex = 6;
            this.HeightLbl.Text = "5";
            // 
            // HeightTB
            // 
            this.HeightTB.Location = new System.Drawing.Point(123, 119);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.ReadOnly = true;
            this.HeightTB.Size = new System.Drawing.Size(47, 22);
            this.HeightTB.TabIndex = 5;
            this.HeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height";
            // 
            // WidthBar
            // 
            this.WidthBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WidthBar.LargeChange = 1;
            this.WidthBar.Location = new System.Drawing.Point(74, 70);
            this.WidthBar.Maximum = 30;
            this.WidthBar.Minimum = 5;
            this.WidthBar.Name = "WidthBar";
            this.WidthBar.Size = new System.Drawing.Size(217, 45);
            this.WidthBar.TabIndex = 1;
            this.WidthBar.Value = 5;
            this.WidthBar.ValueChanged += new System.EventHandler(this.WidthBar_ValueChanged);
            // 
            // HeightBar
            // 
            this.HeightBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeightBar.LargeChange = 1;
            this.HeightBar.Location = new System.Drawing.Point(74, 19);
            this.HeightBar.Maximum = 30;
            this.HeightBar.Minimum = 5;
            this.HeightBar.Name = "HeightBar";
            this.HeightBar.Size = new System.Drawing.Size(217, 45);
            this.HeightBar.TabIndex = 0;
            this.HeightBar.Value = 5;
            this.HeightBar.ValueChanged += new System.EventHandler(this.HeightBar_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BlackFigureBtn);
            this.groupBox2.Controls.Add(this.WhiteFigureBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the starting figure:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(12, 330);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(122, 39);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(239, 330);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(122, 39);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrorLbl.Location = new System.Drawing.Point(112, 304);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(146, 13);
            this.ErrorLbl.TabIndex = 4;
            this.ErrorLbl.Text = "Please choose starting figure!";
            this.ErrorLbl.Visible = false;
            // 
            // BlackFigureBtn
            // 
            this.BlackFigureBtn.BackColor = System.Drawing.SystemColors.Control;
            this.BlackFigureBtn.BackgroundImage = global::GomokuGame.Properties.Resources.GomokuBlack;
            this.BlackFigureBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlackFigureBtn.Location = new System.Drawing.Point(201, 31);
            this.BlackFigureBtn.Name = "BlackFigureBtn";
            this.BlackFigureBtn.Size = new System.Drawing.Size(90, 73);
            this.BlackFigureBtn.TabIndex = 0;
            this.BlackFigureBtn.UseVisualStyleBackColor = false;
            this.BlackFigureBtn.Click += new System.EventHandler(this.BlackFigureBtn_Click);
            // 
            // WhiteFigureBtn
            // 
            this.WhiteFigureBtn.BackColor = System.Drawing.SystemColors.Control;
            this.WhiteFigureBtn.BackgroundImage = global::GomokuGame.Properties.Resources.GomokuWhite;
            this.WhiteFigureBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WhiteFigureBtn.Location = new System.Drawing.Point(62, 31);
            this.WhiteFigureBtn.Name = "WhiteFigureBtn";
            this.WhiteFigureBtn.Size = new System.Drawing.Size(90, 73);
            this.WhiteFigureBtn.TabIndex = 0;
            this.WhiteFigureBtn.UseVisualStyleBackColor = false;
            this.WhiteFigureBtn.Click += new System.EventHandler(this.WhiteFigureBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(373, 389);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Start";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.TextBox HeightTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar WidthBar;
        private System.Windows.Forms.TrackBar HeightBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WidthTB;
        private System.Windows.Forms.Button WhiteFigureBtn;
        private System.Windows.Forms.Button BlackFigureBtn;
        private System.Windows.Forms.Label ErrorLbl;
    }
}