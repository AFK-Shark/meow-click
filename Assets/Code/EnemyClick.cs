using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyClick : MonoBehaviour
{
    [SerializeField] int Score; //Счет на данный момент
    private int total_score; //Общий счет для достижений

    //Объекты для достижений

    [SerializeField] GameObject Achivment;
    [SerializeField] GameObject DefoltAchivment;

    [SerializeField] GameObject Achivment_1;
    [SerializeField] GameObject DefoltAchivment_1;

    [SerializeField] GameObject Achivment_2;
    [SerializeField] GameObject DefoltAchivment_2;

    [SerializeField] GameObject Achivment_3;
    [SerializeField] GameObject DefoltAchivment_3;

    //Счетчики и текст

    public int[] CostInt;
    private int ClickScore = 1;

    public int[] CostIntAUTO;
    private int ClickScoreAUTO = 1;

    public Text[] CostText;
    public Text[] CostTextAUTO;
    public Text ScoreText;

    //Добавление изображений юнитов

    public GameObject Unit1_Image;
    public GameObject Unit2_Image;

    public void ButtonClick()
    {
        Score += ClickScore;
        total_score++;
    }

    //Обновление Счета

    void Update()
    {
        //Обновление текста

        ScoreText.text = Score.ToString();

        //Проверка условия появления юнита

        if (ClickScoreAUTO == 5)
        {
            Unit1_Image.SetActive(true);
        }

        if (ClickScoreAUTO == 10)
        {
            Unit2_Image.SetActive(true);
        }

        //Проверка условий для достижений

        if (Score == 1)
        {
            Achivment.SetActive(true);
            DefoltAchivment.SetActive(false);
        }

        if (Score == 100)
        {
            Achivment_1.SetActive(true);
            DefoltAchivment_1.SetActive(false);
        }

        if (Score == 10000)
        {
            Achivment_2.SetActive(true);
            DefoltAchivment_2.SetActive(false);
        }

        if (Score == 100000)
        {
            Achivment_3.SetActive(true);
            DefoltAchivment_3.SetActive(false);
        }

    }

    //Покупка и обновление статуса магазина

    public void OnClickBuyLevel()
    {
        if (Score >= CostInt[0])
        {
            Score -= CostInt[0];
            CostInt[0] += CostInt[0] / 2;
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
            CostIntAUTO[0] += CostIntAUTO[0] / 2;
            CostTextAUTO[0].text = CostIntAUTO[0] + "$";
        }
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
