namespace Tetris
{
    public partial class MainMenuManagerScript
    {
        public void onLevelMenuReturnClick()
        {
            SoundManager.Manager.UI_Click();
            StartCoroutine(MainMenuOn());
        }

        
        public void onLevelMenuPlay()
        {
            SoundManager.Manager.UI_Click();
            Settings.SetCurrentLevel(Settings.GetMaxCompleteLevel());
            StartCoroutine(PlayGame());
        }
        
        public void onButtonLevelClick(int level)
        {
            SoundManager.Manager.UI_Click();
            Settings.SetCurrentLevel(level);
            StartCoroutine(PlayGame());
        }
        
    }
}