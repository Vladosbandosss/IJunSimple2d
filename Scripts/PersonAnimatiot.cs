using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonAnimatiot : MonoBehaviour
{
    private const string PlayerRun = "Run";
    private const string PlayerStop = "Stop";
    private const string PlayerJump = "Jump";

    private Animator _playerAnimator;
    private void Awake()
    {
        _playerAnimator = GetComponent<Animator>();
    }

 
   private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {

            _playerAnimator.SetTrigger(PlayerRun);

        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {

            _playerAnimator.SetTrigger(PlayerJump);

        }

        else
        {

            _playerAnimator.SetTrigger(PlayerStop);

        }
    
    }
}
