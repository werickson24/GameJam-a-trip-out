using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1f;// in tiles per second
    private float xMove;
    private float yMove;
    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float timeScaledSpeed = movementSpeed * Time.deltaTime;

        xMove = Input.GetAxis("Horizontal") * timeScaledSpeed;
        yMove = Input.GetAxis("Vertical") * timeScaledSpeed;
        //body.AddForce(new Vector2(xMove, yMove));
        body.velocity = new Vector2(xMove, yMove);

    }
}
