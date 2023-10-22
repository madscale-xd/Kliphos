using UnityEngine;
using System.Collections;

public class GaleScript : MonoBehaviour
{
    public float forceMagnitude = 10.0f; // The magnitude of the force to apply.
    public Vector2 forceDirection = Vector2.up; // The direction of the force in 2D.
    public bool applyToRight = true;

    private Rigidbody2D rb;
    private Vector2 lastPosition; // Store the last position of the object above.

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject.
        rb = GetComponent<Rigidbody2D>();

        // Check if the Rigidbody2D component exists.
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on this GameObject.");
        }

        // Initialize the last position to the current position.
        lastPosition = transform.position;
    }

    void FixedUpdate()
    {
        // Calculate the movement vector of the object above since the last FixedUpdate.
        Vector2 movementVector = (Vector2)transform.position - lastPosition;

        // Cast a ray directly upward from this object.
        Vector2 rayOrigin = transform.position;
        Vector2 rayDirection;
        if (applyToRight)
        {
            rayDirection = Vector2.left;
        }
        else
        {
            rayDirection = Vector2.right;
        }

        // Set the maximum distance for the raycast.
        float maxDistance = movementVector.magnitude;

        // Perform the raycast using 2D physics.
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin, rayDirection, maxDistance);

        if (hit.collider != null)
        {
            // Check if the hit object has a Rigidbody2D.
            Rigidbody2D hitRigidbody = hit.collider.GetComponent<Rigidbody2D>();
            if (hitRigidbody != null)
            {
                // Normalize the force direction to ensure consistent speed in all directions.
                forceDirection.Normalize();

                // Apply the force to the object above using 2D physics.
                if (applyToRight)
                {
                    hitRigidbody.AddForce(Vector2.left * forceMagnitude, ForceMode2D.Impulse);
                }
                else
                {
                    hitRigidbody.AddForce(Vector2.right * forceMagnitude, ForceMode2D.Impulse);
                }
            }
        }

        // Update the last position.
        lastPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // 1 corresponds to the right mouse button.
        {
            applyToRight = !applyToRight;
        }
    }
}
