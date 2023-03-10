using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Harjoitukset
{
    public class H7T1 : MonoBehaviour
    {


        [SerializeField]
        private string levelName;

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


    }

}
