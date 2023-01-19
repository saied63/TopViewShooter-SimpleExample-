using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour, ITriggerEnter
{
    [SerializeField]
    private string _targetTag;
    public string TargetTag
    { 
        get 
        {
            return _targetTag;
        } 
        set 
        {
            _targetTag = value;
        } 
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(_targetTag))
        {
            TriggerEnterLogic();
        }
    }

    public virtual void TriggerEnterLogic()
    {
        //do logic here
    }
}
