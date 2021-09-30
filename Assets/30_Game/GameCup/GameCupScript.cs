using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public class GameCupScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Awake()
        {
            gameObject.transform.position = new Vector3(Const.ScreenCenter , -200, 0);
        }

    }
}
