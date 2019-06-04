using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Manager : MonoBehaviour
{
    public GameObject Bton_1;
    public GameObject Bton_2;
    public GameObject Bton_3;
    public GameObject Bton_4;
    public GameObject Bton_5;
    public GameObject Bton_6;
    public GameObject Bton_7;
    public GameObject Bton_8;
    public GameObject[] Cracks;

    public GameObject Instrucciones;
    public GameObject Ganador;

    public float _otroTimer = 3f;
    public float _timer;
    public int _Random;
    public int _counter = 0;
    public int ClicksMaximos;

    public bool Jugando;

    public bool Buttons_bool;
    private bool Bton_1_bool;
    private bool Bton_2_bool;
    private bool Bton_3_bool;
    private bool Bton_4_bool;
    private bool Bton_5_bool;
    private bool Bton_6_bool;
    private bool Bton_7_bool;
    private bool Bton_8_bool;



    void Awake()
    {
        ClicksMaximos = ClicksMaximos + (Vida.ResterTiempo / 2);
    }
    void Start()
    {
        AuidoScript.instance.Mute("Marcha");

        Bton_1.SetActive(false);
        Bton_2.SetActive(false);
        Bton_3.SetActive(false);
        Bton_4.SetActive(false);
        Bton_5.SetActive(false);
        Bton_6.SetActive(false);
        Bton_7.SetActive(false);
        Bton_8.SetActive(false);

        Jugando = false;

        Buttons_bool = true;
        Bton_1_bool = true;
        Bton_2_bool = true;
        Bton_3_bool = true;
        Bton_4_bool = true;
        Bton_5_bool = true;
        Bton_6_bool = true;
        Bton_7_bool = true;
        Bton_8_bool = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Jugando == true)
        {
            if (Buttons_bool == true)
            {
                Bton_1.SetActive(false);
                Bton_2.SetActive(false);
                Bton_3.SetActive(false);
                Bton_4.SetActive(false);
                Bton_5.SetActive(false);
                Bton_6.SetActive(false);
                Bton_7.SetActive(false);
                Bton_8.SetActive(false);

                _timer -= 1 * Time.deltaTime;
            }
            if (_timer <= 0)
            {
                Buttons_bool = false;
                _timer = .5f;
                _Random = Random.Range(1, 8);
                Random_Function();
            }
            if(_counter >= ClicksMaximos)
            {
                Ganador.SetActive(true);
                Jugando = false;
                FindObjectOfType<Timer_muro>().Ganar();
            }
        }

        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            Instrucciones.SetActive(false);
            _otroTimer = 5;
            Jugando = true;
        }

    }

    public void perder()
    {
        Jugando = false;
    }

    private void Random_Function()
    {
        switch (_Random)
        {
            case 1:
                Button_1();
                break;
            case 2:
                Button_2();
                break;
            case 3:
                Button_3();
                break;
            case 4:
                Button_4();
                break;
            case 5:
                Button_5();
                break;
            case 6:
                Button_6();
                break;
            case 7:
                Button_7();
                break;
            case 8:
                Button_8();
                break;
        }
    }

    public void Buttons_Script(int Boton)
    {
        switch(Boton)
        {
            case 1:
                Cracks[0].SetActive(true);
                break;
            case 2:
                Cracks[1].SetActive(true);
                break;
            case 3:
                Cracks[2].SetActive(true);
                break;
            case 4:
                Cracks[3].SetActive(true);
                break;
            case 5:
                Cracks[4].SetActive(true);
                break;
            case 6:
                Cracks[5].SetActive(true);
                break;
            case 7:
                Cracks[6].SetActive(true);
                break;
            case 8:
                Cracks[7].SetActive(true);
                break;
        }

        if (Jugando == true)
        {
            _counter++;
            Buttons_bool = true;
        }
    }
    private void Button_1()
    {
        if (Cracks[0].active == false)
        {
            Debug.Log("Boton 1");
            Bton_1.SetActive(true);
            Bton_1_bool = false;
            StartCoroutine(B_Secs());
        }
        else
        {
            _Random = Random.Range(1, 8);
            Random_Function();
        }
    }
    private void Button_2()
    {
        if (Cracks[1].active == false)
        {
            Debug.Log("Boton 2");
            Bton_2.SetActive(true);
            Bton_2_bool = false;
            StartCoroutine(B_Secs());
        }
        else
        {
            _Random = Random.Range(1, 8);
            Random_Function();
        }
    }
    private void Button_3()
    {
        if (Cracks[2].active == false)
        {
            Debug.Log("Boton 3");
            Bton_3.SetActive(true);
            Bton_3_bool = false;
            StartCoroutine(B_Secs());
        }
        else
        {
            _Random = Random.Range(1, 8);
            Random_Function();
        }
    }
    private void Button_4()
    {
        if (Cracks[3].active == false)
        {
            Debug.Log("Boton 4");
            Bton_4.SetActive(true);
            Bton_4_bool = false;
            StartCoroutine(B_Secs());
        }
        else
        {
            _Random = Random.Range(1, 8);
            Random_Function();
        }
    }
    private void Button_5()
    {
        if (Cracks[4].active == false)
        {
            Debug.Log("Boton 5");
            Bton_5.SetActive(true);
            Bton_5_bool = false;
            StartCoroutine(B_Secs());
        }
        else
        {
            _Random = Random.Range(1, 8);
            Random_Function();
        }
    }
    private void Button_6()
    {
        if (Cracks[5].active == false)
        {
            Debug.Log("Boton 6");
            Bton_6.SetActive(true);
            Bton_6_bool = false;
            StartCoroutine(B_Secs());
        }
        else
        {
            _Random = Random.Range(1, 8);
            Random_Function();
        }
    }
    private void Button_7()
    {
        if (Cracks[6].active == false)
        {
            Debug.Log("Boton 7");
            Bton_7.SetActive(true);
            Bton_7_bool = false;
            StartCoroutine(B_Secs());
        }
        else
        {
            _Random = Random.Range(1, 8);
            Random_Function();
        }
    }
    private void Button_8()
    {
        if (Cracks[7].active == false)
        {
            Debug.Log("Boton 8");
            Bton_8.SetActive(true);
            Bton_8_bool = false;

            StartCoroutine(B_Secs());
        }
        else
        {
            _Random = Random.Range(1, 8);
            Random_Function();
        }
    }
    IEnumerator B_Secs()
    {
        yield return new WaitForSeconds(1f);
        Buttons_bool = true;
    }
}
