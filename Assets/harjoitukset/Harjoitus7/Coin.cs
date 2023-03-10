using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Harjoitukset
{
    public class Coin : MonoBehaviour
    {

        [SerializeField]
        private int score = 1;

        

       

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                H7T1.AddingScore(score);
                Destroy(gameObject);
                
            }
        }

        public int GetScore()
        {
            return score;
        }

    }

}
