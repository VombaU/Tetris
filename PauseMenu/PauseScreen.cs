using System;
using System.Windows.Forms;

namespace Tetris.Menus
{
    public partial class PauseScreen: UserControl
    {
        public event Action UnpauseGame;
        public event Action ReturnToMainMenu;
        public PauseScreen()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            UnpauseGame?.Invoke();
            pnlConfirm.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlConfirm.Visible = true;
        }

        #region Confirmation Panel Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlConfirm.Visible = false;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pnlConfirm.Visible = false;
            ReturnToMainMenu?.Invoke();
        }
        #endregion
    }
}
