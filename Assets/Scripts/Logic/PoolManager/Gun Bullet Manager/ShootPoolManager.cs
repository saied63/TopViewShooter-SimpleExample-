using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPoolManager : MonoBehaviour
{

    [SerializeField]
    private Transform _ShootPoint;
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    
    void Awake()
    {
        InitBulletPools();
    }
    private void InitBulletPools()
    {
        for (int i = 0; i < 50; i++)
        {
            GameObject bullet = Instantiate(_bullet , _ShootPoint.position, _ShootPoint.rotation) as GameObject; 
            bullet.gameObject.SetActive(false);
            bullet.transform.SetParent(_ShootPoint);        
        }
    }

    public void ShootABullet()
    {  
        for (int i = 0; i < _ShootPoint.childCount; i++)
        {
            if (!_ShootPoint.GetChild(i).gameObject.activeSelf)
            {
                _ShootPoint.GetChild(i).GetComponent<Bullet>().Shoot();
                break;
            }
        }
    }
}
