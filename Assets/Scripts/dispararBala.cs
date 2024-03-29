using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispararBala : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    private float nextFireTime = 0f;
    public static int damage;
    public int damageRef = 2;
    private Rigidbody rb;

    public float cantidadDanio = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Disparar();
            nextFireTime = Time.time +0.5f / fireRate;
        }

    }

    void Disparar()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}     
    

