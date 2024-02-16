using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaEnemic1 : MonoBehaviour
{
    public Image barraDeVida;
    public int vidaActual;
    public float vidaMaxima;

    private void UpdateHealthBar(float vidaMaxima, int vidaActual)
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }
}


  

