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
            // Luetaan käyttäjän hahmoa liikuttava syöte muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            Debug.Log($"Syöte: {moveInput}");
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            // Luetaan käyttäjän hahmoa liikuttava syöte muuttujaan.
            //moveInput = context.ReadValue<Vector2>();
            Debug.Log("Jump");
        }

        public Vector2 GetMoveInput()
        {
            return moveInput;
        }

    }
}


