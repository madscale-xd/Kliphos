using UnityEngine;

public class ColliderPause : MonoBehaviour
{
    public GameObject objectToCheck; // Assign the GameObject whose activity determines collider activation

    private BoxCollider2D boxCollider;

    void Start()
    {
        // Get the BoxCollider2D component attached to this GameObject
        boxCollider = GetComponent<BoxCollider2D>();

        // Check if the required components are present
        if (boxCollider == null)
        {
            Debug.LogError("BoxCollider2D component not found on the attached GameObject.");
            enabled = false; // Disable the script if the required components are not present
        }

        // Check if the objectToCheck is assigned
        if (objectToCheck == null)
        {
            Debug.LogError("Please assign the objectToCheck in the Inspector.");
            enabled = false; // Disable the script if objectToCheck is not assigned
        }
    }

    void Update()
    {
        // Check if the objectToCheck is active, and deactivate or activate the collider accordingly
        if (objectToCheck.activeSelf)
        {
            boxCollider.enabled = false; // Deactivate the collider if the objectToCheck is active
        }
        else
        {
            boxCollider.enabled = true; // Activate the collider if the objectToCheck is not active
        }
    }
}