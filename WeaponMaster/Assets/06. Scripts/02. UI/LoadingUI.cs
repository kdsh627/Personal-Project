using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

public class LoadingUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private float       _fadeDuration;

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    /// <summary>
    /// 페이드 인
    /// </summary>
    /// <returns></returns>
    public async UniTask FadeIn()
    {
        _canvasGroup.alpha = 1f;
        await _canvasGroup.DOFade(0f, _fadeDuration);
    }


    /// <summary>
    /// 페이드 아웃
    /// </summary>
    /// <returns></returns>
    public async UniTask FadeOut()
    {
        _canvasGroup.alpha = 0f;
        await _canvasGroup.DOFade(1f, _fadeDuration);
    }
}
