using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Tetris
{
    public partial class MainMenuManagerScript : MonoBehaviour
    {
        [Header("Gate")]
        [SerializeField] private GateScript Gate;
        
        [SerializeField] private AudioMixer Mixer;

        [Header("Menu")] 
        [SerializeField] private GameObject MainMenu;
        [SerializeField] private GameObject SettingsMenu;
        [SerializeField] private GameObject LevelsMenu;

        
        [SerializeField] private GameObject[] DiffImage;
        
        
        [Header("Slider")]
        [SerializeField] private Slider SfxSlider;   
        [SerializeField] private Slider MusSlider;   
        [SerializeField] private Slider DifSlider;   
        
               
        void Start()
        {
            SliderInit();
            InitLevelMenu();
            Gate.Open();
        }


        private void SliderInit()
        {
            SoundManager.Manager.SetActive(false);
            SfxSlider.value = Settings.GetSfxVol();
            MusSlider.value = Settings.GetMusVol();
            DifSlider.value = Settings.GetDifficulty();
            
            SoundManager.Manager.SetActive(true);
        }
        
        
        private IEnumerator PlayGame()
        {
            Gate.Close();
            yield return new WaitForSeconds(1);
            AllMenuOff();
            SceneManager.LoadScene(1);
        }
        
        
        public void SetSfxVol(float vol)
        {
            if (vol == 0) vol = 0.001f; //Log10(0)=1
            Mixer.SetFloat("SfxVol", Mathf.Log10(vol) * 20);
        }

        public void SetMusVol(float vol)
        {
            if (vol == 0) vol = 0.001f; //Log10(0)=1
            Mixer.SetFloat("MusVol", Mathf.Log10(vol) * 20);
        }
        
        private void InitLevelMenu()
        {
            LevelMenuButtonScript[] AllBtn =LevelsMenu.GetComponentsInChildren<LevelMenuButtonScript>(true).ToArray();
            int MaxLevel = Settings.GetMaxCompleteLevel();
            
            foreach (LevelMenuButtonScript btn in AllBtn)
            {
                int btnNum =int.Parse(btn.gameObject.name.Substring(12, 2));
                if (btnNum <= MaxLevel)
                {
                    btn. SetLock(false);
                }
                else
                {
                    btn.SetLock(true);
                }
                
            }
        }
        
    }
}