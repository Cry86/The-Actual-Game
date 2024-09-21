using UnityEngine;

public class QuitButton : MonoBehaviour
{
    // This function is called when the quit button is clicked
    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
        
        // This line is useful to simulate quit behavior in the editor (for testing).
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
