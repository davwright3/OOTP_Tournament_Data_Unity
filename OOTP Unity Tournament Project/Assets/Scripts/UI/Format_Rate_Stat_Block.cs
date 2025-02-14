using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Format_Rate_Stat_Block : MonoBehaviour
{
    public static Format_Rate_Stat_Block Instance {get; private set;}

    private void Awake()
    {
        
        if(Instance != null)
        {
            Debug.LogError("More than one exists " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public string FormatRateStat(float statToFormat, int decimalPlaces)
    {
        //local variable to manipulate
        string statToFormatString;

        //read in the stat to the method and round it to 4, since rounding to 3 will end up with too few digits for the rate stat string
        statToFormat = (float)System.Math.Round(statToFormat, decimalPlaces);

        //cast the stat to a string for display
        statToFormatString = statToFormat.ToString();
        
        if(statToFormatString.Length > 0)
        {
            statToFormatString = statToFormatString.Substring(1);
        }

        if(statToFormatString.Length > decimalPlaces)
        {
            statToFormatString = statToFormatString.Substring(0, decimalPlaces);
        }

        while(statToFormatString.Length <4)
        {
            statToFormatString = statToFormatString + "0";
        }


        return statToFormatString;
    }
}
