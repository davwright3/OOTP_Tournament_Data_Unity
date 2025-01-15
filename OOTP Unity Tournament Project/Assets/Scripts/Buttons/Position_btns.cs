using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position_btns : MonoBehaviour
{
    [SerializeField] StatsDisplay statsDisplay;
    [SerializeField] RatingsDisplay ratingsDisplay;
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
        TextAsset jsonRatingsText = Resources.Load("catcher_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetFirstBase()
    {
        TextAsset jsonText = Resources.Load("firstbase") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("firstbase_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetSecondBase()
    {
        TextAsset jsonText = Resources.Load("secondbase") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("secondbase_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetThirdBase()
    {
        TextAsset jsonText = Resources.Load("thirdbase") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("thirdbase_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetShortstop()
    {
        TextAsset jsonText = Resources.Load("shortstop") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("shortstop_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetLeftField()
    {
        TextAsset jsonText = Resources.Load("leftfield") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("leftfield_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetCenterField()
    {
        TextAsset jsonText = Resources.Load("centerfield") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("centerfield_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
    }

    private void SetRightField()
    {
        TextAsset jsonText = Resources.Load("rightfield") as TextAsset;
        TextAsset jsonRatingsText = Resources.Load("rightfield_ratings") as TextAsset;
        jsonReader.ChangePosition(jsonText, jsonRatingsText);
        SetNewPosition();
        
    }

    private void SetNewPosition()
    {
        
        statsDisplay.SetCurrentPlayer(4);
        ratingsDisplay.SetCurrentPlayer(4);
        ratingsDisplay.SetNewPosition();

    }

}
