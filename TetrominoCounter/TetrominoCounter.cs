using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Tetris.Displays
{
    public partial class TetrominoCounter : UserControl
    {
        private readonly TextureBrush T_TETROMINO = new TextureBrush(new Bitmap(Directory.GetCurrentDirectory() + @"\Colors\RESERVED\Model.png"));
        private Point[][] SHAPES;
        private const int BLOCK_SIZE = 32;

        public void Increment(int shapeIndex)
        {
            foreach (Control control in panel1.Controls)
                if (control.Tag != null && (int)control.Tag == shapeIndex)
                {
                    control.Text = $"{(int.Parse(control.Text) + 1):000}";
                    break;
                }
        }

        public void Reset()
        {
            foreach (Control control in panel1.Controls)
                if (control.Tag != null)
                    control.Text = "000";
        }

        public TetrominoCounter()
        {
            InitializeComponent();
        }

        public void AssignShapes(Point[][] shapes)
        {
            SHAPES = shapes;
            this.Size = new Size(7 * BLOCK_SIZE, (3 * SHAPES.Length + 1) * BLOCK_SIZE);

            Point center = new Point(2, 2);
            for (int i = 0; i < SHAPES.Length; ++i)
            {
                panel1.Controls.Add(new Label()
                {
                    Location = new Point((center.X + 3) * BLOCK_SIZE - 15, center.Y * BLOCK_SIZE),
                    Font = new Font("Arcade Normal", 15),
                    ForeColor = Color.LightSalmon,
                    BackColor = Color.Black,
                    AutoSize = true,
                    Text = "000",
                    Tag = i
                });
                center.Y += 3;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Point center = new Point(2, 2);
            int dx, dy;

            for (int i = 0; i < SHAPES.Length; ++i)
            {
                for (int j = 0; j < SHAPES[i].Length; ++j)
                {
                    dx = center.X + SHAPES[i][j].X;
                    dy = center.Y + SHAPES[i][j].Y;
                    e.Graphics.FillRectangle(T_TETROMINO, dx * BLOCK_SIZE, dy * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE);
                }
                center.Y += 3;
            }
        }
    }
}
