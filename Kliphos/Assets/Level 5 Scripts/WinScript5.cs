using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript5 : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public LevelTracker level;
    public KeyShard key;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D gate)
    {
        if (gate.gameObject.CompareTag("Citizen"))
        {
            level.UpdateLevel(5);
            if (key.keyAcquired == true)
            {
                PlayerPrefs.SetInt("key5", 1);
            }
            SceneManager.LoadScene("Win Screen 5");
        }
    }
}