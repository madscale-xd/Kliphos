using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public LevelTracker level;
    public KeyShard key;
    public GameObject Gate2;
    public GameObject Gate3;
    public GameObject Arrow1;

    // Start is called before the first frame update
    void Start()
    {
        Gate2.SetActive(false); Gate3.SetActive(false);

        Arrow1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LevelCheck();
        KeyCheck();
    }

    void LevelCheck()
    {
        if (level.userLevel >= 1)
        {
            Gate2.SetActive(true);
        }
        if (level.userLevel >= 2)
        {
            Gate3.SetActive(true);
        }
    }
    void KeyCheck()
    {
        if (key.key1Activated == 1 && key.key2Activated == 1 && key.key3Activated == 1)
        {
            Arrow1.SetActive(true);
        }
    }
}
