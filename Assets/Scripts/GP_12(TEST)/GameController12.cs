using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController12 : MonoBehaviour
{

    public Text Txt_mecanica;
    public Text Txt_instruccion;
    public Text Txt_resultado;
    public GameObject Tiempo;
    public GameObject txt_precio;
    public GameObject txt_precio2;
    public GameObject Inicio;
    public GameObject Final;

    public Animator anim_manguera;
    public Animator anim_bomba;
    int precio;
    //public GameObject Inicio;



    void Start()
    {
        AuidoScript.instance.Play("IntroGameEff");
        precio = 6;
        txt_precio.GetComponent<Text>().text = precio.ToString();
        Invoke("quitarInicio", 2);

        Invoke("quitarIntrucciones", 4);

    }

    //*********************************

    void quitarInicio()
    {
        Inicio.SetActive(!Inicio.activeSelf);
    }

    void quitarIntrucciones()
    {
        Txt_mecanica.text = "";
        Txt_instruccion.text = "";
        Tiempo.SetActive(!Tiempo.activeSelf);
        // AuidoScript.instance.Play("PasosEff");
        txt_precio.SetActive(!txt_precio.activeSelf);
        txt_precio2.SetActive(!txt_precio2.activeSelf);
    }

    public void Ganaste()
    {
        Final.SetActive(true);
        Tiempo.SetActive(false);
        Txt_resultado.text = "¡Ganaste!";
       // PlayerPrefs.SetInt("Colecionable_9", 1);
        Invoke("escenaGanar", 1);

    }

    public void Perdiste()
    {
        //   AuidoScript.instance.Stop("PasosEff");
        Tiempo.SetActive(!Tiempo.activeSelf);
        Txt_resultado.text = "¡Perdiste!";
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
        if (precio >= 21)
        {
            Ganaste();
        }
        else
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
                        Debug.Log("right");
                    }
                    else if ((fp.y - lp.y) < -80) // up swipe
                    {
                        Debug.Log("up");
                    }
                    else if ((fp.y - lp.y) > 80) // up down
                    {
                        Debug.Log("down");
                        AuidoScript.instance.Play("bombaDeAireEff");
                        anim_manguera.Play("manguera");
                        anim_bomba.Play("bomba");

                        precio++;
                        txt_precio.GetComponent<Text>().text = precio.ToString();

                        anim_manguera.Play("mangueraInicio");
                        anim_bomba.Play("bombaInicio");
                    }
                }
            }
        }
        
    }
}

