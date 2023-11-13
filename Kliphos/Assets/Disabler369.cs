using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Disabler369 : MonoBehaviour
{
    public KeyShard key;
    public GameObject NextLevelToDisable;
    // Start is called before the first frame update
    void Start()
    {
        NextLevelToDisable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        EnableKey();
    }

    void EnableKey()
    {
        if(SceneManager.GetActiveScene().name == "Win Screen 3")
        {
            if (key.key1Activated == 1 && key.key2Activated == 1 && key.key3Activated == 1)
            {
                NextLevelToDisable.SetActive(true);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Win Screen 6")
        {
            if (key.key4Activated == 1 && key.key5Activated == 1 && key.key6Activated == 1)
            {
                NextLevelToDisable.SetActive(true);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Win Screen 9")
        {
            if (key.key7Activated == 1 && key.key8Activated == 1 && key.key9Activated == 1)
            {
                NextLevelToDisable.SetActive(true);
            }
        }
    }
}
