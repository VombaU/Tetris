using System;
using System.Windows.Forms;
using System.Drawing;

namespace Tetris
{
    public partial class TetrisGame
    {
        // To simulate the dragging of the sliders in real time
        private Timer t1 = new Timer() { Interval = 10 };
        private Timer t2 = new Timer() { Interval = 10 };
        private Timer t3 = new Timer() { Interval = 10 };
        private Timer t4 = new Timer() { Interval = 10 };

        #region Width Slider
        private void dragWidthSlider(object s, EventArgs e)
        {
            var newLocation = new Point(pnlWidthSelection.PointToClient(Cursor.Position).X - btnWidthSlider.Width / 2, btnWidthSlider.Location.Y);

            if (newLocation.X < labWidthBar.Location.X)
                newLocation.X = labWidthBar.Location.X;

            if (newLocation.X > labWidthBar.Width)
                newLocation.X = labWidthBar.Width;

            btnWidthSlider.Location = new Point(newLocation.X, newLocation.Y);

            if (btnWidthSlider.Location.X == labWidthBar.Location.X)
                txtWidthValue.Text = PlayArea.MIN_WIDTH.ToString();
            else
                txtWidthValue.Text = ((int)(btnWidthSlider.Location.X * (float)(PlayArea.MAX_WIDTH - PlayArea.MIN_WIDTH) / labWidthBar.Width) + PlayArea.MIN_WIDTH).ToString();
        }
        private void btnWidthSlider_MouseDown(object sender, MouseEventArgs e)
        {
            t1.Start();
        }
        private void btnWidthSlider_MouseUp(object sender, MouseEventArgs e)
        {
            t1.Stop();
        }
        private void txtWidthValue_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtWidthValue.Text, out int width) == false)
            {
                txtWidthValue.Text = PlayArea.MIN_WIDTH.ToString();
                return;
            }

            if (width > PlayArea.MAX_WIDTH)
                txtWidthValue.Text = PlayArea.MAX_WIDTH.ToString();

            if (width < PlayArea.MIN_WIDTH)
                txtWidthValue.Text = PlayArea.MIN_WIDTH.ToString();
        }
        #endregion
        #region Height Slider
        private void dragHeightSlider(object s, EventArgs e)
        {
            var newLocation = new Point(pnlHeightSelection.PointToClient(Cursor.Position).X - btnHeightSlider.Width / 2, btnHeightSlider.Location.Y);

            if (newLocation.X < labHeightBar.Location.X)
                newLocation.X = labHeightBar.Location.X;

            if (newLocation.X > labHeightBar.Width)
                newLocation.X = labHeightBar.Width;

            btnHeightSlider.Location = new Point(newLocation.X, newLocation.Y);

            if (btnHeightSlider.Location.X == labHeightBar.Location.X)
                txtHeightValue.Text = PlayArea.MIN_HEIGHT.ToString();
            else
                txtHeightValue.Text = ((int)(btnHeightSlider.Location.X * (float)(PlayArea.MAX_HEIGHT - PlayArea.MIN_HEIGHT) / labHeightBar.Width) + PlayArea.MIN_HEIGHT).ToString();
        }

        private void btnHeightSlider_MouseDown(object sender, MouseEventArgs e)
        {
            t2.Start();
        }
        private void btnHeightSlider_MouseUp(object sender, MouseEventArgs e)
        {
            t2.Stop();
        }
        private void txtHeightValue_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtHeightValue.Text, out int height) == false)
            {
                txtHeightValue.Text = PlayArea.MIN_HEIGHT.ToString();
                return;
            }

            if (height > PlayArea.MAX_HEIGHT)
                txtHeightValue.Text = PlayArea.MAX_HEIGHT.ToString();

            if (height < PlayArea.MIN_HEIGHT)
                txtHeightValue.Text = PlayArea.MIN_HEIGHT.ToString();
        }
        #endregion
        #region Freefall Delay Slider
        private void dragFreefallDelaySlider(object sender, EventArgs e)
        {
            var newLocation = new Point(pnlFreefallDelaySelection.PointToClient(Cursor.Position).X - btnFreefallDelaySlider.Width / 2, btnFreefallDelaySlider.Location.Y);

            if (newLocation.X < labFreefallDelayBar.Location.X)
                newLocation.X = labFreefallDelayBar.Location.X;

            if (newLocation.X > labFreefallDelayBar.Width)
                newLocation.X = labFreefallDelayBar.Width;

            btnFreefallDelaySlider.Location = new Point(newLocation.X, newLocation.Y);

            if (btnFreefallDelaySlider.Location.X == labFreefallDelayBar.Location.X)
                txtFreefallDelay.Text = minFreefallDelay.ToString();
            else
                txtFreefallDelay.Text = $"{((btnFreefallDelaySlider.Location.X * (maxFreefallDelay - minFreefallDelay) / labFreefallDelayBar.Width) + minFreefallDelay):F2}";
        }
        private void btnFreefallDelaySlider_MouseDown(object sender, MouseEventArgs e)
        {
            t3.Start();
        }

        private void btnFreefallDelaySlider_MouseUp(object sender, MouseEventArgs e)
        {
            t3.Stop();
        }

        private void txtFreefallDelay_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(txtFreefallDelay.Text, out float delay) == false)
            {
                txtFreefallDelay.Text = minFreefallDelay.ToString();
                return;
            }
            if (delay > maxFreefallDelay)
                txtFreefallDelay.Text = maxFreefallDelay.ToString();

            if (delay < minFreefallDelay)
                txtFreefallDelay.Text = minFreefallDelay.ToString();
        }
        #endregion
        #region Drop Time Window Slider
        private void dragDropTimeWindowSlider(object sender, EventArgs e)
        {
            var newLocation = new Point(pnlDropTimeWindowSelection.PointToClient(Cursor.Position).X - btnDropTimeWindowSlider.Width / 2, btnDropTimeWindowSlider.Location.Y);

            if (newLocation.X < labDropTimeWindowBar.Location.X)
                newLocation.X = labDropTimeWindowBar.Location.X;

            if (newLocation.X > labDropTimeWindowBar.Width)
                newLocation.X = labDropTimeWindowBar.Width;

            btnDropTimeWindowSlider.Location = new Point(newLocation.X, newLocation.Y);

            if (btnDropTimeWindowSlider.Location.X == labDropTimeWindowBar.Location.X)
                txtDropTimeWindow.Text = minDropTimeWindow.ToString();
            else
                txtDropTimeWindow.Text = $"{((btnDropTimeWindowSlider.Location.X * (maxDropTimeWindow - minDropTimeWindow) / labDropTimeWindowBar.Width) + minDropTimeWindow):F2}";
        }
        private void btnDropTimeWindowSlider_MouseDown(object sender, MouseEventArgs e)
        {
            t4.Start();
        }
        private void btnDropTimeWindowSlider_MouseUp(object sender, MouseEventArgs e)
        {
            t4.Stop();
        }
        private void txtDropTimeWindow_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(txtDropTimeWindow.Text, out float delay) == false)
            {
                txtDropTimeWindow.Text = minDropTimeWindow.ToString();
                return;
            }
            if (delay > maxDropTimeWindow)
                txtDropTimeWindow.Text = maxDropTimeWindow.ToString();

            if (delay < minDropTimeWindow)
                txtDropTimeWindow.Text = minDropTimeWindow.ToString();
        }
        #endregion

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
        private void floatableTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = ((TextBox)sender).Text;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && (e.KeyChar == '.' && s.IndexOf(e.KeyChar) > 0))
                e.Handled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PlayArea.ColumnCount = int.Parse(txtWidthValue.Text);
            PlayArea.RowCount = int.Parse(txtHeightValue.Text);
            dropTimer.Interval = (int)(1000 * float.Parse(txtDropTimeWindow.Text == "0" ? "0.001" : txtDropTimeWindow.Text));
            freefallTimer.Interval = (int)(1000 * float.Parse(txtFreefallDelay.Text));
            pnlCustomGameModeOptions.Visible = false;
            btnStart.Enabled = true;
            btnOptions.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCustomGameModeOptions.Visible = false;
            btnStart.Enabled = true;
            btnOptions.Enabled = true;
        }
    }

}
