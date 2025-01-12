using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    [SerializeField] private JsonReader jsonReader;
    
    [SerializeField] private TextMeshProUGUI playerNameText;
    
    [SerializeField] private GameObject playeAverageBlock;
    [SerializeField] private GameObject playerObpBlock;
    [SerializeField] private GameObject playerSlgBlock;
    [SerializeField] private GameObject playerOpsBlock;
    [SerializeField] private GameObject playerWobaBlock;
    [SerializeField] private GameObject playerKBlock;
    [SerializeField] private GameObject playerBbBlock;
  
    private string playerAverageString; 
    private int playerAverageRank;
    private string playerOnBasePctString;
    private int playerOnBasePctRank;
    private string playerSlgString;
    private int playerSlgRank;
    private string playerOpsString;
    private int playerOpsRank;
    private string playerWobaString;
    private int playerWobaRank;
    private string playerKpctString;
    private int playerKpctRank;
    private string playerBbpctString;
    private int playerBpctRank;
    
    

    [SerializeField] int currentPlayer = 4;

    void Start() {
            
        UpdateDisplay();
        
    }

    private void UpdateDisplay()
    {
        ReadStats();
        DisplayStats();
    }


    void ReadStats()
    {
        playerAverageString = FormatRateStat(jsonReader.myPlayerList.players[currentPlayer].avg, 4);
        playerAverageRank = (int)jsonReader.myPlayerList.players[currentPlayer].avgRank;
        
        playerOnBasePctString = FormatRateStat(jsonReader.myPlayerList.players[currentPlayer].obp, 4);
        playerOnBasePctRank = (int)jsonReader.myPlayerList.players[currentPlayer].obpRank;

        playerSlgString = FormatRateStat(jsonReader.myPlayerList.players[currentPlayer].slg, 4);
        playerSlgRank = (int)jsonReader.myPlayerList.players[currentPlayer].slgRank;

        playerOpsString = FormatRateStat(jsonReader.myPlayerList.players[currentPlayer].ops, 4);
        playerOpsRank = (int)jsonReader.myPlayerList.players[currentPlayer].opsRank;

        playerWobaString = FormatRateStat(jsonReader.myPlayerList.players[currentPlayer].woba, 4);
        playerWobaRank = (int)jsonReader.myPlayerList.players[currentPlayer].wobaRank;

        playerKpctString = FormatPctStat(jsonReader.myPlayerList.players[currentPlayer].kp, 2);
        playerKpctRank = (int)jsonReader.myPlayerList.players[currentPlayer].kRank;

        playerBbpctString = FormatPctStat(jsonReader.myPlayerList.players[currentPlayer].bbp, 2);
        playerBpctRank = (int)jsonReader.myPlayerList.players[currentPlayer].bbpkRank;

    }
    
    void DisplayStats()
    {
        playerNameText.text = jsonReader.myPlayerList.players[currentPlayer].title;
        FillStatBlock(playerAverageString, playerAverageRank, playeAverageBlock);
        FillStatBlock(playerOnBasePctString, playerOnBasePctRank, playerObpBlock);
        FillStatBlock(playerSlgString, playerSlgRank, playerSlgBlock);
        FillStatBlock(playerOpsString, playerOpsRank, playerOpsBlock);
        FillStatBlock(playerWobaString, playerWobaRank, playerWobaBlock);
        FillPctStatBlock(playerKpctString, playerKpctRank, playerKBlock);
        FillPctStatBlock(playerBbpctString, playerBpctRank, playerBbBlock);
        
    }

    private void FillStatBlock(string statToDisplay, int statRank, GameObject statBlock)
    {
        TextMeshProUGUI textBox = statBlock.GetComponentInChildren<TextMeshProUGUI>();
        
        textBox.text = String.Format("{0}  ({1})", statToDisplay, statRank);

        Image image = statBlock.GetComponentInChildren<Image>();
        if(statRank <=3)
        {
            image.color = Color.green;
        }
        else
        {
            image.GetComponent<Image>().color = Color.white;
        }
        
        
    }

    private void FillPctStatBlock(string statToDisplay, int statRank, GameObject statBlock)
    {
        TextMeshProUGUI textBox = statBlock.GetComponentInChildren<TextMeshProUGUI>();
        
        textBox.text = String.Format("{0}%  ({1})", statToDisplay, statRank);

        Image image = statBlock.GetComponentInChildren<Image>();
        if(statRank <=3)
        {
            image.color = Color.green;
        }
        else
        {
            image.GetComponent<Image>().color = Color.white;
        }
        
        
    }
    
    
    private string FormatRateStat(float statToFormat, int decimalPlaces)
    {
        //local variable to manipulate
        string statToFormatString;

        //read in the stat to the method and round it to 4, since rounding to 3 will end up with too few digits for the rate stat string
        statToFormat = (float)System.Math.Round(statToFormat, decimalPlaces);

        //cast the stat to a string for display
        statToFormatString = statToFormat.ToString();
        
        if(statToFormatString.Length > 0)
        {
            statToFormatString = statToFormatString.Substring(1);
        }

        if(statToFormatString.Length > decimalPlaces)
        {
            statToFormatString = statToFormatString.Substring(0, decimalPlaces);
        }

        while(statToFormatString.Length <4)
        {
            statToFormatString = statToFormatString + "0";
        }


        return statToFormatString;
    }

    private string FormatPctStat(float statToFormat, int decimalPlaces)
    {
        //local variable to manipulate
        string statToFormatString;

        //read in the stat to the method and round it to 4, since rounding to 3 will end up with too few digits for the rate stat string
        statToFormat = (float)System.Math.Round(statToFormat * 100, decimalPlaces);

        statToFormatString = statToFormat.ToString();

        //cast the stat to a string for display
        


        return statToFormatString;
    }


    //methods for changing the player number
    public void SetNextPlayer()
    {
        if(currentPlayer > 0)
        {
            currentPlayer -= 1;
            UpdateDisplay();
        }
    }

    public void SetPreviousPlayer()
    {
        if(currentPlayer < jsonReader.myPlayerList.players.Length - 1)
        {
            currentPlayer += 1;
            UpdateDisplay();
        }
    }

    public void SetCurrentPlayer(int playerRank)
    {
        currentPlayer = playerRank;
        UpdateDisplay();
    }
    
}
