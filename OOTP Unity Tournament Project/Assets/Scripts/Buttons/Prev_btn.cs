using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prev_btn : MonoBehaviour
{
    [SerializeField] private StatsDisplay statsDisplay;
    [SerializeField] private RatingsDisplay ratingsDisplay;
    [SerializeField] private DefenseRatingsDisplay defenseRatingsDisplay;
    [SerializeField] private StartingPitcherStatsDisplay startingPitcherStatsDisplay;
    [SerializeField] private StartingPitcherRatingsDisplay startingPitcherRatingsDisplay;
    [SerializeField] private StartingPitcherIndividualPitchDisplay startingPitcherIndividualPitchDisplay;
    [SerializeField] private ReliefPitcherStatsDisplay reliefPitcherStatsDisplay;
    [SerializeField] private ReliefPitcherRatingsDisplay reliefPitcherRatingsDisplay;
    [SerializeField] private ReliefPitcherIndividualPitchDisplay reliefPitcherIndividualPitchDisplay;
    [SerializeField] private Button m_prevBtn;

    private void Start()
    {
        m_prevBtn.onClick.AddListener(PreviousPlayer);
    }

    private void PreviousPlayer()
    {
        switch(PositionDisplaySelector.Instance.GetSelectedPosition())
        {
            case PositionDisplay.batters:
                statsDisplay.SetPreviousPlayer();
                ratingsDisplay.SetPreviousPlayer();
                defenseRatingsDisplay.SetPreviousPlayer();
                break;
            
            case PositionDisplay.startingPitcher:
                startingPitcherStatsDisplay.SetPreviousPlayer();
                startingPitcherRatingsDisplay.SetPreviousPlayer();
                startingPitcherIndividualPitchDisplay.SetPreviousPlayer();
                break;

            case PositionDisplay.reliefPitcher:
                reliefPitcherStatsDisplay.SetPreviousPlayer();
                reliefPitcherRatingsDisplay.SetNextPlayer();
                reliefPitcherIndividualPitchDisplay.SetNextPlayer();
                break;
        }
        
        

    }
}
