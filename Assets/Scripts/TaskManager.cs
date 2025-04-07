using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public GameObject completionPanel; // This is the "Task Completed" box
    public Button backButton; // This is the "Go Back" button

    void Start()
    {
        completionPanel.SetActive(false); // Step 2: Hide the panel at the start
        backButton.onClick.AddListener(ReturnToLevel); // When button is clicked, go back
    }

    // Step 3: Show the "Task Completed" box when the task is done
    public void ShowCompletionMessage()
    {
        completionPanel.SetActive(true);
    }

    // Step 4: This function takes the player back to the level
    void ReturnToLevel()
    {
        string lastLevel = PlayerPrefs.GetString("LastLevel", "Level 1"); // Get saved level name
        SceneManager.LoadScene(lastLevel); // Load that level
    }
    }
    

