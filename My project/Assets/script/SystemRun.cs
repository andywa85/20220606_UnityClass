//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
namespace MyNameSpace
{
    /// <summary>
    /// �]�B
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        /*
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        */
        #region ���:�O�s�t�λݭn�����
        [SerializeField , Header("�]�t") , Tooltip("���⪺�]�t") , Range( 0 , 128 )]
        private int RunSpeed = 16;
        [SerializeField]
        private int JumpHigh = 8;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region �\��:��{�Өt�Ϊ�������k

        #endregion

        #region �ƥ�:�{���J�f
        private void Start()
        {
            print("Hollow World!!!")
        }
        #endregion
    }
}

