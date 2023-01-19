using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyInfo", menuName = "Create new enemy/NewEnemyInfo", order = 1)]
public class DefaultEnemyInfo : ScriptableObject, IEnemyInfo
{
    [Space]
    [Header("*** there is three type of enemy")]
    [Range(1, 3)]
    [SerializeField]
    private int _enemyType;
    public int EnemyType
    {
        get
        {
            return _enemyType;
        }
        set
        {
            _enemyType = value;
        }
    }
    [Space]
    [Header("*** more health = more powerful enemy")]
    [Range(50, 100)]
    [SerializeField]
    private int _health;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    [Space]
    [Header("*** a simple color for enemy")]
    [SerializeField]
    private Color _enemyColor;
    public Color EnemyColor
    {
        get
        {
            return _enemyColor;
        }
        set
        {
            _enemyColor = value;
        }
    }

    [Space]
    [Header("*** enemy default speed")]
    [SerializeField]
    private float _speed;
    public float Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }


    [Space]
    [Header("*** instantiate this Enemy")]

    [SerializeField]
    private GameObject _enemyPrefab;
    public GameObject EnemyPrefab
    {
        get
        {
            return _enemyPrefab;
        }
        set
        {
            _enemyPrefab = value;
        }
    }
    
}
