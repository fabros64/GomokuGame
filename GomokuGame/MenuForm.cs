using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomokuGame
{
    public partial class MenuForm : Form
    {
        public ShapeType SelectedShape { get; set; } = ShapeType.Blank;
        public Board SelectedBoard { get; set; }
        public bool IsCancel = false;
        public bool IsStart = false;
        private Form MainGomokuForm;

        public static int CountOfLoadForm = 0;

        public MenuForm(Form MainGomokuForm)
        {
            InitializeComponent();
            this.MainGomokuForm = MainGomokuForm;
            HeightTB.Text = HeightBar.Value.ToString();
            WidthTB.Text = WidthBar.Value.ToString();

            CountOfLoadForm++;
        }

        private void WhiteFigureBtn_Click(object sender, EventArgs e)
        {
            WhiteFigureBtn.BackColor = Color.LightBlue;
            SelectedShape = ShapeType.White;
            BlackFigureBtn.BackColor = Button.DefaultBackColor;
        }

        private void BlackFigureBtn_Click(object sender, EventArgs e)
        {
            BlackFigureBtn.BackColor = Color.LightBlue;
            SelectedShape = ShapeType.Black;
            WhiteFigureBtn.BackColor = Button.DefaultBackColor;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {            
            this.Dispose();
            IsCancel = true;
            IsStart = false;
        }

        private void HeightBar_ValueChanged(object sender, EventArgs e)
        {
            HeightLbl.Text = HeightBar.Value.ToString();
            HeightTB.Text = HeightBar.Value.ToString();
        }

        private void WidthBar_ValueChanged(object sender, EventArgs e)
        {
            WidthLbl.Text = WidthBar.Value.ToString();
            WidthTB.Text = WidthBar.Value.ToString();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((IsCancel || !IsStart) && CountOfLoadForm == 1)
                MainGomokuForm.Dispose();                      
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (SelectedShape != ShapeType.Blank)
            {
                SelectedBoard = new Board(HeightBar.Value, WidthBar.Value);
                IsCancel = false;
                IsStart = true;
                this.Dispose();
            }
            else
            {
                ErrorLbl.Visible = true;
            }
        }
    }
}
