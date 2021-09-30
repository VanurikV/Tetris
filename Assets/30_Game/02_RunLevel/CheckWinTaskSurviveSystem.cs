using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class CheckWinTaskSurviveSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;

        private readonly EcsFilter<TaskSurviveComponent> _filter = null;

        void IEcsRunSystem.Run()
        {
            if (_filter.IsEmpty()) return;

            _filter.Get1(0).Seconds -= Time.deltaTime;

            if (_filter.Get1(0).SecondsInt == (int) _filter.Get1(0).Seconds) return;

            _filter.Get1(0).SecondsInt = (int) _filter.Get1(0).Seconds;
            _filter.Get1(0).text.text = _filter.Get1(0).SecondsInt.ToString("D2");

            if (_filter.Get1(0).Seconds > 1) return;

            _filter.GetEntity(0).Destroy();
            
            _global.Gate.Close();
            GameObject.Instantiate(_global.GameWinPrefab);
        }
    }
}