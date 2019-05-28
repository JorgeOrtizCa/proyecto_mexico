using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogManager : MonoBehaviour
{
    public GameObject Log1;
    public GameObject Log2;
    public GameObject DesactivarInstucciones1;
    public GameObject DesactivarInstucciones2;
    public GameObject Timer;
    public float Tiem;
    private int LogChoose;

    void Awake()
    {
        LogChoose = Random.Range(1, 3);
        switch (LogChoose)
        {
            case 1:
            Log1.SetActive(true);
            Log2.SetActive(false);
                break;
                
            case 2:
                Log1.SetActive(false);
                Log2.SetActive(true);
            break;
        }
    }
    void Update()
    {
        Tiem -= Time.deltaTime * 1;
        if (Tiem <= 0)
        {
            DesactivarInstucciones1.SetActive(false);
            DesactivarInstucciones2.SetActive(false);
            Timer.SetActive(true);
        }
    }

}
