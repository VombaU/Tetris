using System.Windows.Forms;
using System.Drawing;

namespace Tetris
{
    public partial class TetrisGame
    {
        private static class PlayArea
        {
            public static int Width;
            public static int Height;
            public static int[][] Matrix;
            public static Point Origin;
            public static int RowCount = 20;
            public static int ColumnCount = 10;
            public static readonly int HORIZONTAL_PADDING = 8 * BLOCK_SIZE;
            public static readonly int VERTICAL_PADDING = 4 * BLOCK_SIZE;
            public static readonly int MAX_WIDTH = (Screen.PrimaryScreen.WorkingArea.Size.Width - 2 * HORIZONTAL_PADDING) / BLOCK_SIZE;
            public static readonly int MIN_WIDTH = 8;
            public static readonly int MAX_HEIGHT = (Screen.PrimaryScreen.WorkingArea.Size.Height - VERTICAL_PADDING) / BLOCK_SIZE;
            public static readonly int MIN_HEIGHT = 20;
        }
    }
}
