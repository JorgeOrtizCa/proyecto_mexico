using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrancarCamioneta : MonoBehaviour
{

    private Animator ThisAnimator;
    public GameObject EsteColider;

    void Start()
    {
        ThisAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (EsteColider.transform.childCount > 0)
        {
            if (EsteColider.tag == "Win")
            {
                ThisAnimator.SetBool("ArrancarDer", true);
            }
            if (EsteColider.tag == "Loose")
            {
                ThisAnimator.SetBool("ArrancarIzq", true);
                this.gameObject.transform.localScale = new Vector3(-0.9f, 0.9f, 0.9f);
            }
        }
    }
}
