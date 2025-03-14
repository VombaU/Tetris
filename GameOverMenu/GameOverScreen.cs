using System;
using System.Windows.Forms;

namespace Tetris.Menus
{
    public partial class GameOverScreen: UserControl
    {
        public event Action RestartGame;
        public event Action ReturnToMainMenu;
        public GameOverScreen()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame?.Invoke();
            this.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu?.Invoke();
            this.Visible = false;
        }
    }
}
