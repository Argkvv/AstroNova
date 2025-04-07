using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TaskUIController : MonoBehaviour
{
    public static TaskUIController Instance;
    public GameObject taskCompletedUI;

    void Awake()
    {
        Instance = this;
    }

    public void ShowCompletedMessage()
    {
        StartCoroutine(ShowMessageRoutine());
    }

    private IEnumerator ShowMessageRoutine()
    {
        taskCompletedUI.SetActive(true);
        yield return new WaitForSeconds(2f);
        taskCompletedUI.SetActive(false);
    }
}
