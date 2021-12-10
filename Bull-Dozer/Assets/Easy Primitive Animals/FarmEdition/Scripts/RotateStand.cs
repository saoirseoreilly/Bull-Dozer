using UnityEngine;

public class RotateStand : MonoBehaviour
{
    private float rotSpeed = 150f;
    void Update()
    {
        transform.Rotate(-Vector3.up * (rotSpeed * Time.deltaTime));
    }
}
