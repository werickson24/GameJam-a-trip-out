using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int hungerWorth = 0;

    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerManager.instance.ChangeHunger(hungerWorth);
        gameObject.SetActive(false);
    }
}
