using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovementController : MonoBehaviour
{

    private PlayerMovementController _player = default;

    private void Start()
    {
        _player = FindObjectOfType<PlayerMovementController>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            _player.MoveRight();
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            _player.MoveLeft();
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            _player.MoveUp();
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            _player.MoveDown();
        }
    }
}
