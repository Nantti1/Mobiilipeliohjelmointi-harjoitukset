using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static Harjoitukset.H6T1;

namespace Harjoitukset
{
    public class InputReader : MonoBehaviour
    {
        private Vector2 moveInput;
        private bool jumping = false;


        public enum ControlMethod
        {
            VirtualJoystick,
            Tap
        }

        private PlayerInput playerInput;

        private ControlMethod currentControlMethod = ControlMethod.Tap;
        /*
        public void OnMove(InputAction.CallbackContext context)
        {
            // Luetaan käyttäjän hahmoa liikuttava syöte muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            //Debug.Log($"Syöte: {moveInput}");
        }
        */
        private void Awake()
        {
            playerInput = GetComponent<PlayerInput>();
        }

        private void Start()
        {
            // HACK: Estä PlayerInputtia vaihtamasta kontrolliskeemaa 
            if (playerInput.currentActionMap.name == "Game")
            {
                // Jos virtualjoystick käytössä estetään unityä vaihtamasta kontrolliskeemaa
                playerInput.neverAutoSwitchControlSchemes = true;
                playerInput.SwitchCurrentControlScheme(Gamepad.current);
            }
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            currentControlMethod = ControlMethod.VirtualJoystick;
            //Luetaan käyttäjän hahmoa liikuttava syöte muuttujaan
            moveInput = context.ReadValue<Vector2>();
            Debug.Log($"Syöte: {moveInput}");
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
            if (currentControlMethod == ControlMethod.VirtualJoystick)
            {
                return this.moveInput;
            }

            
            return this.moveInput.normalized;

        }


        /*
        public Vector2 GetMoveInput()
        {
            return moveInput;
        }
        */

        public bool GetJump()
        {
            bool canJump = jumping;
            jumping = false;
            return canJump;
        }

    }
}


