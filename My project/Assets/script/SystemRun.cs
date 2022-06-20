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
        private int RunSpeed = 4;
        [SerializeField]
        private int JumpHigh = 8;
        private Animator ani;
        private Rigidbody2D rig;
        private bool Jumpclick;

        #endregion

        #region �\��:��{�Өt�Ϊ�������k
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

        #region �ƥ�:�{���J�f
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

