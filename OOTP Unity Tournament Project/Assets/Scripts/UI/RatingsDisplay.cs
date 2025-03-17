using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using System.Runtime.InteropServices;

public class RatingsDisplay : MonoBehaviour
{
    [SerializeField] private JsonReader jsonReader;

    int currentPlayer = 4;

    [SerializeField] TextMeshProUGUI contactRatingText;
    
    [SerializeField] GameObject contactRatingBlock;
    [SerializeField] GameObject gapRatingBlock;
    [SerializeField] GameObject powerRatingBlock;
    [SerializeField] GameObject eyeRatingBlock;
    [SerializeField] GameObject avoidKRatingBlock;
    [SerializeField] GameObject babipRatingBlock;

    [SerializeField] GameObject contactvLRatingBlock;
    [SerializeField] GameObject gapvLRatingBlock;
    [SerializeField] GameObject powervLRatingBlock;
    [SerializeField] GameObject eyevLRatingBlock;
    [SerializeField] GameObject avoidKvLRatingBlock;
    [SerializeField] GameObject babipvLRatingBlock;

    [SerializeField] GameObject contactvRRatingBlock;
    [SerializeField] GameObject gapvRRatingBlock;
    [SerializeField] GameObject powervRRatingBlock;
    [SerializeField] GameObject eyevRRatingBlock;
    [SerializeField] GameObject avoidKvRRatingBlock;
    [SerializeField] GameObject babipvRRatingBlock;

    [SerializeField] GameObject speedRatingBlock;
    [SerializeField] GameObject stealAggRatingBlock;
    [SerializeField] GameObject stealAbilityRatingBlock;
    [SerializeField] GameObject baserunningRatingBlock;
    [SerializeField] GameObject overallRatingBlock;
    [SerializeField] GameObject batsBlock;
    [SerializeField] GameObject throwsBlock;
    [SerializeField] GameObject combinatorBlock;


    private int minContact;
    private int maxContact;
    private int minGap;
    private int maxGap;
    private int minPower;
    private int maxPower;
    private int minEye;
    private int maxEye;
    private int minAvoidK;
    private int maxAvoidK;
    private int minBabip;
    private int maxBabip;

    private int minContactvL;
    private int maxContactvL;
    private int minGapvL;
    private int maxGapvL;
    private int minPowervL;
    private int maxPowervL;
    private int minEyevL;
    private int maxEyevL;
    private int minAvoidKvL;
    private int maxAvoidKvL;
    private int minBabipvL;
    private int maxBabipvL;

    private int minContactvR;
    private int maxContactvR;
    private int minGapvR;
    private int maxGapvR;
    private int minPowervR;
    private int maxPowervR;
    private int minEyevR;
    private int maxEyevR;
    private int minAvoidKvR;
    private int maxAvoidKvR;
    private int minBabipvR;
    private int maxBabipvR;

    private int minSpeed;
    private int maxSpeed;
    private int minStealAgg;
    private int maxStealAgg;
    private int minStealAbility;
    private int maxStealAbility;
    private int minBaserunning;
    private int maxBaserunning;

    private int playerContactRating;
    private int playerGapRating;
    private int playerPowerRating;
    private int playerEyeRating;
    private int playerAvoidKRating;
    private int playerBabipRating;

    private int playerContactvLRating;
    private int playerGapvLRating;
    private int playerPowervLRating;
    private int playerEyevLRating;
    private int playerAvoidKvLRating;
    private int playerBabipvLRating;

    private int playerContactvRRating;
    private int playerGapvRRating;
    private int playerPowervRRating;
    private int playerEyevRRating;
    private int playerAvoidKvRRating;
    private int playerBabipvRRating;

    private int playerSpeedRating;
    private int playerStealAggRating;
    private int playerStealAbilityRating;
    private int playerBaserunningRating;
    private int playerOverallRating;
    private int playerBats;
    private int playerThrows;
    private int playerCombinatorValue;


    


    private void Start()
    {
        SetCurrentPlayer(currentPlayer);
        SetPositionRatings();
        UpdateDisplay();
        
    }


    private void SetPositionRatings()
    {
        minContact = jsonReader.myPositionRatingsList.ratings[0].contact_min;
        maxContact = jsonReader.myPositionRatingsList.ratings[0].contact_max;
        minContactvL = jsonReader.myPositionRatingsList.ratings[0].l_contact_min;
        maxContactvL = jsonReader.myPositionRatingsList.ratings[0].l_contact_max;
        minContactvR = jsonReader.myPositionRatingsList.ratings[0].r_contact_min;
        maxContactvR = jsonReader.myPositionRatingsList.ratings[0].r_contact_max;

        minGap = jsonReader.myPositionRatingsList.ratings[0].gap_min;
        maxGap = jsonReader.myPositionRatingsList.ratings[0].gap_max;
        minGapvL = jsonReader.myPositionRatingsList.ratings[0].l_gap_min;
        maxGapvL = jsonReader.myPositionRatingsList.ratings[0].l_gap_max;
        minGapvR = jsonReader.myPositionRatingsList.ratings[0].r_gap_min;
        maxGapvR = jsonReader.myPositionRatingsList.ratings[0].r_gap_max;

        minPower = jsonReader.myPositionRatingsList.ratings[0].power_min;
        maxPower = jsonReader.myPositionRatingsList.ratings[0].power_max;
        minPowervL = jsonReader.myPositionRatingsList.ratings[0].l_power_min;
        maxPowervL = jsonReader.myPositionRatingsList.ratings[0].l_power_max;
        minPowervR = jsonReader.myPositionRatingsList.ratings[0].r_power_min;
        maxPowervR = jsonReader.myPositionRatingsList.ratings[0].r_power_max;

        minEye = jsonReader.myPositionRatingsList.ratings[0].eye_min;
        maxEye = jsonReader.myPositionRatingsList.ratings[0].eye_max;
        minEyevL = jsonReader.myPositionRatingsList.ratings[0].l_eye_min;
        maxEyevL = jsonReader.myPositionRatingsList.ratings[0].l_eye_max;
        minEyevR = jsonReader.myPositionRatingsList.ratings[0].r_eye_min;
        maxEyevR = jsonReader.myPositionRatingsList.ratings[0].r_eye_max;

        minAvoidK = jsonReader.myPositionRatingsList.ratings[0].avk_min;
        maxAvoidK = jsonReader.myPositionRatingsList.ratings[0].avk_max;
        minAvoidKvL = jsonReader.myPositionRatingsList.ratings[0].l_avk_min;
        maxAvoidKvL = jsonReader.myPositionRatingsList.ratings[0].l_avk_max;
        minAvoidKvR = jsonReader.myPositionRatingsList.ratings[0].r_avk_min;
        maxAvoidKvR = jsonReader.myPositionRatingsList.ratings[0].r_avk_max;

        minBabip = jsonReader.myPositionRatingsList.ratings[0].babip_min;
        maxBabip = jsonReader.myPositionRatingsList.ratings[0].babip_max;
        minBabipvL = jsonReader.myPositionRatingsList.ratings[0].l_babip_min;
        maxBabipvL = jsonReader.myPositionRatingsList.ratings[0].l_babip_max;
        minBabipvR = jsonReader.myPositionRatingsList.ratings[0].r_babip_min;
        maxBabipvR = jsonReader.myPositionRatingsList.ratings[0].r_babip_max;

        maxSpeed = jsonReader.myPositionRatingsList.ratings[0].speed_max;
        minSpeed = jsonReader.myPositionRatingsList.ratings[0].speed_min;
        maxStealAgg = jsonReader.myPositionRatingsList.ratings[0].steal_rate_max;
        minStealAgg = jsonReader.myPositionRatingsList.ratings[0].steal_rate_min;
        maxStealAbility = jsonReader.myPositionRatingsList.ratings[0].steal_max;
        minStealAbility = jsonReader.myPositionRatingsList.ratings[0].steal_min;
        maxBaserunning = jsonReader.myPositionRatingsList.ratings[0].baserunning_max;
        minBaserunning = jsonReader.myPositionRatingsList.ratings[0].baserunning_min;
          
        

    }

    private void UpdateDisplay()
    {
        UpdatePlayerRatings();
        
        DisplayRating(contactRatingBlock, playerContactRating, maxContact, minContact);
        DisplayRating(gapRatingBlock, playerGapRating, maxGap, minGap);
        DisplayRating(powerRatingBlock, playerPowerRating, maxPower, minPower);
        DisplayRating(eyeRatingBlock, playerEyeRating, maxEye, minEye);
        DisplayRating(avoidKRatingBlock, playerAvoidKRating, maxAvoidK, minAvoidK);
        DisplayRating(babipRatingBlock, playerBabipRating, maxBabip, minBabip);

        DisplayRating(contactvLRatingBlock, playerContactvLRating, maxContactvL, minContactvL);
        DisplayRating(gapvLRatingBlock, playerGapvLRating, maxGapvL, minGapvL);
        DisplayRating(powervLRatingBlock, playerPowervLRating, maxPowervL, minPowervL);
        DisplayRating(eyevLRatingBlock, playerEyevLRating, maxEyevL, minEyevL);
        DisplayRating(avoidKvLRatingBlock, playerAvoidKvLRating, maxAvoidKvL, minAvoidKvL);
        DisplayRating(babipvLRatingBlock, playerBabipvLRating, maxBabipvL, minBabipvL);

        DisplayRating(contactvRRatingBlock, playerContactvRRating, maxContactvR, minContactvR);
        DisplayRating(gapvRRatingBlock, playerGapvRRating, maxGapvR, minGapvR);
        DisplayRating(powervRRatingBlock, playerPowervRRating, maxPowervR, minPowervR);
        DisplayRating(eyevRRatingBlock, playerEyevRRating, maxEyevR, minEyevR);
        DisplayRating(avoidKvRRatingBlock, playerAvoidKvRRating, maxAvoidKvR, minAvoidKvR);
        DisplayRating(babipvRRatingBlock, playerBabipvRRating, maxBabipvR, minBabipvR);

        DisplayRating(speedRatingBlock, playerSpeedRating, maxSpeed, minSpeed);
        DisplayRating(stealAggRatingBlock, playerStealAggRating, maxStealAgg, minStealAgg);
        DisplayRating(stealAbilityRatingBlock, playerStealAbilityRating, maxStealAbility, minStealAbility);
        DisplayRating(baserunningRatingBlock, playerBaserunningRating, maxBaserunning, minBaserunning);

        TextMeshProUGUI overallRatingText = overallRatingBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        overallRatingText.text = playerOverallRating.ToString();

        SetOverallRatingColor(playerOverallRating);
        SetPlayerBats();
        SetPlayerThrows();
        SetPlayerCombinator();
        

        
        

        

    }

    private void UpdatePlayerRatings()
    {
        playerContactRating = jsonReader.myPlayerList.players[currentPlayer].contact;
        playerGapRating = jsonReader.myPlayerList.players[currentPlayer].gap;
        playerPowerRating = jsonReader.myPlayerList.players[currentPlayer].power;
        playerEyeRating = jsonReader.myPlayerList.players[currentPlayer].eye;
        playerAvoidKRating = jsonReader.myPlayerList.players[currentPlayer].avoidk;
        playerBabipRating = jsonReader.myPlayerList.players[currentPlayer].babip;

        playerContactvLRating = jsonReader.myPlayerList.players[currentPlayer].contactvL;
        playerGapvLRating = jsonReader.myPlayerList.players[currentPlayer].gapvL;
        playerPowervLRating = jsonReader.myPlayerList.players[currentPlayer].powervL;
        playerEyevLRating = jsonReader.myPlayerList.players[currentPlayer].eyevL;
        playerAvoidKvLRating = jsonReader.myPlayerList.players[currentPlayer].avoidkvL;
        playerBabipvLRating = jsonReader.myPlayerList.players[currentPlayer].babipvL;

        playerContactvRRating = jsonReader.myPlayerList.players[currentPlayer].contactvR;
        playerGapvRRating = jsonReader.myPlayerList.players[currentPlayer].gapvR;
        playerPowervRRating = jsonReader.myPlayerList.players[currentPlayer].powervR;
        playerEyevRRating = jsonReader.myPlayerList.players[currentPlayer].eyevR;
        playerAvoidKvRRating = jsonReader.myPlayerList.players[currentPlayer].avoidkvR;
        playerBabipvRRating = jsonReader.myPlayerList.players[currentPlayer].babipvR;

        playerSpeedRating = jsonReader.myPlayerList.players[currentPlayer].speed;
        playerStealAggRating = jsonReader.myPlayerList.players[currentPlayer].stealRate;
        playerStealAbilityRating = jsonReader.myPlayerList.players[currentPlayer].stealing;
        playerBaserunningRating = jsonReader.myPlayerList.players[currentPlayer].baserunning;
        playerOverallRating = jsonReader.myPlayerList.players[currentPlayer].value;

        playerBats = jsonReader.myPlayerList.players[currentPlayer].bats;
        playerThrows = jsonReader.myPlayerList.players[currentPlayer].throws;
        playerCombinatorValue = jsonReader.myPlayerList.players[currentPlayer].vlvl;


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

    

    private void DisplayRating(GameObject ratingBlock, int rating, int maxRating, int minRating)
    {
        TextMeshProUGUI ratingTextBox = ratingBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();  
        ratingTextBox.text = rating.ToString();
        Transform ratingBarParent = ratingBlock.transform.Find("Rating_bar").GetComponent<Transform>();
        Image ratingBarImage = ratingBarParent.transform.Find("Foreground_image").GetComponent<Image>();
        float ratingRatio = (float)(rating-minRating)/(maxRating-minRating);
        ratingBarImage.fillAmount = ratingRatio;

        if(ratingRatio > .9f)
        {
            ratingBarImage.color = new Color32(191, 77, 255, 255);
        }
        else if (ratingRatio > 0.8f)
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
        if(currentPlayer > 0)
        {
            currentPlayer -= 1;
            UpdateDisplay();
        }
    }

    public void SetPreviousPlayer()
    {
        if(currentPlayer < jsonReader.myPlayerList.players.Length-1)
        {
            currentPlayer += 1;
            UpdateDisplay();
        }
    }

    
    public void SetCurrentPlayer(int player)
    {
        if(player > jsonReader.GetPlayerListSize() -1)
        {
            currentPlayer = jsonReader.GetPlayerListSize()-1;
            UpdateDisplay();
        }
        else{
            currentPlayer = player;
            UpdateDisplay();
        }
        
    }

    public void SetNewPosition()
    {
        SetPositionRatings();
        
    }
}
