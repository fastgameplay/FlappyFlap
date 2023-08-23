using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSO Data => _playerData;
    [SerializeField] PlayerSO _playerData;
}
