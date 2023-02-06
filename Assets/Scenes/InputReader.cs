using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Harjoitukset
{
    public class InputReader : MonoBehaviour
    {
        private Vector2 moveInput;

        public void OnMove(InputAction.CallbackContext context)
        {
            // Luetaan k�ytt�j�n hahmoa liikuttava sy�te muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            Debug.Log($"Sy�te: {moveInput}");
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            // Luetaan k�ytt�j�n hahmoa liikuttava sy�te muuttujaan.
            //moveInput = context.ReadValue<Vector2>();
            Debug.Log("Jump");
        }

        public Vector2 GetMoveInput()
        {
            return moveInput;
        }

    }
}


