using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pjMain : MonoBehaviour
{
    public float v;
    private Rigidbody2D rigidBody;

    // Update is called once per frame
    void Update()
    {
        mov();
    }

    void mov()
    {
        //Codigo que se encarga de mover al personaje
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rigidBody = GetComponent<Rigidbody2D>();

        rigidBody.velocity = new Vector2(y * v, rigidBody.velocity.y);
        rigidBody.velocity = new Vector2(x * v, rigidBody.velocity.x);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("PROYECTIL COLISIONO CON OBJETO");
        } 
        else
        {
            Debug.Log("No colisionado.");
        }
    }

}