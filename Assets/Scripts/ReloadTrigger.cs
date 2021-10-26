using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadTrigger : MonoBehaviour
{
    public bool triggerReload = false;
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
    }
}
