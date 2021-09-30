using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

namespace Tetris
{
    public partial class LevelManagerScript
    {
        private LevelFormat LoadLevel(int LevelNum)
        {
            //
            //TextAsset levelJson = Resources.Load<TextAsset>("Levels/Level_" + LevelNum.ToString("D2"));
            //return JsonConvert.DeserializeObject<LevelFormat>(levelJson.text);
            
            string path = ".//Assets//Resources//Levels//Level_";
            TextReader t = File.OpenText(path + CurLevel.ToString("D2") + ".txt");
           
            LevelFormat level= JsonConvert.DeserializeObject<LevelFormat>(t.ReadToEnd());
            t.Close();
            return level;

        }

        public void WriteLevel()
        {   
            CurLevelFormatUpdate();
            
            string path = ".//Assets//Resources//Levels//Level_";

            string jsonString = JsonConvert.SerializeObject(_levelFormat);

            TextWriter t = File.CreateText(path + CurLevel.ToString("D2") + ".txt");
            t.WriteLine(jsonString);
            t.Close();
        }
        
        private void LoadBlock()
        {
           BlockPrefab = new Dictionary<int, GameObject>();
            
            TextAsset blockIndex = Resources.Load<TextAsset>("BlockIndex");
            List<string> prefName = blockIndex.text.Trim().Replace("\r", "").Split('\n').ToList();

            foreach (string fs in prefName)
            {
                BlockPrefab.Add(int.Parse(fs.Substring(fs.LastIndexOf('/')+1, 4)), Resources.Load<GameObject>(fs));
            }

            Debug.Log("Loaded " + BlockPrefab.Count.ToString("D3") + " prefab");
        }
        
    }
}