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
            // Luetaan k�ytt�j�n hahmoa liikuttava sy�te muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            //Debug.Log($"Sy�te: {moveInput}");
        }
        */
        private void Awake()
        {
            playerInput = GetComponent<PlayerInput>();
        }

        private void Start()
        {
            // HACK: Est� PlayerInputtia vaihtamasta kontrolliskeemaa 
            if (playerInput.currentActionMap.name == "Game")
            {
                // Jos virtualjoystick k�yt�ss� estet��n unity� vaihtamasta kontrolliskeemaa
                playerInput.neverAutoSwitchControlSchemes = true;
                playerInput.SwitchCurrentControlScheme(Gamepad.current);
            }
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            currentControlMethod = ControlMethod.VirtualJoystick;
            //Luetaan k�ytt�j�n hahmoa liikuttava sy�te muuttujaan
            moveInput = context.ReadValue<Vector2>();
            Debug.Log($"Sy�te: {moveInput}");
        }


        public void OnJump(InputAction.CallbackContext context)
        {
            // Luetaan k�ytt�j�n hahmoa liikuttava sy�te muuttujaan.
            
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


