using UnityEngine;
using UnityEngine.SceneManagement; // Import SceneManager

public class VictoryZone : MonoBehaviour
{
    // Detects when an object enters the trigger zone (2D version)
    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug message to show which object enters the zone
        Debug.Log("Object entered: " + other.gameObject.name);

        // Check if the object that entered the trigger is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the victory zone!");
            LoadVictoryScene();
        }
    }

    // Loads the Victory scene
    void LoadVictoryScene()
    {
        Debug.Log("Loading Victory Scene...");
        SceneManager.LoadScene("Victory");
    }
}