using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public class TetriminoScript : MonoBehaviour
    {
        public GameObject RotaryPivot;
        

        public void Rotate(int index)
        {
            RotaryPivot.transform.eulerAngles=new Vector3(0,0,90*index);
            
        }
        
       
    }
}
