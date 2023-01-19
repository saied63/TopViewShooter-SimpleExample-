using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun1 : DefaultGun
{

    private ShootPoolManager _shootPoolManager;
    [SerializeField]
    private float _delayShoot = 0.1f;
    private float _timeToShoot;
    private void Awake()
    {
        _timeToShoot = Time.time;
        _shootPoolManager = transform.GetComponentInChildren<ShootPoolManager>();
    }

    private  void OnEnable()
    {
        DependencyManager.ShootToGiftBox += AddAmmu;
    }

    private void OnDisable()
    {
        DependencyManager.ShootToGiftBox -= AddAmmu;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)  )
        {
            Shoot();
        }
    }

    public override void Shoot()
    {
        if (BulletCount <= 0)
        {
            DependencyManager.OnGameFinished("Your Ammu Finished!");
            return;
        }
            

        if (Time.time < _timeToShoot + _delayShoot)
            return;
        _timeToShoot = Time.time;
        if (_shootPoolManager == null)
            return;
        _shootPoolManager.ShootABullet();
        BulletCount--;
        DependencyManager.OnShoot();
    }

    public override void AddAmmu(int bullet)
    {
        try
        {
            BulletCount += bullet;
        }
        catch
        {

        }
      
    }



}
