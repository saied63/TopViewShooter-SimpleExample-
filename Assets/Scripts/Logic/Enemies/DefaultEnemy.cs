using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultEnemy :MonoBehaviour, IEnemy
{

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

    public virtual void SetEnemyInformation(int type, int health, float speed, Color _color)
    {

    }

    public virtual IEnumerator StartMove()
    {
        yield return null;
    }

    public virtual void OnTriggerEnter(Collider other)
    {
 
    }

    public virtual void ReachendLine(int score)
    {
       
    }

    public virtual void Dead(int score)
    {
       
    }

    public virtual void OnDisable()
    {
        
    }

    public virtual void OnEnable()
    {
        
    }
}
