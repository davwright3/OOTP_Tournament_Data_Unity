using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class JsonReader : MonoBehaviour
{
    public TextAsset textJSON;

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
    public class PlayerList
    {
        public Player[] players;
    }

    public PlayerList myPlayerList = new PlayerList();

    void Awake()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSON.text);  
        playerListSize = myPlayerList.players.Length;
          

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
