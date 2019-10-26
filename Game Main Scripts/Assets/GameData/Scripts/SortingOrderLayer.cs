using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingOrderLayer : MonoBehaviour
{
    public string SortingLayerName;
    public int SortingOrder;

    void Awake ()
    {
        gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = SortingLayerName;
        gameObject.GetComponent<SpriteRenderer> ().sortingOrder = SortingOrder;
    }
}