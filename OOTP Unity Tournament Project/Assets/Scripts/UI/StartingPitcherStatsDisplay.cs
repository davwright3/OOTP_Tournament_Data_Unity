using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartingPitcherStatsDisplay : MonoBehaviour
{
    [SerializeField] private JsonReader jsonReader;

    [SerializeField] private int currentPlayer = 4;

    [SerializeField] private TextMeshProUGUI playerNameBlock;

    private float playerFip;
    private float playerEra;
    private float playerStrikeouts;
    private float playerWalks;
    private float playerHomeruns;
    private float playerQSPct;
    private float playerGBPct;
    private float playerWar;
    private float playerIpc;

    private int playerFipRank;
    private int playerEraRank;
    private int playerStrikeoutsRank;
    private int playerWalksRank;
    private int playerHomerunsRank;
    private int playerQSPctRank;
    private int playerGBPctRank;
    private int playerWarRank;
    private int playerCid;

    [SerializeField] private GameObject fipBlock;
    [SerializeField] private GameObject eraBlock;
    [SerializeField] private GameObject stikeoutsBlock;
    [SerializeField] private GameObject bbBlock;
    [SerializeField] private GameObject hrBlock;
    [SerializeField] private GameObject qsBlock;
    [SerializeField] private GameObject groundabllBlock;
    [SerializeField] private GameObject warBlock;
    [SerializeField] private TextMeshProUGUI ipcText;



    private void Start()
    {
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        playerNameBlock.text = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].title;

        UpdatePlayerStats();
        UpdateStatsBlocks();
        UpdateInCollectionDisplay.Instance.UpdateCollectionObjectDisplay(playerCid);
    }

    private void UpdatePlayerStats()
    {
        playerFip = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].fip;
        playerFipRank = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].fipRank;

        playerEra = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].era;
        playerEraRank = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].eraRank;

        playerStrikeouts = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].kp9;
        playerStrikeoutsRank = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].kRank;

        playerWalks = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].bbp9;
        playerWalksRank = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].bbRank;

        playerHomeruns = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].hrp9;
        playerHomerunsRank = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].hrRank;

        playerQSPct = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].qspct;
        playerQSPctRank = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].qsRank;

        playerGBPct = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].gbrate;
        playerGBPctRank = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].gbRateRank;

        playerWar = jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].war;
        playerWarRank = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].warRank;

        playerCid = (int)jsonReader.myStartingPitcherlist.starting_pitchers[currentPlayer].cid;
        playerIpc = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].ipc;


    }

    private void UpdateStatsBlocks()
    {
        UpdateFloatStatBlock(fipBlock, playerFip, playerFipRank);
        UpdateFloatStatBlock(eraBlock, playerEra, playerEraRank);
        UpdateFloatStatBlock(stikeoutsBlock, playerStrikeouts, playerStrikeoutsRank);
        UpdateFloatStatBlock(bbBlock, playerWalks, playerWalksRank);
        UpdateFloatStatBlock(hrBlock, playerHomeruns, playerHomerunsRank);
        UpdateFloatStatBlock(qsBlock, playerQSPct, playerQSPctRank);
        UpdateFloatStatBlock(groundabllBlock, playerGBPct, playerGBPctRank);
        UpdateFloatStatBlock(warBlock, playerWar, playerWarRank);

        ipcText.text = playerIpc.ToString();

        
    }

    private void UpdateFloatStatBlock(GameObject statBlock, float stat, int rank)
    {
        TextMeshProUGUI textBox = statBlock.GetComponentInChildren<TextMeshProUGUI>();

        textBox.text = String.Format("{0} ({1})", stat, rank);

        Image image = statBlock.GetComponentInChildren<Image>();
        if(rank <=3)
        {
            image.color = new Color32(154,239,160,255);
        }
        else
        {
            image.GetComponent<Image>().color = new Color32(0,0,0,0);
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
        if(currentPlayer < jsonReader.GetStartingPitcherListSize()-1)
        {
            currentPlayer += 1;
            UpdateDisplay();
        }

    }

    public void SetCurrentPlayer(int playerToSet)
    {   
        currentPlayer = playerToSet;
        UpdateDisplay();
    }


}
