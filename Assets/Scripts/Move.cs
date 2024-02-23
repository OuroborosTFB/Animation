using DG.Tweening;
using UnityEngine;

public class Move : MonoBehaviour
{
	[SerializeField] private float _animationTime;
	[SerializeField] private float _targetPositionX;
	[SerializeField] private float _targetPositionY;
	[SerializeField] private float _targetPositionZ;

	private Transform _transform;
	
	private void Start()
	{
		_transform = GetComponent<Transform>();
		
		StartMoveAnimation();
	}

	private void StartMoveAnimation()
	{
		Vector3 targetPosition = new Vector3(_targetPositionX, _targetPositionY, _targetPositionZ);

		_transform.DOMove(targetPosition, _animationTime)
			.SetEase(Ease.InOutQuint)
			.SetLoops(-1, LoopType.Yoyo);

	}
}