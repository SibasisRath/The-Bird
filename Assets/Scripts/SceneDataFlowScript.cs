using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDataFlowScript : MonoBehaviour
{
    private string winOrLoose;

    public string WinOrLoose { get => winOrLoose; set => winOrLoose = value; }


    private static SceneDataFlowScript _instance;
    public static SceneDataFlowScript Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SceneDataFlowScript>();

                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("SceneDataFlowScript");
                    _instance = singletonObject.AddComponent<SceneDataFlowScript>();
                }
            }

            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (this != _instance)
        {
            Destroy(gameObject);
        }
    }

    /*public static SceneDataFlowScript Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }*/
}
