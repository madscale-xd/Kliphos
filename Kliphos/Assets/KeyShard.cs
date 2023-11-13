using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyShard : MonoBehaviour
{
    public bool keyAcquired = false;
    public int key1Activated;
    public int key2Activated;
    public int key3Activated;
    public int key4Activated;
    public int key5Activated;
    public int key6Activated;
    public int key7Activated;
    public int key8Activated;
    public int key9Activated;
    public int key10Activated;

    // Start is called before the first frame update
    void Start()
    {
        key1Activated = PlayerPrefs.GetInt("key1", 0);
        key2Activated = PlayerPrefs.GetInt("key2", 0);
        key3Activated = PlayerPrefs.GetInt("key3", 0);
        key4Activated = PlayerPrefs.GetInt("key4", 0);
        key5Activated = PlayerPrefs.GetInt("key5", 0);
        key6Activated = PlayerPrefs.GetInt("key6", 0);
        key7Activated = PlayerPrefs.GetInt("key7", 0);
        key8Activated = PlayerPrefs.GetInt("key8", 0);
        key9Activated = PlayerPrefs.GetInt("key9", 0);
        key10Activated = PlayerPrefs.GetInt("key10", 0);
        gameObject.SetActive(false);
        keyAcquired = false;
        KeyBasedOnLevel();
            
    }


    // OnCollisionEnter2D is called when this collider/rigidbody2D has begun touching another rigidbody2D/collider2D
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has a specific tag
        if (collision.gameObject.CompareTag("Citizen") || collision.gameObject.CompareTag("gorgon"))
        {
            keyAcquired = true;
            gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("creature2") || collision.gameObject.CompareTag("gorzone")){
            gameObject.SetActive(false);
        }
    }

    void KeyBasedOnLevel()
    {
        if (SceneManager.GetActiveScene().name == "Level 1" && key1Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 2" && key2Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 3" && key3Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 4" && key4Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 5" && key5Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 6" && key6Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 7" && key7Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 8" && key8Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 9" && key9Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level 10" && key10Activated == 0)
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Options")
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level Choice 1")
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level Choice 2")
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Level Choice 3")
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Win Screen 3")
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Win Screen 6")
        {
            gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Win Screen 9")
        {
            gameObject.SetActive(true);
        }
    }

    public void KeyReset()
    {
        PlayerPrefs.SetInt("key1", 0);
        PlayerPrefs.SetInt("key2", 0);
        PlayerPrefs.SetInt("key3", 0);
        PlayerPrefs.SetInt("key4", 0);
        PlayerPrefs.SetInt("key5", 0);
        PlayerPrefs.SetInt("key6", 0);
        PlayerPrefs.SetInt("key7", 0);
        PlayerPrefs.SetInt("key8", 0);
        PlayerPrefs.SetInt("key9", 0);
        PlayerPrefs.SetInt("key10", 0);
    }
}
