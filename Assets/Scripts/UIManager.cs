using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { private set; get; }
    public GameObject ResultPanel;
    public GameObject MainMenu;
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

    public void GameFinished(string value)
    {
        ResultPanel.SetActive(true);
        MainMenu.SetActive(false);
    }

}
