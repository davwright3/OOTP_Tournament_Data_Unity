using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseRatingsDisplay : MonoBehaviour
{
    [SerializeField] JsonReader jsonReader;

    int currentPlayer = 4;

#region DISPLAY_BOXES
    [SerializeField] private GameObject catcherDisplayBox;

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
        UpdatePlayerRatings();
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

    public void SetPreviousplayer()
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
}
