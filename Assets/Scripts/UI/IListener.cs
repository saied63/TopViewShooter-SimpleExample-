using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public interface IListener
{
    string ListenerName { get; set; }
    void ListnerFunction(string name , string value);
    void OnEnable();
    void OnDisable();
}
