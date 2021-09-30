using System.Collections.Generic;
using System.Linq;
using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class DropLineSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        
        private readonly EcsFilter<DropLineComponent> _filter = null;
        private readonly EcsFilter<GameCupComponent> _filterCup = null;
        
        
        void IEcsRunSystem.Run()
        {
            if(_filter.IsEmpty())return;
            
            _filter.Get1(0).PauseTime -= Time.deltaTime;
            if (_filter.Get1(0).PauseTime>0) return;
                        

            for (int l = 0; l < _filter.Get1(0).DropLine.Count; l++)
            {
                DropLine(_filter.Get1(0).DropLine[l] +l);
            }

            
            EcsEntity ent = _world.NewEntity();
            ent.Get<DropLineCountComponent>().DropLineCount = _filter.Get1(0).DropLine.Count;
            
            ClearFilter();
            
            ent = _world.NewEntity();
            ent.Get<SpawnTetriminoComponent>();
            
        }

        private void DropLine(int line)
        {
            for (int y = line; y > 0; y--)
            { 
                DownLine(y);
            }
        }
            
        

        private void DownLine(int ToLine)
        {
            int[,] cupBlock = _filterCup.Get1(0).Block;
            GameObject[,] cupObjects =_filterCup.Get1(0).Objects;

            int FromLine =ToLine- 1;
            
            for (int x = 0; x < Const.GameCupDx; x++)
            {
                cupBlock[x, ToLine] = cupBlock[x, FromLine];
                cupBlock[x, FromLine] = 0;
                
                if(cupObjects[x, FromLine] is null) continue;
                
                cupObjects[x, ToLine] = cupObjects[x, FromLine];
                cupObjects[x, FromLine] = null;
                cupObjects[x, ToLine].transform.localPosition = new Vector3(cupObjects[x, ToLine].transform.localPosition.x, -(ToLine) * Const.CellSize);
            }
            
            SoundManager.Manager.PlaySfx(SfxClip.DropLine);
            
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