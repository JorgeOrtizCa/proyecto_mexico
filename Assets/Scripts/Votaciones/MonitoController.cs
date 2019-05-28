using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitoController : MonoBehaviour
{
    public float speedMovement;
    private Rigidbody2D rb2D;
    int dirY;
    int dirX;
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    void Awake()
    {
        rb2D = this.GetComponent<Rigidbody2D>();
        //rb2D.freezeRotation = FALSE;
        

        

    }

    void Start()
    {
        dirX = sacaRandom(-9, 9);
        dirY = sacaRandom(-9, 9);

        rb2D.AddForce(new Vector2(dirX, dirY), ForceMode2D.Impulse); ;
    }

    int sacaRandom(int _min, int _max)
    {
        int numRandom;
        numRandom = Random.Range(_min, _max);
        //Debug.Log(numRandom);
        return numRandom;
    }

    void Update()
    {
  
        transform.rotation = Quaternion.LookRotation(Vector3.forward, transform.position);
    }

}
