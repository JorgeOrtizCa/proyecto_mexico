using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AjitarTronco : MonoBehaviour
{

    public float Sensibilidad = 2f;
    public float TiempoParaDetectarProxShake = 0.1f;
    public float VelocidadDeLlenar;
    private float sqrSensibilidad;
    private float timeSinceLastShake;
    public Image Tronco;
    bool jugando = true;
    public float movespeed;
    public float TiempoParaProximaEscena = 2.5f;
    private Rigidbody2D rb;
    private float dirX;
    private float dirY;
    public float slidetime;
    public GameObject Tiempo;
    public GameObject GanasteTxt;



    void Awake()
    {

    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sqrSensibilidad = Mathf.Pow(Sensibilidad, 2);
    }

    void Update()
    {
        dirY = Input.acceleration.x * (movespeed * Time.deltaTime) * 1;
        dirX = Input.acceleration.x * (movespeed * Time.deltaTime) * 1;
            if (Input.acceleration.sqrMagnitude >= sqrSensibilidad && Time.unscaledTime >= timeSinceLastShake + TiempoParaDetectarProxShake && jugando == true)
            {
                rb.velocity = new Vector2(dirX, dirY);
                timeSinceLastShake = Time.unscaledTime;
                slidetime = 1.5f;
            }


            slidetime -= Time.deltaTime * 1;
            if(slidetime <= 0)
            {
                rb.velocity = new Vector2(0, 0);
            }


        //GANAR
        /*
        if (CantidadDeLlenado >= TopeDeLlenado)
        {
            jugando = false;
            TiempoParaProximaEscena -= Time.deltaTime * 1;
            Tiempo.GetComponent<LimiteDeTiempoFua>().enabled = false;
            GanasteTxt.SetActive(true);
        }
        */
        if (TiempoParaProximaEscena <= 0)
        {
            SceneManager.LoadScene("Sc_Ganar");
        }
    }
    

}
