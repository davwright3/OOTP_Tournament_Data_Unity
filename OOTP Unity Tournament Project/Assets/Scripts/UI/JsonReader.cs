using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class JsonReader : MonoBehaviour
{
    public static JsonReader Instance {get; private set;}
    
    public TextAsset textJSON;
    public TextAsset ratingsTextJSON;

    public TextAsset startingPitcherTextJson;
    public TextAsset reliefPitcherTextJson;
    
    public TextAsset pitcherRatingsJson;

    public TextAsset cardCollectionJson;

    private int playerListSize;
    private int startingPitcherListSize;
    private int reliefPitcherListSize;

    

    [System.Serializable]
    public class Player
    {
        public int index;
        public int cid;
        public string title;
        public int value;
        public int bats;
        public int throws;
        public int learnC;
        public int learn1B;
        public int learn2B;
        public int learn3B;
        public int learnSS;
        public int learnLF;
        public int learnCF;
        public int learnRF;
        public int clvl;
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
        public float score;
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
        public float score_rank;
        public int contact;
        public int gap;
        public int power;
        public int eye;
        public int avoidk;
        public int babip;
        public int contactvL;
        public int gapvL;
        public int powervL;
        public int eyevL;
        public int avoidkvL;
        public int babipvL;
        public int contactvR;
        public int gapvR;
        public int powervR;
        public int eyevR;
        public int avoidkvR;
        public int babipvR;
        public int gbprofile;
        public int fbprofile;
        public int batterProfile;
        public int speed;
        public int stealRate;
        public int stealing;
        public int baserunning;
        public int sacBunt;
        public int buntForHit;
        public int catchAbil;
        public int catchFrame;
        public int catchArm;
        public int infRange;
        public int infError;
        public int infArm;
        public int dp;
        public int outfRange;
        public int outfError;
        public int outfArm;
        

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
        public int baserunning_max;
        public int baserunning_min;
        public int sac_bunt_max;
        public int sac_bunt_min;
        public int bunt_for_hit_max;
        public int bunt_for_hit_min;
        public int inf_range_max;
        public int inf_range_min;
        public int inf_error_max;
        public int inf_error_min;
        public int inf_arm_max;
        public int inf_arm_min;
        public int dp_max;
        public int dp_min;
        public int catch_abil_max;
        public int catch_abil_min;
        public int catch_frame_max;
        public int catch_frame_min;
        public int catch_arm_max;
        public int catch_arm_min;
        public int outf_range_max;
        public int outf_range_min;
        public int outf_error_max;
        public int outf_error_min;
        public int outf_arm_max;
        public int outf_arm_min;

    }

    [System.Serializable]
    public class StartingPitcher{
        public int cid;
        public string title;
        public int value;
        public int price;
        public int bats;
        public int throws;
        public int clvl;
        public float fip;
        public float war;
        public float ipc;
        public int w;
        public int l;
        public float wpct;
        public float era;
        public float kp9;
        public float bbp9;
        public float hrp9;
        public float qspct;
        public float gbrate;
        public float fipRank;
        public float warRank;
        public float wpctRank;
        public float eraRank;
        public float kRank;
        public float bbRank;
        public float hrRank;
        public float qsRank;
        public float gbRateRank;
        public int stuff;
        public int movement;
        public int control;
        public int pHR;
        public int pBabip;
        public int stuffvL;
        public int movementvL;
        public int controlvL;
        public int pHRvL;
        public int pBabipvL;
        public int stuffvR;
        public int movementvR;
        public int controlvR;
        public int pHRvR;
        public int pBabipvR;
        public int fastball;
        public int slider;
        public int curveball;
        public int changeup;
        public int cutter;
        public int sinker;
        public int splitter;
        public int forkball;
        public int screwball;
        public int circlechange;
        public int knucklecurve;
        public int knuckleball;
        public int stamina;
        public int hold;
        public int gb;
        public string velocity;
        public int armSlot;
        
    }

    [System.Serializable]
    public class ReliefPitcher{
        public int cid;
        public string title;
        public int value;
        public int bats;
        public int throws;
        public int clvl;
        public float fip;
        public float era;
        public float war;
        public float ipc;
        public float saves;
        public float svo;
        public int sd;
        public int md;
        public int ir;
        public int irs;
        public float svPct;
        public float sdPerMd;
        public float irsPct;
        public float gbRate;
        public float kRate;
        public float bbRate;
        public float hrRate;
        public float fipRank;
        public float eraRank;
        public float warRank;
        public float kRank;
        public float bbRank;
        public float hrRank;
        public float svPctRank;
        public float sdPerMdRank;
        public float irsPctRank;
        public float gbRateRank;
        public int stuff;
        public int movement;
        public int control;
        public int pHR;
        public int pBabip;
        public int stuffvL;
        public int movementvL;
        public int controlvL;
        public int pHRvL;
        public int pBabipvL;
        public int stuffvR;
        public int movementvR;
        public int controlvR;
        public int pHRvR;
        public int pBabipvR;
        public int fastball;
        public int slider;
        public int curveball;
        public int changeup;
        public int cutter;
        public int sinker;
        public int splitter;
        public int forkball;
        public int screwball;
        public int circlechange;
        public int knucklecurve;
        public int knuckleball;
        public int stamina;
        public int hold;
        public int gb;
        public string velocity;
        public int armSlot;
        

    }
    
    [System.Serializable]
    public class PitcherRatings{
        public int stuff_max;
        public int stuff_min;
        public int movement_max;
        public int movement_min;
        public int control_max;
        public int control_min;
        public int pHR_max;
        public int pHR_min;
        public int pBabip_max;
        public int pBabip_min;
        public int stuffvL_max;
        public int stuffvL_min;
        public int movementvL_max;
        public int movementvL_min;
        public int controlvL_max;
        public int controlvL_min;
        public int pHRvL_max;
        public int pHRvL_min;
        public int pBabipvL_max;
        public int pBabipvL_min;
        public int stuffvR_max;
        public int stuffvR_min;
        public int movementvR_max;
        public int movementvR_min;
        public int controlvR_max;
        public int controlvR_min;
        public int pHRvR_max;
        public int pHRvR_min;
        public int pBabipvR_max;
        public int pBabipvR_min;
        public int stamina_max;
        public int stamina_min;
        public int hold_max;
        public int hold_min;
        public int fastball_max;
        public int slider_max;
        public int curveball_max;
        public int changeup_max;
        public int cutter_max;
        public int sinker_max;
        public int splitter_max;
        public int forkball_max;
        public int screwball_max;
        public int circlechange_max;
        public int knucklecurve_max;
        public int knuckleball_max;
        
    }
    
    [System.Serializable]
    public class Card{
        public int CID;
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

    [System.Serializable]
    public class StartingPitcherList
    {
        public StartingPitcher[] starting_pitchers;
    }

    [System.Serializable] 
    public class ReliefPitcherList
    {
        public ReliefPitcher[] relief_pitchers;
    }

    [System.Serializable]
    public class PitcherRatingsList
    {
        public PitcherRatings[] pitcher_ratings;
    }

    [System.Serializable]
    public class CardList{
        public Card[] cards;
    }

    public PlayerList myPlayerList = new PlayerList();
    public PositionRatingsList myPositionRatingsList = new PositionRatingsList();
    public StartingPitcherList myStartingPitcherlist = new StartingPitcherList();
    public ReliefPitcherList myReliefPitcherList = new ReliefPitcherList();
    public PitcherRatingsList myPitcherRatingsList = new PitcherRatingsList();
    public CardList myCardlist = new CardList();

    public List<int> collectionList;

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

        myStartingPitcherlist = JsonUtility.FromJson<StartingPitcherList>(startingPitcherTextJson.text);
        startingPitcherListSize = myStartingPitcherlist.starting_pitchers.Length;

        myReliefPitcherList = JsonUtility.FromJson<ReliefPitcherList>(reliefPitcherTextJson.text);
        reliefPitcherListSize = myReliefPitcherList.relief_pitchers.Length;

        myPitcherRatingsList = JsonUtility.FromJson<PitcherRatingsList>(pitcherRatingsJson.text);

        myCardlist = JsonUtility.FromJson<CardList>(cardCollectionJson.text);

        collectionList = new List<int>();
        FillCollectionList();
     
    }

    private void UpdatePlayerList()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSON.text);  
        playerListSize = myPlayerList.players.Length;
    }

    private void UpdateRatingsList()
    {
        myPositionRatingsList = JsonUtility.FromJson<PositionRatingsList>(ratingsTextJSON.text);
    }

    public int GetPlayerListSize()
    {
        return playerListSize;
    }

    public int GetStartingPitcherListSize()
    {
        return startingPitcherListSize;
    }

    public int GetReliefpitcherListSize()
    {
        return reliefPitcherListSize;
    }

    public int GetCardListSize()
    {
        return myCardlist.cards.Length;
    }
    

    public void ChangePosition(TextAsset jsonText, TextAsset jsonRatingsText)
    {
        textJSON = jsonText;
        ratingsTextJSON = jsonRatingsText;
        UpdatePlayerList();
        UpdateRatingsList();

    }

    private void FillCollectionList()
    {
        for(int i = 0; i < GetCardListSize(); i++)
        {
            collectionList.Add(myCardlist.cards[i].CID);
        }
    }

    
    
}
