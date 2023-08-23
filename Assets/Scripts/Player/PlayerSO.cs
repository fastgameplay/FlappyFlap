using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Player")]
public class PlayerSO : ScriptableObject
{
    public float JumpPower => _jumpPower;
    [SerializeField] float _jumpPower;

}
