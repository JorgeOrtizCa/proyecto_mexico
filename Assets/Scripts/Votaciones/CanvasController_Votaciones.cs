using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController_Votaciones : MonoBehaviour
{

    public Text Txt_mecanica;
    public Text Txt_instruccion;
    public Text Txt_resultado;
    public GameObject Tiempo;
    public GameObject Inicio;
    public int monitos;


    void Start()
    {

        monitos = 0;
        Invoke("quitarInicio", 2);
       
        Invoke("quitarIntrucciones", 4);

    }


    void quitarInicio()
    {
        Inicio.SetActive(!Inicio.activeSelf);
    }
    private void Update()
    {
        if (monitos >= 4)
        {
            Ganaste();
        }
    }
    //*********************************
    void quitarIntrucciones()
    {
        Txt_mecanica.text = "";
        Txt_instruccion.text = "";
        Tiempo.SetActive(!Tiempo.activeSelf);
       // AuidoScript.instance.Play("PasosEff");
    }

    public void Ganaste()
    {

        Tiempo.SetActive(false);
        Txt_resultado.text = "Ganaste";
        PlayerPrefs.SetInt("Colecionable_9", 1);
        Invoke("escenaGanar", 1);
        
    }

    public void Perdiste()
    {
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

}