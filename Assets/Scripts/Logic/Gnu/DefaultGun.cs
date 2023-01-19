using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultGun : MonoBehaviour, IGun
{
    [SerializeField]
    private int _gunType;
    public int GunType
    {
        get
        {
            return _gunType;
        }
        set
        {
            _gunType = value;
        }
    }

    [SerializeField]
    private int _bulletCount;
    public int BulletCount
    {
        get
        {
            return _bulletCount;
        }
        set
        {
            _bulletCount = value;
        }
    }

    [SerializeField]
    private string _gunName;
    public string GunName
    {
        get
        {
            return _gunName;
        }
        set
        {
            _gunName = value;
        }
    }

    [SerializeField]
    public bool _isSingleShot;
    public bool IsSingleShot
    {
        get
        {
            return _isSingleShot;
        }
        set
        {
            _isSingleShot = value;
        }
    }


    public virtual void Shoot()
    {
       
    }

    public virtual void AddAmmu(int bullet)
    {

    }
}
