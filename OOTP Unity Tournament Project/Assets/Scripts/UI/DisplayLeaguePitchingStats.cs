using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayLeaguePitchingStats : MonoBehaviour
{
    [SerializeField] private GameObject lgEraBlock;
    [SerializeField] private GameObject lgHrRateBlock;
    [SerializeField] private GameObject lgKRateBlock;
    [SerializeField] private GameObject lgBbRateBlock;

    private string lgEra;
    private string lgHrRate;
    private string lgKRate;
    private string lgbBrate;


    private void Start()
    {
           SetLeaguePitchingStats();
           UpdateLeaguePitchingStatDisplay();
    }

    private void SetLeaguePitchingStats()
    {
        lgEra = Format_Counting_Stat_Block.Instance.FormatCountingStat(League_Pitching_Json_Reader.Instance.myLeaguePitchingList.lg_pitching_stats[0].era, 2);
        lgHrRate =Format_Counting_Stat_Block.Instance.FormatCountingStat(League_Pitching_Json_Reader.Instance.myLeaguePitchingList.lg_pitching_stats[0].hrRate, 2);
        lgKRate = Format_Counting_Stat_Block.Instance.FormatCountingStat(League_Pitching_Json_Reader.Instance.myLeaguePitchingList.lg_pitching_stats[0].kRate, 2);
        lgbBrate = Format_Counting_Stat_Block.Instance.FormatCountingStat(League_Pitching_Json_Reader.Instance.myLeaguePitchingList.lg_pitching_stats[0].bbRate, 2);
    }

    private void UpdateLeaguePitchingStatDisplay()
    {
        UpdateStatBlock(lgEraBlock, lgEra);
        UpdateStatBlock(lgHrRateBlock, lgHrRate);
        UpdateStatBlock(lgKRateBlock, lgKRate);
        UpdateStatBlock(lgBbRateBlock, lgbBrate);
    }

    private void UpdateStatBlock(GameObject block, string stat)
    {
        TextMeshProUGUI statBlockText = block.transform.Find("Stat_block").GetComponent<TextMeshProUGUI>();
        statBlockText.text = stat;
    }

}
