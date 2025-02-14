using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Format_Counting_Stat_Block : MonoBehaviour
{
    public static Format_Counting_Stat_Block Instance {get; private set;}


    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one format counting stat objects exists " + Instance);
            Destroy(gameObject);
            return;
        }   
        Instance = this;
    }

    public string FormatCountingStat(float statToFormat, int decimalPlaces)
    {
        //local variable to manipulate
        string statToFormatString;

        //read in the stat to the method and round it to 4, since rounding to 3 will end up with too few digits for the rate stat string
        statToFormat = (float)System.Math.Round(statToFormat, decimalPlaces);

        statToFormatString = statToFormat.ToString();

        //cast the stat to a string for display
        


        return statToFormatString;
    }
}
