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
        private float speed = 10f;
      

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

            float xMove = Input.GetAxisRaw("Horizontal");
            float zMove = Input.GetAxisRaw("Vertical"); 

            rigid.velocity = new Vector3(xMove, 0, 0) * speed;

            //Vector2 movement = direction * 2 * Time.deltaTime;

            //float moveInput = Input.GetAxisRaw("Horizontal");
            //velocity.x = Mathf.MoveTowards(velocity.x, 1, moveInput, 1 * Time.deltaTime);


            //if (d)
            //{
            //    direction.y = 1;
            //    rigid.MovePosition(movement);
            //}
            //if (a)
            //{
            //    direction.x = -1;
            //    rigid.MovePosition(movement);
            //}

        }
    }
}


