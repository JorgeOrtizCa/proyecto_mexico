using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microfono : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Juanga")||col.gameObject.tag.Equals("escenario"))
        {
            Invoke("DestruyeMicro",3f);
            Destroy(gameObject, 3f);
        }
    }

    void DestruyeMicro()
    {
        GameControlScript.instance.MenosMicrofonos();
    }
}