using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftPoolManager : MonoBehaviour
{


    [SerializeField]
    private int _delayBetweenGiftSpawn = 10;
    private float _timeToActiveAGift;

    private void Start()
    {
        _timeToActiveAGift = Time.time;
    }

    private void Update()
    {
        if (Time.time > _timeToActiveAGift + _delayBetweenGiftSpawn)
        {
            ActiveARandomGift();
            _timeToActiveAGift = Time.time;
            _delayBetweenGiftSpawn = Random.Range(5, _delayBetweenGiftSpawn);
        }
    }
    public void ActiveARandomGift()
    {
        int rnd = Random.Range(0, transform.childCount);
        for (int i = rnd; i < transform.childCount; i++)
        {
            if (!transform.GetChild(i).gameObject.activeSelf)
            {
                transform.GetChild(i).gameObject.SetActive(true);
                break;
            }
        }
    }
}
