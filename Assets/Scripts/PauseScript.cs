using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }
    private void Update()
    {
        Pause();
    }

    public void Pause()
    {
        if (Time.timeScale == 1 && Input.GetKeyDown(KeyCode.P))
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }

        else if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.P))
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }


    }
}
