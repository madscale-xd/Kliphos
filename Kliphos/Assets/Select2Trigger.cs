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

    public void StartLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void StartLevel5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void StartLevel6()
    {
        SceneManager.LoadScene("Level 6");
    }

    public void StartLevel7()
    {
        SceneManager.LoadScene("Level 7");
    }

    public void StartLevel8()
    {
        SceneManager.LoadScene("Level 8");
    }

    public void StartLevel9()
    {
        SceneManager.LoadScene("Level 9");
    }

    public void StartLevel10()
    {
        SceneManager.LoadScene("Level 10");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
    public void Back()
    {
        SceneManager.LoadScene("Level Choice 1");
    }

    public void Back2()
    {
        SceneManager.LoadScene("Level Choice 2");
    }

    public void Back3()
    {
        SceneManager.LoadScene("Level Choice 3");
    }

    public void Next()
    {
        SceneManager.LoadScene("Level Choice 3");
    }

    public void Next2()
    {
        SceneManager.LoadScene("Level Choice 4");
    }
}