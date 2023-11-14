using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Session sessionData;
    private bool _GameOver = true;
    public bool isGameOver
    {
        get 
        { 
            return _GameOver;
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        Instance.sessionData = new Session();
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        _GameOver = true;
        SceneManager.LoadScene(1);
    }

    public void GameOver()
    {
        _GameOver = false;
        SceneManager.LoadScene(0);
    }

    public class Session
    {
        public string figureName;
        public int figureIndex;
    }
}
