using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Tetris
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Manager;
        
        [SerializeField] private AudioMixer Mixer;
        
        [Header("AudioSource")]
        [SerializeField] private AudioSource SfxPlayer;
        [SerializeField] private AudioSource MusPlayer;
        
        [Header("AudioClips")]
        [SerializeField] private AudioClip[] SfxClips;
        [SerializeField] private AudioClip[] MusClips;
        
        // Start is called before the first frame update
        private void Awake()
        {
            SetVol();
            Manager = this;
        }

        public void SetActive(bool state)
        {
            SfxPlayer.enabled = state;
            MusPlayer.enabled = state;
        }

        public void PlaySfx(SfxClip clip)
        {
            //SfxPlayer.pitch = Random.Range(0.8f, 1.2f);
            SfxPlayer.PlayOneShot(SfxClips[(int)clip]);
        }   

        public void PlayMus(MusClip clip)
        {
            MusPlayer.Stop();
            MusPlayer.clip = MusClips[(int)clip];
            MusPlayer.Play();
        }

        public void UI_Click()
        {
            PlaySfx(SfxClip.UI_Click);
        }
  
        #region SetVolume

        public void SetVol()
        {
           SetMusVol(Settings.GetMusVol());
           SetSfxVol(Settings.GetSfxVol());
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
        
        #endregion

        
    }
}
