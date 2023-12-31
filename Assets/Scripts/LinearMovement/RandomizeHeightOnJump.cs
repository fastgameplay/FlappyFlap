using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(LinearMovement))]
public class RandomizeHeightOnJump : MonoBehaviour
{
    [SerializeField] Vector2 _jumpRange;
    [SerializeField] bool _randomAtStart;
    LinearMovement _linearMovement;

    void Awake(){
        _linearMovement = GetComponent<LinearMovement>();
        if(_randomAtStart) OnJump();
    }
    void OnEnable(){
        _linearMovement.OnJumpPerformed += OnJump;
    }
    void OnDisable(){
        _linearMovement.OnJumpPerformed -= OnJump;
    }
    private void OnJump(){
        transform.position = new Vector3(transform.position.x, Random.Range(_jumpRange.x,_jumpRange.y), transform.position.z);
    }
}
