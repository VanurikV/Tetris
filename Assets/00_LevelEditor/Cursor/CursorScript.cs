using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Tetris
{
    public class CursorScript : MonoBehaviour
    {
        public int CurX;
        public int CurY;

        public int PosX;
        public int PosY;
        
        
        private Vector3 mousePosition;
        private Camera _camera;
        private TetrisControls _controls;
        private LevelManagerScript _levelManagerScript;

        

        // Start is called before the first frame update
        void Awake()
        {
            _camera = Camera.main;
            _controls = new TetrisControls();
            _levelManagerScript = GameObject.Find("LevelManager").GetComponent<LevelManagerScript>();
        }

        // Update is called once per frame
        void Update()
        {

            mousePosition = _controls.Mouse.MousePos.ReadValue<Vector2>();
                
            mousePosition = _camera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));

            CurX = (int) (mousePosition.x / 200);
            CurY = (int) (mousePosition.y / 200);

            PosX = CurX - 18;
            PosY = -CurY -1;
            
            transform.position = new Vector3(CurX * 200, CurY * 200);
            
            if (_controls.Mouse.MouseL.ReadValue<float>()>0)
            {
                //Debug.Log("LMB");
                
                if(PosX<0 || PosX>9) return;
                if(PosY<0 || PosY>19) return;
                if(transform.childCount==0) return;

                int code = int.Parse(transform.GetChild(0).name.Substring(0, 4));
                _levelManagerScript.onMouseClick(PosX,PosY,code);
            }
            
            
        }

        private void OnEnable()
        {
            _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

       
    }
}