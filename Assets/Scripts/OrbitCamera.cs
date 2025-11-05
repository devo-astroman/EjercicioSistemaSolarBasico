using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Camera orbitCamera;
    [SerializeField] private Transform target;

    [Header("Orbit Settings")]
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] private float distance = 10f;

    [Header("Zoom Settings")]
    [SerializeField] private float zoomSpeed = 2f;
    [SerializeField] private float minDistance = 2f;
    [SerializeField] private float maxDistance = 50f;

    [SerializeField] private bool blockOrbit = false;

    private float currentX;
    private float currentY;

    void LateUpdate()
    {
        if (orbitCamera == null || target == null)
            return;

        // Rotate while holding left mouse button
        if (!blockOrbit && Input.GetMouseButton(0))
        {
            currentX += Input.GetAxis("Mouse X") * rotationSpeed;
            currentY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        }

        // Clamp vertical rotation so camera doesn't flip upside down
        currentY = Mathf.Clamp(currentY, -80f, 80f);

        // --- ZOOM (Scroll wheel) ---
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        distance -= scroll * zoomSpeed;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);

        // Calculate camera orbit position
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        Vector3 direction = new Vector3(0, 0, -distance);

        orbitCamera.transform.position = target.position + rotation * direction;
        orbitCamera.transform.LookAt(target);
    }
}
