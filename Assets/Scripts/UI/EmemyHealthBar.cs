using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmemyHealthBar : MonoBehaviour
{
    [SerializeField] private Image healhBar;
    [SerializeField] private Enemy enemy;
    [SerializeField] private Transform enemyPosition;
    [SerializeField] private Transform topPoint, bottomPoint;
    private void Start()
    {
        if (enemyPosition.position.y > 0)
            transform.position = bottomPoint.position;
        else if(enemyPosition.position.y < 0)
            transform.position = topPoint.position;
    }

    private void Update()
    {
        healhBar.fillAmount = enemy.Health / enemy.Maxhealth;
    }
}