using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ConfigColeccionable : MonoBehaviour
{
    public Sprite noDisponible;

    public Button coleccionble1;
    public Text titulo_1;
    public Text contenido_1;
    public Sprite colec_1;

    public Button coleccionble2;
    public Text titulo_2;
    public Text contenido_2;
    public Sprite colec_2;

    public Button coleccionble3;
    public Text titulo_3;
    public Text contenido_3;
    public Sprite colec_3;

    public Button coleccionble4;
    public Text titulo_4;
    public Text contenido_4;
    public Sprite colec_4;

    public Button coleccionble5;
    public Text titulo_5;
    public Text contenido_5;
    public Sprite colec_5;

    public Button coleccionble6;
    public Text titulo_6;
    public Text contenido_6;
    public Sprite colec_6;

    public Button coleccionble7;
    public Text titulo_7;
    public Text contenido_7;
    public Sprite colec_7;

    public Button coleccionble8;
    public Text titulo_8;
    public Text contenido_8;
    public Sprite colec_8;

    public Button coleccionble9;
    public Text titulo_9;
    public Text contenido_9;
    public Sprite colec_9;

    public Button coleccionble10;
    public Text titulo_10;
    public Text contenido_10;
    public Sprite colec_10;

    public Button coleccionble11;
    public Text titulo_11;
    public Text contenido_11;
    public Sprite colec_11;

    public Button coleccionble12;
    public Text titulo_12;
    public Text contenido_12;
    public Sprite colec_12;

    void Start()
    {
        /*
        PlayerPrefs.SetInt("Colecionable_1", 1);
        PlayerPrefs.SetInt("Colecionable_2", 1);
        PlayerPrefs.SetInt("Colecionable_3", 1);
        PlayerPrefs.SetInt("Colecionable_4", 1);
        PlayerPrefs.SetInt("Colecionable_5", 1);
        PlayerPrefs.SetInt("Colecionable_6", 1);
        PlayerPrefs.SetInt("Colecionable_7", 1);
        PlayerPrefs.SetInt("Colecionable_8", 1);
        PlayerPrefs.SetInt("Colecionable_9", 1);
        PlayerPrefs.SetInt("Colecionable_10", 1);
        PlayerPrefs.SetInt("Colecionable_11", 1);
        PlayerPrefs.SetInt("Colecionable_12", 1);
        */

        //-----------------------------------------
        AuidoScript.instance.Play("Colecionables");
        AuidoScript.instance.Set_Volume("Colecionables", 100f);
        AuidoScript.instance.Set_Volume("Marcha", 0f);
        //----------------------------------------

        if ( PlayerPrefs.GetInt("Colecionable_1") == 1)
        {
            titulo_1.text = "Me canso ganso";
            contenido_1.text = "De los dichos más dichos llega: \"me canso ganso\" a formar de nuestro acervo mexicano";
            coleccionble1.GetComponent<Image>().sprite = colec_1;
            
        }

        if (PlayerPrefs.GetInt("Colecionable_2") == 1)
        {
            titulo_2.text = "Galón de oro";
            contenido_2.text = "El huachicol no es para que lo lleves en botellas de plástico.";
            coleccionble2.GetComponent<Image>().sprite = colec_2;
        }

        if (PlayerPrefs.GetInt("Colecionable_3") == 1)
        {
            titulo_3.text = "Cuba de oro";
            contenido_3.text = "Quien te trata como Tonayan cuando eres una Cuba no te merece.";
            coleccionble3.GetComponent<Image>().sprite = colec_3;
        }

        if (PlayerPrefs.GetInt("Colecionable_4") == 1)
        {
            titulo_4.text = "500 gramos de oro";
            contenido_4.text = "A éste le llamo el suspiro del águila.";
            coleccionble4.GetComponent<Image>().sprite = colec_4;
        }

        if (PlayerPrefs.GetInt("Colecionable_5") == 1)
        {
            titulo_5.text = "Copete de oro";
            contenido_5.text = "Ni el mismísimo penacho de Cuauhtémoc es más valioso que este monumento al estilacho.";
            coleccionble5.GetComponent<Image>().sprite = colec_5;
        }

        if (PlayerPrefs.GetInt("Colecionable_6") == 1)
        {
            titulo_6.text = "La libreta de la abundancia de oro";
            contenido_6.text = "¨Si merezco este coleccionable¨.";
            coleccionble6.GetComponent<Image>().sprite = colec_6;
        }

        if (PlayerPrefs.GetInt("Colecionable_7") == 1)
        {
            titulo_7.text = "Alambre de púas de oro";
            contenido_7.text = "¨Este si me lo paso por los...¨";
            coleccionble7.GetComponent<Image>().sprite = colec_7;
        }

        if (PlayerPrefs.GetInt("Colecionable_8") == 1)
        {
            titulo_8.text = "";
            contenido_8.text = "";
            coleccionble6.GetComponent<Image>().sprite = colec_8;
        }

        if (PlayerPrefs.GetInt("Colecionable_9") == 1)
        {
            titulo_9.text = "";
            contenido_9.text = "";
            coleccionble9.GetComponent<Image>().sprite = colec_9;
        }

        if (PlayerPrefs.GetInt("Colecionable_10") == 1)
        {
            titulo_10.text = "";
            contenido_10.text = "";
            coleccionble6.GetComponent<Image>().sprite = colec_10;
        }

        if (PlayerPrefs.GetInt("Colecionable_11") == 1)
        {
            titulo_11.text = "";
            contenido_11.text = "";
            coleccionble6.GetComponent<Image>().sprite = colec_11;
        }

        if (PlayerPrefs.GetInt("Colecionable_12") == 1)
        {
            titulo_12.text = "";
            contenido_12.text = "";
            coleccionble6.GetComponent<Image>().sprite = colec_12;
        }


    }


}
