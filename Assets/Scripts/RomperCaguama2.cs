using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RomperCaguama2 : MonoBehaviour
{
    public Image Caguama2;
    public GameObject CaguamaRota2;
    //public Image CaguamaRota2;

    void Start()
    {
        Caguama2 = GetComponent<Image>();
        if (Vida._vida == 1)
        {
            CaguamaRota2.SetActive(true);
            Caguama2.enabled = false;
        }
    }
}
