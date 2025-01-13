using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

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


    


    private void Start()
    {
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


    }

    

    private void DisplayRating(GameObject ratingBlock, int rating, int maxRating, int minRating)
    {
        TextMeshProUGUI ratingTextBox = ratingBlock.transform.Find("Rating_text").GetComponent<TextMeshProUGUI>();  
        ratingTextBox.text = rating.ToString();
        Transform ratingBarParent = ratingBlock.transform.Find("Rating_bar").GetComponent<Transform>();
        Image ratingBarImage = ratingBarParent.transform.Find("Foreground_image").GetComponent<Image>();
        ratingBarImage.fillAmount = (float)(rating-minRating)/(maxRating-minRating);
        
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
}
