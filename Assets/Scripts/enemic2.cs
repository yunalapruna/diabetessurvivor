using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemic2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocitatMissil = 0.01f;
    public float rotateSpeed = 0.05f;
    public GameObject player;
    private int punts = 2;
    string tag = "Player";
    private Rigidbody2D rb;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    private float nextFireTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag(tag);

    }

    private void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 direccio = (player.transform.position - rb.transform.position);
            direccio.Normalize();

            // this.gameObject.transform.rotation = Quaternion.LookRotation(direccio);
            float rotateAmout = Vector3.Cross(direccio, transform.up).z;
            rb.angularVelocity = -rotateAmout * rotateSpeed;

            //this.gameObject.transform.rotation = transform.rotation;
            rb.velocity = direccio * velocitatMissil;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Disparar();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
    void Disparar()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
