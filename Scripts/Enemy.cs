using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;

    private Transform[] _points;
   
    private int _currentPoint;
  
    private void Start()
    {
        CreateEnemyPath();
    }

    private void CreateEnemyPath()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }

    }

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        Transform target = _points[_currentPoint];
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);


        if (_currentPoint == 0)
        {

            transform.rotation = Quaternion.Euler(0, 180, 0);
         
        }

        if (_currentPoint == 1)
        {

            transform.rotation = Quaternion.Euler(0, 0, 0);

        }


        if (transform.position == target.position)
        {

            _currentPoint++;

        }

        if (_currentPoint >= _points.Length)
        {

            _currentPoint = 0;

        }
    }
}