using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public float barMax;
    public float barMin;
    public GameObject BarFillObject;
    private RectTransform barFill;
    public GameObject BarTextObject;
    private Text barText;

    private Color textColor = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        barFill = BarFillObject.GetComponent<RectTransform>();
        barText = BarTextObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        barText.text = PlayerManager.instance.hunger.ToString();
        barFill.sizeDelta = new Vector2(PlayerManager.instance.subHunger * barMax, 0);

        barText.text = PlayerManager.instance.hunger.ToString();
        if (PlayerManager.instance.hunger <= 2)
        {
            textColor = Color.Lerp(Color.white, Color.red, Mathf.PingPong(Time.time, 1));
        }
        else
        {
            textColor = Color.white;
        }
        barText.color = textColor;
    }
}
