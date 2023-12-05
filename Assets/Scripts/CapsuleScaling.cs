using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;
    [SerializeField] private float _maxScale;
    [SerializeField] private float _sinMultiplier;
    [SerializeField] private float _sinOffset;
    [SerializeField] private float _minScale;

    void Update()
    {
        float scaleChange = Mathf.Sin(Time.time * _scalingSpeed) * _sinMultiplier + _sinOffset;
        float currentScale = Mathf.Lerp(_minScale, _maxScale, scaleChange);

        transform.localScale = Vector3.one * currentScale;
    }
}