using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checar_cae_micro : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("checar_de_caida"))
        {
            GameControlScript.instance.aumentar_score();
            Destroy(col.gameObject);
        }
    }
}
