using Leopotam.Ecs;
using Newtonsoft.Json;
using UnityEngine;

namespace Tetris
{
    sealed partial class InitAllSystem : IEcsInitSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;

        private LevelFormat _level;
        
        public void Init()
        {
            _level = LoadLevel(Settings.GetCurrentLevel());
            GlobalInit();
            CreateCup();
            CreateLevelCompleteTask();
            
            //_global.Gate.Open();

            EcsEntity ent = _world.NewEntity();
            ent.Get<SpawnTetriminoComponent>();

        }


        private LevelFormat LoadLevel(int LevelNum)
        {
            TextAsset levelJson = Resources.Load<TextAsset>("Levels/Level_" + LevelNum.ToString("D2"));
            return JsonConvert.DeserializeObject<LevelFormat>(levelJson.text);
        }
        
    }
}