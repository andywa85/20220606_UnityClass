using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNameSpace
{
    public class APInonStatic : MonoBehaviour
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
        [SerializeField]
        private GameObject Pinkman;
        private void Start()
        {
            print(Pinkman.activeInHierarchy);
            Pinkman.tag = "Player";
        }

    }
}

