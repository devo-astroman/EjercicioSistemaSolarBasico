using UnityEngine;

public class SelfRotate : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10f;

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
