using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript2 : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
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
            SceneManager.LoadScene("Win Screen 2");
        }
    }
}