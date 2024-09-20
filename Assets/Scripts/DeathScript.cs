using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;   // Initial respawn point (can be the initial spawn point of the player)
    public GameObject Player;       // The player object
    private Vector3 respawnPoint;   // Keeps track of the player's respawn point

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial respawn point to the startPoint position
        respawnPoint = startPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // This method is triggered when the player collides with an object (e.g., death zone)
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Reset player's position to the last checkpoint (or start point if no checkpoint was triggered)
            Player.transform.position = respawnPoint;
        }
    }

    // This method is triggered when the player enters a checkpoint trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            // Update the respawn point to the position of the checkpoint
            respawnPoint = other.transform.position;
            Debug.Log("Checkpoint reached!");
        }
    }
}
