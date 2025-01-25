using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Next_btn : MonoBehaviour
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
    [SerializeField] Button m_NextBtn;


    
    private void Start()
    {
        m_NextBtn.onClick.AddListener(NextPlayer);
    }


    private void NextPlayer()
    {
        switch(PositionDisplaySelector.Instance.GetSelectedPosition())
        {
            case PositionDisplay.batters:
                statsDisplay.SetNextPlayer();
                ratingsDisplay.SetNextPlayer();
                defenseRatingsDisplay.SetNextPlayer();
                break;

            case PositionDisplay.startingPitcher:
                startingPitcherStatsDisplay.SetNextPlayer();
                startingPitcherRatingsDisplay.SetNextPlayer();
                startingPitcherIndividualPitchDisplay.SetNextPlayer();
                break;

            case PositionDisplay.reliefPitcher:
                reliefPitcherStatsDisplay.SetNextPlayer();
                reliefPitcherRatingsDisplay.SetNextPlayer();
                reliefPitcherIndividualPitchDisplay.SetNextPlayer();
                break;

            

        }       
        
        

    }
    
}
