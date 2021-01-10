using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GomokuGame.Properties;

namespace GomokuGame
{
   public static class BoardGenerator
    {
        public static Board Board { get; set; }
        private static Panel Panel { get; set; }
        private static Button CurrentTurnButton { get; set; }
        public static ShapeType CurrentTurn { get; set; }
        public static int newWidth;
        public static int newHeight;


        public static void DrawBoard(Board board, Panel panel, Button currentButton)
        {
            Board = board;
            Panel = panel;
            CurrentTurnButton = currentButton;
            int StartPositionH = 0;
            int StartPositionW = 0;
            int size;

            int width = panel.Width;
            int height = panel.Height;

            int buttonWidth = width / board.Width;
            int buttonHeight = height / board.Height;

            size = Math.Min(buttonWidth, buttonHeight);

            newWidth = board.Width * (size) + currentButton.Width / 4 ;
            newHeight = board.Height * (size) + currentButton.Width / 3 + 14;

            if (newHeight < GomokuMainForm.minHeight)            
                StartPositionH = (GomokuMainForm.minHeight / 2) - newHeight/2;


            for (int x = 0; x < board.Height; x++)
            {                
                    for(int y = 0; y < board.Width; y++)
                    {
                        Button button = new Button
                        {
                            Location = new Point(y * size + StartPositionW , x * size + StartPositionH),
                            Size = new Size(size, size),
                            BackgroundImageLayout = ImageLayout.Stretch
                        };
                        button.Click += Button_Click;
                        button.Tag = new Cell(x, y);

                    panel.Controls.Add(button);
                    }                
            }          
        }

        private static void Button_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            Cell ButtonCell = button.Tag as Cell;

            if (Board.BoardTab[ButtonCell.X, ButtonCell.Y] == ShapeType.Blank)
            {
                GomokuGameManager.CountOfFiguresPlaced++;
                Board.BoardTab[ButtonCell.X, ButtonCell.Y] = CurrentTurn;
                
                if (CurrentTurn == ShapeType.Black)
                {
                    button.BackgroundImage = GomokuGame.Properties.Resources.GomokuBlack;                    
                    CurrentTurn = ShapeType.White;
                    CurrentTurnButton.BackgroundImage = GomokuGame.Properties.Resources.GomokuWhite;
                }
                else
                {
                    button.BackgroundImage = GomokuGame.Properties.Resources.GomokuWhite;
                    CurrentTurn = ShapeType.Black;
                    CurrentTurnButton.BackgroundImage = GomokuGame.Properties.Resources.GomokuBlack;
                }

                if (GomokuGameManager.CountOfFiguresPlaced >= 9)
                {
                    if (GomokuGameManager.IsWinner(Board, ButtonCell, CurrentTurn == ShapeType.Black ? ShapeType.White : ShapeType.Black))
                    {
                        ResultForm rf = new ResultForm(CurrentTurn == ShapeType.Black ? ShapeType.White : ShapeType.Black);
                        rf.ShowDialog();
                        ButtonsEnabling(false);
                    }
                    else if (GomokuGameManager.CountOfFiguresPlaced == Board.BoardTab.Length)
                    {
                        ResultForm rf = new ResultForm(ShapeType.Blank);
                        rf.ShowDialog();
                        ButtonsEnabling(false);
                    }
                }
            }

            

        }

        private static int MaximizeBoardInitialize(Panel menuPanel, out Point startPoint)
        {
            int StartPositionH = 0;
            int StartPositionW = 0;

            int width = Screen.PrimaryScreen.Bounds.Width - menuPanel.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            int buttonWidth = width / Board.Width;
            int buttonHeight = menuPanel.Height / Board.Height;

            int size = Math.Min(buttonWidth, buttonHeight);

            StartPositionH = menuPanel.Height / 2 - (Board.Height * size) / 2;
            StartPositionW = width / 2 - (Board.Width * size) / 2;

            startPoint = new Point(StartPositionH, StartPositionW);

            return size;
        }

        public static void NewBoardInMaximizeMode(Panel panel, Panel menuPanel)
        {
            Panel = panel;
            Point point = new Point();
            int size = MaximizeBoardInitialize(menuPanel, out point);

            CleanBoard();
            for (int x = 0; x < Board.Height; x++)
            {
                
                for (int y = 0; y < Board.Width; y++)
                {
                    Button button = new Button
                    {
                        Location = new Point(y * size + point.Y, x * size + point.X),
                        Size = new Size(size, size),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    button.Click += Button_Click;
                    button.Tag = new Cell(x, y);

                    panel.Controls.Add(button);
                }
            }
        }

       

        public static void UpdateMaximizeBoard(Panel panel, Panel menuPanel)
        {
            Panel = panel;
            Point point = new Point();
            int size = MaximizeBoardInitialize(menuPanel,out point);

            for (int x = 0; x < Board.Height; x++)
            {
                for (int y = 0; y < Board.Width; y++)
                {
                    Button button = new Button
                    {
                        Location = new Point(y * size + point.Y, x * size + point.X),
                        Size = new Size(size, size),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    button.Click += Button_Click;
                    button.Tag = new Cell(x, y);

                    if (Board.BoardTab[x, y] == ShapeType.Black)
                        button.BackgroundImage = Resources.GomokuBlack;
                    else if (Board.BoardTab[x, y] == ShapeType.White)
                        button.BackgroundImage = Resources.GomokuWhite;

                    panel.Controls.Add(button);
                }
            }

        }

        public static void UpdateTurnBackToNormalBoard(Panel panel, Panel menuPanel)
        {
            Panel = panel;

            if (Board != null)
            {
                int StartPositionH = 0;
                int StartPositionW = 0;

                int width = Screen.PrimaryScreen.Bounds.Width - 210 - menuPanel.Width;
                int height = Screen.PrimaryScreen.Bounds.Height - 265;

                int buttonWidth = width / Board.Width;
                int buttonHeight = height / Board.Height;

                int size = Math.Min(buttonWidth, buttonHeight);

                newWidth = Board.Width * (size) + CurrentTurnButton.Width / 4;
                newHeight = Board.Height * (size) + CurrentTurnButton.Width / 3 + 14;

                if (newHeight < GomokuMainForm.minHeight)
                    StartPositionH = (GomokuMainForm.minHeight / 2) - newHeight / 2;


                for (int x = 0; x < Board.Height; x++)
                {
                    for (int y = 0; y < Board.Width; y++)
                    {
                        Button button = new Button
                        {
                            Location = new Point(y * size + StartPositionW, x * size + StartPositionH),
                            Size = new Size(size, size),
                            BackgroundImageLayout = ImageLayout.Stretch
                        };
                        button.Click += Button_Click;
                        button.Tag = new Cell(x, y);

                        if (Board.BoardTab[x, y] == ShapeType.Black)
                            button.BackgroundImage = Resources.GomokuBlack;
                        else if (Board.BoardTab[x, y] == ShapeType.White)
                            button.BackgroundImage = Resources.GomokuWhite;

                        panel.Controls.Add(button);
                    }
                }

            }
            
        }

        public static void ResetBoard()
        {
            IEnumerator buttonEnumerator;
            buttonEnumerator = Panel.Controls.GetEnumerator();

            for (int x = 0; x < Board.Height; x++)
            {
                for (int y = 0; y < Board.Width; y++)
                {
                    buttonEnumerator.MoveNext();
                    Button button = buttonEnumerator.Current as Button;
                    button.Enabled = false;
                    if (Board.BoardTab[x, y] == ShapeType.Black || Board.BoardTab[x, y] == ShapeType.White)
                    {
                        button.BackgroundImage = null;                       
                        Board.BoardTab[x, y] = ShapeType.Blank;
                    }
                }
            }

            CleanBoard();
        }

        public static void CleanBoard()
        {
            for(int x = 0; x < Board.Height; x++)
            {
                for(int y = 0; y < Board.Width; y++)
                {
                    Board.BoardTab[x, y] = ShapeType.Blank;
                }
            }
            GomokuGameManager.CountOfFiguresPlaced = 0;
        }

        public static void ButtonsEnabling(bool state)
        {
            IEnumerator buttonEnumerator;
            buttonEnumerator = Panel.Controls.GetEnumerator();

            for (int x = 0; x < Board.Height; x++)
            {
                for (int y = 0; y < Board.Width; y++)
                {
                    buttonEnumerator.MoveNext();
                    Button button = buttonEnumerator.Current as Button;
                    button.Enabled = state;                   
                }
            }
        }
    }
}
