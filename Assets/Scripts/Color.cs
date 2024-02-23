using DG.Tweening;
using UnityEngine;

public class Color : MonoBehaviour
{
	[SerializeField] private Material _material;
	[SerializeField] private float _animationTime;

	private void Start()
	{
		_material.color = UnityEngine.Color.white;

		StartColorAnimation();
	}

	private void StartColorAnimation()
	{
		_material.DOColor(UnityEngine.Color.red, _animationTime)
			.SetLoops(-1, LoopType.Yoyo)
			.SetEase(Ease.InOutBack);
	}
}