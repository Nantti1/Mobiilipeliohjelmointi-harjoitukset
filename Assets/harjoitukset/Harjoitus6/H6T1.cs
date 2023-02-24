using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Harjoitukset
{
    public class H6T1 : MonoBehaviour
    {

        public enum ControlMethod
        {
            VirtualJoystick
        }

        [SerializeField] private float thrust = 20;

        private Vector2 moveInput;
        

        private PlayerInput playerInput;

        private ControlMethod currentControlMethod = ControlMethod.VirtualJoystick;

        private void Awake()
        {
            playerInput = GetComponent<PlayerInput>();
            
        }
        private void Start()
        {
            // HACK: Est� PlayerInputia vaihtamasta kontrolliskeemaa, jos virtual joystick on
            // k�yt�ss�!
            if (playerInput.currentActionMap.name == "Controls")
            {
                // Jos VirtualJoystick on k�yt�ss�, estet��n Unity� vaihtamasta kontrolliskeemaa
                playerInput.neverAutoSwitchControlSchemes = true;
                playerInput.SwitchCurrentControlScheme(Gamepad.current);
            }
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            currentControlMethod = ControlMethod.VirtualJoystick;
            // Luetaan k�ytt�j�n hahmoa liikuttava sy�te muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            Debug.Log($"Sy�te: {moveInput}");
        }

      

        public Vector2 GetMoveInput()
        {
            if (currentControlMethod == ControlMethod.VirtualJoystick)
            {
                return this.moveInput;
            }
            else {
                return this.moveInput.normalized;
            }
            

        }



    }

}
