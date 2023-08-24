using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "LinearMovementData", menuName = "Data/LinearMovement")]
public class LinearMovementSO : ScriptableObject
{
    public Vector3 MovementDirection => _movementDirection;
    public Vector3 JumpDirection => _jumpDirection;

    public float MovementScale => _movementScale.Value;
    public float Speed => _speed * _difficultyVarriable.Value;
    public float JumpDistance => _jumpDistance;
    public float JumpAtHorizontal => _jumpAtHorizontal;

    [Header("Direction")]
    [SerializeField] Vector3 _movementDirection;
    [SerializeField] Vector3 _jumpDirection;

    [Header("Values")]
    [SerializeField] FloatVariable _movementScale;
    [SerializeField] FloatVariable _difficultyVarriable;
    [SerializeField] float _speed;
    [SerializeField] float _jumpDistance;
    //TODO: implement proper way to check distance on any axis(X,Y,Z)
    [SerializeField] float _jumpAtHorizontal;
}