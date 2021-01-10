namespace GomokuGame
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CurrentTurnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(11, 68);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(300, 39);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "THE WINNER IS:";
            // 
            // CurrentTurnBtn
            // 
            this.CurrentTurnBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.CurrentTurnBtn.BackgroundImage = global::GomokuGame.Properties.Resources.GomokuBlack;
            this.CurrentTurnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurrentTurnBtn.Enabled = false;
            this.CurrentTurnBtn.Location = new System.Drawing.Point(317, 12);
            this.CurrentTurnBtn.Name = "CurrentTurnBtn";
            this.CurrentTurnBtn.Size = new System.Drawing.Size(149, 148);
            this.CurrentTurnBtn.TabIndex = 3;
            this.CurrentTurnBtn.UseVisualStyleBackColor = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GomokuGame.Properties.Resources.tlo;
            this.ClientSize = new System.Drawing.Size(478, 172);
            this.Controls.Add(this.CurrentTurnBtn);
            this.Controls.Add(this.ResultLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CurrentTurnBtn;
    }
}