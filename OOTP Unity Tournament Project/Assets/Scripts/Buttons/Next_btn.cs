using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Next_btn : MonoBehaviour
{
    [SerializeField] private DisplayController displayController;
    [SerializeField] Button m_NextBtn;


    
    private void Start()
    {
        m_NextBtn.onClick.AddListener(NextPlayer);
    }


    private void NextPlayer()
    {
        displayController.SetNextPlayer();

    }
    
}
