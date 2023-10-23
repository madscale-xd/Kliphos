using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript7 : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public LevelTracker level;
    private int passCount = 1;

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
                level.UpdateLevel(7);
                SceneManager.LoadScene("Win Screen 7");
            }
        }
    }
}