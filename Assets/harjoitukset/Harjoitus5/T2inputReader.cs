using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Harjoitukset
{
    public class T2inputReader : MonoBehaviour
    {
        private float baseForce = 0.5f;
        private float forceMultiplier = 1.5f;
        private float maxForce = 9f;
        private float chargeTime = 1f;

        public InputAction launchAction;

        private Rigidbody2D rb;
        private float currentForce = 0f;
        private bool isCharging = false;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            launchAction.performed += OnLaunchAction;
            launchAction.canceled += OnLaunchActionCanceled;
        }

        void OnLaunchAction(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Started)
            {
                isCharging = true;
            }
            else if (context.phase == InputActionPhase.Canceled)
            {
                isCharging = false;
                Launch();
            }
        }

        void OnLaunchActionCanceled(InputAction.CallbackContext context)
        {
            isCharging = false;
            currentForce = 0f;
        }

        void Update()
        {
            if (isCharging)
            {
                currentForce += (maxForce / chargeTime) * Time.deltaTime;
                currentForce = Mathf.Min(currentForce, maxForce);
                Debug.Log(currentForce);
            }
        }

        void Launch()
        {
            Vector2 launchDirection = transform.up;
            rb.AddForce(currentForce * launchDirection, ForceMode2D.Impulse);
            rb.AddForce(currentForce * transform.right, ForceMode2D.Impulse);
            currentForce = 0f;
        }

        void OnEnable()
        {
            launchAction.Enable();
        }

        void OnDisable()
        {
            launchAction.Disable();
        }
    }
}