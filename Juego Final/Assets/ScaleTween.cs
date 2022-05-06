using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScaleTween : MonoBehaviour
{
    public LeanTweenType inType;
    public LeanTweenType outType;
    float duration = 0.5f;

    public void OnEnable()
    {
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(gameObject, new Vector3(1,1,0), duration).setEase(inType);
    }

    public void OnComplete()
    {
        LeanTween.scale(gameObject, new Vector3(0.5f, 0.5f, 0), duration).setEase(outType);
    }
}
