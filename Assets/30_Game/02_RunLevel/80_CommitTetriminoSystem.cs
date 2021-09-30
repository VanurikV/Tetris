using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class CommitTetriminoSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        
        private readonly EcsFilter<CommitTetraminoComponent> _filterCommit = null;
        private readonly EcsFilter<TetriminoComponent> _filterTet = null;
        private readonly EcsFilter<GameCupComponent> _filterCup = null;

        void IEcsRunSystem.Run()
        {
            if(_filterCommit.IsEmpty())return;

            TetriminoComponent tetrimino = _filterTet.Get1(0);
            Vector2Int pos = tetrimino.Pos;
            int[,] CupBlock = _filterCup.Get1(0).Block;
            GameObject[,] cuObjects = _filterCup.Get1(0).Objects;

            foreach (Vector2Int blockPos in Const.Tetriminos[tetrimino.type][tetrimino.RotaryPos])
            {
                Vector2Int p = pos + blockPos;
                CupBlock[p.x, p.y] = Const.TetriminoBlockId[tetrimino.type];
                cuObjects[p.x, p.y] = GameObject.Instantiate(_global.BlockPrefab[CupBlock[p.x, p.y]], _global.BlockContainer);
                cuObjects[p.x, p.y].transform.localPosition = new Vector3(p.x * Const.CellSize, -p.y * Const.CellSize);
            }
            
            
            SoundManager.Manager.PlaySfx(SfxClip.Commit);
            
            GameObject.Destroy(tetrimino.Obj);
            GameObject.Destroy(tetrimino.GhostObj);
            
            _filterTet.GetEntity(0).Destroy();
            
            EcsEntity ent = _world.NewEntity();
            ent.Get<CheckFillLineComponent>();

        }
    }
}