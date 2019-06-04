using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private void Start()
    {
        AuidoScript.instance.Mute("Marcha");
    }

    public void colision()
    {
        Debug.Log("ENTER");
    }

}
