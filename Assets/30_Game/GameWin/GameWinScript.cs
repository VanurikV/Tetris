using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tetris
{
    public class GameWinScript : MonoBehaviour
    {
        void Start()
        {
            StartCoroutine(GameOver());
        }

        private IEnumerator GameOver()
        {
            yield return new WaitForSeconds(1);
            Settings.LevelComplete(Settings.GetCurrentLevel());
            SceneManager.LoadScene(4);
        }

       
    }
}
