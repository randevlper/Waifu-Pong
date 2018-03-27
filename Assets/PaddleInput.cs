using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleInput : MonoBehaviour
{

    Vector2 _input;
    public Paddle paddle;

    [Range(0, 1)]
    public int player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (player)
        {
            case 0:
                PlayerOne();
                break;
            case 1:
                PlayerTwo();
                break;
        }
    }

    void PlayerOne()
    {
        _input.x = Input.GetAxisRaw("Vertical1");

        if (_input.x > 0)
        {
            paddle.MoveUp();
        }
        else if (_input.x < 0)
        {
            paddle.MoveDown();
        }
    }

    void PlayerTwo()
    {
        _input.x = Input.GetAxisRaw("Vertical2");

        if (_input.x > 0)
        {
            paddle.MoveUp();
        }
        else if (_input.x < 0)
        {
            paddle.MoveDown();
        }
    }
}
