using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tetris
{
    public class GameWinMenuManager : MonoBehaviour
    {
        [Header("Gate")] [SerializeField] private GateScript Gate;

        private void Start()
        {
            Gate.Open();
        }


        public void onButtonHome()
        {
            StartCoroutine(GetHome());
        }


        private IEnumerator GetHome()
        {
            Gate.Close();
            yield return new WaitForSeconds(1);
            SoundManager.Manager.UI_Click();
            SceneManager.LoadScene(0);
        }
        
        
        public void onButtonPlay()
        {
            StartCoroutine(GetPlay());
        }


        private IEnumerator GetPlay()
        {
            Gate.Close();
            yield return new WaitForSeconds(1);
            SoundManager.Manager.UI_Click();
            SceneManager.LoadScene(1);
        }
    }
}
