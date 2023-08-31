using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class MainGameUIHandelerScript : MonoBehaviour
{
    [SerializeField] GameObject[] liveSymbols;
    [SerializeField] TextMeshProUGUI _scoreUi;

    ScorehandlerScript _scoreHandlerScript;
    BirdScript _birdScript;
    GameObject _player;
    
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _scoreHandlerScript = _player.GetComponent<ScorehandlerScript>();
        _birdScript = _player.GetComponent<BirdScript>();
        _scoreUi.text = "Score: " + 0;
    }

    private void Update()
    {
        UpdatingLivesUI(_birdScript.LivesLeft());
        UpdatingScoreUI(_scoreHandlerScript.GetScore());
    }

    private void UpdatingLivesUI(int i)
    {
        if (i == 2)
        {
            liveSymbols[2].SetActive(false);
        }
        if(i == 1)
        {
            liveSymbols[1].SetActive(false);
        }
        if (i == 0)
        {
            liveSymbols[0].SetActive(false);
        }
    }

    private void UpdatingScoreUI(int score)
    {
        _scoreUi.text = "Score: " + score.ToString() + "/20";
    }
}
