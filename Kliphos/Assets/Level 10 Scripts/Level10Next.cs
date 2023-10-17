using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level10Next : MonoBehaviour
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
        SceneManager.LoadScene("EndOfDemo");
    }

    public void BackToSelect()
    {
        SceneManager.LoadScene("Level Choice 4");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
}