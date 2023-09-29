using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select2Trigger : MonoBehaviour
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

    public void StartLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
    public void Back()
    {
        SceneManager.LoadScene("Level Choice 1");
    }
    public void Next()
    {
        SceneManager.LoadScene("Level Choice 3");
    }
}