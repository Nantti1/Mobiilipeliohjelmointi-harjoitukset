using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H8T4 : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            
        }

    }
}
