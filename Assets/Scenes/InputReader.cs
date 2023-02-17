using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Harjoitukset
{
    public class InputReader : MonoBehaviour
    {
        private Vector2 moveInput;
        private bool jumping = false;


        public void OnMove(InputAction.CallbackContext context)
        {
            // Luetaan käyttäjän hahmoa liikuttava syöte muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            //Debug.Log($"Syöte: {moveInput}");
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            // Luetaan käyttäjän hahmoa liikuttava syöte muuttujaan.
            
            if (context.phase == InputActionPhase.Started)
            {
                jumping = true; 
            } 
            

            //Debug.Log("Jump");
        }


       


        public Vector2 GetMoveInput()
        {
            return moveInput;
        }

        public bool GetJump()
        {
            bool canJump = jumping;
            jumping = false;
            return canJump;
        }

    }
}


