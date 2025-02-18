using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class League_Pitching_Json_Reader : MonoBehaviour
{
    public static League_Pitching_Json_Reader Instance {get; private set;}

    [SerializeField] private TextAsset leaguePitchingJsonText;

    [System.Serializable]
    public class LeaguePitchingStat
    {
        public float innings;
        public int er;
        public float fip;
        public float era;
        public float hrRate;
        public float kRate;
        public float bbRate;

    }

    [System.Serializable]
    public class LeaguePitchingList
    {
        public LeaguePitchingStat[] lg_pitching_stats;
    }

    public LeaguePitchingList myLeaguePitchingList = new LeaguePitchingList();


    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("There is more than one league pitching instance" + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;

        myLeaguePitchingList = JsonUtility.FromJson<LeaguePitchingList>(leaguePitchingJsonText.text);
    }

    

}
