using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H8T3 : MonoBehaviour
{
    [SerializeField]
    public GameObject text;


    public void PauseGame()
    {
        if (Time.timeScale > 0)
        {
            text.SetActive(true);
            Time.timeScale = 0;
        } else
        {
            text.SetActive(false);
            Time.timeScale = 1;
        }
    }
 
}
