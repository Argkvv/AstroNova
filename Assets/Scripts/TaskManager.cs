using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public GameObject taskCompletedCanvas; // Assign the "Task Completed" canvas in the Inspector

    // Call this function when the task is completed
    public void ShowTaskCompleted()
    {
        taskCompletedCanvas.SetActive(true); // Show the task completed canvas
    }
}
