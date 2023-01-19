using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public interface IEnemy 
{
    int EnemyType { get; set; }
    int Health { get; set; }
    float Speed { get; set; }
    void SetEnemyInformation(int type, int health, float speed, Color _color);
    IEnumerator StartMove();
    void OnTriggerEnter(Collider other);
    void ReachendLine(int score);
    void Dead(int score);
    void OnDisable();
    void OnEnable();
}
