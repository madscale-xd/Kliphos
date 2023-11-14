using UnityEngine;

public class Reverse : MonoBehaviour
{
    private Animator animator;
    private bool isMirrored = false;

    void Start()
    {
        animator = GetComponent<Animator>();

        // Check if the Animator component exists.
        if (animator == null)
        {
            Debug.LogError("Animator component not found on this GameObject.");
        }
    }

    void Update()
    {
        // Toggle mirror when the right mouse button is pressed.
        if (Input.GetMouseButtonDown(1)) // Right mouse button
        {
            // Toggle the scale to mirror the object along the X-axis.
            isMirrored = !isMirrored;
            UpdateMirrorState();
        }
    }

    void UpdateMirrorState()
    {
        // Toggle the X-axis scale based on the mirror state.
        Vector3 newScale = transform.localScale;
        newScale.x = isMirrored ? -Mathf.Abs(newScale.x) : Mathf.Abs(newScale.x);
        transform.localScale = newScale;
    }
}
