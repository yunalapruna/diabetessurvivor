using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaEnemic3 : MonoBehaviour
{
    public Image barraDeVida;
    public int vidaActual;
    public float vidaMaxima;

    void Start()
    {

    }

    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }

    public void TreureVida()
    {
        vidaActual = vidaActual - 2;
    }
}
