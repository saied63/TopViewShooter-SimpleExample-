using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform _parent;
    [SerializeField]
    private float _bulletSpeed = 50.0f;
    [SerializeField]
    private int _damage = 20;
    public int Damage
    {
        get
        {
            return _damage;
        }
    }
    public void Shoot()
    {
        if (_parent == null)
        {
            _parent = transform.parent;
        }
        transform.position = _parent.position;
        transform.rotation = _parent.rotation;
        transform.localScale = Vector3.one;
        gameObject.SetActive(true);
    }
    private void OnEnable()
    {
        transform.SetParent(null); 
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _bulletSpeed * Time.deltaTime);
    }

    private void OnDisable()
    {
        Invoke("DisableBullet", 0.1f);
    }

    void DisableBullet()
    {
        transform.SetParent(_parent);
    }


}
