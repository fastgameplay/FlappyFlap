using System;
using UnityEngine;

public class PlayerEvents : MonoBehaviour
{
   
    public Action OnTap;

    public Action OnScoreIncrement;
    public Action<int> OnScoreChange;

    public Action OnDeath;
}
