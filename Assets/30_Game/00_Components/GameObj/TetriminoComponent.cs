using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    struct TetriminoComponent
    {
        public GameObject Obj;
        public GameObject GhostObj;
        
        public TetriminoScript Script;
        public TetriminoScript GhostScript;
        
        public Vector2Int Pos;
        public int RotaryPos;
        
        public Vector2Int GhostPos;
        public int GhostRotaryPos;
        
        public TetriminoType type;
        
        
        public readonly List<Vector2Int[]> Blocks;

        public float ElapseTimeToDown;
        public float ElapseTimeToForceDown;
        public float ElapseTimeToMove;
        public float ElapseTimeToRotate;
        

    }
    
    
    
}   