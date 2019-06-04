using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrojar : MonoBehaviour
{
    Vector2 posicion_inicial, posicion_final, direcion;
    float toque_inicial, toque_final, intervalo_de_tiempo;
    Rigidbody2D rb;
    bool permitir_lanzamiento = true;

    [Range(0.05f, 1f)]
    public float fuerza_de_arrojar = 0.3f;

    void Start()
    {
        AuidoScript.instance.Mute("Marcha");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if(Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Began)
        {
            toque_inicial = Time.time;
            posicion_final = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && permitir_lanzamiento)
        {
            toque_final = Time.time;
            intervalo_de_tiempo = toque_final - toque_inicial;
            posicion_final = Input.GetTouch(0).position;
            direcion = posicion_inicial - posicion_final;
            rb.isKinematic = false;
            rb.AddForce(-direcion / intervalo_de_tiempo * fuerza_de_arrojar);
            permitir_lanzamiento = false;
        }
    }
}