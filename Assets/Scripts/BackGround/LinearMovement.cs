using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    [SerializeField] LinearMovementSO _data;
    
    Vector3 _jumpValue;
    void Awake(){
        _jumpValue = _data.JumpDirection * _data.JumpDistance;
    }
    void Update(){
        transform.Translate(_data.MovementDirection * _data.Speed * Time.deltaTime * _data.MovementScale);
        
        if(transform.position.x <= _data.JumpAtHorizontal) 
            transform.Translate(_jumpValue);
    }
}
