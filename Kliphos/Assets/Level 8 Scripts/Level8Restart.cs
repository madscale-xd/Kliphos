using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level8Restart : MonoBehaviour
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

    public void RestartLevel()
    {
        SceneManager.LoadScene("Level 8");
    }

    public void BackToSelect()
    {
        SceneManager.LoadScene("Level Choice 3");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
}