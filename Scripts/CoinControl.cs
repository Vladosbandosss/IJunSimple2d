using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    private float _timeBeforeDestroy = 4f;

    private void Start()
    {
        Destroy(gameObject, _timeBeforeDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PersonMover>())
        {
            Destroy(gameObject);
        }
    }

}
