using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempojuanga : MonoBehaviour
{
    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    public float TiempoRestante;                               //TIEMPO QUE QUEDA
    public GameObject perderTxt;
    public GameObject panel;


    bool TiempoActivo = true;

    public string NombreDeControlador = " ";                    //NOMBRE DEL OBJETO QUE TIENE EL CONTROLADOR DEL JUEGO
    private arrojar _arrojar;
    //Movimintocha ControladorMovimiento;

    // Start is called before the first frame update
    void Start()
    {
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
        TiempoRestante = TiempoDeJeugo;                 //SE ASIGNA EL TIEMPO

    }

    void Update()
    {
        TiempoRestante -= 1 * Time.deltaTime;
        BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
        if (TiempoRestante <= 0)
        {
            perderTxt.SetActive(true);
            panel.SetActive(true);
        }
    }
}
