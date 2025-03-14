using System.Windows.Forms;

namespace Tetris.Displays
{
    public partial class LineCounter: UserControl
    {
        public LineCounter()
        {
            InitializeComponent();
        }
        public void IncrementLines(int lineCount)
        {
            labLineCounter.Text = $"{int.Parse(labLineCounter.Text) + lineCount:000}";
        }
        public void Reset()
        {
            labLineCounter.Text = "000";
        }
    }
}
