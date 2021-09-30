using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Tetris
{
    public class AddButtonScript : MonoBehaviour
    {
        [MenuItem("My Tools/Generate/TetriminoBlock")]
        public static void GenerateTetriminoBlock()
        {
            GameObject BlockContainer = GameObject.Find("BlockContainer");
        }
    }
}
