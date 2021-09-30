using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class CheckGameOverSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        private readonly EcsFilter<CheckGameOverComponent> _filter = null;

        private readonly EcsFilter<TetriminoComponent> _filterTet = null;
        private readonly EcsFilter<GameCupComponent> _filterCup = null;
        
        void IEcsRunSystem.Run()
        {
         
            if(_filter.IsEmpty())return;

            if (Const.CheckMove(_filterTet.Get1(0).Pos, _filterTet.Get1(0).RotaryPos, _filterTet.Get1(0).type,
                _filterCup.Get1(0).Block))  return;

            _filterTet.GetEntity(0).Destroy();
            
            _global.Gate.Close();
            GameObject.Instantiate(_global.GameOverPrefab);

        }
    }
}