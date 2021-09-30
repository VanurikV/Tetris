using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public class GlobalData
    {
        public int CurLevelNum;
        
        public TetrisControls Controls;
        
        public Transform TetriminoContainer;
        public Transform BlockContainer;

        public GateScript Gate;

        public Dictionary<int, GameObject> BlockPrefab;
        public Dictionary<TetriminoType, GameObject> TetriminoPrefab;
        public Dictionary<TetriminoType, GameObject> GhostPrefab;
        
        public GameObject LinePrefab;
        public GameObject GameOverPrefab;
        public GameObject GameWinPrefab;
        
        public float SpeedMultiplier;

    }
}
