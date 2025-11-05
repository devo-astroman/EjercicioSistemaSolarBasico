using UnityEngine;

public class CameraInfo : MonoBehaviour
{
    [Header("Information")]
    [SerializeField] private string cameraName;
    [SerializeField] private string cameraKey;
    [SerializeField] private string cameraDescription;


    public string GetCameraName(){
        return cameraName;
    }

    public string GetCameraKey(){
        return cameraKey;
    }

    public string GetCameraDescription(){
        return cameraDescription;
    }

    public string[] GetCameraInformation(){
        return new string[] { cameraKey, cameraName, cameraDescription };
    }
}
