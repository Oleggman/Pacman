using Pacman.Models;
using System;

namespace Pacman.Controllers
{
    public class GameController
    {
        private MainForm gameForm;
        private GameInfo gInfo;
        public uint level = 1;

        public GameController(MainForm uiForm)
        {
            gameForm = uiForm;
            gInfo = GameDbContext.GetContext().GetGameInfo(level);
            SetupConfigurationLevel();
        }

        private void SetupConfigurationLevel()
        {
            gameForm.PanelGrid.Width = gInfo.Width;
            gameForm.PanelGrid.Height = gInfo.Height;
            gameForm.PanelGrid.Location = new System.Drawing.Point(
                gameForm.Width / 2 - gameForm.PanelGrid.Width / 2,
                gameForm.Height / 2 - gameForm.PanelGrid.Height / 2
                );
        }

        public void NextLevel()
        {
            level++;
            gInfo = GameDbContext.GetContext().GetGameInfo(level);
            SetupConfigurationLevel();
        }
    }
}
