using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    [Serializable]
    public class LevelFormat
    {
        public bool isTaskQuota;
        public int Line1;
        public int Line2;
        public int Line3;
        public int Line4;

        public bool isTaskDestroyBlock;

        public bool isTaskSurvive;
        public float Seconds;

        public float SpeedMultiplier;
        
        public int[,] Block;

        public LevelFormat()
        {
            isTaskQuota = false;
            isTaskDestroyBlock = false;
            isTaskSurvive = false;
            SpeedMultiplier = 1;
            Block = new int[Const.GameCupDx, Const.GameCupDy];

        }
    }
}