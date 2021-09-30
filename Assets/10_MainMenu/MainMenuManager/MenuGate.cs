using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public partial class MainMenuManagerScript
    {
        private IEnumerator MenuSettingsOn()
        {
            Gate.Close();
            yield return new WaitForSeconds(1);
            AllMenuOff();
            SettingsMenu.SetActive(true);
            Gate.Open();
        }

        
        
        
        private IEnumerator MainMenuOn()
        {
            Gate.Close();
            yield return new WaitForSeconds(1);
            AllMenuOff();
            MainMenu.SetActive(true);
            Gate.Open();
        }


        private IEnumerator LevelsMenuOn()
        {
            Gate.Close();
            yield return new WaitForSeconds(1);
            AllMenuOff();
            LevelsMenu.SetActive(true);
            Gate.Open();
        }
        
        private void AllMenuOff()
        {
            SettingsMenu.SetActive(false);
            MainMenu.SetActive(false);
            LevelsMenu.SetActive(false);
        }
    }
}