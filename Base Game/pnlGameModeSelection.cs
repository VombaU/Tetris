using System;

namespace Tetris
{
    public partial class TetrisGame
    {
        private void btnClassic_Click(object sender, EventArgs e)
        {
            pnlGameModeSelection.Visible = false;
            PlayArea.ColumnCount = 10;
            PlayArea.RowCount = 20;
            dropTimer.Interval = 100;
            freefallTimer.Interval = 1000;
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            pnlCustomGameModeOptions.Visible = true;
            pnlGameModeSelection.Visible = false;
            btnStart.Enabled = false;
            btnOptions.Enabled = false;
        }
    }
}
