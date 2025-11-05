using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Camera targetCamera;
    [SerializeField] private Transform target;

    void LateUpdate()
    {
        if (targetCamera == null || target == null)
            return;

        targetCamera.transform.LookAt(target);
    }
}
