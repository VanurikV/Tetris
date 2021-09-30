using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Tetris
{
    public class LevelMenuButtonScript : MonoBehaviour
    {
        private MainMenuManagerScript _managerScript;

        [SerializeField] private Text _text;
        [SerializeField] private Button _button;
        [SerializeField] private Image _image;

        void Awake()
        {
            _managerScript = GameObject.Find("MainMenuManager").GetComponent<MainMenuManagerScript>();
        }

        public void onButtonClick()
        {
            _managerScript.onButtonLevelClick(int.Parse(_text.text));
        }

        public void SetLock(bool state)
        {
            _button.interactable = !state;
            _image.enabled = state;
        }
    }
}