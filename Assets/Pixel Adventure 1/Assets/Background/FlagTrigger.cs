using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlagTrigger : MonoBehaviour
{
    public GameObject messagePanel; // Assign the Message Panel
    public Text messageText; // Assign the Message Text
    private bool messageShown = false;
    public string puzzleSceneName = "Game"; // Change this to your puzzle scene name

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !messageShown)
        {
            messageShown = true;
            messagePanel.SetActive(true);
            messageText.text = "The path is blocked! Solve the puzzle to activate the gateway to the next environment.";
        }
    }

    public void CloseMessage()
    {
        messagePanel.SetActive(false);
        SceneManager.LoadScene(puzzleSceneName); // Transition to the puzzle scene
    }
}
