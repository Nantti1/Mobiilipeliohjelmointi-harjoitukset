using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Harjoitukset
{
    public class Mover : MonoBehaviour
    {
        [SerializeField]
        private float speed = 1;

        private InputReader inputReader;

        private void Awake()
        {
            inputReader = GetComponent<InputReader>();
        }

        private void Update()
        {
            Vector2 moveInput = inputReader.GetMoveInput();
            Move(moveInput);
        }

        private void Move(Vector2 direction)
        {
            Vector2 movement = direction * speed * Time.deltaTime;
            transform.Translate(movement);
        }
    }

}

