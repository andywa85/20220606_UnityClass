//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
namespace MyNameSpace
{
    /// <summary>
    /// 跑步
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
        #region 資料:保存系統需要的資料
        [SerializeField , Header("跑速") , Tooltip("角色的跑速") , Range( 0 , 128 )]
        private int RunSpeed = 16;
        [SerializeField]
        private int JumpHigh = 8;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region 功能:實現該系統的複雜方法

        #endregion

        #region 事件:程式入口
        private void Start()
        {
            print("Hollow World!!!")
        }
        #endregion
    }
}

