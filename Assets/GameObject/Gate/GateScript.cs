using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public class GateScript : MonoBehaviour
    {
        private Animator _animator;
        private static readonly int OpenAnimationHash = Animator.StringToHash("OpenAnimation");
        private static readonly int CloseAnimationHash = Animator.StringToHash("CloseAnimation");
        
        void Awake()
        {
            //CentrePosition
            gameObject.transform.position = new Vector3(Const.ScreenCenter , 0, 0);
            _animator = gameObject.GetComponent<Animator>();
        }

        public void Close()
        {
            SoundManager.Manager.PlaySfx(SfxClip.SciFiDoor);
            _animator.Play(CloseAnimationHash);
        }

        public void Open()
        {
            SoundManager.Manager.PlaySfx(SfxClip.SciFiDoor);
            _animator.Play(OpenAnimationHash);
        }
        
    }
}
