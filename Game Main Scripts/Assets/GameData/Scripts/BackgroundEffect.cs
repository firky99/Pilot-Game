using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BackgroundEffect : MonoBehaviour
{
    public static BackgroundEffect instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GetComponent<Image>().DOColor(Color.red, 200f).SetLoops(-1, LoopType.Yoyo);
    }

    public void ShakeBackground()
    {
        transform.DOShakePosition(0.1f, 100, 1, 1f, false, true);
    }
}
