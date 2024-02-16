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

   // public Transform playerTrans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);

    }

    private void Awake()
    {
        damage = damageRef;
        rb = GetComponent<Rigidbody>();
    }

    public int cantidadDanio = 2; // Ajusta la cantidad de daño según tus necesidades

    public int GetCantidadDanio()
    {
        return cantidadDanio;
    }

}
