using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed; 

    public SphereMovement(float initialSpeed)
    {
        _movementSpeed = initialSpeed;
    }

    void Update()
    {
        transform.Translate(Vector3.right * _movementSpeed * Time.deltaTime);
    }
}
