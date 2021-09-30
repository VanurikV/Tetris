using System;
using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class EcsStartup : MonoBehaviour
    {
        EcsWorld _world;
        EcsSystems _systems;
        GlobalData _global;

        private TetrisControls _controls;

        private void Awake()
        {
            _controls = new TetrisControls();
        }

        void Start()
        {
            // void can be switched to IEnumerator for support coroutines.

            _world = new EcsWorld();
            _systems = new EcsSystems(_world);
            _global = new GlobalData();
            _global.Controls = _controls;
           


#if UNITY_EDITOR
            Leopotam.Ecs.UnityIntegration.EcsWorldObserver.Create(_world);
            Leopotam.Ecs.UnityIntegration.EcsSystemsObserver.Create(_systems);
#endif
            _systems
                // register your systems here, for example:
                // .Add (new TestSystem1 ())
                .Add(new InitAllSystem())
                
                
                
                .Add(new SpawnTetriminoSystem())
                .Add(new CheckGameOverSystem())
                .Add(new MoveDownSystem())
                .Add(new PlayerControlSystem())
                .Add(new GhostSystem())
                .Add(new CountdownSystem())
                .Add(new CommitTetriminoSystem())
                .Add(new CheckFillLineSystem())
                .Add(new DropLineSystem())
                
                .Add(new CheckWinTaskQuotaSystem())
                .Add(new CheckWinTaskSurviveSystem())
                .Add(new CheckWinTaskDestroySystem())

                // register one-frame components (order is important), for example:
                
                .OneFrame<CheckGameOverComponent>()
                .OneFrame<CommitTetraminoComponent>()
                .OneFrame<CheckFillLineComponent>()
                
                .OneFrame<DropLineCountComponent>()
                
                
                // .OneFrame<TestComponent2> ()

                // inject service instances here (order doesn't important), for example:
                // .Inject (new CameraService ())
                .Inject(_global)
                .Init();
        }

        void Update()
        {
            _systems?.Run();
        }

        void OnDestroy()
        {
            if (_systems != null)
            {
                _systems.Destroy();
                _systems = null;
                _world.Destroy();
                _world = null;
            }
        }
        
        private void OnEnable()
        {
            _controls.Enable();
            //TouchSimulation.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }
        
    }
}