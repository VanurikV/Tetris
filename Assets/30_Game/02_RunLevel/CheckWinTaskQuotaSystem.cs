using Leopotam.Ecs;
using TMPro;
using UnityEngine;

namespace Tetris
{
    sealed class CheckWinTaskQuotaSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        
        private readonly EcsFilter<TaskQuotaComponent> _filter = null;
        private readonly EcsFilter<DropLineCountComponent> _filterLine = null;
        
        void IEcsRunSystem.Run()
        {
            if(_filter.IsEmpty() || _filterLine.IsEmpty()) return;

            TaskQuotaComponent quota = _filter.Get1(0);
            int DropLineCount = _filterLine.Get1(0).DropLineCount;

            while (DropLineCount>0)
            {
                if(DropLineCount==4 && quota.Line4>0)
                {
                    quota.Line4--;
                    DropLineCount -= 4;
                }             
                
                if(DropLineCount>=3 && quota.Line3>0)
                {
                    quota.Line3--;
                    DropLineCount -= 3;
                }
                
                if(DropLineCount>=2 && quota.Line2>0)
                {
                    quota.Line2--;
                    DropLineCount -= 2;
                    continue;
                }
                
                quota.Line1--;
                DropLineCount -= 1;
            }

            _filter.Get1(0) = quota;

            _filter.Get1(0).textLine4.text = quota.Line4.ToString("D2");
            _filter.Get1(0).textLine3.text = quota.Line3.ToString("D2");
            _filter.Get1(0).textLine2.text = quota.Line2.ToString("D2");

            if (quota.Line1 > 0)
            {
                _filter.Get1(0).textLine1.text = quota.Line1.ToString("D2");
            }
            else
            {
                _filter.Get1(0).textLine1.text = "00";
            }

            if (quota.Line4 != 0 || quota.Line3 != 0 || quota.Line2 != 0 || quota.Line1 > 0) return;
            
            _filter.GetEntity(0).Destroy();
            
            _global.Gate.Close();
            GameObject.Instantiate(_global.GameWinPrefab);
            
        }
    }
}