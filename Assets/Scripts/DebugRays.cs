using UnityEngine;

public class DebugRays : MonoBehaviour
{
    [Header("References")]    
    [SerializeField] private Transform target; 
    [SerializeField] private float length = 2; 
    
    void Update()
    {
        // Local axis directions
        Vector3 xAxis = target.right;    // Red   (Local X)
        Vector3 yAxis = target.up;       // Green (Local Y)
        Vector3 zAxis = target.forward;  // Blue  (Local Z)        

        // Draw rays
        Debug.DrawRay(target.position, xAxis * length, Color.red);
        Debug.DrawRay(target.position, yAxis * length, Color.green);
        Debug.DrawRay(target.position, zAxis * length, Color.blue);
    }
}
