using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class CardControl : MonoBehaviour
{
    [SerializeField] private Transform[] cards;
    [SerializeField] private Transform[] points;
    void Start()
    {
        var sequence = DOTween.Sequence();
        for (var i = 0; i < cards.Length; i++)
        {
            var sides = cards[i].GetComponentsInChildren<Transform>();

            sequence.Append(cards[i].DOMove(points[i].position, .3f))
                .Append(sides[2].DOLocalRotate(new Vector3(0, 180, 0), .8f).SetEase(Ease.Linear))
                .Join(sides[1].DOLocalRotate(new Vector3(0, 180, 0), .8f).SetEase(Ease.Linear))
                .Join(sides[2].DOScale(Vector3.zero, 0f).SetDelay(.4f));
        }
    }
}
