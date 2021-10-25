using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    public int hunger;
    public GameObject hungerObject;
    private Text hungerText;
    private Color textColor = Color.white;
    // Start is called before the first frame update
    private void Start()
    {
        if (instance != null)
        {
            Debug.LogWarning("PlayerManager instance already exists in scene, ignoring dupe.");
        }
        else
        {
            instance = this;
        }
        hunger = 3;
        hungerText = hungerObject.GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        hungerText.text = hunger.ToString();
        if (hunger <= 2)
        {
            textColor = Color.Lerp(Color.white, Color.red, Mathf.PingPong(Time.time, 1));
        }
        else
        {
            textColor = Color.white;
        }
        hungerText.color = textColor;
    }

    public void ChangeHunger(int change)
    {
        hunger += change;
    }
}
