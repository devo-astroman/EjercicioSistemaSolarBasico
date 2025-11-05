using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [Header("Cameras in the Scene")]
    [SerializeField] private List<Camera> cameras = new List<Camera>();

    private int currentCameraIndex = -1;
    private Camera currentCamera;

    public Action OnCameraChanged;

    void Start()
    {
        // Optional: Activate the first camera at start
        if (cameras.Count > 0)
            ActivateCamera(0);
    }

    public void ActivateCamera(int id)
    {
        if (id < 0 || id >= cameras.Count)
        {
            Debug.LogWarning($"CameraManager: Invalid camera index {id}");
            return;
        }

        // Disable all cameras
        foreach (Camera cam in cameras)
            cam.enabled = false;

        // Enable the requested camera
        cameras[id].enabled = true;
        currentCameraIndex = id;
        currentCamera = cameras[id];

        OnCameraChanged?.Invoke();
    }

    // Optional helper to cycle cameras (e.g., press key to switch)
    public void NextCamera()
    {
        if (cameras.Count == 0) return;
        int next = (currentCameraIndex + 1) % cameras.Count;
        ActivateCamera(next);
    }

    public string[] GetActiveCameraInfo(){

        CameraInfo cameraInfo = currentCamera.GetComponent<CameraInfo>();

        return cameraInfo.GetCameraInformation();
    }
}
