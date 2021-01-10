using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomokuGame
{
    public class Board
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public ShapeType[,] BoardTab { get; set; }

        public Board(int height, int width)
        {
            this.Width = width;
            this.Height = height;
            BoardTab = new ShapeType[height, width];
            for(int i=0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    BoardTab[i,j] = ShapeType.Blank;
                }
            }
        }
    }

    public enum ShapeType
    {
        White,
        Black,
        Blank
    }
}
