using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tetris
{
    public partial class TetrisGame : Form
    {
        public TetrisGame()
        {
            InitializeComponent();
            t1.Tick += dragWidthSlider;
            t2.Tick += dragHeightSlider;
            t3.Tick += dragFreefallDelaySlider;
            t4.Tick += dragDropTimeWindowSlider;
            CacheControls();
            FORM_ORIGINAL_SIZE = this.Size;
            FORM_ORIGINAL_LOCATION = AlignToCenter(this.Width, this.Height);
            
            maxFreefallDelay = float.Parse(labFreefallMaxDelay.Text);
            minFreefallDelay = float.Parse(labFreefallMinDelay.Text);
            maxDropTimeWindow = float.Parse(labMaxDropTimeWindow.Text);
            minDropTimeWindow = float.Parse(labMinDropTimeWindow.Text);


            dropTimer.Tick += delegate (object s, EventArgs f)
            {
                dropTimer.Enabled = false;
            };

            widthMaxValue.Text = PlayArea.MAX_WIDTH.ToString();
            widthMinValue.Text = PlayArea.MIN_WIDTH.ToString();
            txtWidthValue.Text = widthMinValue.Text;

            heightMaxValue.Text = PlayArea.MAX_HEIGHT.ToString();
            heightMinValue.Text = PlayArea.MIN_HEIGHT.ToString();
            txtHeightValue.Text = heightMinValue.Text;

            Tetromino.UnableToCreate += GameOver;
            Tetromino.Locked += OnTetrominoLock;
            Tetromino.Init();
            tetrominoCounter.AssignShapes(Tetromino.SHAPES);

            freefallTimer.Tick += RenderFrame;

            pauseScreen.ReturnToMainMenu += OnReturnToMainMenu;
            pauseScreen.UnpauseGame += OnUnpauseGame;

            gameOverScreen.ReturnToMainMenu += OnReturnToMainMenu;
            gameOverScreen.RestartGame += OnRestartGame;

        }

        public void Start(params object[] options)
        {
            tetrominoCounter.Reset();
            lineCounter.Reset();
            GAME_STARTED = true;
            this.KeyUp += TetrisGame_KeyUp;
            PlayArea.RowCount = (int)options[0];
            PlayArea.ColumnCount = (int)options[1];
            Init(PlayArea.RowCount, PlayArea.ColumnCount);

            activeTetromino = new Tetromino(TETROMINO_SPAWN, rand.Next(T_BLOCKS.Length));

            freefallTimer.Start();
        }

        private void Init(int rowCount, int columnCount)
        {
            PlayArea.Width = BLOCK_SIZE * columnCount;
            PlayArea.Height = BLOCK_SIZE * rowCount;
            PlayArea.Origin = new Point(PlayArea.HORIZONTAL_PADDING, 0);
            TETROMINO_SPAWN = new Point(columnCount / 2, 1);

            PlayArea.Matrix = Array.ConvertAll(new int[rowCount], x => new int[columnCount]);

            OuterArea = new Region(new Rectangle(0, 0, 0, 0));
            OuterArea.Union(new Rectangle(0, 0, PlayArea.HORIZONTAL_PADDING, Height));                                                        // left
            OuterArea.Union(new Rectangle(PlayArea.HORIZONTAL_PADDING, PlayArea.Height, PlayArea.Width, Height - PlayArea.Height));           // bottom
            OuterArea.Union(new Rectangle(PlayArea.Width + PlayArea.HORIZONTAL_PADDING, 0, Width - PlayArea.Width + PlayArea.HORIZONTAL_PADDING, Height));  // right

            lineCounter.Location = new Point(PlayArea.HORIZONTAL_PADDING, PlayArea.Height + BLOCK_SIZE / 2);
            lineCounter.Width = PlayArea.Width;

            scoreDisplay.Location = new Point(PlayArea.Width + PlayArea.HORIZONTAL_PADDING + BLOCK_SIZE / 2, BLOCK_SIZE / 2);

            tetrominoCounter.Location = new Point(BLOCK_SIZE / 2, BLOCK_SIZE / 2);

            nextTetronimo.Location = new Point(PlayArea.Width + PlayArea.HORIZONTAL_PADDING + BLOCK_SIZE / 2, 5 * BLOCK_SIZE + scoreDisplay.Height);
            nextTetronimo.UpdateNextTetromino(new Tetromino(TETROMINO_SPAWN, rand.Next(T_BLOCKS.Length)));

            gameOverScreen.Location = pauseScreen.Location = new Point(PlayArea.HORIZONTAL_PADDING + PlayArea.Width / 2 - pauseScreen.Width / 2, this.Height / 2 - pauseScreen.Height);
 
   
            this.Controls.AddRange(GameControls);
            this.Location = AlignToCenter(this.Width, this.Height);
            this.Invalidate();
        }
        public void GameOver()
        {
            freefallTimer.Enabled = false;
            this.KeyUp -= TetrisGame_KeyUp;
            GAME_OVER = true;

            int i = 0;
            Timer t = new Timer() { Interval = 100 };
            t.Tick += delegate (object sender, EventArgs e)
            {
                for (int j = 0; j < PlayArea.ColumnCount; ++j)
                    if (PlayArea.Matrix[i][j] != 0)
                        PlayArea.Matrix[i][j] = -1;

                this.Invalidate();

                if (++i == PlayArea.RowCount)
                {
                    gameOverScreen.Visible = true;
                    scoreDisplay.UpdateTopScore();
                    t.Stop();
                }
            };
            t.Start();
        }

        private void OnTetrominoLock(Point[] blocks, int shapeIndex)
        {
            int lineCount = 0;
            foreach (int row in blocks.OrderBy(p => p.Y).Select(p => p.Y).Distinct())
            {
                for (int j = 0; j < PlayArea.ColumnCount; ++j)
                    if (PlayArea.Matrix[row][j] == 0)
                        goto nextRow;

                for (int i = row; i > 0; --i)
                    PlayArea.Matrix[i] = PlayArea.Matrix[i - 1];
                PlayArea.Matrix[0] = new int[PlayArea.ColumnCount];

                ++lineCount;
                
            nextRow:;
            }
            lineCounter.IncrementLines(lineCount);
            scoreDisplay.AddScore(PlayArea.ColumnCount * (1 + COMBO_MULTIPLIERS[lineCount]));
            tetrominoCounter.Increment(shapeIndex);
        }

        private void OnRestartGame()
        {
            GAME_OVER = false;
            Start(PlayArea.RowCount, PlayArea.ColumnCount);
        }

        private void TetrisGame_Paint(object sender, PaintEventArgs e)
        {
            if (!GAME_STARTED)
                return;

            e.Graphics.FillRegion(T_OUTER, OuterArea);
            Rectangle blockToDraw = new Rectangle(0, 0, BLOCK_SIZE, BLOCK_SIZE);

            if (!GAME_OVER)
            {
                int shadowOffset = DetShadowOffset(activeTetromino);
                foreach (Point block in activeTetromino.Blocks.OrderBy(p => p.Y))
                {
                    blockToDraw.X = PlayArea.Origin.X + block.X * BLOCK_SIZE;
                    blockToDraw.Y = PlayArea.Origin.Y + (block.Y + shadowOffset) * BLOCK_SIZE;
                    e.Graphics.FillRectangle(T_SHADOW, blockToDraw);

                    blockToDraw.X = PlayArea.Origin.X + block.X * BLOCK_SIZE;
                    blockToDraw.Y = PlayArea.Origin.Y + block.Y * BLOCK_SIZE;
                    e.Graphics.FillRectangle(T_BLOCKS[activeTetromino.Color], blockToDraw);
                }
            }

            for (int i = 0; i < PlayArea.RowCount; ++i)
                for (int j = 0; j < PlayArea.ColumnCount; ++j)
                    if (PlayArea.Matrix[i][j] != 0)
                    {
                        blockToDraw.X = PlayArea.Origin.X + j * BLOCK_SIZE;
                        blockToDraw.Y = PlayArea.Origin.Y + i * BLOCK_SIZE;
                        e.Graphics.FillRectangle(PlayArea.Matrix[i][j] == -1 ? T_INVALID : T_BLOCKS[PlayArea.Matrix[i][j] - 1], blockToDraw);
                    }
        }
        private void RenderFrame(object sender = null, EventArgs e = null)
        {
            if (!activeTetromino.Translate(0, 1))
            {
                activeTetromino.Lock();
                activeTetromino = nextTetronimo.NextTetromino;
                nextTetronimo.UpdateNextTetromino(new Tetromino(TETROMINO_SPAWN, rand.Next(T_BLOCKS.Length)));
                if (nextTetronimo.NextTetromino.Blocks == null)
                {
                    if (sender is null)
                        throw new Exception();
                    return;
                }
            }
            this.Invalidate();
        }

        private void TetrisGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.Escape)
                PauseGame();
            
            if (e.KeyCode == Keys.Right)
                activeTetromino.Translate(1, 0);

            if (e.KeyCode == Keys.Left)
                activeTetromino.Translate(-1, 0);

            if (e.KeyCode == Keys.Up)
                activeTetromino.Rotate();

            if (e.KeyCode == Keys.Down)
            {
                if (dropTimer.Enabled == true)
                {
                    dropTimer.Enabled = false;
                    activeTetromino.Translate(0, DetShadowOffset(activeTetromino));
                }
                else
                    dropTimer.Enabled = true;
                try {
                    RenderFrame();
                }
                catch (Exception) {
                    dropTimer.Enabled = false;
                    return;
                }
                freefallTimer.Stop();
                freefallTimer.Start();
            }
            this.Invalidate();
        }

        private void PauseGame()
        {
            freefallTimer.Enabled = false;
            this.KeyUp -= TetrisGame_KeyUp;
            pauseScreen.Visible = true;
        }

        private void OnUnpauseGame()
        {
            freefallTimer.Enabled = true;
            this.KeyUp += TetrisGame_KeyUp;
            pauseScreen.Visible = false;
        }
        
        private void OnReturnToMainMenu()
        {
            GAME_OVER = false;
            GAME_STARTED = false;
            scoreDisplay.UpdateTopScore();
            this.Controls.Clear();
            this.Controls.AddRange(MenuControls);
            this.Size = FORM_ORIGINAL_SIZE;
            this.Location = FORM_ORIGINAL_LOCATION;
            this.Invalidate();
        }

        private void CacheControls()
        {
            MenuControls = this.Controls.Cast<Control>().ToArray();
            GameControls = new Control[]
            {
                pauseScreen,
                gameOverScreen,
                nextTetronimo,
                tetrominoCounter,
                scoreDisplay,
                lineCounter,
            };
        }

        private Point AlignToCenter(int width, int height)
        {
            return new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
        }

        private int DetShadowOffset(Tetromino tetro)
        {
            for (int minYOffset = 0; minYOffset < PlayArea.RowCount; ++minYOffset)
                foreach (Point block in tetro.Blocks)
                    if (PlayArea.RowCount <= block.Y + minYOffset || PlayArea.Matrix[block.Y + minYOffset][block.X] != 0)
                        return --minYOffset;
            return -1;
        }
    }
}
