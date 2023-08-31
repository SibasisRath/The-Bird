using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLooseScript : MonoBehaviour
{
    private string winOrLoose;

    ScorehandlerScript _scoreHandlerScript;
    BirdScript _birdScript;

    SceneDataFlowScript resultString;


    public string WinOrLoose { get => winOrLoose; set => winOrLoose = value; }

    // Start is called before the first frame update
    void Start()
    {
        _scoreHandlerScript = gameObject.GetComponent<ScorehandlerScript>();
        _birdScript = gameObject.GetComponent<BirdScript>();
        WinOrLoose = "";

        resultString = GameObject.FindGameObjectWithTag("SceneDataFlow").GetComponent<SceneDataFlowScript>();
    }

    private void Update()
    {
        if (_birdScript.LivesLeft() < 1)
        {
            WinOrLoose += "Loose";
        }
        if (_scoreHandlerScript.GetScore() > 19)
        {
            WinOrLoose += "Win";
        }

        resultString.WinOrLoose = winOrLoose;
    }



}

