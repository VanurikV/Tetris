using System.Threading;
using Leopotam.Ecs;
using UnityEngine;


namespace Tetris
{
    sealed class MoveDownSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        private readonly EcsFilter<CountdownComponent> _filterCountdown = null;
        private readonly EcsFilter<TetriminoComponent> _filterTet = null;
        private readonly EcsFilter<GameCupComponent> _filterCup = null;
        

        void IEcsRunSystem.Run()
        {
            if (_filterTet.IsEmpty()) return;

            _filterTet.Get1(0).ElapseTimeToDown -= Time.deltaTime;
            if (_filterTet.Get1(0).ElapseTimeToDown > 0) return;

            if (Const.CheckMove(_filterTet.Get1(0).Pos+Vector2Int.up,_filterTet.Get1(0).RotaryPos, _filterTet.Get1(0).type,_filterCup.Get1(0).Block))
            {
                if (!_filterCountdown.IsEmpty()) _filterCountdown.GetEntity(0).Destroy();
                
                _filterTet.Get1(0).ElapseTimeToDown = Const.TimeDown * _global.SpeedMultiplier;
                
                Vector2Int pos = _filterTet.Get1(0).Pos;
                pos += Vector2Int.up;
                _filterTet.Get1(0).Pos = pos;
                _filterTet.Get1(0).Obj.transform.localPosition =
                    new Vector3(pos.x * Const.CellSize, -pos.y * Const.CellSize);
            }
            else
            {
                if (_filterCountdown.IsEmpty())
                {
                    EcsEntity ent = _world.NewEntity();
                    ent.Get<CountdownComponent>().countdownTime = Const.TimeCountdown;
                }
            }

        }
    
        
    }
}