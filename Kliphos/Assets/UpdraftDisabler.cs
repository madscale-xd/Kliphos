using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdraftDisabler : MonoBehaviour
{
    public LevelTracker level;
    // Start is called before the first frame update
    void Start()
    {
        if (level.ReturnLevel() < 3)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
