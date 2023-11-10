using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPause : MonoBehaviour
{
    public GameObject deckMenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginLevel()
    {
        Time.timeScale = 1f;
        deckMenu.SetActive(false);
    }
}
