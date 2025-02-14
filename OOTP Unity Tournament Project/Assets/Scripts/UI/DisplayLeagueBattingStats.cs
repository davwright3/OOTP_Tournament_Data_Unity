using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayLeagueBattingStats : MonoBehaviour
{
    [SerializeField] private GameObject avgStatBlock;
    [SerializeField] private GameObject obpStatBlock;
    [SerializeField] private GameObject slgStatBlock;
    [SerializeField] private GameObject opsStatBlock;
    [SerializeField] private GameObject hrStatBlock;
    [SerializeField] private GameObject krateStatBlock;
    [SerializeField] private GameObject bbrateStatBlock;
    [SerializeField] private GameObject sbStatBlock;

    private string lgAvg;
    private string lgObp;
    private string lgSlg;
    private string lgOps;
    private string lgHr;
    private string lgKpct;
    private string lgBbpct;
    private string lgSbrate;

    private void Start()
    {
        SetLeagueStats();
        UpdateLeagueBattingStatsDisplay();
        
    }

    private void SetLeagueStats()
    {
        lgAvg = Format_Rate_Stat_Block.Instance.FormatRateStat(League_Batting_Json_Reader.Instance.myLeagueStatsList.lg_stats[0].avg, 4);
        lgObp = Format_Rate_Stat_Block.Instance.FormatRateStat(League_Batting_Json_Reader.Instance.myLeagueStatsList.lg_stats[0].obp, 4);
        lgSlg = Format_Rate_Stat_Block.Instance.FormatRateStat(League_Batting_Json_Reader.Instance.myLeagueStatsList.lg_stats[0].slg, 4);
        lgOps = Format_Rate_Stat_Block.Instance.FormatRateStat(League_Batting_Json_Reader.Instance.myLeagueStatsList.lg_stats[0].ops, 4);
        lgHr = Format_Counting_Stat_Block.Instance.FormatCountingStat(League_Batting_Json_Reader.Instance.myLeagueStatsList.lg_stats[0].hr, 2);
        lgKpct = Format_Pct_Stat_Block.Instance.FormatPctStat(League_Batting_Json_Reader.Instance.myLeagueStatsList.lg_stats[0].kpct, 2);
        lgBbpct = Format_Pct_Stat_Block.Instance.FormatPctStat(League_Batting_Json_Reader.Instance.myLeagueStatsList.lg_stats[0].bbpct, 2);
        lgSbrate = Format_Counting_Stat_Block.Instance.FormatCountingStat(League_Batting_Json_Reader.Instance.myLeagueStatsList.lg_stats[0].sbrate, 2);
        
    }

    private void UpdateLeagueBattingStatsDisplay()
    {
        UpdateStatBlock(avgStatBlock, lgAvg);
        UpdateStatBlock(obpStatBlock, lgObp);
        UpdateStatBlock(slgStatBlock, lgSlg);
        UpdateStatBlock(opsStatBlock, lgOps);
        UpdateStatBlock(hrStatBlock, lgHr);
        UpdateStatBlock(krateStatBlock, lgKpct);
        UpdateStatBlock(bbrateStatBlock, lgBbpct);
        UpdateStatBlock(sbStatBlock, lgSbrate);
    }

    private void UpdateStatBlock(GameObject block, string stat)
    {
        TextMeshProUGUI statBlockText = block.transform.Find("Stat_block").GetComponent<TextMeshProUGUI>();
        statBlockText.text = stat;
    }

}
