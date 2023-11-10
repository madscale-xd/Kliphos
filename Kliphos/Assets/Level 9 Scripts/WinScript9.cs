using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript9 : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public LevelTracker level;
    private int passCount = 2;

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
        if (gate.gameObject.CompareTag("Citizen") || gate.gameObject.CompareTag("gorgon"))
        {
            if (passCount >= 1)
            {
                passCount--;
            }
            else
            {
                level.UpdateLevel(9);
                SceneManager.LoadScene("Win Screen 9");
            }
        }
    }
}