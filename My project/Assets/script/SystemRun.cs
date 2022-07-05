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
        private int RunSpeed = 1;
        [SerializeField]
        private int JumpHigh = 8;
        [SerializeField , Header("�ˬd�a�O�ؤo")]
        private Vector3 v3checkgroundsize = Vector3.one;
        [SerializeField , Header("�ˬd�a�O�첾")]
        private Vector3 v3checkgroundoff;
        [SerializeField , Header("�ˬd�a�O�C��")]
        private Color colorcheckground = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField , Header("�ˬd�a�O�ϼh")]
        private LayerMask layrtgroundcheck;
        [SerializeField, Header("���D�}��")]
        private string namejump = "���}��";
        private Animator ani;
        private Rigidbody2D rig;
        private bool Jumpclick;
        private bool isground;

        #endregion

        #region �\��:��{�Өt�Ϊ�������k
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

        #region �ƥ�:�{���J�f
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

