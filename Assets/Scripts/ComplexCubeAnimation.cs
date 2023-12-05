using UnityEngine;

public class ComplexCubeAnimation : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float scalingSpeed;
    [SerializeField] private float maxScale;
    [SerializeField] private float sinMultiplier;
    [SerializeField] private float sinOffset;
    [SerializeField] private float minScale;

    void Update()
    {
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        float scaleChange = Mathf.Sin(Time.time * scalingSpeed) * sinMultiplier + sinOffset;
        float currentScale = Mathf.Lerp(minScale, maxScale, scaleChange);
        transform.localScale = Vector3.one * currentScale;
    }
}