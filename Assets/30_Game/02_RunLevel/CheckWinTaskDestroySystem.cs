using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class CheckWinTaskDestroySystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        
        private readonly EcsFilter<TaskDestroyBlockComponent> _filter = null;
        private readonly EcsFilter<GameCupComponent> _filterCup = null;
        
        void IEcsRunSystem.Run()
        {
            if (_filter.IsEmpty()) return;
            
            
            //if found blocID>900
            foreach (int i in _filterCup.Get1(0).Block)
            {
                if(i>=900) return;
            }
            _filter.GetEntity(0).Destroy();
            
            _global.Gate.Close();
            GameObject.Instantiate(_global.GameWinPrefab);

        }
    }
}