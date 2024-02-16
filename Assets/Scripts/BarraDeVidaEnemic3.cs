using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaEnemic3 : MonoBehaviour
{
    public Image barraDeVida;

    private void UpdateHealthBar(float vidaMaxima, int vidaActual)
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }


}
