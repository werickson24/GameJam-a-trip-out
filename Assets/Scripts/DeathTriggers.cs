using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTriggers : MonoBehaviour
{
    //damn did i ever put this animator in the wrong place
    public bool triggerReload = false;
    public bool triggerPlayerDeath = false;
    public bool triggerExplosion = false;

    public GameObject Player;
    public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerReload)
        {
            triggerReload = false;
            PlayerManager.instance.DeathReload();
        }
        if (triggerPlayerDeath)
        {
            triggerPlayerDeath = false;
            Player.GetComponent<SpriteRenderer>().color = new Color(0,0,0,0);
        }
        if (triggerExplosion)
        {
            Explosion.SetActive(true);
            //Explosion.GetComponent<Animator>().SetTrigger("explode");
            //Explosion.GetComponent<Animator>().Play("Explosion");
        }
        else{
            Explosion.SetActive(false);
        }
    }
}
