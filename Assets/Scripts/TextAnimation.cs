using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
	[SerializeField] private Text _text1;
	[SerializeField] private Text _text2;
	[SerializeField] private Text _text3;
	[SerializeField] private float _animationTime;

	private void Start()
	{
		StartSequentialTextAnimation();
	}

	private void StartSequentialTextAnimation()
	{
		_text1.DOText("Я текст", _animationTime);
		_text2.DOText("И я тоже текст", _animationTime).SetRelative();
		_text3.DOText("Произошел взлом жопы", _animationTime, true, ScrambleMode.All);
		_text3.DOColor(UnityEngine.Color.cyan, _animationTime);
	}
}