using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pjEnemy : MonoBehaviour
{
    public float v;
    public Transform target;
    private Rigidbody2D rigidBody;

    // Update is called once per frame
    void Update()
    {
        mov();
    }

    void mov()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        Vector2 pjPos = new Vector2(target.position.x, target.position.y);
        Vector2 enemyPos = new Vector2(rigidBody.position.x, rigidBody.position.y);

        Vector2 lookAt = pjPos - enemyPos;

        rigidBody.velocity = new Vector2(lookAt.y * v, rigidBody.velocity.y);
        rigidBody.velocity = new Vector2(lookAt.x * v, rigidBody.velocity.x);

    }

}
