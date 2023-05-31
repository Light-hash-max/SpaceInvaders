using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour, IMovement
{
    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    private GameObject _boarderDown = default;
    [SerializeField]
    private GameObject _boarderUp = default;
    [SerializeField]
    private GameObject _boarderRight = default;
    [SerializeField]
    private GameObject _boarderLeft = default;

    public void MoveDown()
    {
        if (transform.position.y <= _boarderDown.transform.position.y)
        {
            return;
        }

        transform.position += Vector3.down * _speed * Time.deltaTime;
    }

    public void MoveLeft()
    {
        if (transform.position.x <= _boarderLeft.transform.position.x)
        {
            return;
        }

        transform.position += Vector3.left * _speed * Time.deltaTime;
    }

    public void MoveRight()
    {
        if (transform.position.x >= _boarderRight.transform.position.x)
        {
            return;
        }

        transform.position += Vector3.right * _speed * Time.deltaTime;
    }

    public void MoveUp()
    {
        if (transform.position.y >= _boarderUp.transform.position.y)
        {
            return;
        }

        transform.position += Vector3.up * _speed * Time.deltaTime;
    }
}
