using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    sealed class GhostSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        private readonly EcsFilter<TetriminoComponent> _filterTet = null;
        private readonly EcsFilter<GameCupComponent> _filterCup = null;
            

        void IEcsRunSystem.Run()
        {
            if(_filterTet.IsEmpty())return;

            TetriminoComponent tetrimino = _filterTet.Get1(0);
            
            if(tetrimino.GhostPos.x==tetrimino.Pos.x && tetrimino.GhostRotaryPos==tetrimino.RotaryPos ) return;

            
            
            
            Vector2Int pos = tetrimino.Pos;
            
            for (int y = pos.y; y < Const.GameCupDy; y++)
            {
                pos+=Vector2Int.up;
                if(!Const.CheckMove(pos,tetrimino.RotaryPos,tetrimino.type,_filterCup.Get1(0).Block)) break;
            }

            pos-=Vector2Int.up;
            
            if (tetrimino.GhostRotaryPos != tetrimino.RotaryPos)
            {
                tetrimino.GhostScript.Rotate(tetrimino.RotaryPos);
                _filterTet.Get1(0).GhostRotaryPos = tetrimino.RotaryPos;    
            }
                
            _filterTet.Get1(0).GhostPos = pos;
            
            tetrimino.GhostObj.transform.localPosition =
                new Vector3(tetrimino.Obj.transform.localPosition.x, -pos.y * Const.CellSize);
        }
    }
}