using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int hungerWorth = 0;

    private void OnMouseDown()
    {
        PlayerManager.instance.ChangeHunger(hungerWorth);
    }
}
