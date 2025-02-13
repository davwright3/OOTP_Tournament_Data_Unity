using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DisplayValidPositions : MonoBehaviour
{
    private int currentPlayer = 4;
    
    private int playerLearnCatcher;
    private int playerLearn1B;
    private int playerLearn2B;
    private int playerLearn3B;
    private int playerLearnSS;
    private int playerLearnLF;
    private int playerLearnCF;
    private int playerLearnRF;

    [SerializeField] GameObject learnCatcherBlock;
    [SerializeField] GameObject learnFirstBaseBlock;
    [SerializeField] GameObject learnSecondBaseBlock;
    [SerializeField] GameObject learnThirdBaseBlock;
    [SerializeField] GameObject learnShortstopBlock;
    [SerializeField] GameObject learnLeftFieldBlock;
    [SerializeField] GameObject learnCenterFieldBlock;
    [SerializeField] GameObject learnRighFieldBlock;

    private void Start()
    {
        UpdateDisplay();
    }


    public void UpdateDisplay()
    {
        SetPlayerValidPosition();

        ShowValidPosition(learnCatcherBlock, playerLearnCatcher);
        ShowValidPosition(learnFirstBaseBlock, playerLearn1B);
        ShowValidPosition(learnSecondBaseBlock, playerLearn2B);
        ShowValidPosition(learnShortstopBlock, playerLearnSS);
        ShowValidPosition(learnThirdBaseBlock, playerLearn3B);
        ShowValidPosition(learnLeftFieldBlock, playerLearnLF);
        ShowValidPosition(learnCenterFieldBlock, playerLearnCF);
        ShowValidPosition(learnRighFieldBlock, playerLearnRF);
    }

    private void ShowValidPosition(GameObject positionBlock, int validPosition)
    {
                
        Transform validImage = positionBlock.transform.Find("Valid");
        Transform invalidImage = positionBlock.transform.Find("Invalid");


        if(validPosition == 1)
        {
            validImage.gameObject.SetActive(true);
        invalidImage.gameObject.SetActive(false);
        }
        else
        {
            validImage.gameObject.SetActive(false);
            invalidImage.gameObject.SetActive(true);
        }
        
        
    }

    private void SetPlayerValidPosition()
    {
        playerLearnCatcher = JsonReader.Instance.myPlayerList.players[currentPlayer].learnC;
        playerLearn1B = JsonReader.Instance.myPlayerList.players[currentPlayer].learn1B;
        playerLearn2B = JsonReader.Instance.myPlayerList.players[currentPlayer].learn2B;
        playerLearn3B = JsonReader.Instance.myPlayerList.players[currentPlayer].learn3B;
        playerLearnSS = JsonReader.Instance.myPlayerList.players[currentPlayer].learnSS;
        playerLearnLF = JsonReader.Instance.myPlayerList.players[currentPlayer].learnLF;
        playerLearnCF = JsonReader.Instance.myPlayerList.players[currentPlayer].learnCF;
        playerLearnRF = JsonReader.Instance.myPlayerList.players[currentPlayer].learnRF;
    }

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
        if(currentPlayer < JsonReader.Instance.myPlayerList.players.Length-1)
        {
            currentPlayer += 1;
            UpdateDisplay();
        }
    }

    public void SetCurrentPlayer(int player)
    {
        currentPlayer = player;
        UpdateDisplay();
    }

}
