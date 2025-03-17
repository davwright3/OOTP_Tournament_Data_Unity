
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReliefPitcherIndividualPitchDisplay : MonoBehaviour
{
    [SerializeField] GameObject fastballBlock;
    [SerializeField] GameObject sliderBlock;
    [SerializeField] GameObject curveballBlock;
    [SerializeField] GameObject changeupBlock;
    [SerializeField] GameObject cutterBlock;
    [SerializeField] GameObject sinkerBlock;
    [SerializeField] GameObject splitterBlock;
    [SerializeField] GameObject forkballBlock;
    [SerializeField] GameObject screwballBlock;
    [SerializeField] GameObject circlechangeBlock;
    [SerializeField] GameObject knucklecurveBlock;
    [SerializeField] GameObject knuckleballBlock;

    [SerializeField] private List<GameObject> pitchRatingBlockList = new List<GameObject>();


#region PLAYER_RATINGS 
    private int playerFastball;
    private int playerSlider;
    private int playerCurveball;
    private int playerChangeup;
    private int playerCutter;
    private int playerSinker;
    private int playerSplitter;
    private int playerForkball;
    private int playerScrewball;
    private int playerCirclechange;
    private int playerKnucklecurve;
    private int playerKnuckleball;
#endregion

#region LEAGUE_RATINGS
    private int maxFastball;
    private int maxSlider;
    private int maxCurveball;
    private int maxChangeup;
    private int maxCutter;
    private int maxSinker;
    private int maxSplitter;
    private int maxForkball;
    private int maxScrewball;
    private int maxCirclechange;
    private int maxKnucklecurve;
    private int maxKnuckleball;

#endregion
    
    private int pitches;

    private int currentPlayer = 4;

    private void Start()
    {
        SetCurrentPlayer(currentPlayer);
        SetLeagueRatings();
        DisplayIndividualPitches();

        

    }

    private void SetLeagueRatings()
    {
        maxFastball = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].fastball_max;
        maxSlider = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].slider_max;
        maxCurveball = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].curveball_max;
        maxChangeup = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].changeup_max;
        maxCutter = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].cutter_max;
        maxSinker = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].sinker_max;
        maxSplitter = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].splitter_max;
        maxForkball = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].forkball_max;;
        maxScrewball = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].screwball_max;
        maxCirclechange = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].circlechange_max;
        maxKnucklecurve = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].knucklecurve_max;
        maxKnuckleball = JsonReader.Instance.myPitcherRatingsList.pitcher_ratings[0].knuckleball_max;
    }

    private void DisplayIndividualPitches()
    {
        pitchRatingBlockList.Clear();
        
        UpdatePitchRatings();
        UpdatePitchDisplayBlocks();

        
    }

    private void UpdatePitchRatings()
    {
        playerFastball = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].fastball;
        playerSlider = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].slider;
        playerCurveball = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].curveball;
        playerChangeup = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].changeup;
        playerCutter = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].cutter;
        playerSinker = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].sinker;
        playerSplitter = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].splitter;
        playerForkball = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].forkball;
        playerScrewball = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].screwball;
        playerCirclechange = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].circlechange;
        playerKnucklecurve = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].knucklecurve;
        playerKnuckleball = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].knuckleball;
    }

    private void UpdatePitchDisplayBlocks()
    {
        //start by determining which pitches should be active
        DisplayRatingBlock(fastballBlock, playerFastball, maxFastball);
        DisplayRatingBlock(sliderBlock, playerSlider, maxSlider);
        DisplayRatingBlock(curveballBlock, playerCurveball, maxCurveball);
        DisplayRatingBlock(changeupBlock, playerChangeup, maxChangeup);
        DisplayRatingBlock(cutterBlock, playerCutter, maxCutter);
        DisplayRatingBlock(sinkerBlock, playerSinker, maxSinker);
        DisplayRatingBlock(splitterBlock, playerSplitter, maxSplitter);
        DisplayRatingBlock(forkballBlock, playerForkball, maxForkball);
        DisplayRatingBlock(screwballBlock, playerScrewball, maxScrewball);
        DisplayRatingBlock(circlechangeBlock, playerCirclechange, maxCirclechange);
        DisplayRatingBlock(knucklecurveBlock, playerKnucklecurve, maxKnucklecurve);
        DisplayRatingBlock(knuckleballBlock, playerKnuckleball, maxKnuckleball);

        //next go through the list and move the boxes to where they should be
        for(int i = 0; i < pitchRatingBlockList.Count; i++)
        {
            int startPosY = 20;
            int startPosX = -240;
            int yOffset = 20;
            int xOffset = 175;

            if(i < 4)
            {
            Transform block = pitchRatingBlockList[i].transform;
            var pos = block.localPosition;
            block.localPosition = new Vector3(startPosX, startPosY - (yOffset*i), 0);
            }
            else
            {
            Transform block = pitchRatingBlockList[i].transform;
            var pos = block.localPosition;
            block.localPosition = new Vector3(startPosX + xOffset, startPosY - (yOffset*(i-4)), 0);
            }
            
        }
        
        

    }

    private void DisplayRatingBlock(GameObject block, int playerRating, int maxRating)
    {
        if(playerRating != 0)
        {
            block.gameObject.SetActive(true);
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
                pitchRatingBlockList.Add(block);
                
            }
            else
            {
                block.gameObject.SetActive(false);
            }
    }

    public void SetNextPlayer()
    {
        if(currentPlayer > 0)
        {
            currentPlayer -= 1;
            DisplayIndividualPitches();
        }
    }

    public void SetPreviousPlayer()
    {
        if(currentPlayer < JsonReader.Instance.GetReliefpitcherListSize()-1)
        {
            currentPlayer +=1;
            DisplayIndividualPitches();
        }
    }

    public void SetCurrentPlayer(int playerToSet)
    {
        if(playerToSet > JsonReader.Instance.GetReliefpitcherListSize()-1)
        {
            currentPlayer = JsonReader.Instance.GetReliefpitcherListSize()-1;
            DisplayIndividualPitches();
        }
        else{
            currentPlayer = playerToSet;
            DisplayIndividualPitches();
        }
        
    }
}
