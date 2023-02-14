using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Harjoitukset
{
    public class PhysicsMover : MonoBehaviour
    {
        [SerializeField]
        private float speed = 1;

        private Vector2 direction;
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

            // Bit shift the index of the layer (8) to get a bit mask
            int layerMask = 1 << 8;

            // This would cast rays only against colliders in layer 8.
            // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
            layerMask = ~layerMask;


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