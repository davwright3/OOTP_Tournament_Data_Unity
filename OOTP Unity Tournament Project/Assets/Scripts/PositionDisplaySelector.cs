using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PositionDisplaySelector : MonoBehaviour
{
    
    public static PositionDisplaySelector Instance {get; private set;}
    
    private PositionDisplay selectedPosition;
    
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("There is more than one PositionDisplaySelector" + Instance);
            Destroy(gameObject);
        }
        Instance = this;
        
        selectedPosition = PositionDisplay.batters;
    }

    public void SetPositionDisplay(int positionToDisplay)
    {
        switch(positionToDisplay)
        {
            case 0:
                selectedPosition = PositionDisplay.batters;
                break;
            case 1:
                selectedPosition = PositionDisplay.startingPitcher;
                break;
            case 2:
                selectedPosition = PositionDisplay.reliefPitcher;
                break;
        }
    }

    public PositionDisplay GetSelectedPosition()
    {
        return selectedPosition;
    }

      


    
}

[System.Serializable]
public enum PositionDisplay{
    batters,
    startingPitcher,
    reliefPitcher
}
