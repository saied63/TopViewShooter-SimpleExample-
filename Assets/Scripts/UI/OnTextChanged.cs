using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class OnTextChanged : UIEventListener
{
    private Text _text;
    public override void OnEnable()
    {
        _text = GetComponent<Text>();
        if (!_text)
            return;
        DependencyManager.ChangeUI += ListnerFunction;
    }

    public override void OnDisable()
    {
        DependencyManager.ChangeUI -= ListnerFunction;
    }

    public override void ListnerFunction(string name , string value)
    {
        
        if (name !=ListenerName)
            return;
        
        try
        {          
            _text.text = (int.Parse(_text.text) + int.Parse(value)).ToString();
        }
        catch 
        {
            _text.text = value;
        }
    }
}
