using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public class BackgroundScript : MonoBehaviour
    {
        void Awake()
        {
            //CentrePosition
            gameObject.transform.position = new Vector3(Const.ScreenCenter , -500, 0);
        }

        
        
    }
}
