using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNameSpace
{
    public class managerdead : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nametarget = "pink man";
        [SerializeField, Header("結束管理器")]
        private managerfinal managerfinal;
        [SerializeField, Header("攝影機")]
        private GameObject CM;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if (collision.name.Contains(nametarget))
            {
                managerfinal.enabled = true;
                managerfinal.stringtitle = "失敗";
                CM.SetActive(false);
            }
        }
    }
}
