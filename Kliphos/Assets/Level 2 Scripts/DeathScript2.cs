using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript2 : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D creature)
    {
        if (creature.gameObject.CompareTag("Citizen"))
        {
            SceneManager.LoadScene("Lose Screen 2");
        }
    }
}