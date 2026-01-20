using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

public class LoadingUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    public async UniTask FadeIn()
    {
        _canvasGroup.alpha = 1f;
        await _canvasGroup.DOFade(0f, 1f);
    }

    public async UniTask FadeOut()
    {
        _canvasGroup.alpha = 0f;
        await _canvasGroup.DOFade(1f, 1f);
    }
}
