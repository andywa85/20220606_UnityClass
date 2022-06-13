//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace MyNameSpace
{
    /// <summary>
    /// API 使用方法
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        
        // Start is called before the first frame update
        private void Start()
        {
            /*
            print(Random.Range(0 , 101));
            Cursor.visible = false;
            */
            print(Camera.allCamerasCount);
            print(Application.platform);
            print(Mathf.Floor(9.999f));
            Application.OpenURL("https://unity.com/");
        }

        // Update is called once per frame
        private void Update()
        {
            print(Input.anyKeyDown);
            print(Time.realtimeSinceStartup);
            print(Input.GetButtonDown(" "));
        }
        
    }
}

