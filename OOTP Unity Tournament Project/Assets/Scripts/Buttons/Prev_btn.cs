using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prev_btn : MonoBehaviour
{
    [SerializeField] private StatsDisplay statsDisplay;
    [SerializeField] private RatingsDisplay ratingsDisplay;
    [SerializeField] private Button m_prevBtn;

    private void Start()
    {
        m_prevBtn.onClick.AddListener(PreviousPlayer);
    }

    private void PreviousPlayer()
    {
        statsDisplay.SetPreviousPlayer();
        ratingsDisplay.SetPreviousPlayer();

    }
}
