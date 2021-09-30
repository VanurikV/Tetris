using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public static class Const
    {
        /// <summary>Количество уровней в игре</summary>
        public const int MaxLevel = 50;

        /// <summary>Размер клетки </summary>
        public const int CellSize = 200;

        /// <summary>Длинна игрового стакана </summary>
        public const int GameCupDx = 10;

        /// <summary>Высота игрового стакана </summary>
        public const int GameCupDy = 20;


        /// <summary>Время перед фиксацией фигуры когда ее можно двигать </summary>
        public const float TimeCountdown = 0.5f;

        /// <summary>Время свободного падения фигуры</summary>
        public const float TimeDown = 0.6f;

        /// <summary>Время ускоренного падения фигуры</summary>
        public const float TimeForceDown = 0.1f;

        /// <summary>Время движения по горизонтали </summary>
        public const float TimeMove = 0.15f;

        /// <summary>Время поворота </summary>
        public const float TimeRotate = 0.2f;


        public static readonly Dictionary<TetriminoType, List<Vector2Int[]>> Tetriminos;

        public static readonly Dictionary<TetriminoType, Vector2Int> StartPos;

        public static readonly Dictionary<TetriminoType, int> TetriminoBlockId;

        static Const()
        {
            Tetriminos = new Dictionary<TetriminoType, List<Vector2Int[]>>();
            List<Vector2Int[]> I = new List<Vector2Int[]>
            {
                new[] {new Vector2Int(0, 0), new Vector2Int(1, 0), new Vector2Int(2, 0), new Vector2Int(3, 0)},
                new[] {new Vector2Int(1, -1), new Vector2Int(1, 0), new Vector2Int(1, 1), new Vector2Int(1, 2)},
                new[] {new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(2, 1), new Vector2Int(3, 1)},
                new[] {new Vector2Int(2, -1), new Vector2Int(2, 0), new Vector2Int(2, 1), new Vector2Int(2, 2)},
                
            };
            Tetriminos.Add(TetriminoType.I, I);

            List<Vector2Int[]> O = new List<Vector2Int[]>
            {
                new[] {new Vector2Int(1, 0), new Vector2Int(2, 0), new Vector2Int(1, 1), new Vector2Int(2, 1)},
                new[] {new Vector2Int(1, 0), new Vector2Int(2, 0), new Vector2Int(1, 1), new Vector2Int(2, 1)},
                new[] {new Vector2Int(1, 0), new Vector2Int(2, 0), new Vector2Int(1, 1), new Vector2Int(2, 1)},
                new[] {new Vector2Int(1, 0), new Vector2Int(2, 0), new Vector2Int(1, 1), new Vector2Int(2, 1)}
            };
            Tetriminos.Add(TetriminoType.O, O);

            List<Vector2Int[]> T = new List<Vector2Int[]>
            {
                new[] {new Vector2Int(1, 0), new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(2, 1)},
                new[] {new Vector2Int(1, 0), new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(1, 2)},
                new[] {new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(2, 1), new Vector2Int(1, 2)},
                new[] {new Vector2Int(1, 0), new Vector2Int(1, 1), new Vector2Int(2, 1), new Vector2Int(1, 2)}
            };
            Tetriminos.Add(TetriminoType.T, T);

            List<Vector2Int[]> L = new List<Vector2Int[]>
            {
                new[] {new Vector2Int(1, 0), new Vector2Int(1, 1), new Vector2Int(1, 2), new Vector2Int(2, 2)},
                new[] {new Vector2Int(2, 0), new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(2, 1)},
                new[] {new Vector2Int(0, 0), new Vector2Int(1, 0), new Vector2Int(1, 1), new Vector2Int(1, 2)},
                new[] {new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(2, 1), new Vector2Int(0, 2)}
            };
            Tetriminos.Add(TetriminoType.L, L);

            List<Vector2Int[]> J = new List<Vector2Int[]>
            {
                new[] {new Vector2Int(1, 0), new Vector2Int(1, 1), new Vector2Int(1, 2), new Vector2Int(0, 2)},
                new[] {new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(2, 1), new Vector2Int(2, 2)},
                new[] {new Vector2Int(1, 0), new Vector2Int(2, 0), new Vector2Int(1, 1), new Vector2Int(1, 2)},
                new[] {new Vector2Int(0, 0), new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(2, 1)}
            };
            Tetriminos.Add(TetriminoType.J, J);

            List<Vector2Int[]> S = new List<Vector2Int[]>
            {
                new[] {new Vector2Int(1, 0), new Vector2Int(2, 0), new Vector2Int(0, 1), new Vector2Int(1, 1)},
                new[] {new Vector2Int(0, 0), new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(1, 2)},
                new[] {new Vector2Int(1, 1), new Vector2Int(2, 1), new Vector2Int(0, 2), new Vector2Int(1, 2)},
                new[] {new Vector2Int(1, 0), new Vector2Int(1, 1), new Vector2Int(2, 1), new Vector2Int(2, 2)}
            };
            Tetriminos.Add(TetriminoType.S, S);

            List<Vector2Int[]> Z = new List<Vector2Int[]>
            {
                new[] {new Vector2Int(0, 0), new Vector2Int(1, 0), new Vector2Int(1, 1), new Vector2Int(2, 1)},
                new[] {new Vector2Int(1, 0), new Vector2Int(1, 1), new Vector2Int(0, 1), new Vector2Int(0, 2)},
                new[] {new Vector2Int(0, 1), new Vector2Int(1, 1), new Vector2Int(1, 2), new Vector2Int(2, 2)},
                new[] {new Vector2Int(2, 0), new Vector2Int(2, 1), new Vector2Int(1, 1), new Vector2Int(1, 2)}
            };
            Tetriminos.Add(TetriminoType.Z, Z);

            StartPos = new Dictionary<TetriminoType, Vector2Int>()
            {
                {TetriminoType.I, new Vector2Int(3, -0)},
                {TetriminoType.O, new Vector2Int(3, -0)},
                {TetriminoType.T, new Vector2Int(4, -0)},
                {TetriminoType.J, new Vector2Int(4, -0)},
                {TetriminoType.L, new Vector2Int(3, -0)},
                {TetriminoType.S, new Vector2Int(4, -0)},
                {TetriminoType.Z, new Vector2Int(3, -0)}
            };

            TetriminoBlockId = new Dictionary<TetriminoType, int>()
            {
                {TetriminoType.I, 102},
                {TetriminoType.O, 108},
                {TetriminoType.T, 106},
                {TetriminoType.J, 103},
                {TetriminoType.L, 105},
                {TetriminoType.S, 104},
                {TetriminoType.Z, 107}
            };
        }

        public static float ScreenCenter => (int) (Camera.main.orthographicSize * Camera.main.aspect);

       /// <summary>
       /// Проверка может ли находится фигура в данном месте
       /// </summary>
       /// <param name="Pos"></param>
       /// <param name="RotaryPos"></param>
       /// <param name="type"></param>
       /// <param name="CupBlock"></param>
       /// <returns></returns>
        public static bool CheckMove(Vector2Int Pos, int RotaryPos, TetriminoType type,int[,] CupBlock)
        {
            foreach (Vector2Int blockPos in Const.Tetriminos[type][RotaryPos])
            {
                Vector2Int p = Pos + blockPos;
                //Debug.Log(p);
                if (p.x < 0 || p.y < 0 || p.x >= Const.GameCupDx || p.y >= Const.GameCupDy) return false;
                if (CupBlock[p.x, p.y] != 0) return false;
            }

            return true;
        }
    }
}