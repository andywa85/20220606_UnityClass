using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNameSpace
{
    public class managerdead : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nametarget = "pink man";
        [SerializeField, Header("�����޲z��")]
        private managerfinal managerfinal;
        [SerializeField, Header("��v��")]
        private GameObject CM;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if (collision.name.Contains(nametarget))
            {
                managerfinal.enabled = true;
                managerfinal.stringtitle = "����";
                CM.SetActive(false);
            }
        }
    }
}
