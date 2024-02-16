using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaEnemic1 : MonoBehaviour
{
    public Image barraDeVida;
    public float vidaActual = 100;
    public int vidaMaxima = 100;

    private float resVida;

    void Start()
    {
        vidaActual = vidaMaxima;
    }

    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }


}

  

