using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class Fader : MonoBehaviour
{
    public Image fadeImage;
    public float fadeTime;
    public float fadeDelay = 0.5f;

    public UnityEvent onCompletefadeToBlack;

    void Start()
    {
        fadeImage.raycastTarget = false;
        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1);
        FadeFromBlack();
    }

    public void FadeFromBlack()
    {
        fadeImage.DOFade(0, fadeTime).SetDelay(fadeDelay);
    }

    public void FadeToBlack()
    {
        fadeImage.DOFade(1, fadeTime).OnComplete(onCompletefadeToBlack.Invoke);
    }
}
