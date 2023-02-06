using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Harjoitukset
{
    public class Liikkuminen : MonoBehaviour
    {

        //[SerializeField] private float maxYPiste = 0;
        //[SerializeField] private float yPiste = -2;
        private Rigidbody2D rigid;
        private float speed = 5f;
      

        //private Vector3 direction = new(0, 0, 0);

        // Start is called before the first frame update
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();

            //direction = direction.normalized;

        }

        // Update is called once per frame
        void Update()
        {
            //bool d = Input.GetKey(KeyCode.D);
            //bool a = Input.GetKey(KeyCode.A);


            // Tässä ratkaisu
            //float xMove = Input.GetAxisRaw("Horizontal");
            //float zMove = Input.GetAxisRaw("Vertical"); 
            //rigid.velocity = new Vector3(xMove, 0, 0) * speed;

            


        }
    }
}


