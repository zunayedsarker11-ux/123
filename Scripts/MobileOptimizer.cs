using UnityEngine;

/// <summary>
/// Mobile optimization script to ensure smooth performance on Android devices
/// Attach this script to an empty GameObject in your scene
/// </summary>
public class MobileOptimizer : MonoBehaviour
{
    void Awake()
    {
        // Set lower quality settings for mobile devices
        QualitySettings.SetQualityLevel(1);
        
        // Lock frame rate to 60 FPS for consistent performance
        Application.targetFrameRate = 60;
        
        // Reduce physics timestep on mobile
        Time.fixedDeltaTime = 0.02f;
        
        // Disable unused render layers
        Physics.autoSimulation = true;
        
        Debug.Log("Mobile optimization applied!");
    }
    
    void OnDestroy()
    {
        // Clean up unused resources when scene changes
        Resources.UnloadUnusedAssets();
    }
}