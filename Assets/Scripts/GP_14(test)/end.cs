using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public GameObject controller;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameController14 Controller = controller.GetComponent<GameController14>();
        Debug.Log("entered");
        Controller.Ganaste();
    }
        
}
