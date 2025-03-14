using Tetris.Displays;
using Tetris.Menus;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tetris
{
    public partial class TetrisGame
    {
        public static readonly int BLOCK_SIZE = 32;

        private readonly float maxFreefallDelay;
        private readonly float minFreefallDelay;
        private float maxDropTimeWindow;
        private float minDropTimeWindow;

        private LineCounter lineCounter = new LineCounter();
        private readonly Size FORM_ORIGINAL_SIZE;
        private readonly Point FORM_ORIGINAL_LOCATION;

        private Control[] MenuControls;
        private Control[] GameControls;
        public Region OuterArea;
        public static readonly TextureBrush[] T_BLOCKS = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Colors")
                                                                  .Select(fileName => new TextureBrush(new Bitmap(fileName)))
                                                                  .ToArray();
        public readonly TextureBrush T_OUTER = new TextureBrush(new Bitmap(Directory.GetCurrentDirectory() + @"\Colors\RESERVED\Outer.png"));
        public readonly TextureBrush T_INVALID = new TextureBrush(new Bitmap(Directory.GetCurrentDirectory() + @"\Colors\RESERVED\Invalid.png"));
        public readonly TextureBrush T_SHADOW = new TextureBrush(new Bitmap(Directory.GetCurrentDirectory() + @"\Colors\RESERVED\Shadow.png"));

        private Timer freefallTimer = new Timer() { Interval = 1000 };
        private Timer dropTimer = new Timer() { Interval = 100 };

        private Tetromino activeTetromino;
        private bool GAME_STARTED = false;
        private bool GAME_OVER = false;
        private static readonly Random rand = new Random();
        private Point TETROMINO_SPAWN;

        private PauseScreen pauseScreen = new PauseScreen();
        private GameOverScreen gameOverScreen = new GameOverScreen();

        private readonly int[] COMBO_MULTIPLIERS = new int[5] { 0, 100, 300, 700, 2000 };

        private NextTetrominoDisplay nextTetronimo = new NextTetrominoDisplay();
        private TetrominoCounter tetrominoCounter = new TetrominoCounter();
        private ScoreDisplay scoreDisplay = new ScoreDisplay();
    }
}
