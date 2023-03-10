using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Harjoitukset
{
    public class H7T4 : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI HowManyCoins; // TextMeshPro object to display the score

        private void Start()
        {
            UpdateScoreText(); // update the score text when the game starts
        }

        private void Update()
        {
            UpdateScoreText(); // update the score text every frame
        }

        private void UpdateScoreText()
        {
            HowManyCoins.SetText("Score: " + H7T1.RetScore()); // update the score text with the current score
        }
    }
}

