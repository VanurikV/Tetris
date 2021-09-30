using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Tetris
{
    public class Script : MonoBehaviour
    {
        [MenuItem("My Tools/MaxLevel/SetMaxLevel 0")]
        public static void SetMaxLevel0()
        {
            Settings.SetMaxCompleteLevel(0);
            Settings.SetCurrentLevel(0);
        }
        
        [MenuItem("My Tools/MaxLevel/SetMaxLevel 1")]
        public static void SetMaxLevel1()
        {
            Settings.SetMaxCompleteLevel(1);
            Settings.SetCurrentLevel(1);
        }
        
        [MenuItem("My Tools/MaxLevel/SetMaxLevel 2")]
        public static void SetMaxLevel2()
        {
            Settings.SetMaxCompleteLevel(2);
            Settings.SetCurrentLevel(2);
        }
        
        [MenuItem("My Tools/MaxLevel/SetMaxLevel 25")]
        public static void SetMaxLevel10()
        {
            Settings.SetMaxCompleteLevel(25);
            Settings.SetCurrentLevel(25);
        }

        
        [MenuItem("My Tools/MaxLevel/SetMaxLevel 49")]
        public static void SetMaxLevel49()
        {
            Settings.SetMaxCompleteLevel(49);
            Settings.SetCurrentLevel(49);
        }
    }
}
