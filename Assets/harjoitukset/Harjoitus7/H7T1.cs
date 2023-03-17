using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

namespace Harjoitukset
{
    public class H7T1 : MonoBehaviour
    {
        private static int playerScore = 0;

        [SerializeField]
        private string levelName;

        private Coin coins;


        private void Start()
        {
            coins = GetComponent<Coin>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                LoadLevel(levelName);
            }
        }
        public static void LoadLevel(string sceneName)
        {
            // A very simple way of loading a new scene
            SceneManager.LoadScene(sceneName);
        }

        public static void AddingScore(int amount)
        {
            playerScore += amount;
            SaveNumber();
        }

        public static void SaveNumber()
        {
            PlayerPrefs.SetInt("myNumber", playerScore);
        }

        public static int RetScore()
        {
            return playerScore; 
        }

    }

}
