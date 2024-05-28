using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyClick : MonoBehaviour
{
    [SerializeField] int Score;
    public int[] CostInt;
    private int ClickScore = 1;

    public int[] CostIntAUTO;
    private int ClickScoreAUTO = 1;

    public Text[] CostText;
    public Text[] CostTextAUTO;
    public Text ScoreText;

    public void ButtonClick()
    {
        Score += ClickScore;
    }

    //Обновление Счета

    void Update()
    {
        ScoreText.text = Score.ToString();

    }

    //Покупка и обновление статуса магазина

    public void OnClickBuyLevel()
    {
        if (Score >= CostInt[0])
        {
            Score -= CostInt[0];
            CostInt[0] *= 2;
            ClickScore += 2;
            CostText[0].text = CostInt[0] + "$";
        }
    }

    public void ByAutoClick() 
    {
        if (Score >= CostIntAUTO[0])
        {
            Score -= CostIntAUTO[0];
            StartCoroutine(AutoClick());
            ClickScoreAUTO += 1;
            CostIntAUTO[0] *= 2;
            CostTextAUTO[0].text = CostIntAUTO[0] + "$";
        }

        //if (ClickScoreAUTO == 4)
        //{
            
        //}
    }

    //+1 в секунду

    IEnumerator AutoClick()
    {
        while (true)
        {
            Score += 1;
            yield return new WaitForSeconds(1);
        }
    }

}
