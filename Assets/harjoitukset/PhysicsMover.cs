using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Harjoitukset
{
    public class PhysicsMover : MonoBehaviour
    {
        [SerializeField]
        private float speed = 1;

        private Rigidbody2D rb2D;
        private InputReader inputReader;
        public bool grounded = false;
        
        [SerializeField] 
        private float thrust = 2;
        private void Awake()
        {
            inputReader = GetComponent<InputReader>();
            rb2D = GetComponent<Rigidbody2D>();
            if (rb2D == null)
            {
                Debug.LogError($"{gameObject} is missing a component Rigidbody2D which it is dependant on!");
            }
        }

        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            grounded = true; 
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            grounded = false;
        }



        private void FixedUpdate()
        {

            


            bool jump = false;
            if (inputReader.GetJump())
            {
                jump = true;
            }

            


            Vector2 direction = inputReader.GetMoveInput();
            Vector2 movement = direction * speed * Time.fixedDeltaTime;
            transform.Translate(movement);
            if (jump && grounded)
            {
                rb2D.AddForce(transform.up * thrust,ForceMode2D.Impulse);
                
            }
            
            
            
            
        }




        

        //public void Move(Vector2 direction)
        //{
        //    this.direction = direction;
        //}

        
        

    }
}