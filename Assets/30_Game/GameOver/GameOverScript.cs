using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tetris
{
    public class GameOverScript : MonoBehaviour
    {
        void Start()
        {
            StartCoroutine(GameOver());
        }

        private IEnumerator GameOver()
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(3);
        }
    }
}
