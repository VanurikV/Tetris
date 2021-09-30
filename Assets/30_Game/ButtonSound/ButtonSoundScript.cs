using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tetris
{
    public class ButtonSoundScript : MonoBehaviour
    {

        private bool _soundState;
        
        public Image Image_On;
        public Image Image_Off;
        public GameObject SfxPlayer;

        public float CurVol;
        
        private void Start()
        {
            _soundState = true;
            CurVol=Settings.GetSfxVol();
            Debug.Log(CurVol);
        }

        public void onButtonSoundClick()
        {
            _soundState ^= true;
            Image_Off.gameObject.SetActive(!_soundState);
            Image_On.gameObject.SetActive(_soundState);

            if (_soundState)
            {
                SoundManager.Manager.SetSfxVol(CurVol);
            }
            else
            {
                SoundManager.Manager.SetSfxVol(0);
            }
                
            

        }
        
    }
}
