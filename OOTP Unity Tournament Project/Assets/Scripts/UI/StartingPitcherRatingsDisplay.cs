using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StartingPitcherRatingsDisplay : MonoBehaviour
{
       
    private int currentPlayer = 4;

    [SerializeField] private GameObject stuffDisplay;
    [SerializeField] private GameObject movementDisplay;
    [SerializeField] private GameObject controlDisplay;
    [SerializeField] private GameObject pHRDisplay;
    [SerializeField] private GameObject pBabipDisplay;

    [SerializeField] private GameObject stuffvLDisplay;
    [SerializeField] private GameObject movementvLDisplay;
    [SerializeField] private GameObject controlvLDisplay;
    [SerializeField] private GameObject pHRvLDisplay;
    [SerializeField] private GameObject pBabipvLDisplay;

    [SerializeField] private GameObject stuffvRDisplay;
    [SerializeField] private GameObject movementvRDisplay;
    [SerializeField] private GameObject controlvRDisplay;
    [SerializeField] private GameObject pHRvRDisplay;
    [SerializeField] private GameObject pBabipvRDisplay;

    [SerializeField] private GameObject staminaDisplay;
    [SerializeField] private GameObject holdDisplay;
    [SerializeField] private GameObject veloDisplay;
    [SerializeField] private GameObject armSlotDisplay;
    [SerializeField] private GameObject groundBallProfileDisplay;
    [SerializeField] private GameObject overallRatingBlock;
    [SerializeField] private GameObject batsBlock;
    [SerializeField] private GameObject throwsBlock;
    [SerializeField] private GameObject combinatorBlock;


    private int playerStuffRating;
    private int playerMovementRating;
    private int playerControlRating;
    private int playerHRRating;
    private int playerBabipRating;

    private int playerStuffvLRating;
    private int playerMovementvLRating;
    private int playerControlvLRating;
    private int playerHRvLRating;
    private int playerBabipvLRating;

    private int playerStuffvRRating;
    private int playerMovementvRRating;
    private int playerControlvRRating;
    private int playerHRvRRating;
    private int playerBabipvRRating;

    private int playerStaminaRating;
    private int playerHoldRating;
    private string playerVeloRating;
    private int playerArmSlot;
    private int playerGroundballProfile;
    private int playerOverallRating; 

    private int playerBats;
    private int playerThrows;
    private int playerCombinatorValue;


    private void Start()
    {
        UpdateRatingsDisplay();
    }

    private void UpdateRatingsDisplay()
    {
        SetPlayerRatings();
        UpdatePlayerRatingDisplaybars();

        

    }

    private void SetPlayerRatings()
    {
        playerStuffRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].stuff;
        playerMovementRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].movement;
        playerControlRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].control;
        playerHRRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].pHR;
        playerBabipRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].pBabip;

        playerStuffvLRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].stuffvL;
        playerMovementvLRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].movementvL;
        playerControlvLRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].controlvL;
        playerHRvLRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].pHRvL;
        playerBabipvLRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].pBabipvL;

        playerStuffvRRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].stuffvR;
        playerMovementvRRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].movementvR;
        playerControlvRRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].controlvR;
        playerHRvRRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].pHRvR;
        playerBabipvRRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].pBabipvR;

        playerStaminaRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].stamina;
        playerHoldRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].hold;
        playerVeloRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].velocity;
        playerArmSlot = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].armSlot;
        playerGroundballProfile = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].gb;
        playerOverallRating = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].value;

        playerBats = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].bats;
        playerThrows = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].throws;
        playerCombinatorValue = JsonReader.Instance.myStartingPitcherlist.starting_pitchers[currentPlayer].clvl;
        
    }

    private void UpdatePlayerRatingDisplaybars()
    {
        UpdateRatingBlock(stuffDisplay, playerStuffRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].stuff_max);
        UpdateRatingBlock(movementDisplay, playerMovementRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].movement_max);
        UpdateRatingBlock(controlDisplay, playerControlRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].control_max);
        UpdateRatingBlock(pHRDisplay, playerHRRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].pHR_max);
        UpdateRatingBlock(pBabipDisplay, playerBabipRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].pBabip_max);

        UpdateRatingBlock(stuffvLDisplay, playerStuffvLRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].stuffvL_max);
        UpdateRatingBlock(movementvLDisplay, playerMovementvLRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].movementvL_max);
        UpdateRatingBlock(controlvLDisplay, playerControlvLRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].controlvL_max);
        UpdateRatingBlock(pHRvLDisplay, playerHRvLRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].pHRvL_max);
        UpdateRatingBlock(pBabipvLDisplay, playerBabipvLRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].pBabipvL_max);

        UpdateRatingBlock(stuffvRDisplay, playerStuffvRRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].stuffvR_max);
        UpdateRatingBlock(movementvRDisplay, playerMovementvRRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].movementvR_max);
        UpdateRatingBlock(controlvRDisplay, playerControlvRRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].controlvR_max);
        UpdateRatingBlock(pHRvRDisplay, playerHRvRRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].pHRvR_max);
        UpdateRatingBlock(pBabipvRDisplay, playerBabipvRRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].pBabipvR_max);

        UpdateRatingBlock(staminaDisplay, playerStaminaRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].stamina_max);
        UpdateRatingBlock(holdDisplay, playerHoldRating, JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].hold_max);

        //update velo display
        TextMeshProUGUI veloDisplayText = veloDisplay.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        veloDisplayText.text = playerVeloRating;

        //update arm slot
        TextMeshProUGUI slotDisplayText = armSlotDisplay.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();

        switch((int)playerArmSlot)
        {
            case 1:
            slotDisplayText.text = "Submarine";
            break;
            case 2:
            slotDisplayText.text = "Sidearm";
            break;
            case 3:
            slotDisplayText.text = "Normal 3/4";
            break;
            case 4:
            slotDisplayText.text = "Over the Top";
            break;
        }
        

        //update groundball profile
        TextMeshProUGUI profileDisplayText = groundBallProfileDisplay.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        switch((int)playerGroundballProfile)
        {
            case 0:
            profileDisplayText.text = "Extreme Grounball";
            break;
            case 1:
            profileDisplayText.text = "Groundball";
            break;
            case 2:
            profileDisplayText.text = "Neutral";
            break;
            case 3:
            profileDisplayText.text = "Flyball";
            break;
            case 4:
            profileDisplayText.text = "Extreme Flyball";
            break;
        }

        TextMeshProUGUI overallRatingDisplayText = overallRatingBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        overallRatingDisplayText.text = playerOverallRating.ToString();

        SetOverallRatingColor(playerOverallRating);
        SetPlayerBats();
        SetPlayerThrows();
        SetPlayerCombinator();

        


    }
    
    private void UpdateRatingBlock(GameObject block, int playerRating, int maxRating)
    {
        TextMeshProUGUI textBlock = block.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        textBlock.text = playerRating.ToString();
        Transform ratingBarParent = block.transform.Find("Rating_bar").GetComponent<Transform>();
        Image ratingBarImage = ratingBarParent.transform.Find("Foreground_image").GetComponent<Image>();
        float ratingRatio = (float)playerRating/maxRating;
        ratingBarImage.fillAmount = ratingRatio;

        if (ratingRatio > 0.8f)
        {
            ratingBarImage.color = new Color32(0, 153, 255, 255);
        }
        else if (ratingRatio > 0.6f)
        {
            ratingBarImage.color = new Color32(101, 226, 18, 255);
        }
        else if (ratingRatio > 0.4f)
        {
            ratingBarImage.color = new Color32(255, 151, 0, 255);
        }
        else
        {
            ratingBarImage.color = new Color32(255, 89, 89, 255);
        }

        
        
    }

    private void SetPlayerBats()
    {
        TextMeshProUGUI batsText = batsBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        
        switch(playerBats)
        {
            case 1:
                batsText.text = "Right";
                break;
            case 2:
                batsText.text = "Left";
                break;
            case 3:
                batsText.text = "Switch";
                break;
        }
        
    }

    private void SetPlayerThrows()
    {
        TextMeshProUGUI throwsText = throwsBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        
        switch(playerThrows)
        {
            case 1:
                throwsText.text = "Right";
                break;
            case 2:
                throwsText.text = "Left";
                break;
        }
    }

    private void SetPlayerCombinator()
    {
        TextMeshProUGUI combinatorText = combinatorBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        Image combinatorBackground = combinatorBlock.transform.Find("Combinator_bg").GetComponent<Image>();

        if(playerCombinatorValue == -1)
        {
            combinatorText.text = "NA";
        }
        else
        {
            combinatorText.text = playerCombinatorValue.ToString();
        }

        switch(playerCombinatorValue)
        {
            case -1:
                combinatorBackground.color = new Color32(178,178,179,255);
                break;
            case 0:
                combinatorBackground.color = new Color32(229,2,13,255);
                break;
            case 1:
                combinatorBackground.color = new Color32(239,115,2,255);
                break;
            case 2:
                combinatorBackground.color = new Color32(245,180,1,255);
                break;
            case 3:
                combinatorBackground.color = new Color32(61,205,54,255);
                break;
            case 4:
                combinatorBackground.color = new Color32(0,189,191,255);
                break;
            case 5:
                combinatorBackground.color = new Color32(1,116,231,255);
                break;
        }
    }

    private void SetOverallRatingColor(int rating)
    {
        Image ratingImage = overallRatingBlock.transform.Find("Rating_image").GetComponent<Image>();
        TextMeshProUGUI ratingText = overallRatingBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI overallText = overallRatingBlock.transform.Find("Overall_text").GetComponent<TextMeshProUGUI>();


        switch(rating)
        {
            case >= 100: 
                ratingImage.color = new Color32(30,21,6,255);
                ratingText.color = new Color32(151,98,23,255);   
                overallText.color = new Color32(151,98,23,255);               
                break;
            case >= 90:
                ratingImage.color = new Color32(62,159,176,255);
                ratingText.color = Color.white;
                overallText.color = Color.white;
                break;
            case >= 80:
                ratingImage.color = new Color32(221,158, 51,255);
                ratingText.color = Color.white;
                overallText.color = Color.white;
                break;
            case >= 70:
                ratingImage.color = new Color32(140,158,165,255);
                ratingText.color = Color.white;
                overallText.color = Color.white;
                break;
            case >= 60:
                ratingImage.color = new Color32(176,101,64,255);
                ratingText.color = Color.white;
                overallText.color = Color.white;
                break;
            default:
                ratingImage.color = new Color32(95,94,94,255);
                ratingText.color = Color.white;
                overallText.color = Color.white;
                break;
        }
    }

    

    public void SetNextPlayer()
    {
        if(currentPlayer >0)
        {
            currentPlayer -= 1;
            UpdateRatingsDisplay();
        }
    }

    public void SetPreviousPlayer()
    {
        if(currentPlayer < JsonReader.Instance.GetStartingPitcherListSize()-1)
        {
            currentPlayer += 1;
            UpdateRatingsDisplay();
        }
    }

    public void SetCurrentPlayer(int playerToSet)
    {
        currentPlayer = playerToSet;
        UpdateRatingsDisplay();
    }

}
