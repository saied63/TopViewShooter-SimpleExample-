using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer
{
    string Name { get; set; }
    Vector2 RotateLimit { get; set; }
    GameObject CurrentGun { get; set; }
    int Health { get; set; }
    void ChangeHealth(int value);

}
