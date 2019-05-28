using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingxD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Global", 1);
    }
}
