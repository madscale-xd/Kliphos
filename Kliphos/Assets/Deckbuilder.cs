using UnityEngine;

public class Deckbuilder : MonoBehaviour
{
    public GameObject objectToDelete1; // Reference to the first object to be deleted.
    public GameObject objectToDelete2; // Reference to the second object to be deleted.
    public GameObject objectToInstantiate; // Reference to the object prefab to be instantiated.
    public float dragAlpha = 0.5f; // Alpha value when dragging.

    private bool isDragging = false;
    private Vector3 offset;
    private Material objectMaterial; // Reference to the object's material.

    private void Start()
    {
        // Get the material of the object (assuming it uses a Standard Shader).
        objectMaterial = GetComponent<Renderer>().material;
    }

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

        // Set the object's transparency to the dragAlpha value.
        SetObjectTransparency(dragAlpha);
    }

    private void OnMouseUp()
    {
        // Stop dragging.
        isDragging = false;

        // Set the object's transparency back to 1.0f (fully opaque).
        SetObjectTransparency(1.0f);

        // Delete the assigned objects.
        Destroy(objectToDelete1);
        Destroy(objectToDelete2);

        // Instantiate the assigned object.
        Instantiate(objectToInstantiate, transform.position, Quaternion.identity);

        // Deactivate the dragging object.
        gameObject.SetActive(false);
    }

    private void SetObjectTransparency(float alphaValue)
    {
        Color newColor = objectMaterial.color;
        newColor.a = alphaValue;
        objectMaterial.color = newColor;
    }
}
