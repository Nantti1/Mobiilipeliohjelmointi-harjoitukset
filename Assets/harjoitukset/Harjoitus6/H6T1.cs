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
            // HACK: Estä PlayerInputia vaihtamasta kontrolliskeemaa, jos virtual joystick on
            // käytössä!
            if (playerInput.currentActionMap.name == "Controls")
            {
                // Jos VirtualJoystick on käytössä, estetään Unityä vaihtamasta kontrolliskeemaa
                playerInput.neverAutoSwitchControlSchemes = true;
                playerInput.SwitchCurrentControlScheme(Gamepad.current);
            }
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            currentControlMethod = ControlMethod.VirtualJoystick;
            // Luetaan käyttäjän hahmoa liikuttava syöte muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            Debug.Log($"Syöte: {moveInput}");
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
