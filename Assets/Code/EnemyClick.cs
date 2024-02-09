using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyClick : MonoBehaviour
{
    [SerializeField] int Score;
    public int[] CostInt;
    private int ClickScore = 1;

    public GameObject ShopPanel;

    public Text[] CostText;
    public Text ScoreText;

    public void ButtonClick()
    {
        Score += ClickScore;
    }

    void Update()
    {
        ScoreText.text = Score.ToString();
    }

    public void ShowAndHideShopPanel()
    {
        ShopPanel.SetActive(!ShopPanel.activeSelf);
    }

    public void OnClickBuyLevel()
    {
        if (Score >= CostInt[0])
        {
            Score -= CostInt[0];
            CostInt[0] *= 2;
            ClickScore *= 2;
            CostText[0].text = CostInt[0] + "";
        }
    }
}
