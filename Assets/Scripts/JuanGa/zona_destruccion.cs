using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zona_destruccion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("microfono"))
        {
            GameControlScript.instance.MenosMicrofonos();
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag.Equals("Juanga"))
        {
            Destroy(col.gameObject);
        }
    }
}