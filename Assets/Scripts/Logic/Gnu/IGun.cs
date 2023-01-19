using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGun 
{
    int GunType { get; set; }
    int BulletCount { get; set; }
    string GunName { get; set; }
    bool IsSingleShot { get; set; }
    void Shoot();
    void AddAmmu(int bullet);
}
