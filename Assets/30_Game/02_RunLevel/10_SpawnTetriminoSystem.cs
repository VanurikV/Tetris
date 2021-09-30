using System;
using Leopotam.Ecs;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Tetris
{
    sealed class SpawnTetriminoSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        private readonly EcsFilter<SpawnTetriminoComponent> _filter = null;

        void IEcsRunSystem.Run()
        {
            if(_filter.IsEmpty())return;

            TetriminoComponent tetrimino = new TetriminoComponent();

            TetriminoType type = GetRandomTetrimino();
            //type = TetriminoType.Z;

            tetrimino.type = type;
            tetrimino.Pos = Const.StartPos[type];
            tetrimino.Obj = GameObject.Instantiate(_global.TetriminoPrefab[type], _global.TetriminoContainer);
            tetrimino.Script = tetrimino.Obj.GetComponent<TetriminoScript>();
            tetrimino.Obj.transform.localPosition = new Vector3(tetrimino.Pos.x * Const.CellSize, -tetrimino.Pos.y * Const.CellSize);
            tetrimino.ElapseTimeToDown = Const.TimeDown * _global.SpeedMultiplier;

            
            tetrimino.GhostObj = GameObject.Instantiate(_global.GhostPrefab[type], _global.TetriminoContainer);
            tetrimino.GhostScript = tetrimino.GhostObj.GetComponent<TetriminoScript>();
            tetrimino.GhostObj.transform.localPosition = new Vector3(tetrimino.Pos.x * Const.CellSize, -tetrimino.Pos.y * Const.CellSize);
            tetrimino.GhostPos = new Vector2Int(-1, -1);

            
            ClearFilter();
            
            EcsEntity ent = _world.NewEntity();
            ent.Get<TetriminoComponent>() = tetrimino;
            
            EcsEntity ent1 = _world.NewEntity();
            ent1.Get<CheckGameOverComponent>();
            
            
        }

        private TetriminoType GetRandomTetrimino()
        {
            if (Settings.GetDifficulty() == 1) return GetNormal();
            if (Settings.GetDifficulty() == 2) return GetHard();
            return GetEase();
        }

        private TetriminoType GetHard()
        {
            int r = Random.Range(0, 101);

            if (r >= 86) return TetriminoType.Z;
            if (r >= 72) return TetriminoType.S;
            if (r >= 58) return TetriminoType.L;
            if (r >= 44) return TetriminoType.J;
            if (r >= 30) return TetriminoType.T;
            if (r >= 16) return TetriminoType.O;
            return TetriminoType.I;
        }
        
        private TetriminoType GetNormal()
        {
            int r = Random.Range(0, 101);

            if (r >= 90) return TetriminoType.Z;
            if (r >= 80) return TetriminoType.S;
            if (r >= 64) return TetriminoType.L;
            if (r >= 48) return TetriminoType.J;
            if (r >= 32) return TetriminoType.T;
            if (r >= 16) return TetriminoType.O;
            return TetriminoType.I;
        }
        
        private TetriminoType GetEase()
        {
            int r = Random.Range(0, 101);

            if (r >= 94) return TetriminoType.Z;
            if (r >= 88) return TetriminoType.S;
            if (r >= 69) return TetriminoType.L;
            if (r >= 53) return TetriminoType.J;
            if (r >= 36) return TetriminoType.T;
            if (r >= 19) return TetriminoType.O;
            return TetriminoType.I;
        }
        
        
        private void ClearFilter()
        {
            foreach (int i in _filter)
            {
                _filter.GetEntity(i).Destroy();
            }
        }
        
    }
}