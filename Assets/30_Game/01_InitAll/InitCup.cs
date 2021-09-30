using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed partial class InitAllSystem
    {
        private void CreateCup()
        {
            EcsEntity ent = _world.NewEntity();
            ent.Get<GameCupComponent>().Block = new int[Const.GameCupDx, Const.GameCupDy];
            ent.Get<GameCupComponent>().Objects = new GameObject[Const.GameCupDx, Const.GameCupDy];
            
            for (int x = 0; x < Const.GameCupDx; x++)
            {
                for (int y = 0; y < Const.GameCupDy; y++)
                {
                    ent.Get<GameCupComponent>().Block[x, y] = _level.Block[x, y];
                    
                    if(_level.Block[x, y]==0) continue;

                    GameObject o = GameObject.Instantiate(_global.BlockPrefab[_level.Block[x, y]], _global.BlockContainer);
                    o.transform.localPosition = new Vector3(x * Const.CellSize, -y * Const.CellSize);
                    ent.Get<GameCupComponent>().Objects[x, y] = o;
                }
            }
        }
    }
}