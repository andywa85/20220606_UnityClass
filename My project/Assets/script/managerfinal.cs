using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace MyNameSpace
{
    public class managerfinal : MonoBehaviour
    {
        /// <summary>
        /// 遊戲結束
        /// </summary>
        [SerializeField, Header("Canvas")]
        private CanvasGroup groupfinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textfinal;

        public string stringtitle;

        private void Start()
        {
            textfinal.text = stringtitle;
            InvokeRepeating("fadein", 0, 0.01f);
        }

        /// <summary>
        /// 淡入
        /// </summary>
        private void fadein()
        {
            groupfinal.alpha += 0.1f;
            if (groupfinal.alpha>=1)
            {
                groupfinal.interactable = true;
                groupfinal.blocksRaycasts = true;
                CancelInvoke("fadein");
            }
        }
        public void quit()
        {
            //print("game over");
            Application.Quit();
        }
        public void replay()
        {
            SceneManager.LoadScene(0);
        }
    }
}