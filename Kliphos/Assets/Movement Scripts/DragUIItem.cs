using UnityEngine;

public class DragUIItem : MonoBehaviour
{
    public GameObject objectToInstantiate; // Reference to the object prefab to be instantiated.

    private bool isDragging = false;
    private Vector3 offset;

    private void Update()
    {
        if (isDragging)
        {
            // Get the mouse position in world coordinates.
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Update the object's position based on the mouse position and the offset.
            transform.position = new Vector3(mousePos.x - offset.x, mousePos.y - offset.y, transform.position.z);
        }
    }

    private void OnMouseDown()
    {
        // Calculate the offset between the object's position and the mouse position.
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = new Vector3(mousePos.x - transform.position.x, mousePos.y - transform.position.y, 0);

        // Start dragging.
        isDragging = true;
    }

    private void OnMouseUp()
    {
        // Stop dragging.
        isDragging = false;

        // Instantiate the objectToInstantiate prefab.
        Instantiate(objectToInstantiate, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
