using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Tetris
{
    public class TaskMenuManagerSript : MonoBehaviour
    {
        [Header("Gate")] [SerializeField] private GateScript Gate;

        [Header("SubMenuQuota")] [SerializeField]
        private GameObject SubMenuQuota;

        [SerializeField] private Text Line1;
        [SerializeField] private Text Line2;
        [SerializeField] private Text Line3;
        [SerializeField] private Text Line4;

        [Header("SubMenuDestroyBlock")] [SerializeField]
        private GameObject SubMenuDestroyBlock;

        [Header("SubMenuSurvive")] [SerializeField]
        private GameObject SubMenuSurvive;

        [SerializeField] private Text Seconds;

        // Start is called before the first frame update
        void Start()
        {
            int LevelNum = Settings.GetCurrentLevel();
            TextAsset levelJson = Resources.Load<TextAsset>("Levels/Level_" + LevelNum.ToString("D2"));
            LevelFormat level = JsonConvert.DeserializeObject<LevelFormat>(levelJson.text);

            if (level.isTaskDestroyBlock)
            {
                ShowDestroyBlockMenu(level);
            }

            if (level.isTaskSurvive)
            {
                ShowSurviveBlockMenu(level);
            }

            if (level.isTaskQuota)
            {
                ShowQuotaBlockMenu(level);
            }
            
            Gate.Open();
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
            SceneManager.LoadScene(2);
        }

        private void ShowDestroyBlockMenu(LevelFormat level)
        {
            SubMenuDestroyBlock.SetActive(true);
        }

        private void ShowSurviveBlockMenu(LevelFormat level)
        {
            SubMenuSurvive.SetActive(true);
            Seconds.text = ((int)level.Seconds).ToString("D2");
        }

        private void ShowQuotaBlockMenu(LevelFormat level)
        {
            SubMenuQuota.SetActive(true);

            if (level.Line1 > 0)
            {
                Line1.text = level.Line1.ToString("D2");
            }
            else
            {
                Line1.enabled = false;
            }

            if (level.Line2 > 0)
            {
                Line2.text = level.Line2.ToString("D2");
            }
            else
            {
                Line2.enabled = false;
            }


            if (level.Line3 > 0)
            {
                Line3.text = level.Line3.ToString("D2");
            }
            else
            {
                Line3.enabled = false;
            }

            if (level.Line4 > 0)
            {
                Line4.text = level.Line4.ToString("D2");
            }
            else
            {
                Line4.enabled = false;
            }
            
        }

        
    }
}