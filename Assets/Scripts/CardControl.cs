using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class CardControl : MonoBehaviour
{
    [SerializeField] private Transform[] cards;
    [SerializeField] private Transform[] points;
    [SerializeField] private GameObject pp;
    void Start()
    {
        var sequence = DOTween.Sequence();
        for (var i = 0; i < cards.Length; i++)
        {
           sequence.Append(cards[i].DOMove(points[i].position, .3f));
           sequence.Append(cards[i].DOLocalRotate(new Vector3(0, 180, 0), .6f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
