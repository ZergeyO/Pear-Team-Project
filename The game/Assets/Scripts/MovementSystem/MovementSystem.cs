using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    private bool _isLookingRight = true;
    private bool _isMoving = true;
    [SerializeField] private float _speed;

    public bool IsLookingRight 
    { 
        get { return _isLookingRight;}
    }

    public bool IsMoving
    {
        get { return _isMoving; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public Vector2 ProcessingInputVector(Vector2 inputVector)
    { 
        if(inputVector.x>0) { _isLookingRight = true; }
        if(inputVector.x<0) { _isLookingRight = false; }
        if (inputVector != Vector2.zero) { _isMoving = true; } else { _isMoving = false; }
        return inputVector.normalized * (_speed * Time.fixedDeltaTime);
    }

    public static Vector2 GetRandomDir()
    {
        return new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
        /* 
            Создаётся вектор со случайными координатами в целочисленном диапазоне от -1 до 1. 
            Требуется ли исключить вектор (0,0)?
        */
    }
}
