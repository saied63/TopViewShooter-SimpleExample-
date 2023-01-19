using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveByDelay : MonoBehaviour
{
    [SerializeField]
    private float _deactiveTime = 2.0f;
    private void OnEnable()
    {
        StartCoroutine(DeactiveyDelay());
    }
    private IEnumerator DeactiveyDelay()
    {
        yield return new WaitForSeconds(_deactiveTime);
        if(gameObject.activeSelf)
            gameObject.SetActive(false);
    }
}
