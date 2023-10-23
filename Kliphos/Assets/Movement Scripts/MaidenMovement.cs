using UnityEngine;
using UnityEngine.SceneManagement;

public class MaidenMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust this speed as needed
    public int hp = 0;
    private Rigidbody2D rb;
    public SceneCaller sc;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();

        // Ensure the Rigidbody2D does not rotate around the Z-axis
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        // Move the GameObject to the right using its Rigidbody2D
        Vector2 movement = new Vector2(speed, 0);
        rb.velocity = movement;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if ((other.gameObject.CompareTag("creature2") || other.gameObject.CompareTag("gorzone")) && hp > 0)
        {
            hp--;
        }
        else if ((other.gameObject.CompareTag("creature2") || other.gameObject.CompareTag("gorzone")) && hp == 0)
        {
            if (SceneManager.GetActiveScene().name.Equals("Level 4"))
            {
                sc.callDeath4();
            }
            else if (SceneManager.GetActiveScene().name.Equals("Level 5"))
            {
                sc.callDeath5();
            }
            else if (SceneManager.GetActiveScene().name.Equals("Level 6"))
            {
                sc.callDeath6();
            }
            else if (SceneManager.GetActiveScene().name.Equals("Level 7"))
            {
                sc.callDeath7();
            }
            else if (SceneManager.GetActiveScene().name.Equals("Level 8"))
            {
                sc.callDeath8();
            }
            else if (SceneManager.GetActiveScene().name.Equals("Level 9"))
            {
                sc.callDeath9();
            }
            else if (SceneManager.GetActiveScene().name.Equals("Level 10"))
            {
                sc.callDeath10();
            }
        }
        if (other.gameObject.CompareTag("gate"))
        {
            gameObject.SetActive(false);
        }
    }
}