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
        private int RunSpeed = 1;
        [SerializeField]
        private int JumpHigh = 8;
        [SerializeField , Header("檢查地板尺寸")]
        private Vector3 v3checkgroundsize = Vector3.one;
        [SerializeField , Header("檢查地板位移")]
        private Vector3 v3checkgroundoff;
        [SerializeField , Header("檢查地板顏色")]
        private Color colorcheckground = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField , Header("檢查地板圖層")]
        private LayerMask layrtgroundcheck;
        [SerializeField, Header("跳躍開關")]
        private string namejump = "跳開關";
        private Animator ani;
        private Rigidbody2D rig;
        private bool Jumpclick;
        private bool isground;

        #endregion

        #region 功能:實現該系統的複雜方法
        private void Run()
        {
            rig.velocity = new Vector2(RunSpeed, rig.velocity.y);
        }
        private void Jumpkey()
        {
            if(Input.GetKeyDown(KeyCode.Space) && isground)
            {
                Jumpclick = true;
            }
            else if(Input.GetKeyUp(KeyCode.Space))
            {
                Jumpclick = false;
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
        private void groundcheck()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3checkgroundoff, v3checkgroundsize, 0, layrtgroundcheck);
            //print(hit.name);
            isground = true;
        }
        private void updateanimtor()
        {
            ani.SetBool(namejump, !isground);
        }
        #endregion

        #region 事件:程式入口
        private void OnDrawGizmos()
        {
            Gizmos.color = colorcheckground;
            Gizmos.DrawCube(transform.position + v3checkgroundoff, v3checkgroundsize);
        }
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
            groundcheck();
            updateanimtor();
        }
        private void FixedUpdate()
        {
            Jumpforus();
        }
        private void OnEnable()
        {
            
        }
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
        }
        #endregion
    }
}

