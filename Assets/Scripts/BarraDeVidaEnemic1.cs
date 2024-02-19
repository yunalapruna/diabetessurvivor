using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaEnemic1 : MonoBehaviour
{
    public Slider barraDeVida;
    public float vidaActual;
    public float vidaMaxima = 100f;

    private void Start()
    {
        vidaActual = vidaMaxima;
        ActualizarBarraVida();
    }
    
    public void RecibirDaño(float cantidadDaño)
    {
        vidaActual -= cantidadDaño;
        vidaActual = Mathf.Clamp(vidaActual, 0f, vidaMaxima);
        ActualizarBarraVida();

        if (vidaActual <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void ActualizarBarraVida()
    {
        barraDeVida.value = vidaMaxima / vidaActual;
    }
}


  

