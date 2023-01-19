using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventListener : MonoBehaviour,IListener
{
    [SerializeField]
    private string _listenerName;
    public string ListenerName 
    {
        get
        {
            return _listenerName;
        }
        set
        {
            _listenerName = value;
        }
        
    }

    public virtual void OnDisable()
    {
        DependencyManager.ChangeUI += ListnerFunction;
    }

    public virtual void OnEnable()
    {
        DependencyManager.ChangeUI -= ListnerFunction;
    }

    public virtual void ListnerFunction(string name, string value)
    {
        
    }


}
