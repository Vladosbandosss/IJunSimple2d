using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawmer : MonoBehaviour
{
    [SerializeField] private GameObject _coin;

    private Vector3 _spawnCoinPos;

    private float _maxXpos = 6f;
    private float _minXpos = -6f;
    private float _randomXpos;
    private float _timeBeforeStart = 1f;
    private float _repeatTimeSpawn = 5f;

  private  void Start()
    {
        InvokeRepeating(nameof(SpawnCoins), _timeBeforeStart, _repeatTimeSpawn);
    }

  private void SpawnCoins()
    {
        _randomXpos = Random.Range(_minXpos, _maxXpos);
        _spawnCoinPos =new Vector3 (_randomXpos,_coin.transform.position.y,0);
        Instantiate(_coin, _spawnCoinPos, Quaternion.identity);
    }
}
