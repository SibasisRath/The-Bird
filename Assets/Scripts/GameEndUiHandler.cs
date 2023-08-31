using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndUiHandler : MonoBehaviour
{
    [SerializeField] GameObject winPage;
    [SerializeField] GameObject loosePage;

    SceneDataFlowScript sceneHandler;
    private void Start()
    {
        sceneHandler = GameObject.Find("SceneDataFlow").GetComponent<SceneDataFlowScript>();
        winPage.SetActive(false);
        loosePage.SetActive(false);
    }

    private void Update()
    {
        ResultingUIDisplaMethod(sceneHandler.WinOrLoose);
    }
    private void ResultingUIDisplaMethod(string s)
    {
        if (s == "Win")
        {
            winPage.SetActive(true);
        }
        if (s == "Loose")
        {
            loosePage.SetActive(true);
        }
    }
}
