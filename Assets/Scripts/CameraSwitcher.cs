using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    [Header("CameraManager")]
    [SerializeField] private CameraManager cameraManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            cameraManager.ActivateCamera(0);
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
            cameraManager.ActivateCamera(1);
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
            cameraManager.ActivateCamera(2);
            
    }
}
