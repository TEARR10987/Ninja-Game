using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public GameObject CatfoodPrefab;
    float span = 1.0f;            
    float delta = 0;            
    public GameObject hpGauge;
    public Text SconeText;
    int Score = 0;
    private void Start()
    {
        InvokeRepeating("GenerateArrow", 0, 1);
        InvokeRepeating("GenerateCatfood", 5, 5);
    }
    void Update()
    {
    }

    void GenerateArrow()
    {
        float px = Random.Range(-6.0f, 7.0f);
        Instantiate(ArrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);
    }
    void GenerateCatfood()
    {
        float px = Random.Range(-6.0f, 7.0f);
        Instantiate(CatfoodPrefab, new Vector3(px, 7, 0), Quaternion.identity);
    }
    public void DecreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void IncreaseScore()
    {
        Score += 100;
        SconeText.text = $"分數:{Score}";
    }
}

