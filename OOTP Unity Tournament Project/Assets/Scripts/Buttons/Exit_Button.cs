using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit_Button : MonoBehaviour
{
    [SerializeField] Button m_ExitButton;

    private void Start()
    {
        m_ExitButton.onClick.AddListener(ExitProgram);
    }
   

    public void ExitProgram()
    {
        Application.Quit();
    }
}
