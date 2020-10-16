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
        loadingObject1.DORotate(new Vector3(0, 0, -360), .8f, RotateMode.FastBeyond360)
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }
    
}
