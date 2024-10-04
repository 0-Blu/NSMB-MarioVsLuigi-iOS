using UnityEngine;

public class FrameRateSetter : MonoBehaviour
{
    void Start()
    {
        // Set the target frame rate to 120
        Application.targetFrameRate = 120;
    }
}
