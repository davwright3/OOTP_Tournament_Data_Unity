using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class League_Batting_Json_Reader : MonoBehaviour
{
    public static League_Batting_Json_Reader Instance {get; private set;}
    
    [SerializeField] private TextAsset league_batting_text;

    [System.Serializable]
    public class LeagueStats{
        public int totalpa;
        public float avg;
        public float obp;
        public float slg;
        public float ops;
        public float hr;
        public float kpct;
        public float bbpct;
        public float sbrate;
    }

    [System.Serializable]
    public class LeagueStatsList
    {
        public LeagueStats[] lg_stats;
    }

    public LeagueStatsList myLeagueStatsList = new LeagueStatsList();


    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("More thane one league batting reader exists " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;

        myLeagueStatsList = JsonUtility.FromJson<LeagueStatsList>(league_batting_text.text);
        
    }


}
