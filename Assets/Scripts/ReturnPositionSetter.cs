using UnityEngine;

public class ReturnPositionSetter : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        if (PlayerPrefs.GetInt("ShowTaskCompleted", 0) == 1)
        {
            player.transform.position = PlayerPositionSaver.SavedPosition;

            PlayerPrefs.SetInt("ShowTaskCompleted", 0);

            TaskUIController.Instance.ShowCompletedMessage();
        }
    }
}
