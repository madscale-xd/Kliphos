using UnityEngine;

public class BruteMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust this speed as needed

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
        // Move the GameObject to the right using its Rigidbody2D
        Vector2 movement = new Vector2(speed, 0);
        rb.velocity = movement;
    }
}