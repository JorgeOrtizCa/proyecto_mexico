using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour
{
    public static GameControlScript instance = null;
    int numero_micro = 2;
    int score = 0;
    public int maxScore = 6;
    public Text texto_micro, texto_perder, texto_ganar; 
    public GameObject microfono;
    public GameObject tiempojuanga;
    bool detener_micro;

    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        texto_perder.gameObject.SetActive(false);
        texto_ganar.gameObject.SetActive(false);
    }

    void Update()
    {
        texto_micro.text = "Micros: " + numero_micro;

        if (score == 1)
        {
            resultado_ganar();
        }

        if (numero_micro <= 0)
        {

            micro_restantes();

            if (detener_micro && score < maxScore)
                resultado_perder();
        }
        if(GameObject.Find("Juanga") == null)
        {
            resultado_ganar();
        }
    }

    public void MenosMicrofonos()
    {
        numero_micro -= 1;
        if (numero_micro > 0)
            Instantiate(microfono, new Vector2(-6f, -2f), Quaternion.identity);
    }

    public void aumentar_score()
    {
        score += 1;
    }

    void RestartGame()
    {
        SceneManager.LoadScene("juego de Juanga");
    }

    void resultado_perder()
    {
        texto_perder.gameObject.SetActive(true);
    }
    
    void resultado_ganar()
    {
        tiempojuanga.SetActive(false);
        texto_ganar.gameObject.SetActive(true);
    }

    void micro_restantes()
    {
        int no_mover_micro = 0; 
        
        GameObject[] micro_restante = GameObject.FindGameObjectsWithTag("microfono");

        for (int i = 0; i < micro_restante.Length; i++)
        {
            if (micro_restante[i].GetComponent<Rigidbody2D>().velocity.x == 0
                && micro_restante[i].GetComponent<Rigidbody2D>().velocity.y == 0)
                no_mover_micro += 1;
        }
        if (no_mover_micro == micro_restante.Length)
            detener_micro = true;
    }
}