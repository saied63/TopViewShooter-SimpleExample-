using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }
    public bool _gameIsFinished = false;
    public bool GameIsFinished
    {
        get
        {
            return _gameIsFinished;
        }
        set
        {
            _gameIsFinished = value;
        }
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        DependencyManager.GameFinished += OnGameFinished;
    }

    private void OnDisable()
    {
        DependencyManager.GameFinished -= OnGameFinished;
    }

    public void OnGameFinished(string value)
    {
        if (GameIsFinished)
            return;
        GameIsFinished = true;
        UIManager.Instance.GameFinished(value);
        DependencyManager.OnGameFinished(value);
        Time.timeScale = 0;
    }
}
