using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1f;// in tiles per second
    private float xMove;
    private float yMove;



    void Awake()
    {

    }


    void Update()
    {
        float timeScaledSpeed = movementSpeed * Time.deltaTime;

        xMove = Input.GetAxis("Horizontal") * timeScaledSpeed;
        yMove = Input.GetAxis("Vertical") * timeScaledSpeed;
        transform.Translate(new Vector3(xMove, yMove, 0));
    }
}
