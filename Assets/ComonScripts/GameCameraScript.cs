using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public class GameCameraScript : MonoBehaviour
    {
        
        //Размер в пикселях для отображения * targetAspect
        private readonly float _widthSize = Const.CellSize*Const.GameCupDx+512;
        
        
        void Awake()
        {
           Camera _camera = Camera.main;
               
            _camera.orthographicSize = Mathf.Round(_widthSize / _camera.aspect/2);

            if (_camera.orthographicSize < 3000) _camera.orthographicSize = 2600;
            
            
            _camera.transform.position = new Vector3(_camera.aspect * _camera.orthographicSize, -_camera.orthographicSize, -10);
        }

       
    }
}
