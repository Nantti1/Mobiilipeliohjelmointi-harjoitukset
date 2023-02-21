using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Harjoitukset
{

    public class T4TriggerCollider : MonoBehaviour
    {

        [SerializeField] private GameObject target;
        private Rigidbody2D rb;

        private void Awake()
        {
            rb = target.GetComponent<Rigidbody2D>();
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (rb)
            {
                rb.gravityScale = 1;
                Destroy(this.gameObject);
            } else
            {

            }
            
        }



    }


}
