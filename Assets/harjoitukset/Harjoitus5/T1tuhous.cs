using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Harjoitukset
{
    public class T1tuhous : MonoBehaviour
    {

        [SerializeField] private float speed = 1;

        [SerializeField] private GameObject target;




        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(this.gameObject);
        }

        private void Update()
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }


    }

}

