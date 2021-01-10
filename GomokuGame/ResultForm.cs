using GomokuGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomokuGame
{
    public partial class ResultForm : Form
    {
        private ShapeType Resullt { get; set; }
        public ResultForm(ShapeType result)
        {
            InitializeComponent();
            LoadForm(result);
        }

        private void LoadForm(ShapeType result)
        {
            if (result == ShapeType.Black)
                CurrentTurnBtn.BackgroundImage = Resources.GomokuBlack;
            else if (result == ShapeType.White)
                CurrentTurnBtn.BackgroundImage = Resources.GomokuWhite;
            else
            {
                CurrentTurnBtn.Visible = false;
                ResultLabel.Text = "No contest! Draw!";
                ResultLabel.Location = new Point(this.Width/2-ResultLabel.Width/2-10, this.Height/2-ResultLabel.Height);
            }
        }
    }
}
