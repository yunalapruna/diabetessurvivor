using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class enemic1 : MonoBehaviour
{
    public float velocitatMissil = 0.01f;
    public float rotateSpeed = 0.05f;
    public GameObject player;
    private int punts = 2;
    string tag = "Player";
    private Rigidbody2D rb;

    private BarraDeVidaEnemic1 barraVida;
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

    }

}