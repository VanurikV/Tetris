using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

namespace Tetris
{
    public class GenerateLevel : MonoBehaviour
    {
        // [MenuItem("My Tools/Generate/Generate All Level")]
        // public static void GenerateAllLevel()
        // {
        //     for (int i = 0; i < Const.MaxLevel; i++)
        //     {
        //         LevelFormat level = new LevelFormat();
        //         level.Block = new int[Const.GameCupDX, Const.GameCupDY];
        //         WriteLevel(i, level);
        //     }
        // }
        //
        //
        // private static void WriteLevel(int LevelNum, LevelFormat level)
        // {
        //     string path = ".//Assets//Resources//Levels//Level_";
        //     
        //     string jsonString = JsonConvert.SerializeObject(level);
        //
        //     TextWriter t = File.CreateText(path + LevelNum.ToString("D2") + ".txt");
        //     t.WriteLine(jsonString);
        //     t.Close();
        // }
        
    }
}
