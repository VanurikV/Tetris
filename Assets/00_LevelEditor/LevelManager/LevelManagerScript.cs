using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Toggle = UnityEngine.UI.Toggle;

namespace Tetris
{
    public partial class LevelManagerScript : MonoBehaviour
    {
        public int CurLevel;
        public Text CurLevelText;
        public Transform BlockContainer;


        private Dictionary<int, GameObject> BlockPrefab;
        private LevelFormat _levelFormat;
        public GameObject[,] _levelObj;

        [Header("Toggle")]
        public Toggle ToggleDestroy;
        public Toggle ToggleSurvive;
        public Toggle ToggleQuota;

        [Header("SurviveText")]
        public InputField SurviveText;
        public InputField SpeedMul;
        
        [Header("Line")]
        public InputField Line1Text;
        public InputField Line2Text;
        public InputField Line3Text;
        public InputField Line4Text;
        
        // Start is called before the first frame update
        void Start()
        {
            LoadBlock();
            RebuildMap();
        }


        public void onMouseClick(int x,int y,int code)
        {
            _levelFormat.Block[x, y] = code;
            GameObject.Destroy(_levelObj[x, y]);
            
            GameObject o = GameObject.Instantiate(BlockPrefab[_levelFormat.Block[x, y]], BlockContainer);
            o.transform.localPosition = new Vector3(x * Const.CellSize, -y * Const.CellSize);
            _levelObj[x, y] = o;
        }
        
        private void RebuildMap()
        {
            foreach (Transform child in BlockContainer)
            {
                GameObject.Destroy(child.gameObject);
            }

            _levelFormat = LoadLevel(CurLevel);
            _levelObj = new GameObject[Const.GameCupDx, Const.GameCupDy];
            
            for (int x = 0; x < Const.GameCupDx; x++)
            {
                for (int y = 0; y < Const.GameCupDy; y++)
                {
                    
                    if( _levelFormat.Block[x, y]==0) continue;

                    GameObject o = GameObject.Instantiate(BlockPrefab[_levelFormat.Block[x, y]], BlockContainer);
                    o.transform.localPosition = new Vector3(x * Const.CellSize, -y * Const.CellSize);
                    _levelObj[x, y] = o;
                }
            }

            CurLevelTextUpdate();
            CurLevelTaskUpdate();


        }
    }
}