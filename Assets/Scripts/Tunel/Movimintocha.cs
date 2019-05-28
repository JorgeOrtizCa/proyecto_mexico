using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movimintocha : MonoBehaviour
{
    private bool Click = false;

    private Rigidbody2D _botella;

    public float _velocity;
    public bool _izquierda;
    public bool _jugando = true;
    public float VelocidadSubir;

    public GameObject WinTxt;
    public GameObject LooseTxt;
    public GameObject Player;
    public GameObject[] Carros;

    public BoxCollider2D car1;
    public BoxCollider2D car2;
    public BoxCollider2D car3;
    public BoxCollider2D car4;
    public BoxCollider2D car5;
    public BoxCollider2D car6;
    public BoxCollider2D car7;
    public BoxCollider2D car8;

    public Animator AniCar1;
    public Animator AniCar2;
    public Animator AniCar3;
    public Animator AniCar4;

    public GameObject Tiempo;
    private Animator ThisAnimator;


    private bool Moviendose = true;
    private bool moverArriba;
    private bool PararMoverArriba;
    private Vector3 VoltearDerecha;
    private Vector3 VolteaIzquierda;

    // Start is called before the first frame update
    void Start()
    {
        _botella = GetComponent<Rigidbody2D>();
        ThisAnimator = GetComponent<Animator>();
        _izquierda = true;
        _botella.gravityScale = 0;
        VoltearDerecha = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        VolteaIzquierda = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (_jugando == true && Moviendose==true)
        {
            if (_izquierda)
            {
                _botella.velocity = new Vector2(-_velocity, 0)*Time.deltaTime;
                VoltiarIzq();
            }
            else
            {
                _botella.velocity = new Vector2(_velocity, 0) * Time.deltaTime;
                VoltiarDer();
            }
        }

        if (_jugando == true && moverArriba == true)
        {
                _botella.velocity = new Vector2(0, VelocidadSubir);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Click = true;
        }

        if (_jugando == false)
        {
            LooseTxt.SetActive(true);
            _botella.velocity = new Vector2(0, 0) * Time.deltaTime;
        }

        

    }

    void VoltiarDer()
    {
        transform.localScale = VoltearDerecha;
    }

    void VoltiarIzq()
    {
        transform.localScale = VolteaIzquierda;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            if (_izquierda)
            {
                _izquierda = false;
            }
            else
            {
                _izquierda = true;
            }
        }

        if (other.tag == "No" && Click == true)
        {
            Moviendose = false;
        }


        if (ThisAnimator.GetBool("Sentado") == false)
        {
            switch (other.name)
            {
                case "Colider1":
                    Player.transform.SetParent(Carros[0].transform, true);
                    break;
                case "Colider2":
                    Player.transform.SetParent(Carros[1].transform, true);
                    break;
                case "Colider3":
                    Player.transform.SetParent(Carros[2].transform, true);
                    break;
                case "Colider4":
                    Player.transform.SetParent(Carros[3].transform, true);
                    break;
            }
        }

        if (other.name == "Stop")
        {
            ThisAnimator.SetBool("Sentado", true);
            this.transform.localScale = new Vector3(-0.3597847f, 0.3597847f, 0.3597847f);
            _botella.velocity = new Vector2(0, 0);
            car1.enabled = false;
            car2.enabled = false;
            car3.enabled = false;
            car4.enabled = false;
            car5.enabled = false;
            car6.enabled = false;
            car7.enabled = false;
            car8.enabled = false;
            AniCar1.enabled = true;
            AniCar2.enabled = true;
            AniCar3.enabled = true;
            AniCar4.enabled = true;
            moverArriba = false;
        }

        if (other.tag == "Loose")
        {
            LooseTxt.SetActive(true);
        }

        if (other.tag == "Win")
        {
            WinTxt.SetActive(true);
        }


    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Click == true)
        {
            if (other.tag == "No" || other.tag == "Si")
            {
                Tiempo.GetComponent<Tiemo>().enabled = false;
                Moviendose = false;
                _botella.velocity = new Vector2(0, 0);
                moverArriba = true;
                ThisAnimator.SetBool("Subiendo", true);
            }
        }

    }
}
