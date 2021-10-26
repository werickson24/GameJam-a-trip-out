using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    [Header("Hunger Managment")]
    public int hunger;
    [Range(0.0f, 1.0f)]
    public float subHunger;
    public float normalLoss;

    public Animator circleMaskAnimator;


    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1; //make sure death animation is undone
        if (instance != null)
        {
            Debug.LogWarning("PlayerManager instance already exists in scene, ignoring dupe.");
        }
        else
        {
            instance = this;
        }
        hunger = 3;
    }

    // Update is called once per frame
    private void Update()
    {
        subHunger -= normalLoss * Time.deltaTime;
        if (subHunger <= 0 && hunger > 1)
        {
            hunger--;
            subHunger = 1;
        }else if (subHunger <= 0 && hunger <= 1)
        {
            hunger = 0;
            DeathSequence();
        }
    }

    public void ChangeHunger(int change)
    {
        hunger += change;
        if (hunger <= 0)
        {
            subHunger = 0;
        }
    }
    private void DeathSequence()
    {
        Time.timeScale = 0;
        circleMaskAnimator.SetTrigger("PlayerDied");
        //animation will trigger bool to call reload method here
    }
    public void DeathReload()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex);
    }
}
