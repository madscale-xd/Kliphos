using UnityEngine;
using UnityEngine.SceneManagement;

public class GorgonZone : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    private void Start() 
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();

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
    }
}