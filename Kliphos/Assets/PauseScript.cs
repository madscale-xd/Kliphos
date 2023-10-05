using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject[] objectsToDeactivate; // An array to hold up to five objects to deactivate

    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    public void TogglePauseMenu()
    {
        if (!pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;

            // Deactivate up to five objects by disabling their BoxCollider2D components
            foreach (var obj in objectsToDeactivate)
            {
                if (obj != null)
                {
                    BoxCollider2D collider = obj.GetComponent<BoxCollider2D>();
                    if (collider != null)
                    {
                        collider.enabled = false;
                    }
                }
            }
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;

            // Activate the previously deactivated objects by enabling their BoxCollider2D components
            foreach (var obj in objectsToDeactivate)
            {
                if (obj != null)
                {
                    BoxCollider2D collider = obj.GetComponent<BoxCollider2D>();
                    if (collider != null)
                    {
                        collider.enabled = true;
                    }
                }
            }
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToSelect1()
    {
        SceneManager.LoadScene("Level Choice 1");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

        // Activate the previously deactivated objects by enabling their BoxCollider2D components
        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                BoxCollider2D collider = obj.GetComponent<BoxCollider2D>();
                if (collider != null)
                {
                    collider.enabled = true;
                }
            }
        }
    }
}
