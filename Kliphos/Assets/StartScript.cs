using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
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

    public void StartThis()
    {
        SceneManager.LoadScene("Level Choice 1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}