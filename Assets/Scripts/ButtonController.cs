using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button myButton;

    private Transform buttonTransform;
    void Start()
    {
        buttonTransform = myButton.transform;
        myButton.onClick.AddListener(Rotate);
    }

    private void Rotate()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(buttonTransform.DOLocalRotate(new Vector3(0, 0, -720), 1f));
    }
}
