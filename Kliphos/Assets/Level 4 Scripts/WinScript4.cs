using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript4 : MonoBehaviour
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
            level.UpdateLevel(4);
            if (key.keyAcquired == true)
            {
                PlayerPrefs.SetInt("key4", 1);
            }
            SceneManager.LoadScene("Win Screen 4");
        }
    }
}