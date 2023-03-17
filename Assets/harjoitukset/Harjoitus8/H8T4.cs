using Harjoitukset;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class H8T4 : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Osu");
            PhysicsMover speed = collision.gameObject.GetComponent<PhysicsMover>();
            speed.SpeedingUp();

            
            Destroy(gameObject);

        }

    }

    


    


}
