using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    }

    private void UpdatePlayerRatingDisplayBars()
    {
        
    }
}
