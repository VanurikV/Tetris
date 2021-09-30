using UnityEngine;

namespace Tetris
{
    public partial class MainMenuManagerScript
    {
        public void onMainMenuPlayClick()
        {
            SoundManager.Manager.UI_Click();
            StartCoroutine(LevelsMenuOn());
        }

        public void onMainMenuSettingsClick()
        {
            SoundManager.Manager.UI_Click();
            StartCoroutine(MenuSettingsOn());
        }
    }
}