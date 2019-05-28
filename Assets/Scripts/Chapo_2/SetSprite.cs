using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSprite : MonoBehaviour
{
    public Sprite WinSprite;
    public Sprite LooseSprite;

    void Start()
    {
        if (this.gameObject.tag == "Win")
        {
            this.GetComponent<SpriteRenderer>().sprite = WinSprite;
        }
        if (this.gameObject.tag == "Loose")
        {
            this.GetComponent<SpriteRenderer>().sprite = LooseSprite;
        }


    }
}
