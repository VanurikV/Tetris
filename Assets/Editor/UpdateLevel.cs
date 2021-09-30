using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

namespace Tetris
{
    public class UpdateLevel : MonoBehaviour
    {
        [MenuItem("My Tools/Update/Update Level 0")]
        public static void UpdateLevel_00()
        {
            int LevelNum = 0;
            LevelFormat level= LoadLevel(LevelNum);
            level = new LevelFormat();
            
            level.isTaskQuota = true;
            level.Line1 = 1;
            level.Line2 = 1;
            level.Line3 = 1;
            level.Line4 = 1;
            

            
           // level.Block[4, 6] = 102;
           // level.Block[5, 6] = 102;
           // level.Block[6, 6] = 103;
            
            
            level.Block[0, 19] = 102;
            level.Block[1, 19] = 102;
            level.Block[2, 19] = 103;
            level.Block[3, 19] = 102;
            level.Block[4, 19] = 103;
            level.Block[5, 19] = 104;
            level.Block[6, 19] = 104;
            level.Block[7, 19] = 104;
            level.Block[8, 19] = 104;
            level.Block[9, 19] = 104;
            
            level.Block[0, 18] = 102;
            level.Block[1, 18] = 102;
            level.Block[2, 18] = 103;
            level.Block[3, 18] = 102;
            level.Block[4, 18] = 103;
            level.Block[5, 18] = 104;
            level.Block[6, 18] = 104;
            level.Block[7, 18] = 104;
            level.Block[8, 18] = 104;
            level.Block[9, 18] = 104;
            
            
            WriteLevel(LevelNum, level);

        }

        
        [MenuItem("My Tools/Update/Update Level 1")]
        public static void UpdateLevel_01()
        {
            int LevelNum = 1;
            LevelFormat level= LoadLevel(LevelNum);
            level = new LevelFormat();
            
            level.isTaskSurvive = true;
            level.Seconds = 15;
            level.SpeedMultiplier = 1.3f;

            WriteLevel(LevelNum, level);

        }

        [MenuItem("My Tools/Update/Update Level 2")]
        public static void UpdateLevel_02()
        {
            int LevelNum = 2;
            LevelFormat level= LoadLevel(LevelNum);
            
            level.isTaskDestroyBlock = true;
           
            level.Block[8, 19] = 901;
            level.Block[9, 19] = 901;
            
            level.Block[0, 18] = 901;
            level.Block[1, 18] = 901;
            
            
            WriteLevel(LevelNum, level);

        }
        
        
        [MenuItem("My Tools/Update/Update All")]
        public static void UpdateAll()
        {
            return;
            for (int i = 0; i < Const.MaxLevel; i++)
            {
                LevelFormat level= LoadLevel(i);
                level.SpeedMultiplier = 1;
                WriteLevel(i,level);
            }
        }
        

        private static LevelFormat LoadLevel(int LevelNum)
        {
            TextAsset levelJson = Resources.Load<TextAsset>("Levels/Level_" + LevelNum.ToString("D2"));
            return JsonConvert.DeserializeObject<LevelFormat>(levelJson.text);
        }
        
        private static void WriteLevel(int LevelNum, LevelFormat level)
        {
            string path = ".//Assets//Resources//Levels//Level_";
            
            string jsonString = JsonConvert.SerializeObject(level);
        
            TextWriter t = File.CreateText(path + LevelNum.ToString("D2") + ".txt");
            t.WriteLine(jsonString);
            t.Close();
        }
        
    }
}
