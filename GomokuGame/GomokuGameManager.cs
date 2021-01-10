using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomokuGame
{
    public static class GomokuGameManager
    {
        public static int CountOfFiguresPlaced = 0;

        public static bool IsWinner(Board board, Cell cell, ShapeType shapeType)
        {
            int[] countsInRow = new int[8];
            for (int i = 0; i < countsInRow.Length; i++)
            {
                countsInRow[i] = 0;
            }

            // Down
            for (int i = 0, x = cell.X; i < 5; i++, x++)
            {
                if (x >= board.Height)
                    break;
                else if (board.BoardTab[x, cell.Y] == shapeType)
                    countsInRow[0]++;
                else 
                    break;
                if (countsInRow[0] == 5)
                    return true;
            }
            // Upward
            for (int i = 0, x = cell.X; i < 5; i++, x--)
            {
                if (x < 0)
                    break;
                else if (board.BoardTab[x, cell.Y] == shapeType)
                    countsInRow[1]++;
                else 
                    break;
                if (countsInRow[1] == 5)
                    return true;
            }

            if (countsInRow[0] + countsInRow[1] > 5)
                return true;


            // Left slant down
            for (int i = 0, x = cell.X, y = cell.Y; i < 5; i++, x++, y--)
            {
                if (x >= board.Height || y < 0)
                    break;
                else if (board.BoardTab[x, y] == shapeType)
                    countsInRow[2]++;
                else 
                    break;
                if (countsInRow[2] == 5)
                    return true;
            }
            // Upper right slant
            for (int i = 0, x = cell.X, y = cell.Y; i < 5; i++, x--, y++)
            {
                if (x < 0 || y >= board.Width)
                    break;
                else if (board.BoardTab[x, y] == shapeType)
                    countsInRow[3]++;
                else
                    break;  
                if (countsInRow[3] == 5)
                    return true;
            }

            if (countsInRow[2] + countsInRow[3] > 5)
                return true;

            // To the Left
            for (int i = 0, y = cell.Y; i < 5; i++, y--)
            {
                if (y < 0)
                    break;
                else if (board.BoardTab[cell.X, y] == shapeType)
                    countsInRow[4]++;
                else
                    break;
                if (countsInRow[4] == 5)
                    return true;
            }
            // To the right
            for (int i = 0, y = cell.Y; i < 5; i++, y++)
            {
                if (y >= board.Width)
                    break;
                else if (board.BoardTab[cell.X, y] == shapeType)
                    countsInRow[5]++;
                else
                    break;
                if (countsInRow[5] == 5)
                    return true;
            }

            if (countsInRow[4] + countsInRow[5] > 5)
                return true;


            // Upper left slant
            for (int i = 0, x = cell.X, y = cell.Y; i < 5; i++, x--, y--)
            {
                if (x < 0 || y < 0)
                    break;
                else if (board.BoardTab[x, y] == shapeType)
                    countsInRow[6]++;
                else
                    break;
                if (countsInRow[6] == 5)
                    return true;
            }
            // Right slant down
            for (int i = 0, x = cell.X, y = cell.Y; i < 5; i++, x++, y++)
            {
                if (x >= board.Height || y >= board.Width)
                    break;
                else if (board.BoardTab[x, y] == shapeType)
                    countsInRow[7]++;
                else
                    break;
                if (countsInRow[7] == 5)
                    return true;
            }

            if (countsInRow[6] + countsInRow[7] > 5)
                return true;

            return false;
        
        }
    }
}
