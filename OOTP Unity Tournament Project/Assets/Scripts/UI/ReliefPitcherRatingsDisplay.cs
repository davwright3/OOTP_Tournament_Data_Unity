using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReliefPitcherRatingsDisplay : MonoBehaviour
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

    public void Start()
    {
        UpdateRatingsDisplay();
    }

    private void UpdateRatingsDisplay()
    {
        SetPlayerRatings();
        UpdatePlayerRatingDisplayBars();
    }

    private void SetPlayerRatings()
    {
        playerStuffRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].stuff;
        playerMovementRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].movement;
        playerControlRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].control;
        playerHRRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].pHR;
        playerBabipRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].pBabip;

        playerStuffvLRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].stuffvL;
        playerMovementvLRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].movementvL;
        playerControlvLRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].controlvL;
        playerHRvLRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].pHRvL;
        playerBabipvLRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].pBabipvL;

        playerStuffvRRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].stuffvR;
        playerMovementvRRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].movementvR;
        playerControlvRRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].controlvR;
        playerHRvRRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].pHRvR;
        playerBabipvRRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].pBabipvR;

        playerStaminaRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].stamina;
        playerHoldRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].hold;
        playerVeloRating = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].pBabipvR.ToString();
        playerArmSlot = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].pBabipvR;
        playerGroundballProfile = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].gb;
        
    }

    private void UpdatePlayerRatingDisplayBars()
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


        
    }

    private void UpdateRatingBlock(GameObject block, int playerRating, int maxRating)
    {
        TextMeshProUGUI textBlock = block.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();
        textBlock.text = playerRating.ToString();
        Transform ratingBarParent = block.transform.Find("Rating_bar").GetComponent<Transform>();
        Image ratingBarImage = ratingBarParent.transform.Find("Foreground_image").GetComponent<Image>();
        ratingBarImage.fillAmount = (float)playerRating/maxRating;

        
        
    }

    public void SetNextPlayer()
    {
        if(currentPlayer>0)
        {
            currentPlayer -=1;
            UpdateRatingsDisplay();
        }
    }

    public void SetPreviousPlayer()
    {
        if(currentPlayer < JsonReader.Instance.myReliefPitcherList.relief_pitchers.Length)
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
