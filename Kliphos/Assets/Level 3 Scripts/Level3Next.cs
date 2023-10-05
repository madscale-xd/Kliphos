using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Next : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void BackToSelect()
    {
        SceneManager.LoadScene("Level Choice 1");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
}