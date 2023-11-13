using UnityEngine;

public class GorgonZone : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    public Transform gorgon;
    public Vector2 offset = new Vector2(1.0f, 1.0f); // Adjust the offset as needed

    private void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent < Rigidbody2D >();

        // Ensure the Rigidbody2D does not rotate around the Z-axis
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(speed, 0);
        rb.velocity = movement;
    }

    private void OnCollisionEnter2D(Collision2D gorZon)
    {
        if (gorZon.gameObject.CompareTag("Citizen") || gorZon.gameObject.CompareTag("creature2"))
        {
            gameObject.SetActive(false);
        }
        if (gorZon.gameObject.CompareTag("gate"))
        {
            gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (gorgon != null)
        {
            // Calculate the target position based on the gorgon's position and the offset.
            Vector3 targetPosition = gorgon.position + new Vector3(offset.x, offset.y, 0);

            // Set "gorZone" position to the target position.
            transform.position = targetPosition;
        }
    }
}
