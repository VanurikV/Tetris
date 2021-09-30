using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public class HexScript : MonoBehaviour
    {
        public float Speed;
        private Transform _transform;

        private void Start()
        {
            _transform = gameObject.transform;
        }

        void Update()
        {
            
            _transform.position = new Vector3(_transform.position.x, _transform.position.y + Speed * Time.deltaTime);
            if(_transform.position.y<-6000)GameObject.Destroy(gameObject);
        }
    }
}
