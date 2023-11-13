using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager1 : MonoBehaviour
{
    public LevelTracker level;
    public KeyShard key;
    public GameObject Gate4;
    public GameObject Gate5;
    public GameObject Gate6;
    public GameObject Arrow2;

    // Start is called before the first frame update
    void Start()
    {
        Gate4.SetActive(false); Gate5.SetActive(false); Gate6.SetActive(false);

        Arrow2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LevelCheck1();
        KeyCheck1();
    }

    void LevelCheck1()
    {
        if (level.userLevel >= 3)
        {
            Gate4.SetActive(true);
        }
        if (level.userLevel >= 4)
        {
            Gate5.SetActive(true);
        }
        if (level.userLevel >= 5)
        {
            Gate6.SetActive(true);
        }
    }

    void KeyCheck1()
    {
        if (key.key4Activated == 1 && key.key5Activated == 1 && key.key6Activated == 1)
        {
            Arrow2.SetActive(true);
        }
    }
}
