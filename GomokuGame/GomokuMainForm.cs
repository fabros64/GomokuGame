using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GomokuGame.Properties;

namespace GomokuGame
{
    public partial class GomokuMainForm : Form
    {

        public static int minHeight = 400;
        public int FormWidth = Screen.PrimaryScreen.Bounds.Width - 210;
        public int FormHeight = Screen.PrimaryScreen.Bounds.Height - 265;
        FormWindowState LastWindowState = FormWindowState.Minimized;
        public static int countResizeToNormal = 0;

        public GomokuMainForm()
        {
            InitializeComponent();
            this.Width = FormWidth;
            this.Height = FormHeight;
            
        }


        private void GomokuMainForm_Load(object sender, EventArgs e)
        {

            MenuForm mf = new MenuForm(this);
            mf.ShowDialog(this);
            this.Visible = false;
            if (mf.IsCancel || !mf.IsStart)
                this.Dispose();
            else
            {
                minHeight = Screen.PrimaryScreen.Bounds.Height - 265 - (760 - 400);
                PanelLoad(mf.SelectedShape, mf.SelectedBoard);
                BoardGenerator.CleanBoard();
                
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BoardGenerator.ResetBoard();
            chooseStartFigureGB.Enabled = true;

            if (StartWhiteRB.Checked || StartBlackRB.Checked)
                StartBtn.Enabled = true;
        }

        private void StartWhiteRB_CheckedChanged(object sender, EventArgs e)
        {
            StartBtn.Enabled = true;
        }

        private void StartBlackRB_CheckedChanged(object sender, EventArgs e)
        {
            StartBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (StartBlackRB.Checked)
            {
                CurrentTurnBtn.BackgroundImage = Resources.GomokuBlack;
                BoardGenerator.CurrentTurn = ShapeType.Black;
            }
            else
            {
                CurrentTurnBtn.BackgroundImage = Resources.GomokuWhite;
                BoardGenerator.CurrentTurn = ShapeType.White;
            }

            StartBtn.Enabled = false;
            chooseStartFigureGB.Enabled = false;
            BoardGenerator.ButtonsEnabling(true);
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm(this);
            mf.ShowDialog(this);
            if (mf.IsStart)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    BoardGenerator.Board = mf.SelectedBoard;
                    CurrentTurnBtn.BackgroundImage =
                    mf.SelectedShape == ShapeType.Black ? Resources.GomokuBlack : Resources.GomokuWhite;
                    if (mf.SelectedShape == ShapeType.Black)
                        StartBlackRB.Checked = true;
                    else StartWhiteRB.Checked = true;

                    BoardGenerator.CurrentTurn = mf.SelectedShape;
                    CopiedInitialPanelCreate();
                    
                    BoardGenerator.NewBoardInMaximizeMode(BoardPanel, MenuPanel);
                }
                else
                {
                    CopiedInitialPanelCreate();
                    
                    PanelLoad(mf.SelectedShape, mf.SelectedBoard);
                }
            }
        }

        private void PanelLoad(ShapeType selectedShape, Board selectedBoard)
        {
            CurrentTurnBtn.BackgroundImage =
                    selectedShape == ShapeType.Black ? Resources.GomokuBlack : Resources.GomokuWhite;
            if (selectedShape == ShapeType.Black)
                StartBlackRB.Checked = true;
            else StartWhiteRB.Checked = true;

            BoardGenerator.CurrentTurn = selectedShape;
            this.Width = Screen.PrimaryScreen.Bounds.Width - 210;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 265;
            BoardPanel.Width = this.Width - MenuPanel.Width;
            BoardPanel.Height = this.Height;
            BoardGenerator.DrawBoard(selectedBoard, BoardPanel, CurrentTurnBtn);
            this.Width = BoardGenerator.newWidth + MenuPanel.Width;
            this.Height = BoardGenerator.newHeight < minHeight ? minHeight : BoardGenerator.newHeight;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
            StartBtn.Enabled = false;
            chooseStartFigureGB.Enabled = false;
            GomokuGameManager.CountOfFiguresPlaced = 0;
        }

        private void GomokuMainForm_Resize(object sender, EventArgs e)
        {
            // When window state changes
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {
                    CopiedInitialPanelCreate();
                    BoardGenerator.UpdateMaximizeBoard(BoardPanel, MenuPanel);
                }
                if (WindowState == FormWindowState.Normal)
                {
                    this.Width = Screen.PrimaryScreen.Bounds.Width - 210;
                    this.Height = Screen.PrimaryScreen.Bounds.Height - 265;
                    BoardPanel.Width = this.Width - MenuPanel.Width;
                    BoardPanel.Height = this.Height;

                    CopiedInitialPanelCreate();
                    BoardGenerator.UpdateTurnBackToNormalBoard(BoardPanel, MenuPanel);
                    this.Width = BoardGenerator.newWidth + MenuPanel.Width;
                    this.Height = BoardGenerator.newHeight < minHeight ? minHeight : BoardGenerator.newHeight;


                    this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
                }
            }
        }

        public void CopiedInitialPanelCreate()
        {
            Panel CopiedInitialPanel = new Panel();
            CopiedInitialPanel = BoardPanel.Clone();

            CopiedInitialPanel.BorderStyle = BoardPanel.BorderStyle;
            CopiedInitialPanel.BackColor = BoardPanel.BackColor;
            CopiedInitialPanel.BackgroundImage = BoardPanel.BackgroundImage;
            CopiedInitialPanel.Size = BoardPanel.Size;

            CopiedInitialPanel.Region = BoardPanel.Region;
            CopiedInitialPanel.Anchor = BoardPanel.Anchor;
            CopiedInitialPanel.AutoSize = BoardPanel.AutoSize;
            CopiedInitialPanel.Location = BoardPanel.Location;
            CopiedInitialPanel.Bounds = BoardPanel.Bounds;
            CopiedInitialPanel.Width = BoardPanel.Width;
            CopiedInitialPanel.Height = BoardPanel.Height;
            CopiedInitialPanel.Parent = BoardPanel.Parent;
            CopiedInitialPanel.AutoSizeMode = BoardPanel.AutoSizeMode;            
            CopiedInitialPanel.Cursor = BoardPanel.Cursor;
            
            CopiedInitialPanel.Visible = true;
            CopiedInitialPanel.Enabled = true;
            CopiedInitialPanel.Dock = DockStyle.None;
            CopiedInitialPanel.ClientSize = BoardPanel.ClientSize;
            
            BoardPanel.Dispose();
            BoardPanel = CopiedInitialPanel;
        }
    }
}
