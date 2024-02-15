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
    public GameObject enemic1;
    public GameObject enemic2;
    public GameObject enemic3;
    public int enemic5 = 4;

    public Transform playerTrans;
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
        enemic1 = GameObject.FindGameObjectWithTag("Enemic1");
        playerTrans = enemic1.transform;
    }

    
}
