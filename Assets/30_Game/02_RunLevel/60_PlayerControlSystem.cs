using Leopotam.Ecs;
using UnityEngine;
using UnityEngine.UI;

namespace Tetris
{
    sealed class PlayerControlSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private readonly GlobalData _global = null;
        private readonly EcsFilter<TetriminoComponent> _filterTet = null;
        private readonly EcsFilter<GameCupComponent> _filterCup = null;

        void IEcsRunSystem.Run()
        {
            if(_filterTet.IsEmpty())return;

            _filterTet.Get1(0).ElapseTimeToMove -= Time.deltaTime;
            _filterTet.Get1(0).ElapseTimeToRotate -= Time.deltaTime;
            _filterTet.Get1(0).ElapseTimeToForceDown -= Time.deltaTime;
            
            if(_filterTet.Get1(0).ElapseTimeToMove<0)
            {
                if (_global.Controls.KeyboardTetrisControl.MoveLeft.ReadValue<float>() > 0) Move(Vector2Int.left);
                if (_global.Controls.KeyboardTetrisControl.MoveRight.ReadValue<float>() > 0) Move(Vector2Int.right);
                //if(GameObject.Find("ButtonLeft").GetComponent<Button>().
            }

            if (_filterTet.Get1(0).ElapseTimeToRotate < 0)
            {
                if (_global.Controls.KeyboardTetrisControl.RotateLeft.ReadValue<float>() > 0) Rotate(1);
                if (_global.Controls.KeyboardTetrisControl.RotateRight.ReadValue<float>() > 0) Rotate(-1);
            }

            if (_filterTet.Get1(0).ElapseTimeToForceDown < 0)
            {
                if (_global.Controls.KeyboardTetrisControl.Down.ReadValue<float>() > 0) Move(Vector2Int.up);
            }
        }

        private void Move(Vector2Int dir)
        {
            if (!CheckMove(dir)) return;
            

                _filterTet.Get1(0).ElapseTimeToMove = Const.TimeMove;
                _filterTet.Get1(0).ElapseTimeToForceDown = Const.TimeForceDown;
                
                Vector2Int pos = _filterTet.Get1(0).Pos;

                pos += dir;

                _filterTet.Get1(0).Pos = pos;

                _filterTet.Get1(0).Obj.transform.localPosition =
                    new Vector3(pos.x * Const.CellSize, -pos.y * Const.CellSize);

                if (dir.y == 0)
                {
                    SoundManager.Manager.PlaySfx(SfxClip.Move_Click);
                }
                else
                {
                    SoundManager.Manager.PlaySfx(SfxClip.Fallingdown);
                }
            
        }

        private void Rotate(int rotateDir)
        {

            int newRotate = _filterTet.Get1(0).RotaryPos + rotateDir;
            if (newRotate < 0) newRotate = 3;
            if (newRotate > 3) newRotate = 0;
            
            
            if (!CheckRotate(newRotate)) return;
            
            _filterTet.Get1(0).ElapseTimeToRotate = Const.TimeRotate;
            
            _filterTet.Get1(0).RotaryPos = newRotate;
            _filterTet.Get1(0).Script.Rotate(newRotate);
            
            SoundManager.Manager.PlaySfx(SfxClip.Rotate_Click);
            
        }
        

        private bool CheckMove(Vector2Int dir)
        {
            return Const.CheckMove(
                _filterTet.Get1(0).Pos + dir,
                _filterTet.Get1(0).RotaryPos, 
                _filterTet.Get1(0).type,
                _filterCup.Get1(0).Block);
        }
        
        private bool CheckRotate(int rotate)
        {
            return Const.CheckMove(
                _filterTet.Get1(0).Pos,
                rotate, 
                _filterTet.Get1(0).type,
                _filterCup.Get1(0).Block);
        }
    }
}