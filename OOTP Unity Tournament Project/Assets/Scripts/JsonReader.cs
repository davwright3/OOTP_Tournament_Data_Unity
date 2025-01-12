using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class JsonReader : MonoBehaviour
{
    public static JsonReader Instance {get; private set;}
    
    public TextAsset textJSON;
    public TextAsset ratingsTextJSON;

    [SerializeField] TextMeshProUGUI playerNameText;
    [SerializeField] private int playerListSize;

    [System.Serializable]
    public class Player
    {
        public int index;
        public int cid;
        public string title;
        public int value;
        public int price;
        public int pa;
        public float war;
        public float avg;
        public float obp;
        public float slg;
        public float ops;
        public float hr;
        public float kp;
        public float bbp; 
        public float bbpk;
        public float sbp;
        public float sb;
        public float woba;
        public float normWar;
        public float warRank;
        public float paRank;
        public float avgRank;
        public float obpRank;
        public float slgRank;
        public float opsRank;
        public float hrRank;
        public float kRank;
        public float bbRank;
        public float bbpkRank;
        public float sbpRank;
        public float sbRank;
        public float wobaRank;
    }

    [System.Serializable]
    public class PositionRatings
    {
        public int contact_max;
        public int contact_min;
        public int gap_max;
        public int gap_min;
        public int power_max;
        public int power_min;
        public int eye_max;
        public int eye_min;
        public int avk_max;
        public int avk_min;
        public int babip_max;
        public int babip_min;
        public int l_contact_max;
        public int l_contact_min;
        public int l_gap_max;
        public int l_gap_min;
        public int l_power_max;
        public int l_power_min;
        public int l_eye_max;
        public int l_eye_min;
        public int l_avk_max;
        public int l_avk_min;
        public int l_babip_max;
        public int l_babip_min;
        public int r_contact_max;
        public int r_contact_min;
        public int r_gap_max;
        public int r_gap_min;
        public int r_power_max;
        public int r_power_min;
        public int r_eye_max;
        public int r_eye_min;
        public int r_avk_max;
        public int r_avk_min;
        public int r_babip_max;
        public int r_babip_min;
        public int speed_max;
        public int speed_min;
        public int steal_rate_max;
        public int steal_rate_min;
        public int steal_max;
        public int steal_min;
        public int sac_bunt_max;
        public int sac_bunt_min;
        public int bunt_for_hit_max;
        public int bunt_for_hit_min;

    }

    [System.Serializable]
    public class PlayerList
    {
        public Player[] players;
    }

    [System.Serializable]
    public class PositionRatingsList
    {
        public PositionRatings[] ratings;
    }

    public PlayerList myPlayerList = new PlayerList();
    public PositionRatingsList myPositionRatingsList = new PositionRatingsList();

    void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("More than one JSON Reader exits!" + Instance);
            Destroy(gameObject);
        }
        Instance = this;
        
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSON.text);  
        playerListSize = myPlayerList.players.Length;

        myPositionRatingsList = JsonUtility.FromJson<PositionRatingsList>(ratingsTextJSON.text);
     
    }

    private void UpdatePlayerList()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSON.text);  
        playerListSize = myPlayerList.players.Length;
    }

    public int GetPlayerListSize()
    {
        return playerListSize;
    }
    

    public void ChangePosition(TextAsset jsonText)
    {
        textJSON = jsonText;
        UpdatePlayerList();

    }
    
}
