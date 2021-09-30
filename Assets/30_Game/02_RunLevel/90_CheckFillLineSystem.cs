using System.Collections.Generic;
using System.Linq;
using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class CheckFillLineSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        private readonly EcsFilter<CheckFillLineComponent> _filter = null;
        private readonly EcsFilter<GameCupComponent> _filterCup = null;


        void IEcsRunSystem.Run()
        {
            if (_filter.IsEmpty()) return;


            List<int> FillLine = GetFillLine();
            if (FillLine.Count == 0)
            {
                EcsEntity ent1 = _world.NewEntity();
                ent1.Get<SpawnTetriminoComponent>();
                return;
            }

            foreach (int line in FillLine)
            {
                EraseLine(line);
                CreteLine(line);
            }

            FillLine.Reverse();

            EcsEntity ent = _world.NewEntity();
            ent.Get<DropLineComponent>().DropLine = FillLine;
            ent.Get<DropLineComponent>().PauseTime = -0.3f;
        }

        private List<int> GetFillLine()
        {
            List<int> FillLine = new List<int>();


            int[,] cupBlock = _filterCup.Get1(0).Block;


            for (int y = 0; y < Const.GameCupDy; y++)
            {
                int l = 0;
                for (int x = 0; x < Const.GameCupDx; x++)
                {
                    if (cupBlock[x, y] == 0) continue;
                    l++;
                }

                if (l == Const.GameCupDx) FillLine.Add(y);
            }

            return FillLine;
        }

        private void EraseLine(int line)
        {
            int[,] cupBlock = _filterCup.Get1(0).Block;
            GameObject[,] cupObjects = _filterCup.Get1(0).Objects;

            for (int x = 0; x < Const.GameCupDx; x++)
            {
                cupBlock[x, line] = 0;
                GameObject.Destroy(cupObjects[x, line]);
                cupObjects[x, line] = null;
            }
        }

        private void CreteLine(int line)
        {
            GameObject o = GameObject.Instantiate(_global.LinePrefab, _global.BlockContainer);
            o.transform.localPosition = new Vector3(0, -line * Const.CellSize);
        }
    }
}