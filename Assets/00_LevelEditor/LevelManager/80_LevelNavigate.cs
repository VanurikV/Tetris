namespace Tetris
{
    public partial class LevelManagerScript
    {
        public void OnPrevBtnClick()
        {
            CurLevel--;
            if (CurLevel < 0) CurLevel = Const.MaxLevel - 1;
            RebuildMap();
        }

        public void OnNextBtnClick()
        {
            CurLevel++;
            if (CurLevel >= Const.MaxLevel) CurLevel = 0;
            RebuildMap();
        }

        public void OnRelBtnClick()
        {
            RebuildMap();
        }

        private void CurLevelTextUpdate()
        {
            CurLevelText.text = CurLevel.ToString("D2");
        }

        private void CurLevelTaskUpdate()
        {
            ToggleDestroy.isOn = _levelFormat.isTaskDestroyBlock;
            ToggleQuota.isOn = _levelFormat.isTaskQuota;
            ToggleSurvive.isOn = _levelFormat.isTaskSurvive;

            SurviveText.text = _levelFormat.Seconds.ToString();
            SpeedMul.text = _levelFormat.SpeedMultiplier.ToString();

            Line1Text.text = _levelFormat.Line1.ToString("D2");
            Line2Text.text = _levelFormat.Line2.ToString("D2");
            Line3Text.text = _levelFormat.Line3.ToString("D2");
            Line4Text.text = _levelFormat.Line4.ToString("D2");

        }
        
        
        private void CurLevelFormatUpdate()
        {
            _levelFormat.isTaskDestroyBlock = ToggleDestroy.isOn;
            _levelFormat.isTaskQuota = ToggleQuota.isOn;
            _levelFormat.isTaskSurvive = ToggleSurvive.isOn;

            _levelFormat.Seconds = float.Parse(SurviveText.text);
            _levelFormat.SpeedMultiplier = float.Parse(SpeedMul.text);
            
            _levelFormat.Line1 = int.Parse(Line1Text.text);
            _levelFormat.Line2 = int.Parse(Line2Text.text);
            _levelFormat.Line3 = int.Parse(Line3Text.text);
            _levelFormat.Line4 = int.Parse(Line4Text.text);
            

        }
        
    }
}