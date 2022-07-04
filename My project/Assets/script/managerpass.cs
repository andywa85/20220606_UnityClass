using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNameSpace
{
    public class managerpass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nametarget = "pink man";
        [SerializeField, Header("跑步系統")]
        private SystemRun SystemRun;
        [SerializeField, Header("結束管理器")]
        private managerfinal managerfinal;

        /// <summary>
        /// 管理過關
        /// </summary>
        /// <param name="collision"></param>
        #region
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if(collision.name.Contains(nametarget))
            {
                SystemRun.enabled = false;
                managerfinal.enabled = true;
                managerfinal.stringtitle = "過關!";
            }
        }
        #endregion
    }
}
