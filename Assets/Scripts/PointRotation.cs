using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PointRotation : MonoBehaviour
{
    [SerializeField] private Transform loadingObject1;
    void Start()
    {
        var s = DOTween.Sequence();
        s.Append(loadingObject1.DORotate(new Vector3(0, 0, 180), 1f));
    }
    
}
