using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerEnter 
{
    string TargetTag { get; set; }
    void OnTriggerEnter(Collider other);
    void TriggerEnterLogic();
}
