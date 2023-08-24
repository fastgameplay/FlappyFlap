using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "FloatVariable", menuName = "Variables/Float")]
public class FloatVariable : ScriptableObject
{
    public float Value{
        get => _value;
        set {
            _value = Mathf.Clamp01(value);
        }
    }
    [SerializeField] float _value;
}
