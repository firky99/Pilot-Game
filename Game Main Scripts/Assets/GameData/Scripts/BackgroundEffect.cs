using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BackgroundEffect : MonoBehaviour
{
    public static BackgroundEffect instance;
    public GameObject[] plant;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GetComponent<Image>().DOColor(Color.red, 200f).SetLoops(-1, LoopType.Yoyo);

        for(int i = 0; i < plant.Length; i++) 
            plant[i].transform.DORotate(
                new Vector3(0,0,360), 5f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo);
    }

    public void ShakeBackground()
    {
        transform.DOShakePosition(0.1f, 100, 1, 1f, false, true);
    }
}
