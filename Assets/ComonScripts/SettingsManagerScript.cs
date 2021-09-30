using System.Collections;
using System.Collections.Generic;
using Tetris;
using UnityEngine;

    
    public enum PPString
    {
        SoundSfxVol,
        SoundMusVol,
        MaxCompleteLevel,
        CurrentLevel,
        Difficulty,
    }
    
    public static class Settings
    {
        static Settings()
        {
            // проверяем если ключа не было то создаем
            if (!PlayerPrefs.HasKey(PPString.SoundMusVol.ToString()))
            {
                PlayerPrefs.SetFloat(PPString.SoundMusVol.ToString(), 0.5f);
                PlayerPrefs.Save();
            }

            if (!PlayerPrefs.HasKey(PPString.SoundSfxVol.ToString()))
            {
                PlayerPrefs.SetFloat(PPString.SoundSfxVol.ToString(), 0.5f);
                PlayerPrefs.Save();
            }

            if (!PlayerPrefs.HasKey(PPString.MaxCompleteLevel.ToString()))
            {
                PlayerPrefs.SetInt(PPString.MaxCompleteLevel.ToString(), 0);
                PlayerPrefs.Save();
            }

            if (!PlayerPrefs.HasKey(PPString.CurrentLevel.ToString()))
            {
                PlayerPrefs.SetInt(PPString.CurrentLevel.ToString(), 0);
                PlayerPrefs.Save();
            }
            
            if (!PlayerPrefs.HasKey(PPString.Difficulty.ToString()))
            {
                PlayerPrefs.SetInt(PPString.Difficulty.ToString(), 1);
                PlayerPrefs.Save();
            }
            
            
        }
        
        public static float GetMusVol()
        {
            return PlayerPrefs.GetFloat(PPString.SoundMusVol.ToString());
        }

        public static float GetSfxVol()
        {
            return PlayerPrefs.GetFloat(PPString.SoundSfxVol.ToString());
        }
        
        public static void SetMusVol(float vol)
        {
            PlayerPrefs.SetFloat(PPString.SoundMusVol.ToString(), vol);
            PlayerPrefs.Save();
        }

        public static void SetSfxVol(float vol)
        {
            PlayerPrefs.SetFloat(PPString.SoundSfxVol.ToString(), vol);
            PlayerPrefs.Save();
        }


        public static int GetDifficulty()
        {
            return PlayerPrefs.GetInt(PPString.Difficulty.ToString());
        }
        
        public static void SetDifficulty(int level)
        {
            PlayerPrefs.SetInt(PPString.Difficulty.ToString(), level);
            PlayerPrefs.Save();
        }
        
        public static int GetCurrentLevel()
        {
            return PlayerPrefs.GetInt(PPString.CurrentLevel.ToString());
        }

        public static void SetCurrentLevel(int level)
        {
            PlayerPrefs.SetInt(PPString.CurrentLevel.ToString(), level);
            PlayerPrefs.Save();
        }


        public static int GetMaxCompleteLevel()
        {
            return PlayerPrefs.GetInt(PPString.MaxCompleteLevel.ToString());
        }

        public static void SetMaxCompleteLevel(int level)
        {
            PlayerPrefs.SetInt(PPString.MaxCompleteLevel.ToString(), level);
            PlayerPrefs.Save();
        }

        public static void LevelComplete(int level)
        {
            level++;
            if(level>=Const.MaxLevel) return;

            if (GetMaxCompleteLevel() < level)
            {
                SetMaxCompleteLevel(level);
                SetCurrentLevel(level);
            }else
                SetCurrentLevel(level);
        }

        
        
    }
    
