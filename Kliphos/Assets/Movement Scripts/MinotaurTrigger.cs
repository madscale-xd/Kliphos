using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurTrigger : MonoBehaviour
{
    public MinotaurMovement mino;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure that the MinotaurMovement script is assigned to mino
        if (mino == null)
        {
            Debug.LogError("MinotaurMovement script is not assigned to mino.");
        }
    }

    // OnTriggerEnter2D is called when a collider enters the trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is tagged as "citizen"
        if (other.CompareTag("Citizen") || other.CompareTag("gorgon"))
        {
            // Set the "move" variable of the MinotaurMovement script to true
            mino.move = true;
        }
    }
}
