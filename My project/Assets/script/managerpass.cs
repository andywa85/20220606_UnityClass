using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNameSpace
{
    public class managerpass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nametarget = "pink man";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun SystemRun;
        [SerializeField, Header("�����޲z��")]
        private managerfinal managerfinal;

        /// <summary>
        /// �޲z�L��
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
                managerfinal.stringtitle = "�L��!";
            }
        }
        #endregion
    }
}
