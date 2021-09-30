using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Tetris
{
    sealed partial class InitAllSystem
    {

        private void GlobalInit()
        {

            _global.SpeedMultiplier = _level.SpeedMultiplier;
            _global.CurLevelNum = Settings.GetCurrentLevel();

            _global.BlockContainer = GameObject.Find("BlockContainer").transform;
            _global.TetriminoContainer = GameObject.Find("TetriminoContainer").transform;
            _global.Gate = GameObject.Find("Gate").GetComponent<GateScript>();
            
            LoadTetrimino();
            LoadGhost();
            LoadObj();
            
            LoadBlock();
        }

        private void LoadBlock()
        {
            _global.BlockPrefab = new Dictionary<int, GameObject>();
            
            TextAsset blockIndex = Resources.Load<TextAsset>("BlockIndex");
            List<string> prefName = blockIndex.text.Trim().Replace("\r", "").Split('\n').ToList();

            foreach (string fs in prefName)
            {
                _global.BlockPrefab.Add(int.Parse(fs.Substring(fs.LastIndexOf('/')+1, 4)), Resources.Load<GameObject>(fs));
            }

            Debug.Log("Loaded " + _global.BlockPrefab.Count.ToString("D3") + " prefab");
        }

        private void LoadTetrimino()
        {
            _global.TetriminoPrefab = new Dictionary<TetriminoType, GameObject>();

            foreach (string name in Enum.GetNames(typeof(TetriminoType)))
            {
                _global.TetriminoPrefab.Add((TetriminoType)Enum.Parse(typeof(TetriminoType),name),Resources.Load<GameObject>("Tetrimino/Tetrimino_"+name));
            }

        }
        
        private void LoadGhost()
        {
            _global.GhostPrefab = new Dictionary<TetriminoType, GameObject>();

            foreach (string name in Enum.GetNames(typeof(TetriminoType)))
            {
                _global.GhostPrefab.Add((TetriminoType)Enum.Parse(typeof(TetriminoType),name),Resources.Load<GameObject>("Tetrimino/Ghost_"+name));
            }

        }
        
        private void LoadObj()
        {
            _global.LinePrefab= Resources.Load<GameObject>("Obj/Line");
            _global.GameOverPrefab = Resources.Load<GameObject>("Obj/GameOver");
            _global.GameWinPrefab = Resources.Load<GameObject>("Obj/GameWin");
        }
        
    }
}