using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Player")]
public class PlayerSO : ScriptableObject
{
    public float JumpForce => _jumpForce;
    [SerializeField] float _jumpForce;

    public PlayerEvents Events;
}
