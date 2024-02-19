using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float velocidad = 5f;
    public static int damage;
    public int damageRef = 2;
    private Rigidbody rb;
    public float bulletLife = 0.75f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        damage = damageRef;
    }

    public int cantidadDanio = 2; // Ajusta la cantidad de da�o seg�n tus necesidades

    public int GetCantidadDanio()
    {
        return cantidadDanio;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemic"))
        {

        }
    }

}
