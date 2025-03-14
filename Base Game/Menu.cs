using System;
using System.Windows.Forms;
using System.Drawing;

namespace Tetris
{
    public partial class TetrisGame
    {
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Size = new Size(PlayArea.ColumnCount * BLOCK_SIZE + 2 * PlayArea.HORIZONTAL_PADDING, PlayArea.RowCount * BLOCK_SIZE + PlayArea.VERTICAL_PADDING);
            this.Start(PlayArea.RowCount, PlayArea.ColumnCount);
            GAME_STARTED = true;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            pnlGameModeSelection.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
