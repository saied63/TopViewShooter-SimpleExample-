using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DefaultPlayer : MonoBehaviour , IPlayer
{

    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    private Vector2 _rotateLimit;
    public Vector2 RotateLimit
    {
        get
        {
            return _rotateLimit;
        }
        set
        {
            _rotateLimit = value;
        }
    }


    private GameObject _currentGun;
    public GameObject CurrentGun
    {
        get
        {
            return _currentGun;
        }
        set
        {
            _currentGun = value;
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

    public virtual void ChangeHealth(int value)
    {
     
    }
}
