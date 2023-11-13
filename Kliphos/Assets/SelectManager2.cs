using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager2 : MonoBehaviour
{
    public LevelTracker level;
    public KeyShard key;
    public GameObject Gate7;
    public GameObject Gate8;
    public GameObject Gate9;
    public GameObject Arrow3;

    // Start is called before the first frame update
    void Start()
    {
        Gate7.SetActive(false); Gate8.SetActive(false); Gate9.SetActive(false);

        Arrow3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LevelCheck2();
        KeyCheck2();
    }

    void LevelCheck2()
    {
        if (level.userLevel >= 6)
        {
            Gate7.SetActive(true);
        }
        if (level.userLevel >= 7)
        {
            Gate8.SetActive(true);
        }
        if (level.userLevel >= 8)
        {
            Gate9.SetActive(true);
        }
    }

    void KeyCheck2()
    {
        if (key.key7Activated == 1 && key.key8Activated == 1 && key.key9Activated == 1)
        {
            Arrow3.SetActive(true);
        }
    }
}
