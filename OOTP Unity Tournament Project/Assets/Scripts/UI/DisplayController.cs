using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DisplayController : MonoBehaviour
{
    [SerializeField] private JsonReader jsonReader;
    
    [SerializeField] private TextMeshProUGUI playerNameText;
    [SerializeField] private TextMeshProUGUI playerAverageText;

    [SerializeField] float playerAverage;

    [SerializeField] string playerAverageString; 

    [SerializeField] int currentPlayer = 4;

    

    


    void Start() {
        
        ReadStats();
        DisplayStats();
        
        
    }


    void ReadStats()
    {
        playerAverageString = FormatRateStat(jsonReader.myPlayerList.player[currentPlayer].avg, 4);


        
        

    }
    
    void DisplayStats()
    {
        playerNameText.text = jsonReader.myPlayerList.player[currentPlayer].title;
        playerAverageText.text = "AVG: " + playerAverageString;
    }

    private string FormatRateStat(float statToFormat, int decimalPlaces)
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

        if(statToFormatString.Length != 4)
        {
            statToFormatString = statToFormatString.Substring(0, decimalPlaces);
        }

        return statToFormatString;
    }


    //methods for changing the player number
    public void SetNextPlayer()
    {
        if(currentPlayer > 0)
        {
            currentPlayer -= 1;
            ReadStats();
            DisplayStats();
        }
    }
    
}
