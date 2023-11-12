using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeckPause : MonoBehaviour
{
    public GameObject deckMenu;
    public GameObject pauseButton;
    public GameObject[] objectsToDeactivate;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginLevel()
    {
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        deckMenu.SetActive(false);

        foreach (GameObject obj in objectsToDeactivate)
        {
            // Check if the object is not null and is not destroyed
            if (obj != null && obj.activeSelf)
            {
                obj.SetActive(false);
            }
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToSelect()
    {
        if(SceneManager.GetActiveScene().name == "Level 1" || SceneManager.GetActiveScene().name == "Level 2" || SceneManager.GetActiveScene().name == "Level 3")
        {
            SceneManager.LoadScene("Level Choice 1");
        }
        else if (SceneManager.GetActiveScene().name == "Level 4" || SceneManager.GetActiveScene().name == "Level 5" || SceneManager.GetActiveScene().name == "Level 6")
        {
            SceneManager.LoadScene("Level Choice 2");
        }
        else if (SceneManager.GetActiveScene().name == "Level 7" || SceneManager.GetActiveScene().name == "Level 8" || SceneManager.GetActiveScene().name == "Level 9")
        {
            SceneManager.LoadScene("Level Choice 3");
        }
        else if (SceneManager.GetActiveScene().name == "Level 10")
        {
            SceneManager.LoadScene("Level Choice 4");
        }
    }
}
