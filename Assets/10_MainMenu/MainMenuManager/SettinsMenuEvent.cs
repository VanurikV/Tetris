using UnityEngine;
using UnityEngine.UI;

namespace Tetris
{
    public partial class MainMenuManagerScript
    {
        public void onSettingsMenuReturnClick()
        {
            SoundManager.Manager.UI_Click();
            StartCoroutine(MainMenuOn());
        }

        public void odDifficultyChange(float vol)
        {
            SoundManager.Manager.UI_Click();
            
            foreach (GameObject image in DiffImage)
            {
                image.SetActive(false);
            }

            DiffImage[(int) vol].SetActive(true);
            Settings.SetDifficulty((int)vol);
        }

        public void onSfxSliderChange(float vol)
        {
            SoundManager.Manager.UI_Click();
            Settings.SetSfxVol(vol);
            SetSfxVol(vol);
        }
        
        public void onMusSliderChange(float vol)
        {
            SoundManager.Manager.UI_Click();
            Settings.SetMusVol(vol);
            SetMusVol(vol);
        }
        
        
        
    }
}