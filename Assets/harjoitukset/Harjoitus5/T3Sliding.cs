using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Harjoitukset
{
    public class T3Sliding : MonoBehaviour
    {
        

        [SerializeField]
        private float thrust = 1;

        private InputReader inputReader;
        private Rigidbody2D rb2D;

        private void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
            inputReader = GetComponent<InputReader>();
        }

        private void Update()
        {
            Vector2 moveInput = inputReader.GetMoveInput();
            rb2D.AddForce(thrust * moveInput, ForceMode2D.Impulse);
        }

        
    }

}

