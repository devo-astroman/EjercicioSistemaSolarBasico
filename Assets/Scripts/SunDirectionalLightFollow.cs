using UnityEngine;

public class SunDirectionalLightFollow : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Light directionalLight;
    [SerializeField] private Transform target; // Earth

    void LateUpdate()
    {
        if (directionalLight == null || target == null)
            return;

        // Make the light point TOWARD the target
        Vector3 directionToTarget = (target.position - directionalLight.transform.position).normalized;
        directionalLight.transform.rotation = Quaternion.LookRotation(directionToTarget);
    }
}
