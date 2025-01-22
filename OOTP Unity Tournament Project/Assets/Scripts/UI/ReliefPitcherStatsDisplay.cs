using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReliefPitcherStatsDisplay : MonoBehaviour
{
    private int currentPlayer = 4;

    [SerializeField] private TextMeshProUGUI playerNameBox;

    private void Start()
    {
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        playerNameBox.text = JsonReader.Instance.myReliefPitcherList.relief_pitchers[currentPlayer].title;
    }

    

}
