using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : DefaultPlayer
{

    public void OnEnable()
    {
        DependencyManager.EnemyHitEndLine += ChangeHealth;
        DependencyManager.EnemyDied += ChangeHealth;
    }

    public void OnDisable()
    {
        DependencyManager.EnemyHitEndLine -= ChangeHealth;
        DependencyManager.EnemyDied -= ChangeHealth;
    }


    public override void ChangeHealth(int value)
    {
        Health += value;

        if (Health <= 0)
            DependencyManager.OnGameFinished("You Are Dead");
    }
}
