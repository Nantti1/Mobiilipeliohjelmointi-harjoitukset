using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Harjoitukset
{
    public class HelloWorld : MonoBehaviour
    {
        int fibonacci = 0;
        int lastNum = 0;
        int helpNum = 0;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Hello World!");  
        }

        // Update is called once per frame
        void Update()
        {
            while (fibonacci < 1000)
            {
                Debug.Log(fibonacci);
                fibonacci += helpNum;
                    
                
                helpNum = lastNum;
                lastNum = fibonacci;
                if (fibonacci == 0)
                {
                    fibonacci = 1;
                    Debug.Log(fibonacci);
                }
            }
                

        }
    }

}
