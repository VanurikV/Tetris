using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Tetris
{
    public class SetSettings
    {
        [MenuItem("My Tools/Set_Vol")]
        public static void SetVol()
        {
  
            PlayerPrefs.SetFloat(PPString.SoundSfxVol.ToString(),0.5f);
            PlayerPrefs.SetFloat(PPString.SoundMusVol.ToString(),0.5f);
           
            
        }
    }
}
