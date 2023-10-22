using UnityEngine;
using UnityEngine.SceneManagement;

public class MinotaurMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust this speed as needed
    public bool move = false; // Boolean to control movement

    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();

        // Ensure the Rigidbody2D does not rotate around the Z-axis
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        if (move) // Check the "move" boolean to determine whether to move
        {
            // Move the GameObject to the right using its Rigidbody2D
            Vector2 movement = new Vector2(speed, 0);
            rb.velocity = movement;
        }
        else
        {
            // If "move" is false, stop the Minotaur's movement
            rb.velocity = Vector2.zero;
        }
    }
    private void OnCollisionEnter2D(Collision2D mino)
    {
        if (mino.gameObject.CompareTag("Citizen") || mino.gameObject.CompareTag("gorzone"))
        {
            gameObject.SetActive(false);
        }
    }
}
