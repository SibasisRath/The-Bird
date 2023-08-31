using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScorehandlerScript : MonoBehaviour
{
    private int _score;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ScoreBar"))
        {
            Debug.Log("ScoreBar ...");
            ScoreUpdate(1);
        }
    }

    public void ScoreUpdate(int i)
    {
        _score += i;
        Debug.Log($"Your Score is: {_score}");
        if (_score > 19)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
    }
    public int GetScore()
    {
        return _score;
    }

}
