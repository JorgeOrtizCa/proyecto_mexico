using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaMasRapido : MonoBehaviour
{
    public float TiempoDeEspera;

    public int NumeroRandom;

    void Start()
    {
        NumeroRandom = Random.Range(1, 9);
    }

    void Update()
    {
        TiempoDeEspera -= Time.deltaTime * 1;

        NumeroRandom = Random.Range(1, 14);

        if (TiempoDeEspera < 0)
        {
            switch (NumeroRandom)
            {
                case 1:
                    SceneManager.LoadScene("GP_1(No te duermaas)");
                    break;
                case 2:
                    SceneManager.LoadScene("GP_2(Huachicol)");
                    break;
                case 3:
                    SceneManager.LoadScene("Gp_3(Alcohol)");
                    break;
                case 4:
                    SceneManager.LoadScene("GP_4(chapo_jorge)");
                    break;
                case 5:
                    SceneManager.LoadScene("GP_5(PenaNieto)");
                    break;
                case 6:
                    SceneManager.LoadScene("GP_6(Duarte)");
                    break;
                case 7:
                    SceneManager.LoadScene("GP_7(Muro)");
                    break;
                case 8:
                    SceneManager.LoadScene("GP_8(chapo2)");
                    break;
                case 9:
                    SceneManager.LoadScene("GP_9(votaciones)");
                    break;
                case 10:
                    SceneManager.LoadScene("GP_10(Fua)");
                    break;
                case 11:
                    SceneManager.LoadScene("GP_11(Edgar)");
                    break;
                case 12:
                    SceneManager.LoadScene("Gp_12(gas)");
                    break;
                case 13:
                    SceneManager.LoadScene("GP_14(test)");
                    break;
            }
        }
    }

}
