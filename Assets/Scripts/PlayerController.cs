using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1f;
    private float xMove;
    private float yMove;
    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float timeScaledSpeed = movementSpeed * Time.fixedDeltaTime;

        xMove = Input.GetAxis("Horizontal") * timeScaledSpeed;
        yMove = Input.GetAxis("Vertical") * timeScaledSpeed;
        //body.AddForce(new Vector2(xMove, yMove));
        body.MovePosition(new Vector2(gameObject.transform.position.x + xMove, gameObject.transform.position.y + yMove));

    }
}
