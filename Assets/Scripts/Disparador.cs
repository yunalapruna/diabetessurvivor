using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public float cantidadDanio = 2; // Ajusta la cantidad de da�o seg�n tus necesidades

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si el objeto que colision� tiene un componente que te interese (puedes ajustar esto)
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Asume que los enemigos tienen un script llamado "BarraDeVida" que define la funci�n RecibirDanio
            BarraDeVidaEnemic1 barraDeVida = collision.gameObject.GetComponent<BarraDeVidaEnemic1>();

            if (barraDeVida != null)
            {
                // Reduce la vida seg�n la cantidad de da�o definida en este script
                barraDeVida.RecibirDa�o(cantidadDanio);
            }
        }
    }
}
