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
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);
        // Start is called before the first frame update
        private void Start()
        {
            /*
            print(Random.Range(0 , 101));
            Cursor.visible = false;
            */
            print(Camera.allCamerasCount);
            print(Application.platform);
            Physics.sleepThreshold = 10;
            print(Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print(Time.timeScale);
            print(Vector3.Distance(a, b));
            print(Mathf.Floor(9.999f));
            Application.OpenURL("https://unity.com/");
        }

        // Update is called once per frame
        private void Update()
        {
            print(Input.anyKeyDown);
            print(Time.timeSinceLevelLoad);
            print(Input.GetButtonDown(" "));
        }
        
    }
}

