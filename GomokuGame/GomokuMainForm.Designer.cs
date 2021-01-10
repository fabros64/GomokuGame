namespace GomokuGame
{
    partial class GomokuMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GomokuMainForm));
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.chooseStartFigureGB = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StartBlackRB = new System.Windows.Forms.RadioButton();
            this.StartWhiteRB = new System.Windows.Forms.RadioButton();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentTurnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.chooseStartFigureGB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoardPanel
            // 
            this.BoardPanel.AutoSize = true;
            this.BoardPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.BoardPanel.BackgroundImage = global::GomokuGame.Properties.Resources.tlo;
            this.BoardPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardPanel.Location = new System.Drawing.Point(0, 0);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(821, 722);
            this.BoardPanel.TabIndex = 5;
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoSize = true;
            this.MenuPanel.BackgroundImage = global::GomokuGame.Properties.Resources.tlo;
            this.MenuPanel.Controls.Add(this.StartBtn);
            this.MenuPanel.Controls.Add(this.chooseStartFigureGB);
            this.MenuPanel.Controls.Add(this.ResetBtn);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.MenuBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPanel.Location = new System.Drawing.Point(821, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(233, 722);
            this.MenuPanel.TabIndex = 4;
            // 
            // StartBtn
            // 
            this.StartBtn.AutoSize = true;
            this.StartBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartBtn.Enabled = false;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(0, 545);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.StartBtn.Size = new System.Drawing.Size(233, 60);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // chooseStartFigureGB
            // 
            this.chooseStartFigureGB.BackColor = System.Drawing.SystemColors.Control;
            this.chooseStartFigureGB.Controls.Add(this.button2);
            this.chooseStartFigureGB.Controls.Add(this.button1);
            this.chooseStartFigureGB.Controls.Add(this.StartBlackRB);
            this.chooseStartFigureGB.Controls.Add(this.StartWhiteRB);
            this.chooseStartFigureGB.Enabled = false;
            this.chooseStartFigureGB.Location = new System.Drawing.Point(0, 95);
            this.chooseStartFigureGB.Name = "chooseStartFigureGB";
            this.chooseStartFigureGB.Size = new System.Drawing.Size(230, 87);
            this.chooseStartFigureGB.TabIndex = 6;
            this.chooseStartFigureGB.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.BackgroundImage = global::GomokuGame.Properties.Resources.GomokuWhite;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(153, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 20);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.BackgroundImage = global::GomokuGame.Properties.Resources.GomokuBlack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(153, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // StartBlackRB
            // 
            this.StartBlackRB.AutoSize = true;
            this.StartBlackRB.BackColor = System.Drawing.SystemColors.Control;
            this.StartBlackRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBlackRB.Location = new System.Drawing.Point(55, 42);
            this.StartBlackRB.Name = "StartBlackRB";
            this.StartBlackRB.Size = new System.Drawing.Size(106, 20);
            this.StartBlackRB.TabIndex = 1;
            this.StartBlackRB.Text = "starts black";
            this.StartBlackRB.UseVisualStyleBackColor = false;
            this.StartBlackRB.CheckedChanged += new System.EventHandler(this.StartBlackRB_CheckedChanged);
            // 
            // StartWhiteRB
            // 
            this.StartWhiteRB.AutoSize = true;
            this.StartWhiteRB.BackColor = System.Drawing.SystemColors.Control;
            this.StartWhiteRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartWhiteRB.Location = new System.Drawing.Point(55, 19);
            this.StartWhiteRB.Name = "StartWhiteRB";
            this.StartWhiteRB.Size = new System.Drawing.Size(103, 20);
            this.StartWhiteRB.TabIndex = 0;
            this.StartWhiteRB.Text = "starts white";
            this.StartWhiteRB.UseVisualStyleBackColor = false;
            this.StartWhiteRB.CheckedChanged += new System.EventHandler(this.StartWhiteRB_CheckedChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.AutoSize = true;
            this.ResetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(0, 605);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(233, 60);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.CurrentTurnBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 100);
            this.panel1.TabIndex = 4;
            // 
            // CurrentTurnBtn
            // 
            this.CurrentTurnBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.CurrentTurnBtn.BackgroundImage = global::GomokuGame.Properties.Resources.GomokuBlack;
            this.CurrentTurnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurrentTurnBtn.Enabled = false;
            this.CurrentTurnBtn.Location = new System.Drawing.Point(143, 13);
            this.CurrentTurnBtn.Name = "CurrentTurnBtn";
            this.CurrentTurnBtn.Size = new System.Drawing.Size(78, 73);
            this.CurrentTurnBtn.TabIndex = 2;
            this.CurrentTurnBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn of:";
            // 
            // MenuBtn
            // 
            this.MenuBtn.AutoSize = true;
            this.MenuBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(0, 665);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(233, 57);
            this.MenuBtn.TabIndex = 3;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // GomokuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::GomokuGame.Properties.Resources.tlo;
            this.ClientSize = new System.Drawing.Size(1054, 722);
            this.Controls.Add(this.BoardPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GomokuMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gomoku Game";
            this.Load += new System.EventHandler(this.GomokuMainForm_Load);
            this.Resize += new System.EventHandler(this.GomokuMainForm_Resize);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.chooseStartFigureGB.ResumeLayout(false);
            this.chooseStartFigureGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CurrentTurnBtn;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.GroupBox chooseStartFigureGB;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.RadioButton StartBlackRB;
        private System.Windows.Forms.RadioButton StartWhiteRB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

