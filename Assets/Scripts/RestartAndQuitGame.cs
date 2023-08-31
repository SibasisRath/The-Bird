using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAndQuitGame : MonoBehaviour
{
    private float playingSpeed;

    private void Start()
    {
        
        
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OnStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }


    

}
