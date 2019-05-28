using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAPocicion : MonoBehaviour
{
    public Transform PocicionTronco;
    public GameObject thisObject;
    public GameObject Ganaste;
    public GameObject Timer;
    public GameObject Ed;
    public Animator EdAni;
    public Transform EndPos;
    public float speed = 300;
    private bool MoveToPosition = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveToPosition == true)
        {
            thisObject.transform.position = new Vector3(PocicionTronco.transform.position.x, PocicionTronco.transform.position.y, PocicionTronco.transform.position.z);

            float step = speed * Time.deltaTime;
            Ed.transform.position = Vector3.MoveTowards(Ed.transform.position, EndPos.position, step);
            //EdAni.enabled = true;
            Ganaste.SetActive(true);
            Timer.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Tronco_punteado")
        {
            MoveToPosition = true;
        }
    }

}
