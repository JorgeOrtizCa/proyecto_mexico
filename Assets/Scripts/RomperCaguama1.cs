using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RomperCaguama1 : MonoBehaviour
{
    public Image Caguama1;
    public GameObject CaguamaRota1;
    //public Image CaguamaRota2;

    void Awake()
    {
        Caguama1 = GetComponent<Image>();
        if (Vida._vida <= 2)
        {
            Caguama1.enabled = false;
            CaguamaRota1.SetActive(true);
        }
    }

}
