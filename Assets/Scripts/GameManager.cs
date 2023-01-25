using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour //MonoSingleton<GameManager>
{
    public int Lives;// { get; private set; }
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            Lives = 3;
            DontDestroyOnLoad(gameObject);
        }

    }

    internal void KillPlayer()
    {
        
        Lives--;
        SceneManager.LoadScene(0);
    }
}
