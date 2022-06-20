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
        private int RunSpeed = 4;
        [SerializeField]
        private int JumpHigh = 8;
        private Animator ani;
        private Rigidbody2D rig;
        private bool Jumpclick;

        #endregion

        #region 功能:實現該系統的複雜方法
        private void Run()
        {
            rig.velocity = new Vector2(RunSpeed, rig.velocity.y);
        }
        private void Jumpkey()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Jumpclick = true;
            }
        }
        private void Jumpforus()
        {
            if(Jumpclick)
            {
                rig.AddForce(new Vector2(0, JumpHigh));
                Jumpclick = false;
            }
        }
        #endregion

        #region 事件:程式入口
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        private void Start()
        {
            
        }
        private void Update()
        {
            Run();
            Jumpkey();
        }
        private void FixedUpdate()
        {
            Jumpforus();
        }
        #endregion
    }
}

