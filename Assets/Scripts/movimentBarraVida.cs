using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentBarraVida : MonoBehaviour
{
    public Transform enemigo;  // Asigna el objeto enemigo desde el Inspector
    private float offsetVertical;

    void Update()
    {
        if (enemigo != null)
        {
            // Obt�n la posici�n del enemigo en el mundo
            Vector3 posicionEnemigo = Camera.main.WorldToScreenPoint(enemigo.position);

            // Actualiza la posici�n de la barra de vida para que siga al enemigo
            transform.position = new Vector3(posicionEnemigo.x, posicionEnemigo.y + offsetVertical, 0f);
        }
    }
}

