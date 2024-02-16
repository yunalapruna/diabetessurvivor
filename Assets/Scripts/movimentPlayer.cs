using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimento = Vector2.zero;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movimento += Vector2.right * velocidad;
            //Hace que se mueva a la derecha
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movimento += Vector2.right * -velocidad;
            //Hace que se mueva a la izquierda
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movimento += Vector2.up * velocidad;
            //Hace que se mueva hacia arriba
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movimento += Vector2.up * -velocidad;
            //Hace que se mueva hacia abajo
        }

        rb.velocity = movimento;
    }

    public void OnCollision2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("Bala"))
        {
            vidaActual = vidaActual - 2;
        }

    }
