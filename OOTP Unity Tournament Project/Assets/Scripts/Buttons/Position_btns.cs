using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position_btns : MonoBehaviour
{
    [SerializeField] StatsDisplay statsDisplay;
    [SerializeField] JsonReader jsonReader;

    [SerializeField] Button m_catcherBtn;
    [SerializeField] Button m_firstBaseBtn;
    [SerializeField] Button m_secondBaseBtn;
    [SerializeField] Button m_thirdBaseBtn;
    [SerializeField] Button m_shortstopBtn;
    [SerializeField] Button m_LeftFieldBtn;
    [SerializeField] Button m_CenterFieldBtn;
    [SerializeField] Button m_RightFieldBtn;

    private void Start()
    {
        m_catcherBtn.onClick.AddListener(SetCatcher);
        m_firstBaseBtn.onClick.AddListener(SetFirstBase);
        m_secondBaseBtn.onClick.AddListener(SetSecondBase);
        m_thirdBaseBtn.onClick.AddListener(SetThirdBase);
        m_shortstopBtn.onClick.AddListener(SetShortstop);
        m_LeftFieldBtn.onClick.AddListener(SetLeftField);
        m_CenterFieldBtn.onClick.AddListener(SetCenterField);
        m_RightFieldBtn.onClick.AddListener(SetRightField);
    }

    private void SetCatcher()
    {
        TextAsset jsonText = Resources.Load("catchers") as TextAsset;
        jsonReader.ChangePosition(jsonText);
        statsDisplay.SetCurrentPlayer(5);
    }

    private void SetFirstBase()
    {
        TextAsset jsonText = Resources.Load("firstbase") as TextAsset;
        jsonReader.ChangePosition(jsonText);
        statsDisplay.SetCurrentPlayer(5);
    }

    private void SetSecondBase()
    {
        TextAsset jsonText = Resources.Load("secondbase") as TextAsset;
        jsonReader.ChangePosition(jsonText);
        statsDisplay.SetCurrentPlayer(5);
    }

    private void SetThirdBase()
    {
        TextAsset jsonText = Resources.Load("thirdbase") as TextAsset;
        jsonReader.ChangePosition(jsonText);
        statsDisplay.SetCurrentPlayer(5);
    }

    private void SetShortstop()
    {
        TextAsset jsonText = Resources.Load("shortstop") as TextAsset;
        jsonReader.ChangePosition(jsonText);
        statsDisplay.SetCurrentPlayer(5);
    }

    private void SetLeftField()
    {
        TextAsset jsonText = Resources.Load("leftfield") as TextAsset;
        jsonReader.ChangePosition(jsonText);
        statsDisplay.SetCurrentPlayer(5);
    }

    private void SetCenterField()
    {
        TextAsset jsonText = Resources.Load("centerfield") as TextAsset;
        jsonReader.ChangePosition(jsonText);
        statsDisplay.SetCurrentPlayer(5);
    }

    private void SetRightField()
    {
        TextAsset jsonText = Resources.Load("rightfield") as TextAsset;
        jsonReader.ChangePosition(jsonText);
        statsDisplay.SetCurrentPlayer(5);
    }

}
