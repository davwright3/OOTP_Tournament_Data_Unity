using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Position_btns : MonoBehaviour
{
    [SerializeField] StatsDisplay statsDisplay;
    [SerializeField] RatingsDisplay ratingsDisplay;
    [SerializeField] DefenseRatingsDisplay defenseRatingsDisplay;
    [SerializeField] DisplayValidPositions displayValidPositions;
    [SerializeField] JsonReader jsonReader;
    [SerializeField] GameObject batterDisplayBox;
    [SerializeField] GameObject startingPitcherDisplayBox;
    [SerializeField] GameObject reliefPitcherDisplayBox;
    [SerializeField] GameObject leaguePitchingStatsDisplay;
    [SerializeField] StartingPitcherStatsDisplay startingPitcherStatsDisplay;
    [SerializeField] StartingPitcherRatingsDisplay startingPitcherRatingsDisplay;
    [SerializeField] StartingPitcherIndividualPitchDisplay startingPitcherIndividualPitchDisplay;
    [SerializeField] ReliefPitcherStatsDisplay reliefPitcherStatsDisplay;
    [SerializeField] ReliefPitcherRatingsDisplay reliefPitcherRatingsDisplay;
    [SerializeField] private ReliefPitcherIndividualPitchDisplay reliefPitcherIndividualPitchDisplay;


    [SerializeField] Button m_catcherBtn;
    [SerializeField] Button m_cornerInfieldBtn;
    [SerializeField] Button m_middleInfieldBtn;
    [SerializeField] Button m_OutfieldBtn;
    [SerializeField] Button m_StartingPitcherBtn;
    [SerializeField] Button m_ReliefPitcherBtn;

    
    private void Start()
    {
        m_catcherBtn.onClick.AddListener(SetCatcher);
        m_cornerInfieldBtn.onClick.AddListener(SetCornerInfield);
        m_middleInfieldBtn.onClick.AddListener(SetMiddleInfield);
        m_OutfieldBtn.onClick.AddListener(SetOutfield);
        m_StartingPitcherBtn.onClick.AddListener(SetStartingPitcher);
        m_ReliefPitcherBtn.onClick.AddListener(SetReliefPItcher);
    }

    private void SetCatcher()
    {
        TextAsset jsonText = Resources.Load("catchers") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("catcher_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetMiddleInfield()
    {
        TextAsset jsonText = Resources.Load("middle_infield") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("rightfield_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetCornerInfield()
    {
        TextAsset jsonText = Resources.Load("corner_infield") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("rightfield_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetOutfield()
    {
        TextAsset jsonText = Resources.Load("all_outfield") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("rightfield_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetStartingPitcher()
    {
        batterDisplayBox.gameObject.SetActive(false);
        reliefPitcherDisplayBox.gameObject.SetActive(false);
        startingPitcherDisplayBox.gameObject.SetActive(true);
        startingPitcherStatsDisplay.SetCurrentPlayer(4);
        startingPitcherRatingsDisplay.SetCurrentPlayer(4);
        startingPitcherIndividualPitchDisplay.SetCurrentPlayer(4);
        leaguePitchingStatsDisplay.gameObject.SetActive(true);
        PositionDisplaySelector.Instance.SetPositionDisplay(1);

    }

    private void SetReliefPItcher()
    {
        batterDisplayBox.gameObject.SetActive(false);
        reliefPitcherDisplayBox.gameObject.SetActive(true);
        startingPitcherDisplayBox.gameObject.SetActive(false);
        reliefPitcherStatsDisplay.SetCurrentPlayer(4);
        reliefPitcherRatingsDisplay.SetCurrentPlayer(4);
        reliefPitcherIndividualPitchDisplay.SetCurrentPlayer(4);
        leaguePitchingStatsDisplay.gameObject.SetActive(true);
        PositionDisplaySelector.Instance.SetPositionDisplay(2);
    }

    private void SetNewPosition()
    {
        
        statsDisplay.SetCurrentPlayer(4);
        ratingsDisplay.SetCurrentPlayer(4);
        ratingsDisplay.SetNewPosition();
        defenseRatingsDisplay.SetCurrentPlayer(4);
        displayValidPositions.SetCurrentPlayer(4);
        startingPitcherDisplayBox.gameObject.SetActive(false);
        reliefPitcherDisplayBox.gameObject.SetActive(false);        
        batterDisplayBox.gameObject.SetActive(true);
        leaguePitchingStatsDisplay.gameObject.SetActive(false);
        PositionDisplaySelector.Instance.SetPositionDisplay(0);


    }

    

}
