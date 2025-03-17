using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReliefPitcherStatsDisplay : MonoBehaviour
{
    private int currentPlayer = 4;

    [SerializeField] private TextMeshProUGUI playerNameBox;

    [SerializeField] private GameObject fipBlock;
    [SerializeField] private GameObject eraBlock;
    [SerializeField] private GameObject strikeoutBlock;
    [SerializeField] private GameObject walksBlock;
    [SerializeField] private GameObject homeRunsBlock;
    [SerializeField] private GameObject svPctBlock;
    [SerializeField] private GameObject sdMdBlock;
    [SerializeField] private GameObject irsPctBlock;
    [SerializeField] private GameObject gbPctBlock;
    [SerializeField] private GameObject warBlock;
    [SerializeField] private TextMeshProUGUI ipcText;

    private float playerFip;
    private float playerEra;
    private float playerStrikeouts;
    private float playerWalks;
    private float playerHomeRuns;
    private float playerSavePct;
    private float playerSdMd;
    private float playerIrsPct;
    private float playerGroundballPct;
    private float playerWar;
    private float playerIpc;

    private int playerFipRank;
    private int playerEraRank;
    private int playerStrikeoutRank;
    private int playerWalkRank;
    private int playerHomeRunRank;
    private int playerSavePctRank;
    private int playerSdMdRank;
    private int playerIrsPctRank;
    private int playerGroundballPctRank;
    private int playerWarRank;
    private int playerCid;

    

    private void Start()
    {
        SetCurrentPlayer(currentPlayer);
    }

    private void UpdateDisplay()
    {
        playerNameBox.text = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].title;
        UpdatePlayerStats();
        UpdateDisplayBlocks();
        UpdateInCollectionDisplay.Instance.UpdateCollectionObjectDisplay(playerCid);


    }

    private void UpdatePlayerStats()
    {
        playerFip = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].fip;
        playerFipRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].fipRank;

        playerEra = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].era;
        playerEraRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].eraRank;

        playerStrikeouts = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].kRate;
        playerStrikeoutRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].kRank;

        playerWalks = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].bbRate;
        playerWalkRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].bbRank;

        playerHomeRuns = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].hrRate;
        playerHomeRunRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].hrRank;

        playerSavePct = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].svPct;
        playerSavePctRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].svPctRank;

        playerSdMd = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].sdPerMd;
        playerSdMdRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].sdPerMdRank;

        playerIrsPct = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].irsPct;
        playerIrsPctRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].irsPctRank;

        playerGroundballPct = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].gbRate;
        playerGroundballPctRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].gbRateRank;

        playerWar  = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].war;
        playerWarRank = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].warRank;

        playerCid = (int)JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].cid;
        playerIpc = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].ipc;
    }

    private void UpdateDisplayBlocks()
    {
        UpdateFloatDisplayBlock(fipBlock, playerFip, playerFipRank);
        UpdateFloatDisplayBlock(eraBlock, playerEra, playerEraRank);
        UpdateFloatDisplayBlock(strikeoutBlock, playerStrikeouts, playerStrikeoutRank);
        UpdateFloatDisplayBlock(walksBlock, playerWalks, playerWalkRank);
        UpdateFloatDisplayBlock(homeRunsBlock, playerHomeRuns, playerHomeRunRank);
        UpdateFloatDisplayBlock(svPctBlock, playerSavePct, playerSavePctRank);
        UpdateFloatDisplayBlock(sdMdBlock, playerSdMd, playerSdMdRank);
        UpdateFloatDisplayBlock(irsPctBlock, playerIrsPct, playerIrsPctRank);
        UpdateFloatDisplayBlock(gbPctBlock, playerGroundballPct, playerGroundballPctRank);
        UpdateFloatDisplayBlock(warBlock, playerWar, playerWarRank);

        ipcText.text = playerIpc.ToString();
    }

    private void UpdateFloatDisplayBlock(GameObject statBlock, float stat, int rank)
    {
        TextMeshProUGUI textBox = statBlock.GetComponentInChildren<TextMeshProUGUI>();

        textBox.text = String.Format("{0} ({1})", stat, rank);

        Image image = statBlock.GetComponentInChildren<Image>();
        if(rank <=3)
        {
            image.color = Color.green;
        }
        else
        {
            image.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        }
    }

    public void SetNextPlayer()
    {
        if(currentPlayer >0)
        {
            currentPlayer -= 1;
            UpdateDisplay();
        }
    }

    public void SetPreviousPlayer()
    {
        if(currentPlayer < JsonReader.Instance.myReliefPitcherList.relief_pitchers.Length)
        {
            currentPlayer += 1;
            UpdateDisplay();
        }
    }

    public void SetCurrentPlayer(int playerToSet)
    {
        if(playerToSet > JsonReader.Instance.myReliefPitcherList.relief_pitchers.Length -1)
        {
            currentPlayer = JsonReader.Instance.myReliefPitcherList.relief_pitchers.Length -1;
            UpdateDisplay();
        }
        else{
            currentPlayer = playerToSet;
            UpdateDisplay();
        }
        
    }

    

}
