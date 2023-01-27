using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


namespace Harjoitukset
{
    public class MovingTransform : MonoBehaviour
    {

        [SerializeField] private float minXAkseli = 2;
        [SerializeField] private float maxXAkseli = 4;
        private Transform transforming;

        private Vector2 direction = new Vector2(1,0);
        


        // Start is called before the first frame update
        void Start()
        {
            transforming = GetComponent<Transform>();
            direction = direction.normalized;
            
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 movement = direction * 1 * Time.deltaTime;

            transforming.Translate(movement);

            Debug.Log(transforming.position.x);
            if (transforming.position.x <= maxXAkseli)
            {
                direction.x = 1;
            } else if (transforming.position.x >= minXAkseli)
            {
                direction.x = -1;
            }
            
            
            

        }
    }
}


