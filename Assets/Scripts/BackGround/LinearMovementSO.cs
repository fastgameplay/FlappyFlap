using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "LinearMovementData", menuName = "Data/LinearMovement")]
public class LinearMovementSO : ScriptableObject
{
    [Header("Direction")]
    [SerializeField] Vector3 _movementDirection;
    public Vector3 MovementDirection => _movementDirection;
    [SerializeField] Vector3 _jumpDirection;
    public Vector3 JumpDirection => _jumpDirection;

    [Header("Values")]
    [SerializeField] float _speed;
    public float Speed => _speed;
    [SerializeField] float _jumpDistance;
    public float JumpDistance => _jumpDistance;
    //TODO: implement proper way to check distance on any axis(X,Y,Z)
    [SerializeField] float _jumpAtHorizontal;
    public float JumpAtHorizontal => _jumpAtHorizontal;
}