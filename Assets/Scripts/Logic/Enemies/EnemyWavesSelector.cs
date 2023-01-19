using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class EnemyWavesSelector : MonoBehaviour
{

    [SerializeField]
    private string _defaultWave;
    public string DefaultWave
    {
        get
        {
            return _defaultWave;
        }
        set
        {
            _defaultWave = value;
       
        }
    }


    public JSONNode ReturnRandomWave()
    {
        try
        {
            JSONNode lastCashedWaveInfoes = JSON.Parse(_defaultWave);
            int waveCount = lastCashedWaveInfoes["data"]["waves"].Count;
            int randomWave = Random.Range(0, waveCount);
            return lastCashedWaveInfoes["data"]["waves"][randomWave];
        }
        catch (UnityException e)
        {
            Debug.LogException(e);
            Debug.LogError("bad json format!");
            return null;
        }
    }
}
