using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSpecification : MonoBehaviour
{
    
    private Renderer _renderer;

    public void SetColor(Color color)
    {
        if (_renderer == null)
        {
            _renderer = GetComponent<Renderer>();
        }
        _renderer.material.color = color;
    }
}
