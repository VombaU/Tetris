using System.Windows.Forms;
using System.Drawing;

namespace Tetris.Displays
{
    public partial class NextTetrominoDisplay : UserControl
    {
        public TetrisGame.Tetromino NextTetromino;
        private readonly int BLOCK_SIZE = TetrisGame.BLOCK_SIZE;
        private Point Center;
        public NextTetrominoDisplay()
        {
            InitializeComponent();
        }

        public void UpdateNextTetromino(TetrisGame.Tetromino nextTetromino)
        {
            Center = new Point(this.Width / 2 - BLOCK_SIZE / 2, this.Height / 2 + BLOCK_SIZE / 2);

            if (nextTetromino.ShapeIndex == TetrisGame.Tetromino.Type.IShape) // IShape
            {
                Center.Y -= BLOCK_SIZE;
            }
            if (nextTetromino.ShapeIndex == TetrisGame.Tetromino.Type.OShape) // OShape
            {
                Center.X -= BLOCK_SIZE;
            }

            NextTetromino = nextTetromino;
            this.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var block in TetrisGame.Tetromino.SHAPES[NextTetromino.ShapeIndex])
            {
                int dx = block.X * BLOCK_SIZE;
                int dy = block.Y * BLOCK_SIZE;
                e.Graphics.FillRectangle(TetrisGame.T_BLOCKS[NextTetromino.Color], Center.X + dx, Center.Y + dy, BLOCK_SIZE, BLOCK_SIZE);
            }
        }
    }
}
