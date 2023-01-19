using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
public class EnemyPoolManager : MonoBehaviour
{
    public DefaultEnemyInfo[] enemyInfoes;
    private EnemyWavesSelector _wavesSelector;


    [SerializeField]
    private float _distanceBeetweenLines = 3;
    [SerializeField]
    private float _maxDelayBetweenWaves = 15f;
    private float _randomDelayWave;
    private float _timeToSendWave;
    private int _selectedLineIndex ;
    private JSONNode _selectedWave;


    private void Awake()
    {
        _wavesSelector = GetComponent<EnemyWavesSelector>();
        for (int i = -1; i < enemyInfoes.Length-1; i++)
        {
            GameObject enemyParent = new GameObject("Enemy Parent" + i) as GameObject;
            enemyParent.transform.SetParent(transform);
            Vector3 position = transform.position;
            position.x += i * _distanceBeetweenLines;
            enemyParent.transform.localPosition = position;
        }
        InitEnemyPools();
    }


    private void InitEnemyPools()
    {
        for (int i = 0; i < 3; i++)
        {
            IEnemyInfo enemyInfo = enemyInfoes[i];
            for (int j = 0; j < 20; j++)
            {
                GameObject enemy = Instantiate(enemyInfoes[i].EnemyPrefab) as GameObject;
                enemy.GetComponent<Enemy>().SetEnemyInformation(enemyInfo.EnemyType, enemyInfo.Health,
                    enemyInfo.Speed, enemyInfo.EnemyColor);
                enemy.transform.SetParent(transform.GetChild(i));
                enemy.gameObject.SetActive(false);
            }
        }
        _randomDelayWave = Random.Range(_maxDelayBetweenWaves / 3, _maxDelayBetweenWaves);
        _timeToSendWave = Time.time;
    }

   

    private void Update()
    {
        if(Time.time> _timeToSendWave + _randomDelayWave)
        {
            _selectedWave = _wavesSelector.ReturnRandomWave();

            if (_selectedWave == null)
                return;

            StartCoroutine(SendAnEnemyWave());

            _timeToSendWave = Time.time;
            _randomDelayWave = Random.Range(_maxDelayBetweenWaves / 2, _maxDelayBetweenWaves);
        }
    }


    private IEnumerator SendAnEnemyWave()
    {
        Vector3 linePosition = SelectLinePosition();
        _selectedWave = _selectedWave["enemy"];
        for (int i = 0; i < _selectedWave.Count; i++) 
        {
            for (int j = 0; j < _selectedWave[i]["count"].AsInt; j++)
            {
                ActiveOneEnemyWhithThisType(_selectedWave[i]["type"].AsInt-1, linePosition);
                yield return new WaitForSeconds(0.5f);
            } 
        }
    }

    private void ActiveOneEnemyWhithThisType(int type  , Vector3 linePos)
    { 
        Transform child = transform.GetChild(type);
        IEnemyInfo enemyInfo = enemyInfoes[type];
        for (int j = 0; j < child.childCount; j++)
        {
            if (!child.GetChild(j).gameObject.activeSelf)
            {
                child.GetChild(j).GetComponent<Enemy>().SetEnemyInformation(enemyInfo.EnemyType, enemyInfo.Health,
                    enemyInfo.Speed, enemyInfo.EnemyColor);
                child.GetChild(j).position = linePos;
                child.GetChild(j).gameObject.SetActive(true);
                break;
            }
        }
    }


    private Vector3 SelectLinePosition()
    {
        ReturnAFreeLineIndex();
        return transform.GetChild(_selectedLineIndex).position;
    }

    private int ReturnAFreeLineIndex()
    {
        int rnd = Random.Range(0, transform.childCount);
        if (_selectedLineIndex == rnd)
        {
            rnd++;
            if (rnd >= transform.childCount)
            {
                rnd = 0;
            }
        }
        _selectedLineIndex = rnd;
        return _selectedLineIndex;
    }


   
}
