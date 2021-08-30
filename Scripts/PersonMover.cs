using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMover : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody;
    private Vector2 _jumpUp;

    [SerializeField] private float _playerSpeed;

    private float _inputX;
    private float _movement;
    private float _jumpForce = 5f;

    private void Awake()
    {

        _playerRigidbody = GetComponent<Rigidbody2D>();
    
    }

    private void Start()
    {
        _jumpUp = new Vector2(0, _jumpForce);
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
          
            _inputX = Input.GetAxis("Horizontal");
            _movement = _inputX * _playerSpeed;
            _playerRigidbody.velocity = new Vector3(_movement, 0);

            if (_playerRigidbody.velocity.x > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            if (_playerRigidbody.velocity.x < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }

        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRigidbody.AddForce(_jumpUp, ForceMode2D.Impulse);
          
        }

    }
}