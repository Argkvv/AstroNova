using UnityEngine;

public class PlayerPositionSaver : MonoBehaviour
{
    public static Vector3 SavedPosition;

    public void SavePosition(Vector3 position)
    {
        SavedPosition = position;
    }
}
