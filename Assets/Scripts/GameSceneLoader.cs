using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace SpaceMadness
{
    public class GameSceneLoader : MonoBehaviour
    {
         public void LoadNextScene()
    {
        
        SceneManager.LoadScene("Game"); // Replace with actual scene name
    }
    }
}
