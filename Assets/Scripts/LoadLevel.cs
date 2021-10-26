using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public bool initiate = false;

    private void Update()
    {
        if (initiate)
        {
            initiate = false;
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(++currentIndex);
        }
    }
}
