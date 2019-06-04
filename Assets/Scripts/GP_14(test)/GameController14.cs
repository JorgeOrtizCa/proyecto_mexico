using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController14 : MonoBehaviour
{

    public Text Txt_mecanica;
    public Text Txt_instruccion;
    public Text Txt_resultado;
    public GameObject Tiempo;
    public GameObject Inicio;
    public GameObject Final;

    public GameObject MafiaDelPoder;
    public GameObject amlo;

    private Rigidbody2D rb2D;

    bool juega =false ;

    public int distancia = 10;
    public float thrust = 60f;
    void Start()
    {
        rb2D = MafiaDelPoder.GetComponent<Rigidbody2D>();
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Mute("Marcha");


        //  Invoke("quitarInicio", 2);

        Invoke("quitarIntrucciones", 4);

    }

    //*********************************

    void quitarInicio()
    {
        Inicio.SetActive(!Inicio.activeSelf);
    }

    void quitarIntrucciones()
    {
        juega = true;
        Txt_mecanica.text = "";
        Txt_instruccion.text = "";
        Tiempo.SetActive(!Tiempo.activeSelf);
        // AuidoScript.instance.Play("PasosEff");

      
    }

    public void Ganaste()
    {
        juega = false;
        //Final.SetActive(true);
        Tiempo.SetActive(false);
        Txt_resultado.text = "Ganaste";
        // PlayerPrefs.SetInt("Colecionable_9", 1);
        Invoke("escenaGanar", 1);

    }

    public void Perdiste()
    {
        juega = false;
        //   AuidoScript.instance.Stop("PasosEff");
        Tiempo.SetActive(!Tiempo.activeSelf);
        Txt_resultado.text = "Perdiste";
        Invoke("escenaPerder", 1);

    }


    public void escenaGanar()
    {
        SceneManager.LoadScene("Sc_Ganar");
    }

    public void escenaPerder()
    {
        SceneManager.LoadScene("Sc_Perder");
    }
    //**********************************

    private Vector2 fp; // first finger position
    private Vector2 lp; // last finger position

    void Update()
    {
        if (juega)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    fp = touch.position;
                    lp = touch.position;
                }
                if (touch.phase == TouchPhase.Moved)
                {
                    lp = touch.position;
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    if ((fp.x - lp.x) > 80) // left swipe
                    {
                        Debug.Log("Left");
                    }
                    else if ((fp.x - lp.x) < -80) // right swipe
                    {
                        rb2D.AddForce(transform.right * thrust);
                        //  Vector3 movimiento2 = new Vector3(amlo.transform.position.x + distancia, amlo.transform.position.y, amlo.transform.position.z);

                        amlo.transform.position = new Vector3(MafiaDelPoder.transform.position.x - 280 + distancia, amlo.transform.position.y, MafiaDelPoder.transform.position.z); ;


                        Debug.Log("right");
                    }
                    else if ((fp.y - lp.y) < -80) // up swipe
                    {
                        Debug.Log("up");
                    }
                    else if ((fp.y - lp.y) > 80) // up down
                    {
                        Debug.Log("down");

                    }
                }
            }
        }
       
        

    }
}

