using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H8T2 : MonoBehaviour
{
    public void Reset()
    {
        PlayerPrefs.DeleteKey("myNumber");
    }
}
