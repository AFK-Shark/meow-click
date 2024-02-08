using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyClick : MonoBehaviour
{
    [SerializeField] int soul;
    public Text soulPoints;

    public void ButtonClick()
    {
        soul++;
    }

    void Update()
    {
        soulPoints.text = soul.ToString();
    }
}
