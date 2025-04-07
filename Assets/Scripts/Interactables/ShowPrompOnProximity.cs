using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowPromptOnProximity : MonoBehaviour
{
    public GameObject promptUI;
    private bool isPlayerNear = false;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            promptUI.SetActive(true);
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            promptUI.SetActive(false);
            isPlayerNear = false;
        }
    }
}
