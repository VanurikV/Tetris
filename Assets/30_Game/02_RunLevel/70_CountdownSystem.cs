using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class CountdownSystem : IEcsRunSystem
    {
        // auto-injected fields.
        private readonly EcsWorld _world = null;
        private readonly EcsFilter<CountdownComponent> _filter = null;

        void IEcsRunSystem.Run()
        {
            if (_filter.IsEmpty()) return;
            _filter.Get1(0).countdownTime -= Time.deltaTime;
            
            if(_filter.Get1(0).countdownTime>0) return;

            ClearFilter();
            EcsEntity ent = _world.NewEntity();
            ent.Get<CommitTetraminoComponent>();
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