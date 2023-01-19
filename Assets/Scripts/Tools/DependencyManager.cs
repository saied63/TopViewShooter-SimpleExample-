using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DependencyManager 
{

    public static event Action<int> EnemyHitEndLine;
    public static event Action<int> EnemyDied;
    public static event Action<int> ShootToGiftBox;
    public static event Action Shoot;
    public static event Action<string,string> ChangeUI;
    public static event Action<string> GameFinished;

    public static void OnEnemyHitEndLine(int value)
    {
        EnemyHitEndLine?.Invoke(value);
        OnChangeUI("OnEnemyHitEndLine", value.ToString());
    }

    public static void OnEnemyDied(int value)
    {
        EnemyDied?.Invoke(value);
        OnChangeUI("OnEnemyDied",value.ToString());
    }

    public static void OnShootToGiftBox(int value)
    {
        ShootToGiftBox?.Invoke(value);
        OnChangeUI("OnShootToGiftBox", value.ToString());
    }

    public static void OnShoot()
    {
        Shoot?.Invoke();
        OnChangeUI("OnShoot","-1");
    }
    public static void OnGameFinished(string value)
    {
        GameFinished?.Invoke(value);
        OnChangeUI("OnGameFinished", value);
    }

    public static void OnChangeUI(string name , string value = "")
    {
        ChangeUI?.Invoke(name,value);
    }


}
