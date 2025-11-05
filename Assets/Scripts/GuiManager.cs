using UnityEngine;

public class GuiManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private CameraInfo[] cameraInfoList;
    [SerializeField] private CameraManager cameraManager;
    
    
    
    
    private string cameraName = "Sun camera";
    private string cameraDescription = "Points to the Sun, hold left click to orbit, use scroll to zoom in and zom out";

    //Add here the list of CameraInfo
    //Get from the current active camera
    //Then should show the info 

    // For quick HUD/debug
    void Start()
    {
        cameraManager.OnCameraChanged += UpdateGuiCameraInfo;
    }

    void UpdateGuiCameraInfo(){
        string[] cameraInfo =  cameraManager.GetActiveCameraInfo();

        cameraName = cameraInfo[1];
        cameraDescription = cameraInfo[2];
    }

    // For quick HUD/debug
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 250, 30), cameraName);
        GUI.Label(new Rect(10, 50, 500, 30), cameraDescription);
    }
}
