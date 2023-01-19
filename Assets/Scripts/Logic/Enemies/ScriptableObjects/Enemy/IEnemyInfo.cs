using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyInfo
{
    int EnemyType { get; set; }
    int Health { get; set; }
    float Speed { get; set; }
    Color EnemyColor { get; set; }
    GameObject EnemyPrefab { get; set; }
}
