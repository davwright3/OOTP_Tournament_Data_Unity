using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DefenseRatingsDisplay : MonoBehaviour
{
    [SerializeField] JsonReader jsonReader;

    int currentPlayer = 4;

    [SerializeField] private FieldPosition fieldPosition;

#region DISPLAY_BOXES
    [SerializeField] private GameObject catcherDisplayBox;
    [SerializeField] private GameObject infieldDisplayBox;
    [SerializeField] private GameObject outfieldDisplayBox;


    [SerializeField] private GameObject catcherAbilBox;
    [SerializeField] private GameObject catcherFrameBlock;
    [SerializeField] private GameObject catcherArmBlock;

    [SerializeField] private GameObject infieldRangeBlock;
    [SerializeField] private GameObject infieldErrorBlock;
    [SerializeField] private GameObject infieldArmBlock;
    [SerializeField] private GameObject turnDoublePlayBlock;

    [SerializeField] private GameObject outfieldRangeBlock;
    [SerializeField] private GameObject outfieldErrorBlock;
    [SerializeField] private GameObject outfieldArmBlock;

#endregion


#region PLAYER_RATINGS
    //catcher ratings
    private int playerCatchAbil;
    private int playerCatchFrame;
    private int playerCatchArm;

    //infield ratings
    private int playerInfRange;
    private int playerInfError;
    private int playerInfArm;
    private int playerDp;

    //outfield ratings
    private int playerOutfRange;
    private int playerOutfError;
    private int playerOutfArm;

#endregion

#region LEAGUE_RATINGS
    //catcher ratings
    private int maxCatchAbil;
    private int minCatchAbil;
    private int maxCatchFrame;
    private int minCatchFrame;
    private int maxCatchArm;
    private int minCatchArm;

    //infield ratings
    private int maxInfRange;
    private int minInfRange;
    private int maxInfError;
    private int minInfError;
    private int maxInfArm;
    private int minInfArm;
    private int maxDp;
    private int minDp;

    //outfield ratings
    private int maxOutfRange;
    private int minOutfRange;
    private int maxOutfError;
    private int minOutfError;
    private int maxOutfArm;
    private int minOutfArm;
#endregion

    private void Start()
    {
        SetDefensiveRatings();
        DisplayDefensiveRatings();
    }

    


    private void SetDefensiveRatings()
    {
        maxCatchAbil = jsonReader.myPositionRatingsList.ratings[0].catch_abil_max;
        minCatchAbil = jsonReader.myPositionRatingsList.ratings[0].catch_abil_min;
        maxCatchFrame = jsonReader.myPositionRatingsList.ratings[0].catch_frame_max;
        minCatchFrame = jsonReader.myPositionRatingsList.ratings[0].catch_frame_min;
        maxCatchArm = jsonReader.myPositionRatingsList.ratings[0].catch_arm_max;
        minCatchArm = jsonReader.myPositionRatingsList.ratings[0].catch_arm_min;

        maxInfRange = jsonReader.myPositionRatingsList.ratings[0].inf_range_max;
        minInfRange = jsonReader.myPositionRatingsList.ratings[0].inf_range_min;
        maxInfError = jsonReader.myPositionRatingsList.ratings[0].inf_error_max;
        minInfError = jsonReader.myPositionRatingsList.ratings[0].inf_error_min;
        maxInfArm = jsonReader.myPositionRatingsList.ratings[0].inf_arm_max;
        minInfArm = jsonReader.myPositionRatingsList.ratings[0].inf_arm_min;
        maxDp = jsonReader.myPositionRatingsList.ratings[0].dp_max;
        minDp = jsonReader.myPositionRatingsList.ratings[0].dp_min;

        maxOutfRange = jsonReader.myPositionRatingsList.ratings[0].outf_range_max;
        minOutfRange = jsonReader.myPositionRatingsList.ratings[0].outf_range_min;
        maxOutfError = jsonReader.myPositionRatingsList.ratings[0].outf_error_max;
        minOutfError = jsonReader.myPositionRatingsList.ratings[0].outf_error_min;
        maxOutfArm = jsonReader.myPositionRatingsList.ratings[0].outf_arm_max;
        minOutfArm = jsonReader.myPositionRatingsList.ratings[0].outf_arm_min;
    }

    private void DisplayDefensiveRatings()
    {
        SetDefensiveRatings();
   
        UpdatePlayerRatings();

        DisplayRating(catcherAbilBox, playerCatchAbil, maxCatchAbil, minCatchAbil);
        DisplayRating(catcherFrameBlock, playerCatchFrame, maxCatchFrame, minCatchFrame);
        DisplayRating(catcherArmBlock, playerCatchArm, maxCatchArm, minCatchArm);

        DisplayRating(infieldRangeBlock, playerInfRange, maxInfRange, minInfRange);
        DisplayRating(infieldErrorBlock, playerInfError, maxInfError, minInfError);
        DisplayRating(infieldArmBlock, playerInfArm, maxInfArm, minInfArm);
        DisplayRating(turnDoublePlayBlock, playerDp, maxDp, minDp);

        DisplayRating(outfieldRangeBlock, playerOutfRange, maxOutfRange, minOutfRange);
        DisplayRating(outfieldErrorBlock, playerOutfError, maxOutfError, minOutfError);
        DisplayRating(outfieldArmBlock, playerOutfArm, maxOutfArm, minOutfArm);

        
    }

    private void DisplayRating(GameObject ratingBlock, int rating, int maxRating, int minRating)
    {
        TextMeshProUGUI ratingTextBox = ratingBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();  
        ratingTextBox.text = rating.ToString();
        Transform ratingBarParent = ratingBlock.transform.Find("Rating_bar").GetComponent<Transform>();
        Image ratingBarImage = ratingBarParent.transform.Find("Foreground_image").GetComponent<Image>();
        float ratingRatio = (float)(rating-minRating)/(maxRating-minRating);
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

    private void UpdatePlayerRatings()
    {
        playerCatchAbil = jsonReader.myPlayerList.players[currentPlayer].catchAbil;
        playerCatchFrame = jsonReader.myPlayerList.players[currentPlayer].catchFrame;
        playerCatchArm = jsonReader.myPlayerList.players[currentPlayer].catchArm;
        playerInfRange = jsonReader.myPlayerList.players[currentPlayer].infRange;
        playerInfError = jsonReader.myPlayerList.players[currentPlayer].infError;
        playerInfArm = jsonReader.myPlayerList.players[currentPlayer].infArm;
        playerDp = jsonReader.myPlayerList.players[currentPlayer].dp;
        playerOutfRange = jsonReader.myPlayerList.players[currentPlayer].outfRange;
        playerOutfError = jsonReader.myPlayerList.players[currentPlayer].outfError;
        playerOutfArm = jsonReader.myPlayerList.players[currentPlayer].outfArm;
    }

    public void SetNextPlayer()
    {
        if(currentPlayer >0)
        {
            currentPlayer -= 1;
            DisplayDefensiveRatings();

        }
    }

    public void SetPreviousPlayer()
    {
        if(currentPlayer < jsonReader.GetPlayerListSize() -1)
        {
            currentPlayer += 1;
            DisplayDefensiveRatings();
        }
    }

    public void SetCurrentPlayer(int player)
    {
        currentPlayer = player;
        DisplayDefensiveRatings();
    }

    /*public void SetFieldPosition(int positionToSet)
    {
        fieldPosition = (FieldPosition)positionToSet;

        switch(fieldPosition)
        {
            case FieldPosition.infield:
                catcherDisplayBox.gameObject.SetActive(false);
                infieldDisplayBox.gameObject.SetActive(true);
                outfieldDisplayBox.gameObject.SetActive(false);
                break;
            case FieldPosition.outfield:
                catcherDisplayBox.gameObject.SetActive(false);
                infieldDisplayBox.gameObject.SetActive(false);
                outfieldDisplayBox.gameObject.SetActive(true);
                break;
            case FieldPosition.catcher:
                catcherDisplayBox.gameObject.SetActive(true);
                infieldDisplayBox.gameObject.SetActive(false);
                outfieldDisplayBox.gameObject.SetActive(false);
                break;
        }

        
    }  
    */ 
}

[Serializable]
public enum FieldPosition{
    infield,
    outfield,
    catcher
}
