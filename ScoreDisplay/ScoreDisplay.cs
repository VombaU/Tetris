using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Tetris.Displays
{
    public partial class ScoreDisplay: UserControl
    {
        private readonly string _topScoreFile = Directory.GetCurrentDirectory() + @"\TopScore.txt";
        private int _topScore;
        private int _score = 0;

        public ScoreDisplay()
        {
            InitializeComponent();
            _topScore = int.Parse(File.ReadAllText(_topScoreFile));
            labTopScore.Text = $"{_topScore:000000}";
        }

        public void UpdateTopScore()
        {
            if (_score > _topScore)
            {

                _topScore = _score;
                File.WriteAllText(_topScoreFile, _topScore.ToString());

                labTopScore.Text = $"{_score:000000}";
                DisplayNewHighScoreEffect();
            }
            else
                labScore.Text = "000000";
            _score = 0;
        }

        private void DisplayNewHighScoreEffect()
        {
            int i = 0;

            labScore.Text = "NEW HI!";
            Timer t1 = new Timer() { Interval = 300 };
            t1.Tick += delegate (object sender, EventArgs e)
            {
                labScore.ForeColor = i++ % 2 != 0 ? Color.White : Color.Tomato;
            };
            t1.Start();

            Timer t2 = new Timer() { Interval = 3 * 1000 };
            t2.Tick += delegate (object sender, EventArgs e)
            {
                labScore.ForeColor = Color.White;
                labScore.Text = $"{_score:000000}";
                t2.Stop();
                t1.Stop();
            };
            t2.Start();
        }

        public void AddScore(int points)
        {
            _score += points;
            labScore.Text = $"{_score:000000}";
        }
    }
}
