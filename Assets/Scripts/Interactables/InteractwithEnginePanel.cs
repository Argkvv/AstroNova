using SpaceMadness.InteractionSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceMadness.Interactables
{
    public class InteractwithEnginePanel : BaseInteractable
    {

        
        [SerializeField] private string sceneToLoad = "SampleScene";

        public override void ExecuteInteraction(GameObject interactorObject)
        {
            PlayerPositionSaver.SavedPosition = interactorObject.transform.position;
            SceneManager.LoadScene(sceneToLoad);
        }

        public override bool CheckIfAvailable(GameObject interactorObject)
        {
            // Always available for interaction
            return true;
        }
        
    }
}
