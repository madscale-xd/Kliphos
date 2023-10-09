using UnityEngine;

public class CharAirCheck : MonoBehaviour
{
    private Animator animator;
    private bool isInAir = false; // Your custom boolean parameter

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Update the animator parameter based on whether the character is in the air.
        animator.SetBool("isInAir", isInAir);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an object tagged as "platform."
        if (collision.gameObject.CompareTag("platform"))
        {
            // The character is grounded.
            isInAir = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the character is no longer colliding with any objects.
        // If so, it's in the air.
        isInAir = true;
    }
}
