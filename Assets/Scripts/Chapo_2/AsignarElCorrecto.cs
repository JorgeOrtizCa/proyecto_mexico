using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignarElCorrecto : MonoBehaviour
{
    private int NumRandom;
    public GameObject colider1;
    public GameObject colider2;
    public GameObject colider3;
    public GameObject colider4;

    void Awake()
    {
        NumRandom = Random.Range(1, 5);

        switch (NumRandom)
        {
            case 1:
                colider1.gameObject.tag = "Win";
                colider2.gameObject.tag = "Loose";
                colider3.gameObject.tag = "Loose";
                colider4.gameObject.tag = "Loose";
                break;

            case 2:
                colider1.gameObject.tag = "Loose";
                colider2.gameObject.tag = "Win";
                colider3.gameObject.tag = "Loose";
                colider4.gameObject.tag = "Loose";
                break;
            case 3:
                colider1.gameObject.tag = "Loose";
                colider2.gameObject.tag = "Loose";
                colider3.gameObject.tag = "Win";
                colider4.gameObject.tag = "Loose";
                break;
            case 4:
                colider1.gameObject.tag = "Loose";
                colider2.gameObject.tag = "Loose";
                colider3.gameObject.tag = "Loose";
                colider4.gameObject.tag = "Win";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
